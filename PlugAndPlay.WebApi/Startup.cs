using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using PlugAndPlay.AuditLogging;
using PlugAndPlay.AuditLogging.EF;
using PlugAndPlay.CommandValidators;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Contracting.Queries;
using PlugAndPlay.Contracting.Security;
using PlugAndPlay.Dal.CommandHandlers;
using PlugAndPlay.Dal.Model;
using PlugAndPlay.Dal.QueryHandlers;
using PlugAndPlay.Util.ServiceFilters;
using PlugAndPlay.WebApi.Util;
using PlugAndPlay.WebApi.Util.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlugAndPlay.WebApi
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();              

      services.AddHttpContextAccessor();
      services.AddTransient<IUserResolverService, UserResolverService>();

      SetupTokenAuth(services);


      //List<Assembly> assemblies = new List<Assembly>
      //{
        //AppDomain.CurrentDomain.Load("PlugAndPlay.Dal"),
        //AppDomain.CurrentDomain.Load("PlugAndPlay.Contract")
      //};

      services.AddMediatR(AppDomain.CurrentDomain.Load("PlugAndPlay.Dal"));

      //services.AddMediatR(typeof(PlugAndPlay.Dal.QueryHandlers.BidQueryHandler));

      services.AddDbContext<PlugAndPlayContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PlugAndPlay")));
      services.AddDbContext<PlugAndPlayLogContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PlugAndPlayLog")));

      services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
      services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CommandHistoryLogger<,>));

      services.AddValidatorsFromAssemblyContaining(typeof(ValidationBehaviour<,>));

      services.AddScoped<BadRequestOnRuleValidationException>();
      services.AddScoped<BadRequestOnArgumentException>();
      services.AddScoped<ProblemDetailsForSqlException>();

      services.AddSwaggerGen(c =>
      {
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath);
      });




    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      //if (env.IsDevelopment())
      //{
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
          c.SwaggerEndpoint("/swagger/v1/swagger.json", "Plug and Play Web Api V1");
          c.RoutePrefix = string.Empty;
        });
      //}

      app.UseCors(builder =>
      {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()
               .WithExposedHeaders("Token-Expired");
      });

      app.UseHttpsRedirection();

      app.UseRouting();

#warning Provjeri treba li ovo dvoje dolje ili je dovoljno s onim u SetupTokenAuth
      //app.UseAuthentication();
      //app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }

      

    private void SetupTokenAuth(IServiceCollection services)
    {
      services.AddTransient<IPasswordHasher<string>, PasswordHasher<string>>();
      services.AddTransient<IUserManagementService, UserManagementService>();
      services.AddTransient<ITokenUtil, TokenUtil>();

      var tokenSection = Configuration.GetSection("TokenConfiguration");
      services.Configure<TokenConfig>(tokenSection);
      var token = tokenSection.Get<TokenConfig>();
      var secret = Encoding.Default.GetBytes(token.Secret);

      services.AddAuthentication(opt =>
              {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
              })
              .AddJwtBearer(opt =>
              {
                opt.SaveToken = true;
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                  ValidateIssuer = true,
                  ValidateAudience = true,
                  ValidateLifetime = true,
                  ValidateIssuerSigningKey = true,

                  IssuerSigningKey = new SymmetricSecurityKey(secret),
                  ValidIssuer = token.Issuer,
                  ValidAudience = token.Audience,
                };
                opt.Events = new JwtBearerEvents
                {
                  OnAuthenticationFailed = context =>
                  {
                    if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                    {
                      context.Response.Headers.Add("Token-Expired", "true");
                    }
                    return Task.CompletedTask;
                  }
                };
              });

      services.AddAuthorization(options =>
      {
        foreach (var policy in Policies.All)
        {
          options.AddPolicy(policy.Key, policy.Value);
        }
      });
    }

  }
}

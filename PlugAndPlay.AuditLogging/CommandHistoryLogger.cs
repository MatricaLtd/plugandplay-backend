﻿using MediatR;
using PlugAndPlay.AuditLogging.EF;
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using PlugAndPlay.Common.Extensions;
using PlugAndPlay.Contracting.Commands;

namespace PlugAndPlay.AuditLogging
{
  public class CommandHistoryLogger<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
  {
    private readonly PlugAndPlayLogContext logContext;
    private readonly IUserResolverService userResolverService;

    public CommandHistoryLogger(PlugAndPlayLogContext logContext, IUserResolverService userResolverService)
    {
      this.logContext = logContext;
      this.userResolverService = userResolverService;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
      TResponse response;      
      bool logging = request is ICommand || request is ICommand<TResponse>;
      if (logging)
      {        
        JsonSerializerOptions serializerOptions = new JsonSerializerOptions
        {
          IgnoreNullValues = true,
          WriteIndented = true
        };
        string json = JsonSerializer.Serialize(request, serializerOptions);
        Command logEntry = new Command
        {
          CommandData = json,
          CommandName = request.GetType().FullName,
          Username = userResolverService.GetCurrentUserName()
        };
        logContext.Add(logEntry);
        await logContext.SaveChangesAsync();

        try
        {
          response = await next();
          logEntry.Success = true;
        }
        catch (Exception exc)
        {
          logEntry.Success = false;
          logEntry.Error = exc.CompleteExceptionMessage();
          logEntry.EndTime = DateTime.Now;
          await logContext.SaveChangesAsync();
          throw;
        }
        logEntry.EndTime = DateTime.Now;
        await logContext.SaveChangesAsync();       
      }
      else
      {
        response = await next();
      }
      return response;

    }
  }
}

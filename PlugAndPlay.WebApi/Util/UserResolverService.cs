using Microsoft.AspNetCore.Http;
using PlugAndPlay.AuditLogging;

namespace PlugAndPlay.WebApi.Util
{
  public class UserResolverService : IUserResolverService
  {
    private readonly IHttpContextAccessor context;

    public UserResolverService(IHttpContextAccessor context)
    {
      this.context = context;
    }   

    public string GetCurrentUserName()
    {
      return context.HttpContext.User?.Identity?.Name ?? "anonymous";
    }
  }
}

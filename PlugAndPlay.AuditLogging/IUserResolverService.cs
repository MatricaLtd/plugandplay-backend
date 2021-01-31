using System;

namespace PlugAndPlay.AuditLogging
{
  public interface IUserResolverService
  {
    string GetCurrentUserName();
  }
}

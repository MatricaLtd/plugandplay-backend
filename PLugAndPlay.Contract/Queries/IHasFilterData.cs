using System.Collections.Generic;

namespace PlugAndPlay.Contracting.Queries
{
  public interface IHasFilterData
  {
    List<Filter> Filters { get; set; }
  }
}
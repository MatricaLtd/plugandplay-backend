using System.Collections.Generic;

namespace PlugAndPlay.Contracting.Queries
{
  public class FilteredCountQuery : CountQuery, IHasFilterData
  {
    public List<Filter> Filters { get; set; }
  }
}

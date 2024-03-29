﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlugAndPlay.Contracting.Queries
{
  public abstract class FilterAndPagingQuery : IHasPagingData, IHasFilterData
  {
    public PagingData PagingData { get; set; }
    public List<Filter> Filters { get; set; }
  }
}

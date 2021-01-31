using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.DTOs;
using PlugAndPlay.Dal.Model;
using PlugAndPlay.Dal.QueryHandlers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PlugAndPlay.Dal.QueryHandlers
{
    public class DrzavaQueryHandler : GenericQueryHandler<Model.Drzava, DrzavaDto, DrzavaDto>
    {

        public DrzavaQueryHandler(PlugAndPlayContext ctx, ILogger<DrzavaQueryHandler> logger) : base(ctx, logger)
        {
        }

        protected override Expression<Func<Model.Drzava, DrzavaDto>> SelectorInList => SelectorSingle;
        protected override Expression<Func<Model.Drzava, DrzavaDto>> SelectorSingle =>
          a => new DrzavaDto
          {
                Id = a.Id,              
                
                
	                naziv = a.Naziv,
	            
	            
                
          };

        protected override Dictionary<string, Expression<Func<Model.Drzava, object>>> OrderSelectors => orderSelectors;
        private static Dictionary<string, Expression<Func<Model.Drzava, object>>> orderSelectors = new Dictionary<string, Expression<Func<Model.Drzava, object>>>
        {
            [nameof(DrzavaDto.Id).ToLower()] = a => a.Id,
            
            
	        [nameof(DrzavaDto.naziv).ToLower()] = a => a.Naziv,
	        
	        
            
        };

        protected override Expression<Func<Model.Drzava, bool>> CreatePKPredicate(int value)
        {
            return a => a.Id == value;
        }
    }
}

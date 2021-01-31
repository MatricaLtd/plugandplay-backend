using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.DTOs;
using PlugAndPlay.Dal.Model;
using PlugAndPlay.Dal.QueryHandlers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PlugAndPlay.Dal.QueryHandlers
{
    public class StavkaPopustQueryHandler : GenericQueryHandler<Model.StavkaPopust, StavkaPopustDto, StavkaPopustDto>
    {

        public StavkaPopustQueryHandler(PlugAndPlayContext ctx, ILogger<StavkaPopustQueryHandler> logger) : base(ctx, logger)
        {
        }

        protected override Expression<Func<Model.StavkaPopust, StavkaPopustDto>> SelectorInList => SelectorSingle;
        protected override Expression<Func<Model.StavkaPopust, StavkaPopustDto>> SelectorSingle =>
          a => new StavkaPopustDto
          {
                Id = a.Id,              
                
                
	                agePopust = a.AgePopust,
	            
	            
                
	                ageIznos = a.AgeIznos,
	            
	            
                
	                avansPopust = a.AvansPopust,
	            
	            
                
	                avansIznos = a.AvansIznos,
	            
	            
                
                    PonudaId = a.PonudaId,
	            
          };

        protected override Dictionary<string, Expression<Func<Model.StavkaPopust, object>>> OrderSelectors => orderSelectors;
        private static Dictionary<string, Expression<Func<Model.StavkaPopust, object>>> orderSelectors = new Dictionary<string, Expression<Func<Model.StavkaPopust, object>>>
        {
            [nameof(StavkaPopustDto.Id).ToLower()] = a => a.Id,
            
            
	        [nameof(StavkaPopustDto.agePopust).ToLower()] = a => a.AgePopust,
	        
	        
            
	        [nameof(StavkaPopustDto.ageIznos).ToLower()] = a => a.AgeIznos,
	        
	        
            
	        [nameof(StavkaPopustDto.avansPopust).ToLower()] = a => a.AvansPopust,
	        
	        
            
	        [nameof(StavkaPopustDto.avansIznos).ToLower()] = a => a.AvansIznos,
	        
	        
            
            [nameof(StavkaPopustDto.PonudaId).ToLower()] = a => a.PonudaId,
	        
        };

        protected override Expression<Func<Model.StavkaPopust, bool>> CreatePKPredicate(int value)
        {
            return a => a.Id == value;
        }
    }
}

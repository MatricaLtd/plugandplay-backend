using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.DTOs;
using PlugAndPlay.Dal.Model;
using PlugAndPlay.Dal.QueryHandlers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PlugAndPlay.Dal.QueryHandlers
{
    public class StavkaPonudeQueryHandler : GenericQueryHandler<Model.StavkaPonude, StavkaPonudeDto, StavkaPonudeDto>
    {

        public StavkaPonudeQueryHandler(PlugAndPlayContext ctx, ILogger<StavkaPonudeQueryHandler> logger) : base(ctx, logger)
        {
        }

        protected override Expression<Func<Model.StavkaPonude, StavkaPonudeDto>> SelectorInList => SelectorSingle;
        protected override Expression<Func<Model.StavkaPonude, StavkaPonudeDto>> SelectorSingle =>
          a => new StavkaPonudeDto
          {
                Id = a.Id,              
                
	            
	            
                
	                opis = a.Opis,
	            
	            
                
	                kolicina = a.Količina,
	            
	            
                
	                jedinicnaCijena = a.JedinicnaCijena,
	            
	            
                
	                cijena = a.Cijena,
	            
	            
                
	                popust = a.Popust,
	            
	            
                
	                iznos = a.Iznos,
	            
	            
                
                    PonudaId = a.PonudaId,
	            
          };

        protected override Dictionary<string, Expression<Func<Model.StavkaPonude, object>>> OrderSelectors => orderSelectors;
        private static Dictionary<string, Expression<Func<Model.StavkaPonude, object>>> orderSelectors = new Dictionary<string, Expression<Func<Model.StavkaPonude, object>>>
        {
            [nameof(StavkaPonudeDto.Id).ToLower()] = a => a.Id,
                 
	        
            
	        [nameof(StavkaPonudeDto.opis).ToLower()] = a => a.Opis,
	        
	        
            
	        [nameof(StavkaPonudeDto.kolicina).ToLower()] = a => a.Količina,
	        
	        
            
	        [nameof(StavkaPonudeDto.jedinicnaCijena).ToLower()] = a => a.JedinicnaCijena,
	        
	        
            
	        [nameof(StavkaPonudeDto.cijena).ToLower()] = a => a.Cijena,
	        
	        
            
	        [nameof(StavkaPonudeDto.popust).ToLower()] = a => a.Popust,
	        
	        
            
	        [nameof(StavkaPonudeDto.iznos).ToLower()] = a => a.Iznos,
	        
	        
            
            [nameof(StavkaPonudeDto.PonudaId).ToLower()] = a => a.PonudaId,
	        
        };

        protected override Expression<Func<Model.StavkaPonude, bool>> CreatePKPredicate(int value)
        {
            return a => a.Id == value;
        }
    }
}

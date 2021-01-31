using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.DTOs;
using PlugAndPlay.Dal.Model;
using PlugAndPlay.Dal.QueryHandlers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PlugAndPlay.Dal.QueryHandlers
{
    public class MjestoQueryHandler : GenericQueryHandler<Model.Mjesto, MjestoDto, MjestoDto>
    {

        public MjestoQueryHandler(PlugAndPlayContext ctx, ILogger<MjestoQueryHandler> logger) : base(ctx, logger)
        {
        }

        protected override Expression<Func<Model.Mjesto, MjestoDto>> SelectorInList => SelectorSingle;
        protected override Expression<Func<Model.Mjesto, MjestoDto>> SelectorSingle =>
          a => new MjestoDto
          {
                Id = a.Id,              
                
                
	                postanskiBroj = a.PostanskiBroj,
	            
	            
                
	                naziv = a.Naziv,
	            
	            
                
	                drzavaId = a.DrzavaId,

                    drzavaName=a.Drzava.Naziv
	            
	            
                
          };

        protected override Dictionary<string, Expression<Func<Model.Mjesto, object>>> OrderSelectors => orderSelectors;
        private static Dictionary<string, Expression<Func<Model.Mjesto, object>>> orderSelectors = new Dictionary<string, Expression<Func<Model.Mjesto, object>>>
        {
            [nameof(MjestoDto.Id).ToLower()] = a => a.Id,
            
            
	        [nameof(MjestoDto.postanskiBroj).ToLower()] = a => a.PostanskiBroj,
	        
	        
            
	        [nameof(MjestoDto.naziv).ToLower()] = a => a.Naziv,
	        
	        
            
            [nameof(MjestoDto.drzavaId).ToLower()] = a => a.DrzavaId,
	        
	        
            
        };

        protected override Expression<Func<Model.Mjesto, bool>> CreatePKPredicate(int value)
        {
            return a => a.Id == value;
        }
    }
}

using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.DTOs;
using PlugAndPlay.Dal.Model;
using PlugAndPlay.Dal.QueryHandlers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PlugAndPlay.Dal.QueryHandlers
{
    public class KlijentQueryHandler : GenericQueryHandler<Model.Klijent, KlijentDto, KlijentDto>
    {

        public KlijentQueryHandler(PlugAndPlayContext ctx, ILogger<KlijentQueryHandler> logger) : base(ctx, logger)
        {
        }

        protected override Expression<Func<Model.Klijent, KlijentDto>> SelectorInList => SelectorSingle;
        protected override Expression<Func<Model.Klijent, KlijentDto>> SelectorSingle =>
          a => new KlijentDto
          {
                Id = a.Id,              
                
                
	                naziv = a.Naziv,
	            
	            
                
	                partnerId = a.PartnerId,
                    partnerName=a.Partner.Naziv,
	            
	            
                
	                primarniKontaktId = a.PrimarniKontaktId,
	            
	            
                
	                napomena = a.Napomena,
	           
	            
	            
                
	                adresa = a.Adresa,
	            
	            
                
	                mjestoId = a.MjestoId,
                    mjestoName=a.Mjesto.Naziv

	            
	            
                
          };

        protected override Dictionary<string, Expression<Func<Model.Klijent, object>>> OrderSelectors => orderSelectors;
        private static Dictionary<string, Expression<Func<Model.Klijent, object>>> orderSelectors = new Dictionary<string, Expression<Func<Model.Klijent, object>>>
        {
            [nameof(KlijentDto.Id).ToLower()] = a => a.Id,
            
            
	        [nameof(KlijentDto.naziv).ToLower()] = a => a.Naziv,
	        
	        
            
            [nameof(KlijentDto.partnerId).ToLower()] = a => a.PartnerId,
	        
	        
            
            [nameof(KlijentDto.primarniKontaktId).ToLower()] = a => a.PrimarniKontaktId,
	        
	        
            
	        [nameof(KlijentDto.napomena).ToLower()] = a => a.Napomena,
	       
	        
            
	        [nameof(KlijentDto.adresa).ToLower()] = a => a.Adresa,
	        
	        
            
            [nameof(KlijentDto.mjestoId).ToLower()] = a => a.MjestoId,
	        
	        
            
        };

        protected override Expression<Func<Model.Klijent, bool>> CreatePKPredicate(int value)
        {
            return a => a.Id == value;
        }
    }
}

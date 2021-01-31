using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.DTOs;
using PlugAndPlay.Dal.Model;
using PlugAndPlay.Dal.QueryHandlers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PlugAndPlay.Dal.QueryHandlers
{
    public class KontaktQueryHandler : GenericQueryHandler<Model.Kontakt, KontaktDto, KontaktDto>
    {

        public KontaktQueryHandler(PlugAndPlayContext ctx, ILogger<KontaktQueryHandler> logger) : base(ctx, logger)
        {
        }

        protected override Expression<Func<Model.Kontakt, KontaktDto>> SelectorInList => SelectorSingle;
        protected override Expression<Func<Model.Kontakt, KontaktDto>> SelectorSingle =>
          a => new KontaktDto
          {
                Id = a.Id,              
                
                
	                aktivan = a.Aktivan,
	            
	            
                
	                prefiks = a.Prefiks,
	            
	            
                
	                ime = a.Ime,
	            
	            
                
	                prezime = a.Prezime,
	            
	            
                
	                funkcija = a.Funkcija,
	            
	            
                
	                email = a.Email,
	            
	            
                
	                telefon = a.Telefon,
	            
	            
                
	                jezik = a.Jezik,
	            
	            
                
	                napomena = a.Napomena,
	            
	            
                
                    KlijentId = a.KlijentId,

			  PartnerId = a.PartnerId,

		  };

        protected override Dictionary<string, Expression<Func<Model.Kontakt, object>>> OrderSelectors => orderSelectors;
        private static Dictionary<string, Expression<Func<Model.Kontakt, object>>> orderSelectors = new Dictionary<string, Expression<Func<Model.Kontakt, object>>>
        {
            [nameof(KontaktDto.Id).ToLower()] = a => a.Id,
            
            
	        [nameof(KontaktDto.aktivan).ToLower()] = a => a.Aktivan,
	        
	        
            
	        [nameof(KontaktDto.prefiks).ToLower()] = a => a.Prefiks,
	        
	        
            
	        [nameof(KontaktDto.ime).ToLower()] = a => a.Ime,
	        
	        
            
	        [nameof(KontaktDto.prezime).ToLower()] = a => a.Prezime,
	        
	        
            
	        [nameof(KontaktDto.funkcija).ToLower()] = a => a.Funkcija,
	        
	        
            
	        [nameof(KontaktDto.email).ToLower()] = a => a.Email,
	        
	        
            
	        [nameof(KontaktDto.telefon).ToLower()] = a => a.Telefon,
	        
	        
            
	        [nameof(KontaktDto.jezik).ToLower()] = a => a.Jezik,
	        
	        
            
	        [nameof(KontaktDto.napomena).ToLower()] = a => a.Napomena,
	        
	        
            
            [nameof(KontaktDto.KlijentId).ToLower()] = a => a.KlijentId,

			[nameof(KontaktDto.PartnerId).ToLower()] = a => a.PartnerId,

		};

        protected override Expression<Func<Model.Kontakt, bool>> CreatePKPredicate(int value)
        {
            return a => a.Id == value;
        }
    }
}

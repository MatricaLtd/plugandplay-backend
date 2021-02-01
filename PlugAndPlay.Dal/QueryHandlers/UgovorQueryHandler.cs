using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.DTOs;
using PlugAndPlay.Dal.Model;
using PlugAndPlay.Dal.QueryHandlers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PlugAndPlay.Dal.QueryHandlers
{
    public class UgovorQueryHandler : GenericQueryHandler<Model.Ugovor, UgovorDto, UgovorDto>
    {

        public UgovorQueryHandler(PlugAndPlayContext ctx, ILogger<UgovorQueryHandler> logger) : base(ctx, logger)
        {
        }

        protected override Expression<Func<Model.Ugovor, UgovorDto>> SelectorInList => SelectorSingle;
        protected override Expression<Func<Model.Ugovor, UgovorDto>> SelectorSingle =>
          a => new UgovorDto
          {
                Id = a.Id,              
                
                
	                naziv = a.Naziv,
	            
	            
                
	                godina = a.Godina,
	            
	            
                
	                aktivan = a.Aktivan,
	            
	            
                
	                realizirano = a.Realizirano,
	            
	            
                
	                naplaćeno = a.Naplaceno,
	            
	            
                
	                valuta = a.Valuta,
	            
	            
                
	                valutaPlaćanja = a.ValutaPlacanja,
	            
	            
                
	                aVB = a.Avb,
	            
	            
                
	                commit = a.Commit,
	            
	            
                
	                agePopust = a.AgePopust,
	            
	            
                
	                ugovorFlatPopust = a.UgovorFlatPopust,
	            
	            
                
	                ugovorKoličinaPopust = a.UgovorKoličinaPopust,
	            
	            
                
	                avansKoličina = a.AvansKolicina,
	            
	            
                
	                napomena = a.Napomena,
	            
	            
                
	                //filename = a.Filename,
	            
	            
                
	                klijentId = a.KlijentId,

					klijentName= a.Klijent.Naziv,
	            
	            
                
	                partnerId = a.PartnerId,

					partnerName=a.Partner.Naziv,
	            
	            
                
          };

        protected override Dictionary<string, Expression<Func<Model.Ugovor, object>>> OrderSelectors => orderSelectors;
        private static Dictionary<string, Expression<Func<Model.Ugovor, object>>> orderSelectors = new Dictionary<string, Expression<Func<Model.Ugovor, object>>>
        {
            [nameof(UgovorDto.Id).ToLower()] = a => a.Id,
            
            
	        [nameof(UgovorDto.naziv).ToLower()] = a => a.Naziv,
	        
	        
            
	        [nameof(UgovorDto.godina).ToLower()] = a => a.Godina,
	        
	        
            
	        [nameof(UgovorDto.aktivan).ToLower()] = a => a.Aktivan,
	        
	        
            
	        [nameof(UgovorDto.realizirano).ToLower()] = a => a.Realizirano,
	        
	        
            
	        [nameof(UgovorDto.naplaćeno).ToLower()] = a => a.Naplaceno,
	        
	        
            
	        [nameof(UgovorDto.valuta).ToLower()] = a => a.Valuta,
	        
	        
            
	        [nameof(UgovorDto.valutaPlaćanja).ToLower()] = a => a.ValutaPlacanja,
	        
	        
            
	        [nameof(UgovorDto.aVB).ToLower()] = a => a.Avb,
	        
	        
            
	        [nameof(UgovorDto.commit).ToLower()] = a => a.Commit,
	        
	        
            
	        [nameof(UgovorDto.agePopust).ToLower()] = a => a.AgePopust,
	        
	        
            
	        [nameof(UgovorDto.ugovorFlatPopust).ToLower()] = a => a.UgovorFlatPopust,
	        
	        
            
	        [nameof(UgovorDto.ugovorKoličinaPopust).ToLower()] = a => a.UgovorKoličinaPopust,
	        
	        
            
	        [nameof(UgovorDto.avansKoličina).ToLower()] = a => a.AvansKolicina,
	        
	        
            
	        [nameof(UgovorDto.napomena).ToLower()] = a => a.Napomena,
	        
	        
            
	        //[nameof(UgovorDto.filename).ToLower()] = a => a.Filename,
	        
	        
            
            [nameof(UgovorDto.klijentId).ToLower()] = a => a.KlijentId,
	        
	        
            
            [nameof(UgovorDto.partnerId).ToLower()] = a => a.PartnerId,
	        
	        
            
        };

        protected override Expression<Func<Model.Ugovor, bool>> CreatePKPredicate(int value)
        {
            return a => a.Id == value;
        }
    }
}

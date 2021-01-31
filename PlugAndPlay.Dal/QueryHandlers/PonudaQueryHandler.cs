using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.DTOs;
using PlugAndPlay.Dal.Model;
using PlugAndPlay.Dal.QueryHandlers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PlugAndPlay.Dal.QueryHandlers
{
    public class PonudaQueryHandler : GenericQueryHandler<Model.Ponuda, PonudaDto, PonudaDto>
    {

        public PonudaQueryHandler(PlugAndPlayContext ctx, ILogger<PonudaQueryHandler> logger) : base(ctx, logger)
        {
        }

        protected override Expression<Func<Model.Ponuda, PonudaDto>> SelectorInList => SelectorSingle;
        protected override Expression<Func<Model.Ponuda, PonudaDto>> SelectorSingle =>
          a => new PonudaDto
          {
                Id = a.Id,              
                
                
	                broj = a.Broj,
	            
	            
                
	                status = a.Status,
	            
	            
                
	                statusDatum = a.StatusDatum,
	            
	            
               
	            
	            
                
	                datumKreiranja = a.DatumKreiranja,
	            
	            
                
          
	            
                
	                valutaPlaćanja = a.ValutaPlaćanja,
	            
	            
                
	                startDatum = a.StartDatum,
	            
	            
                
	                endDatum = a.EndDatum,
	            
	            
                
	                oIB = a.Oib,
	            
	            
                
	                brand = a.Brand,
	            
	            
                
	                izvoz = a.Izvoz,
	            
	            
                
	                valuta = a.Valuta,
	            
	            
                
	                napomena = a.Napomena,
	            
	            
                
	                ukupno = a.Ukupno,
	            
	            
                
	                pDV = a.Pdv,
	            
	            
                
	                zaPlatiti = a.ZaPlatiti,
	            

	            
	            
                
	                ugovorId = a.UgovorId,
	            
	            
                
	                partnerId = a.PartnerId,
	            
	            
                
	                klijentId = a.KlijentId,
	            
	            
                
          };

        protected override Dictionary<string, Expression<Func<Model.Ponuda, object>>> OrderSelectors => orderSelectors;
        private static Dictionary<string, Expression<Func<Model.Ponuda, object>>> orderSelectors = new Dictionary<string, Expression<Func<Model.Ponuda, object>>>
        {
            [nameof(PonudaDto.Id).ToLower()] = a => a.Id,
            
            
	        [nameof(PonudaDto.broj).ToLower()] = a => a.Broj,
	        
	        
            
	        [nameof(PonudaDto.status).ToLower()] = a => a.Status,
	        
	        
            
	        [nameof(PonudaDto.statusDatum).ToLower()] = a => a.StatusDatum,
	      
	        
	        
            
	        [nameof(PonudaDto.datumKreiranja).ToLower()] = a => a.DatumKreiranja,
	        
	        
	        
	        
            
	        [nameof(PonudaDto.valutaPlaćanja).ToLower()] = a => a.ValutaPlaćanja,
	        
	        
            
	        [nameof(PonudaDto.startDatum).ToLower()] = a => a.StartDatum,
	        
	        
            
	        [nameof(PonudaDto.endDatum).ToLower()] = a => a.EndDatum,
	        
	        
            
	        [nameof(PonudaDto.oIB).ToLower()] = a => a.Oib,
	        
	        
            
	        [nameof(PonudaDto.brand).ToLower()] = a => a.Brand,
	        
	        
            
	        [nameof(PonudaDto.izvoz).ToLower()] = a => a.Izvoz,
	        
	        
            
	        [nameof(PonudaDto.valuta).ToLower()] = a => a.Valuta,
	        
	        
            
	        [nameof(PonudaDto.napomena).ToLower()] = a => a.Napomena,
	        
	        
            
	        [nameof(PonudaDto.ukupno).ToLower()] = a => a.Ukupno,
	        
	        
            
	        [nameof(PonudaDto.pDV).ToLower()] = a => a.Pdv,
	        
	        
            
	        [nameof(PonudaDto.zaPlatiti).ToLower()] = a => a.ZaPlatiti,
	        
	        
            
	        
	        
            
            [nameof(PonudaDto.ugovorId).ToLower()] = a => a.UgovorId,
	        
	        
            
            [nameof(PonudaDto.partnerId).ToLower()] = a => a.PartnerId,
	        
	        
            
            [nameof(PonudaDto.klijentId).ToLower()] = a => a.KlijentId,
	        
	        
            
        };

        protected override Expression<Func<Model.Ponuda, bool>> CreatePKPredicate(int value)
        {
            return a => a.Id == value;
        }
    }
}

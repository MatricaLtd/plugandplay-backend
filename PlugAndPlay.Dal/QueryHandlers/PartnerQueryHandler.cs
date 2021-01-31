using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.DTOs;
using PlugAndPlay.Dal.Model;
using PlugAndPlay.Dal.QueryHandlers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PlugAndPlay.Dal.QueryHandlers
{
    public class PartnerQueryHandler : GenericQueryHandler<Model.Partner, PartnerDto, PartnerDto>
    {

        public PartnerQueryHandler(PlugAndPlayContext ctx, ILogger<PartnerQueryHandler> logger) : base(ctx, logger)
        {
        }

        protected override Expression<Func<Model.Partner, PartnerDto>> SelectorInList => SelectorSingle;
        protected override Expression<Func<Model.Partner, PartnerDto>> SelectorSingle =>
          a => new PartnerDto
          {
                Id = a.Id,              
                
                
	                naziv = a.Naziv,
	            
	            
                
	                oIB = a.Oib,
	            
	            
                
	                adresa = a.Adresa,
	            
	            
                
	                mjestoId = a.MjestoId,

			  mjestoNaziv = a.Mjesto.Naziv,



			  agencija = a.Agencija,
	            
	            
                
	                aktivan = a.Aktivan,
	            
	            
                
	                izvoz = a.Izvoz,
	            
	            
                
	                racun = a.Racun,
	            
	            
                
	                pDV = a.Pdv,
	            
	            
                
	                valuta = a.Valuta,
	            
	            
                
	                primarniKontaktId = a.PrimarniKontaktId,
	            
	            
                
	                eRacun = a.Eracun,
	            
	            
                
	                eRacunEmail = a.EracunEmail,
	            
	            
                
	                telefon = a.Telefon,
	            
	            
                
	                uvjet = a.Uvjet,
	            
	            
                
	                napomena = a.Napomena,
	            
	            
	            
	            
                
	                limit = a.Limit,
	            
	            
                
	                realizirano = a.Realizirano,
	            
	            
                
	                naplaceno = a.Naplaceno,
	            
	            
                
	                duguje = a.Duguje,
	            
	            
                
	                odgoda = a.Odgoda,
	            
	            
                
	                bonitet = a.Bonitet,
	            
	            
                
	                napomenaUvjet = a.NapomenaUvjet,
	            
	            
                
          };

        protected override Dictionary<string, Expression<Func<Model.Partner, object>>> OrderSelectors => orderSelectors;
        private static Dictionary<string, Expression<Func<Model.Partner, object>>> orderSelectors = new Dictionary<string, Expression<Func<Model.Partner, object>>>
        {
            [nameof(PartnerDto.Id).ToLower()] = a => a.Id,
            
            
	        [nameof(PartnerDto.naziv).ToLower()] = a => a.Naziv,
	        
	        
            
	        [nameof(PartnerDto.oIB).ToLower()] = a => a.Oib,
	        
	        
            
	        [nameof(PartnerDto.adresa).ToLower()] = a => a.Adresa,
	        
	        
            
            [nameof(PartnerDto.mjestoId).ToLower()] = a => a.MjestoId,
	        
	        
            
	        [nameof(PartnerDto.agencija).ToLower()] = a => a.Agencija,
	        
	        
            
	        [nameof(PartnerDto.aktivan).ToLower()] = a => a.Aktivan,
	        
	        
            
	        [nameof(PartnerDto.izvoz).ToLower()] = a => a.Izvoz,
	        
	        
            
	        [nameof(PartnerDto.racun).ToLower()] = a => a.Racun,
	        
	        
            
	        [nameof(PartnerDto.pDV).ToLower()] = a => a.Pdv,
	        
	        
            
	        [nameof(PartnerDto.valuta).ToLower()] = a => a.Valuta,
	        
	        
            
            [nameof(PartnerDto.primarniKontaktId).ToLower()] = a => a.PrimarniKontaktId,
	        
	        
            
	        [nameof(PartnerDto.eRacun).ToLower()] = a => a.Eracun,
	        
	        
            
	        [nameof(PartnerDto.eRacunEmail).ToLower()] = a => a.EracunEmail,
	        
	        
            
	        [nameof(PartnerDto.telefon).ToLower()] = a => a.Telefon,
	        
	        
            
	        [nameof(PartnerDto.uvjet).ToLower()] = a => a.Uvjet,
	        
	        
            
	        [nameof(PartnerDto.napomena).ToLower()] = a => a.Napomena,
	        
	      
	        
	        
            
	        [nameof(PartnerDto.limit).ToLower()] = a => a.Limit,
	        
	        
            
	        [nameof(PartnerDto.realizirano).ToLower()] = a => a.Realizirano,
	        
	        
            
	        [nameof(PartnerDto.naplaceno).ToLower()] = a => a.Naplaceno,
	        
	        
            
	        [nameof(PartnerDto.duguje).ToLower()] = a => a.Duguje,
	        
	        
            
	        [nameof(PartnerDto.odgoda).ToLower()] = a => a.Odgoda,
	        
	        
            
	        [nameof(PartnerDto.bonitet).ToLower()] = a => a.Bonitet,
	        
	        
            
	        [nameof(PartnerDto.napomenaUvjet).ToLower()] = a => a.NapomenaUvjet,
	        
	        
            
        };

        protected override Expression<Func<Model.Partner, bool>> CreatePKPredicate(int value)
        {
            return a => a.Id == value;
        }
    }
}

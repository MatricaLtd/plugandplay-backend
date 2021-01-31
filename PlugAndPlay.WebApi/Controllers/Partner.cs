using MediatR;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.WebApi.Controllers
{

  public class PartnerController : CRUDController<
    PartnerDto, AddPartnerCommand, PartnerDto, UpdatePartnerCommand, DeletePartnerCommand,
    PartnerDto, PartnerDto>
  {

    public PartnerController(IMediator mediator, ILogger<PartnerController> logger) : base(mediator, logger)
    {

    }    

    protected override AddPartnerCommand ModelToCreateCommand(PartnerDto model) => new AddPartnerCommand
    { 
      Id=model.Id,
      
        
	        naziv = model.naziv,
	    
	    
        
	        oIB = model.oIB,
	    
	    
        
	        adresa = model.adresa,
	    
	    
        
	        mjestoId = model.mjestoId,
	    
	    
        
	        agencija = model.agencija,
	    
	    
        
	        aktivan = model.aktivan,
	    
	    
        
	        izvoz = model.izvoz,
	    
	    
        
	        račun = model.racun,
	    
	    
        
	        pDV = model.pDV,
	    
	    
        
	        valuta = model.valuta,
	    
	    
        
	        primarniKontaktId = model.primarniKontaktId,
	    
	    
        
	        eRacun = model.eRacun,
	    
	    
        
	        eRacunEmail = model.eRacunEmail,
	    
	    
        
	        telefon = model.telefon,
	    
	    
        
	        uvjet = model.uvjet,
	    
	    
        
	        napomena = model.napomena,
	    
	    
        
	        kontaktiId = model.kontaktiId,
	    
	    
        
	        limit = model.limit,
	    
	    
        
	        realizirano = model.realizirano,
	    
	    
        
	        naplaceno = model.naplaceno,
	    
	    
        
	        duguje = model.duguje,
	    
	    
        
	        odgoda = model.odgoda,
	    
	    
        
	        bonitet = model.bonitet,
	    
	    
        
	        napomenaUvjet = model.napomenaUvjet,
	    
	    

        
      
    };

    protected override UpdatePartnerCommand ModelToUpdateCommand(PartnerDto model) => new UpdatePartnerCommand
    {
      Id=model.Id,
      
        
	        naziv = model.naziv,
	    
	    
        
	        oIB = model.oIB,
	    
	    
        
	        adresa = model.adresa,
	    
	    
        
	        mjestoId = model.mjestoId,
	    
	    
        
	        agencija = model.agencija,
	    
	    
        
	        aktivan = model.aktivan,
	    
	    
        
	        izvoz = model.izvoz,
	    
	   
			račun=model.racun,
	    
        
	        pDV = model.pDV,
	    
	    
        
	        valuta = model.valuta,
	    
	    
        
	        primarniKontaktId = model.primarniKontaktId,
	    
	    
        
	        eRacun = model.eRacun,
	    
	    
        
	        eRacunEmail = model.eRacunEmail,
	    
	    
        
	        telefon = model.telefon,
	    
	    
        
	        uvjet = model.uvjet,
	    
	    
        
	        napomena = model.napomena,
	    
	    
        
	        kontaktiId = model.kontaktiId,
	    
	    
        
	        limit = model.limit,
	    
	    
        
	        realizirano = model.realizirano,
	    
	    
        
	        naplaceno = model.naplaceno,
	    
	    
        
	        duguje = model.duguje,
	    
	    
        
	        odgoda = model.odgoda,
	    
	    
        
	        bonitet = model.bonitet,
	    
	    
        
	        napomenaUvjet = model.napomenaUvjet,
	    
	    

        
    };

  }
}
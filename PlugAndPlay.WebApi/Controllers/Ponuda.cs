using MediatR;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.WebApi.Controllers
{

  public class PonudaController : CRUDController<
    PonudaDto, AddPonudaCommand, PonudaDto, UpdatePonudaCommand, DeletePonudaCommand,
    PonudaDto, PonudaDto>
  {

    public PonudaController(IMediator mediator, ILogger<PonudaController> logger) : base(mediator, logger)
    {

    }    

    protected override AddPonudaCommand ModelToCreateCommand(PonudaDto model) => new AddPonudaCommand
    { 
      Id=model.Id,
      
        
	        broj = model.broj,
	    
	    
        
	        status = model.status,
	    
	    
        
	        statusDatum = model.statusDatum,
	    
	    
        
	        statusUser = model.statusUser,
	    
	    
        
	        datumKreiranja = model.datumKreiranja,
	    
	    
        
	        vlasnikUser = model.vlasnikUser,
	    
	    
        
	        valutaPlaćanja = model.valutaPlaćanja,
	    
	    
        
	        startDatum = model.startDatum,
	    
	    
        
	        endDatum = model.endDatum,
	    
	    
        
	        oIB = model.oIB,
	    
	    
        
	        brand = model.brand,
	    
	    
        
	        izvoz = model.izvoz,
	    
	    
        
	        valuta = model.valuta,
	    
	    
        
	        napomena = model.napomena,
	    
	    
        
	        ukupno = model.ukupno,
	    
	    
        
	        pDV = model.pDV,
	    
	    
        
	        zaPlatiti = model.zaPlatiti,
	    
	    
        
	        stavkaId = model.stavkaId,
	    
	    
        
	        stavkePopustaId = model.stavkePopustaId,
	    
	    
        
	        ugovorId = model.ugovorId,
	    
	    
        
	        partnerId = model.partnerId,
	    
	    
        
	        klijentId = model.klijentId,
	    
	    

        
      
    };

    protected override UpdatePonudaCommand ModelToUpdateCommand(PonudaDto model) => new UpdatePonudaCommand
    {
      Id=model.Id,
      
        
	        broj = model.broj,
	    
	    
        
	        status = model.status,
	    
	    
        
	        statusDatum = model.statusDatum,
	    
	    
        
	        statusUser = model.statusUser,
	    
	    
        
	        datumKreiranja = model.datumKreiranja,
	    
	    
        
	        vlasnikUser = model.vlasnikUser,
	    
	    
        
	        valutaPlaćanja = model.valutaPlaćanja,
	    
	    
        
	        startDatum = model.startDatum,
	    
	    
        
	        endDatum = model.endDatum,
	    
	    
        
	        oIB = model.oIB,
	    
	    
        
	        brand = model.brand,
	    
	    
        
	        izvoz = model.izvoz,
	    
	    
        
	        valuta = model.valuta,
	    
	    
        
	        napomena = model.napomena,
	    
	    
        
	        ukupno = model.ukupno,
	    
	    
        
	        pDV = model.pDV,
	    
	    
        
	        zaPlatiti = model.zaPlatiti,
	    
	    
        
	        stavkaId = model.stavkaId,
	    
	    
        
	        stavkePopustaId = model.stavkePopustaId,
	    
	    
        
	        ugovorId = model.ugovorId,
	    
	    
        
	        partnerId = model.partnerId,
	    
	    
        
	        klijentId = model.klijentId,
	    
	    

        
    };

  }
}
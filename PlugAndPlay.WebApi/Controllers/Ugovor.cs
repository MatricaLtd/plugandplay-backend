using MediatR;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.WebApi.Controllers
{

  public class UgovorController : CRUDController<
    UgovorDto, AddUgovorCommand, UgovorDto, UpdateUgovorCommand, DeleteUgovorCommand,
    UgovorDto, UgovorDto>
  {

    public UgovorController(IMediator mediator, ILogger<UgovorController> logger) : base(mediator, logger)
    {

    }    

    protected override AddUgovorCommand ModelToCreateCommand(UgovorDto model) => new AddUgovorCommand
    { 
      Id=model.Id,
      
        
	        naziv = model.naziv,
	    
	    
        
	        godina = model.godina,
	    
	    
        
	        aktivan = model.aktivan,
	    
	    
        
	        realizirano = model.realizirano,
	    
	    
        
	        naplaćeno = model.naplaćeno,
	    
	    
        
	        valuta = model.valuta,
	    
	    
        
	        valutaPlaćanja = model.valutaPlaćanja,
	    
	    
        
	        aVB = model.aVB,
	    
	    
        
	        commit = model.commit,
	    
	    
        
	        agePopust = model.agePopust,
	    
	    
        
	        ugovorFlatPopust = model.ugovorFlatPopust,
	    
	    
        
	        ugovorKoličinaPopust = model.ugovorKoličinaPopust,
	    
	    
        
	        avansKoličina = model.avansKoličina,
	    
	    
        
	        napomena = model.napomena,
	    
	    
        
	        filename = model.filename,
	    
	    
        
	        klijentId = model.klijentId,
	    
	    
        
	        partnerId = model.partnerId,
	    
	    

        
      
    };

    protected override UpdateUgovorCommand ModelToUpdateCommand(UgovorDto model) => new UpdateUgovorCommand
    {
      Id=model.Id,
      
        
	        naziv = model.naziv,
	    
	    
        
	        godina = model.godina,
	    
	    
        
	        aktivan = model.aktivan,
	    
	    
        
	        realizirano = model.realizirano,
	    
	    
        
	        naplaćeno = model.naplaćeno,
	    
	    
        
	        valuta = model.valuta,
	    
	    
        
	        valutaPlaćanja = model.valutaPlaćanja,
	    
	    
        
	        aVB = model.aVB,
	    
	    
        
	        commit = model.commit,
	    
	    
        
	        agePopust = model.agePopust,
	    
	    
        
	        ugovorFlatPopust = model.ugovorFlatPopust,
	    
	    
        
	        ugovorKoličinaPopust = model.ugovorKoličinaPopust,
	    
	    
        
	        avansKoličina = model.avansKoličina,
	    
	    
        
	        napomena = model.napomena,
	    
	    
        
	        filename = model.filename,
	    
	    
        
	        klijentId = model.klijentId,
	    
	    
        
	        partnerId = model.partnerId,
	    
	    

        
    };

  }
}
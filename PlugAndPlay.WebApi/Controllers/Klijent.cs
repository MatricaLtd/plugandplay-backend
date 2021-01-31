using MediatR;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.WebApi.Controllers
{

  public class KlijentController : CRUDController<
    KlijentDto, AddKlijentCommand, KlijentDto, UpdateKlijentCommand, DeleteKlijentCommand,
    KlijentDto, KlijentDto>
  {

    public KlijentController(IMediator mediator, ILogger<KlijentController> logger) : base(mediator, logger)
    {

    }    

    protected override AddKlijentCommand ModelToCreateCommand(KlijentDto model) => new AddKlijentCommand
    { 
      Id=model.Id,
      
        
	        naziv = model.naziv,
	    
	    
        
	        partnerId = model.partnerId,
	    
	    
        
	        primarniKontaktId = model.primarniKontaktId,
	    
	    
        
	        napomena = model.napomena,
	    
	    
        
	        kontaktiId = model.kontaktiId,
	    
	    
        
	        adresa = model.adresa,
	    
	    
        
	        mjestoId = model.mjestoId,
	    
	    

        
      
    };

    protected override UpdateKlijentCommand ModelToUpdateCommand(KlijentDto model) => new UpdateKlijentCommand
    {
      Id=model.Id,
      
        
	        naziv = model.naziv,
	    
	    
        
	        partnerId = model.partnerId,
	    
	    
        
	        primarniKontaktId = model.primarniKontaktId,
	    
	    
        
	        napomena = model.napomena,
	    
	    
        
	        kontaktiId = model.kontaktiId,
	    
	    
        
	        adresa = model.adresa,
	    
	    
        
	        mjestoId = model.mjestoId,
	    
	    

        
    };

  }
}
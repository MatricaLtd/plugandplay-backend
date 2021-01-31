using MediatR;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.WebApi.Controllers
{

  public class KontaktController : CRUDController<
    KontaktDto, AddKontaktCommand, KontaktDto, UpdateKontaktCommand, DeleteKontaktCommand,
    KontaktDto, KontaktDto>
  {

    public KontaktController(IMediator mediator, ILogger<KontaktController> logger) : base(mediator, logger)
    {

    }    

    protected override AddKontaktCommand ModelToCreateCommand(KontaktDto model) => new AddKontaktCommand
    { 
      Id=model.Id,
      
        
	        aktivan = model.aktivan,
	    
	    
        
	        prefiks = model.prefiks,
	    
	    
        
	        ime = model.ime,
	    
	    
        
	        prezime = model.prezime,
	    
	    
        
	        funkcija = model.funkcija,
	    
	    
        
	        email = model.email,
	    
	    
        
	        telefon = model.telefon,
	    
	    
        
	        jezik = model.jezik,
	    
	    
        
	        napomena = model.napomena,
	    
	    

        
        KlijentId = model.KlijentId,

		PartnerId = model.PartnerId,


	};

    protected override UpdateKontaktCommand ModelToUpdateCommand(KontaktDto model) => new UpdateKontaktCommand
    {
      Id=model.Id,
      
        
	        aktivan = model.aktivan,
	    
	    
        
	        prefiks = model.prefiks,
	    
	    
        
	        ime = model.ime,
	    
	    
        
	        prezime = model.prezime,
	    
	    
        
	        funkcija = model.funkcija,
	    
	    
        
	        email = model.email,
	    
	    
        
	        telefon = model.telefon,
	    
	    
        
	        jezik = model.jezik,
	    
	    
        
	        napomena = model.napomena,
	    
	    

        
        KlijentId = model.KlijentId,

		PartnerId = model.PartnerId,

	};

  }
}
using MediatR;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.WebApi.Controllers
{

  public class StavkaPonudeController : CRUDController<
    StavkaPonudeDto, AddStavkaPonudeCommand, StavkaPonudeDto, UpdateStavkaPonudeCommand, DeleteStavkaPonudeCommand,
    StavkaPonudeDto, StavkaPonudeDto>
  {

    public StavkaPonudeController(IMediator mediator, ILogger<StavkaPonudeController> logger) : base(mediator, logger)
    {

    }    

    protected override AddStavkaPonudeCommand ModelToCreateCommand(StavkaPonudeDto model) => new AddStavkaPonudeCommand
    { 
      Id=model.Id,
      
       
	    
	    
        
	        opis = model.opis,
	    
	    
        
	        količina = model.kolicina,
	    
	    
        
	        jediničnaCijena = model.jedinicnaCijena,
	    
	    
        
	        cijena = model.cijena,
	    
	    
        
	        popust = model.popust,
	    
	    
        
	        iznos = model.iznos,
	    
	    

        
        PonudaId = model.PonudaId,
	    
      
    };

    protected override UpdateStavkaPonudeCommand ModelToUpdateCommand(StavkaPonudeDto model) => new UpdateStavkaPonudeCommand
    {
      Id=model.Id,
      
	    
	    
        
	        opis = model.opis,
	    
	    
        
	        količina = model.kolicina,
	    
	    
        
	        jediničnaCijena = model.jedinicnaCijena,
	    
	    
        
	        cijena = model.cijena,
	    
	    
        
	        popust = model.popust,
	    
	    
        
	        iznos = model.iznos,
	    
	    

        
        PonudaId = model.PonudaId,
	    
    };

  }
}
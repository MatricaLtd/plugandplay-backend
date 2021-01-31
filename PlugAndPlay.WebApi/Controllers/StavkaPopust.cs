using MediatR;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.WebApi.Controllers
{

  public class StavkaPopustController : CRUDController<
    StavkaPopustDto, AddStavkaPopustCommand, StavkaPopustDto, UpdateStavkaPopustCommand, DeleteStavkaPopustCommand,
    StavkaPopustDto, StavkaPopustDto>
  {

    public StavkaPopustController(IMediator mediator, ILogger<StavkaPopustController> logger) : base(mediator, logger)
    {

    }    

    protected override AddStavkaPopustCommand ModelToCreateCommand(StavkaPopustDto model) => new AddStavkaPopustCommand
    { 
      Id=model.Id,
      
        
	        agePopust = model.agePopust,
	    
	    
        
	        ageIznos = model.ageIznos,
	    
	    
        
	        avansPopust = model.avansPopust,
	    
	    
        
	        avansIznos = model.avansIznos,
	    
	    

        
        PonudaId = model.PonudaId,
	    
      
    };

    protected override UpdateStavkaPopustCommand ModelToUpdateCommand(StavkaPopustDto model) => new UpdateStavkaPopustCommand
    {
      Id=model.Id,
      
        
	        agePopust = model.agePopust,
	    
	    
        
	        ageIznos = model.ageIznos,
	    
	    
        
	        avansPopust = model.avansPopust,
	    
	    
        
	        avansIznos = model.avansIznos,
	    
	    

        
        PonudaId = model.PonudaId,
	    
    };

  }
}
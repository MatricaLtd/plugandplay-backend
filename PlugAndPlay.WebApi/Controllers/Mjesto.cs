using MediatR;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.WebApi.Controllers
{

  public class MjestoController : CRUDController<
    MjestoDto, AddMjestoCommand, MjestoDto, UpdateMjestoCommand, DeleteMjestoCommand,
    MjestoDto, MjestoDto>
  {

    public MjestoController(IMediator mediator, ILogger<MjestoController> logger) : base(mediator, logger)
    {

    }    

    protected override AddMjestoCommand ModelToCreateCommand(MjestoDto model) => new AddMjestoCommand
    { 
      Id=model.Id,
      
        
	        postanskiBroj = model.postanskiBroj,
	    
	    
        
	        naziv = model.naziv,
	    
	    
        
	        drzavaId = model.drzavaId
	    
            
        
      
    };

    protected override UpdateMjestoCommand ModelToUpdateCommand(MjestoDto model) => new UpdateMjestoCommand
    {
      Id=model.Id,
      
        
	        postanskiBroj = model.postanskiBroj,
	    
	    
        
	        naziv = model.naziv,
	    
	    
        
	        drzavaId = model.drzavaId,
	    
	    

        
    };

  }
}
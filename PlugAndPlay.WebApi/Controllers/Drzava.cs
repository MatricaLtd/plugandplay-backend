using MediatR;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.WebApi.Controllers
{

  public class DrzavaController : CRUDController<
    DrzavaDto, AddDrzavaCommand, DrzavaDto, UpdateDrzavaCommand, DeleteDrzavaCommand,
    DrzavaDto, DrzavaDto>
  {

    public DrzavaController(IMediator mediator, ILogger<DrzavaController> logger) : base(mediator, logger)
    {

    }    

    protected override AddDrzavaCommand ModelToCreateCommand(DrzavaDto model) => new AddDrzavaCommand
    { 
      Id=model.Id,
      
        
	        naziv = model.naziv,
	    
	    

        
      
    };

    protected override UpdateDrzavaCommand ModelToUpdateCommand(DrzavaDto model) => new UpdateDrzavaCommand
    {
      Id=model.Id,
      
        
	        naziv = model.naziv,
	    
	    

        
    };

  }
}
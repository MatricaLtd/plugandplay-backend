using MediatR;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Contracting.Security;

namespace PlugAndPlay.WebApi.Controllers
{

  public class UserController : CRUDController<
    UserDto, AddUserCommand, UserDto, UpdateUserCommand, DeleteUserCommand,
    UserDto, UserDto>
  {

    public UserController(IMediator mediator, ILogger<UserController> logger) : base(mediator, logger)
    {

    }    

    protected override AddUserCommand ModelToCreateCommand(UserDto model) => new AddUserCommand
    {
        UserId = model.Id,
      FirstName = model.FirstName,
      LastName=model.LastName,
      Password=model.Password

	    
	    

        
      
    };

    protected override UpdateUserCommand ModelToUpdateCommand(UserDto model) => new UpdateUserCommand
    {
      Id=model.Id,
      FirstName = model.FirstName,
      LastName=model.LastName,
      Password=model.Password
	    
	    

        
    };

  }
}
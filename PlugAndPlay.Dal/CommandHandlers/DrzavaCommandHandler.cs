using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Dal.Model;
using System.Threading.Tasks;

namespace PlugAndPlay.Dal.CommandHandlers
{
  public class DrzavaCommandHandler : GenericCommandHandler<Model.Drzava, AddDrzavaCommand, UpdateDrzavaCommand, DeleteDrzavaCommand>,
    IRequestHandler<DeleteDrzavaCommand>, IRequestHandler<AddDrzavaCommand, int>, IRequestHandler<UpdateDrzavaCommand>
  {
    
    public DrzavaCommandHandler(PlugAndPlayContext ctx, ILogger<DrzavaCommandHandler> logger) : base(ctx, logger)
    {
      
    }

    protected override Task<Model.Drzava> LoadForUpdate(int id)
    {
      return ctx.Drzava.FirstOrDefaultAsync(a => a.Id == id);
    }

    protected override void CopyValues(UpdateDrzavaCommand request, Model.Drzava item)
    {

       
        
	        item.Naziv = request.naziv;
	    
	    

        
      
    }

    protected override Model.Drzava CreateItem(AddDrzavaCommand request) => new Model.Drzava
    {
      Id=request.Id,
      
        
	        Naziv = request.naziv,
	    
	    

        
    };  
  }
}

using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Dal.Model;
using System.Threading.Tasks;

namespace PlugAndPlay.Dal.CommandHandlers
{
  public class StavkaPopustCommandHandler : GenericCommandHandler<Model.StavkaPopust, AddStavkaPopustCommand, UpdateStavkaPopustCommand, DeleteStavkaPopustCommand>,
    IRequestHandler<DeleteStavkaPopustCommand>, IRequestHandler<AddStavkaPopustCommand, int>, IRequestHandler<UpdateStavkaPopustCommand>
  {
    
    public StavkaPopustCommandHandler(PlugAndPlayContext ctx, ILogger<StavkaPopustCommandHandler> logger) : base(ctx, logger)
    {
      
    }

    protected override Task<Model.StavkaPopust> LoadForUpdate(int id)
    {
      return ctx.StavkaPopust.FirstOrDefaultAsync(a => a.Id == id);
    }

    protected override void CopyValues(UpdateStavkaPopustCommand request, Model.StavkaPopust item)
    {

       
        
	        item.AgePopust = request.agePopust;
	    
	    
        
	        item.AgeIznos = request.ageIznos;
	    
	    
        
	        item.AvansPopust = request.avansPopust;
	    
	    
        
	        item.AvansIznos = request.avansIznos;
	    
	    

        
        item.PonudaId = request.PonudaId;
	    
      
    }

    protected override Model.StavkaPopust CreateItem(AddStavkaPopustCommand request) => new Model.StavkaPopust
    {
      Id=request.Id,
      
        
	        AgePopust = request.agePopust,
	    
	    
        
	        AgeIznos = request.ageIznos,
	    
	    
        
	        AvansPopust = request.avansPopust,
	    
	    
        
	        AvansIznos = request.avansIznos,
	    
	    

        
        PonudaId = request.PonudaId,
	    
    };  
  }
}

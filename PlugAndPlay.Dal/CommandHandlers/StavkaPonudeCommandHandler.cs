using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Dal.Model;
using System.Threading.Tasks;

namespace PlugAndPlay.Dal.CommandHandlers
{
  public class StavkaPonudeCommandHandler : GenericCommandHandler<Model.StavkaPonude, AddStavkaPonudeCommand, UpdateStavkaPonudeCommand, DeleteStavkaPonudeCommand>,
    IRequestHandler<DeleteStavkaPonudeCommand>, IRequestHandler<AddStavkaPonudeCommand, int>, IRequestHandler<UpdateStavkaPonudeCommand>
  {
    
    public StavkaPonudeCommandHandler(PlugAndPlayContext ctx, ILogger<StavkaPonudeCommandHandler> logger) : base(ctx, logger)
    {
      
    }

    protected override Task<Model.StavkaPonude> LoadForUpdate(int id)
    {
      return ctx.StavkaPonude.FirstOrDefaultAsync(a => a.Id == id);
    }

    protected override void CopyValues(UpdateStavkaPonudeCommand request, Model.StavkaPonude item)
    {

	    
	    
        
	        item.Opis = request.opis;
	    
	    
        
	        item.Količina = request.količina;
	    
	    
        
	        item.JedinicnaCijena = request.jediničnaCijena;
	    
	    
        
	        item.Cijena = request.cijena;
	    
	    
        
	        item.Popust = request.popust;
	    
	    
        
	        item.Iznos = request.iznos;
	    
	    

        
        item.PonudaId = request.PonudaId;
	    
      
    }

    protected override Model.StavkaPonude CreateItem(AddStavkaPonudeCommand request) => new Model.StavkaPonude
    {
      Id=request.Id,
      
        

	    
        
	        Opis = request.opis,
	    
	    
        
	        Količina = request.količina,
	    
	    
        
	        JedinicnaCijena = request.jediničnaCijena,
	    
	    
        
	        Cijena = request.cijena,
	    
	    
        
	        Popust = request.popust,
	    
	    
        
	        Iznos = request.iznos,
	    
	    

        
        PonudaId = request.PonudaId,
	    
    };  
  }
}

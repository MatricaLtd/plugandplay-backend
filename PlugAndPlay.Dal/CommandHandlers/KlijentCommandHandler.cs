using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Dal.Model;
using System.Threading.Tasks;

namespace PlugAndPlay.Dal.CommandHandlers
{
  public class KlijentCommandHandler : GenericCommandHandler<Model.Klijent, AddKlijentCommand, UpdateKlijentCommand, DeleteKlijentCommand>,
    IRequestHandler<DeleteKlijentCommand>, IRequestHandler<AddKlijentCommand, int>, IRequestHandler<UpdateKlijentCommand>
  {
    
    public KlijentCommandHandler(PlugAndPlayContext ctx, ILogger<KlijentCommandHandler> logger) : base(ctx, logger)
    {
      
    }

    protected override Task<Model.Klijent> LoadForUpdate(int id)
    {
      return ctx.Klijent.FirstOrDefaultAsync(a => a.Id == id);
    }

    protected override void CopyValues(UpdateKlijentCommand request, Model.Klijent item)
    {

       
        
	        item.Naziv = request.naziv;
	    
	    
        
	        item.PartnerId = request.partnerId;
	    
	    
        
	        item.PrimarniKontaktId = request.primarniKontaktId;
	    
	    
        
	        item.Napomena = request.napomena;
	    
	   
	    
	    
        
	        item.Adresa = request.adresa;
	    
	    
        
	        item.MjestoId = request.mjestoId;
	    
	    

        
      
    }

    protected override Model.Klijent CreateItem(AddKlijentCommand request) => new Model.Klijent
    {
      Id=request.Id,
      
        
	        Naziv = request.naziv,
	    
	    
        
	        PartnerId = request.partnerId,
	    
	    
        
	        PrimarniKontaktId = request.primarniKontaktId,
	    
	    
        
	        Napomena = request.napomena,
	    
	    
        
	    
	    
        
	        Adresa = request.adresa,
	    
	    
        
	        MjestoId = request.mjestoId,
	    
	    

        
    };  
  }
}

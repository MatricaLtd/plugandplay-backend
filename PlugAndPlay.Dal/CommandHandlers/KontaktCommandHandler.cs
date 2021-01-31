using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Dal.Model;
using System.Threading.Tasks;

namespace PlugAndPlay.Dal.CommandHandlers
{
  public class KontaktCommandHandler : GenericCommandHandler<Model.Kontakt, AddKontaktCommand, UpdateKontaktCommand, DeleteKontaktCommand>,
    IRequestHandler<DeleteKontaktCommand>, IRequestHandler<AddKontaktCommand, int>, IRequestHandler<UpdateKontaktCommand>
  {
    
    public KontaktCommandHandler(PlugAndPlayContext ctx, ILogger<KontaktCommandHandler> logger) : base(ctx, logger)
    {
      
    }

    protected override Task<Model.Kontakt> LoadForUpdate(int id)
    {
      return ctx.Kontakt.FirstOrDefaultAsync(a => a.Id == id);
    }

    protected override void CopyValues(UpdateKontaktCommand request, Model.Kontakt item)
    {

       
        
	        item.Aktivan = request.aktivan;
	    
	    
        
	        item.Prefiks = request.prefiks;
	    
	    
        
	        item.Ime = request.ime;
	    
	    
        
	        item.Prezime = request.prezime;
	    
	    
        
	        item.Funkcija = request.funkcija;
	    
	    
        
	        item.Email = request.email;
	    
	    
        
	        item.Telefon = request.telefon;
	    
	    
        
	        item.Jezik = request.jezik;
	    
	    
        
	        item.Napomena = request.napomena;
	    
	    

        
        item.KlijentId = request.KlijentId;

			item.PartnerId = request.PartnerId;
	    
      
    }

    protected override Model.Kontakt CreateItem(AddKontaktCommand request) => new Model.Kontakt
    {
      Id=request.Id,
      
        
	        Aktivan = request.aktivan,
	    
	    
        
	        Prefiks = request.prefiks,
	    
	    
        
	        Ime = request.ime,
	    
	    
        
	        Prezime = request.prezime,
	    
	    
        
	        Funkcija = request.funkcija,
	    
	    
        
	        Email = request.email,
	    
	    
        
	        Telefon = request.telefon,
	    
	    
        
	        Jezik = request.jezik,
	    
	    
        
	        Napomena = request.napomena,
	    
	    

        
        KlijentId = request.KlijentId,
		PartnerId=request.PartnerId
	    
    };  
  }
}

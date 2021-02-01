using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Dal.Model;
using System.Threading.Tasks;

namespace PlugAndPlay.Dal.CommandHandlers
{
  public class UgovorCommandHandler : GenericCommandHandler<Model.Ugovor, AddUgovorCommand, UpdateUgovorCommand, DeleteUgovorCommand>,
    IRequestHandler<DeleteUgovorCommand>, IRequestHandler<AddUgovorCommand, int>, IRequestHandler<UpdateUgovorCommand>
  {
    
    public UgovorCommandHandler(PlugAndPlayContext ctx, ILogger<UgovorCommandHandler> logger) : base(ctx, logger)
    {
      
    }

    protected override Task<Model.Ugovor> LoadForUpdate(int id)
    {
      return ctx.Ugovor.FirstOrDefaultAsync(a => a.Id == id);
    }

    protected override void CopyValues(UpdateUgovorCommand request, Model.Ugovor item)
    {

       
        
	        item.Naziv = request.naziv;
	    
	    
        
	        item.Godina = request.godina;
	    
	    
        
	        item.Aktivan = request.aktivan;
	    
	    
        
	        item.Realizirano = request.realizirano;
	    
	    
        
	        item.Naplaceno = request.naplaćeno;
	    
	    
        
	        item.Valuta = request.valuta;
	    
	    
        
	        item.ValutaPlacanja = request.valutaPlaćanja;
	    
	    
        
	        item.Avb = request.aVB;
	    
	    
        
	        item.Commit = request.commit;
	    
	    
        
	        item.AgePopust = request.agePopust;
	    
	    
        
	        item.UgovorFlatPopust = request.ugovorFlatPopust;
	    
	    
        
	        item.UgovorKoličinaPopust = request.ugovorKoličinaPopust;
	    
	    
        
	        item.AvansKolicina = request.avansKoličina;
	    
	    
        
	        item.Napomena = request.napomena;
	    
	    
        
	        //item.Filename = request.filename;
	    
	    
        
	        item.KlijentId = request.klijentId;
	    
	    
        
	        item.PartnerId = request.partnerId;
	    
	    

        
      
    }

    protected override Model.Ugovor CreateItem(AddUgovorCommand request) => new Model.Ugovor
    {
      Id=request.Id,
      
        
	        Naziv = request.naziv,
	    
	    
        
	        Godina = request.godina,
	    
	    
        
	        Aktivan = request.aktivan,
	    
	    
        
	        Realizirano = request.realizirano,
	    
	    
        
	        Naplaceno = request.naplaćeno,
	    
	    
        
	        Valuta = request.valuta,
	    
	    
        
	        ValutaPlacanja = request.valutaPlaćanja,
	    
	    
        
	        Avb = request.aVB,
	    
	    
        
	        Commit = request.commit,
	    
	    
        
	        AgePopust = request.agePopust,
	    
	    
        
	        UgovorFlatPopust = request.ugovorFlatPopust,
	    
	    
        
	        UgovorKoličinaPopust = request.ugovorKoličinaPopust,
	    
	    
        
	        AvansKolicina = request.avansKoličina,
	    
	    
        
	        Napomena = request.napomena,
	    
	    
        
	        //Filename = request.filename,
	    
	    
        
	        KlijentId = request.klijentId,
	    
	    
        
	        PartnerId = request.partnerId,
	    
	    

        
    };  
  }
}

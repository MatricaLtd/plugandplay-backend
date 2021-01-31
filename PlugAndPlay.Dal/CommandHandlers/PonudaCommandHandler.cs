using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Dal.Model;
using System.Threading.Tasks;

namespace PlugAndPlay.Dal.CommandHandlers
{
  public class PonudaCommandHandler : GenericCommandHandler<Model.Ponuda, AddPonudaCommand, UpdatePonudaCommand, DeletePonudaCommand>,
    IRequestHandler<DeletePonudaCommand>, IRequestHandler<AddPonudaCommand, int>, IRequestHandler<UpdatePonudaCommand>
  {
    
    public PonudaCommandHandler(PlugAndPlayContext ctx, ILogger<PonudaCommandHandler> logger) : base(ctx, logger)
    {
      
    }

    protected override Task<Model.Ponuda> LoadForUpdate(int id)
    {
      return ctx.Ponuda.FirstOrDefaultAsync(a => a.Id == id);
    }

    protected override void CopyValues(UpdatePonudaCommand request, Model.Ponuda item)
    {

       
        
	        item.Broj = request.broj;
	    
	    
        
	        item.Status = request.status;
	    
	    
        
	        item.StatusDatum = request.statusDatum;
	    
	       
	    
        
	        item.DatumKreiranja = request.datumKreiranja;
	    
	    
        
    
	    
        
	        item.ValutaPlaćanja = request.valutaPlaćanja;
	    
	    
        
	        item.StartDatum = request.startDatum;
	    
	    
        
	        item.EndDatum = request.endDatum;
	    
	    
        
	        item.Oib = request.oIB;
	    
	    
        
	        item.Brand = request.brand;
	    
	    
        
	        item.Izvoz = request.izvoz;
	    
	    
        
	        item.Valuta = request.valuta;
	    
	    
        
	        item.Napomena = request.napomena;
	    
	    
        
	        item.Ukupno = request.ukupno;
	    
	    
        
	        item.Pdv = request.pDV;
	    
	    
        
	        item.ZaPlatiti = request.zaPlatiti;
	  
	    
	    
        
	        item.UgovorId = request.ugovorId;
	    
	    
        
	        item.PartnerId = request.partnerId;
	    
	    
        
	        item.KlijentId = request.klijentId;
	    
	    

        
      
    }

    protected override Model.Ponuda CreateItem(AddPonudaCommand request) => new Model.Ponuda
    {
      Id=request.Id,
      
        
	        Broj = request.broj,
	    
	    
        
	        Status = request.status,
	    
	    
        
	        StatusDatum = request.statusDatum,
	    
	    
       
	    
	    
        
	        DatumKreiranja = request.datumKreiranja,
	    
	    
       
	    
	    
        
	        ValutaPlaćanja = request.valutaPlaćanja,
	    
	    
        
	        StartDatum = request.startDatum,
	    
	    
        
	        EndDatum = request.endDatum,
	    
	    
        
	        Oib = request.oIB,
	    
	    
        
	        Brand = request.brand,
	    
	    
        
	        Izvoz = request.izvoz,
	    
	    
        
	        Valuta = request.valuta,
	    
	    
        
	        Napomena = request.napomena,
	    
	    
        
	        Ukupno = request.ukupno,
	    
	    
        
	        Pdv = request.pDV,
	    
	    
        
	        ZaPlatiti = request.zaPlatiti,
     
	        UgovorId = request.ugovorId,
	    
	    
        
	        PartnerId = request.partnerId,
	    
	    
        
	        KlijentId = request.klijentId,
	    
	    

        
    };  
  }
}

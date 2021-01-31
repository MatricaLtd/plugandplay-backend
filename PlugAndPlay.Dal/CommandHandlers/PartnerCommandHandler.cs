using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Dal.Model;
using System.Threading.Tasks;

namespace PlugAndPlay.Dal.CommandHandlers
{
  public class PartnerCommandHandler : GenericCommandHandler<Model.Partner, AddPartnerCommand, UpdatePartnerCommand, DeletePartnerCommand>,
    IRequestHandler<DeletePartnerCommand>, IRequestHandler<AddPartnerCommand, int>, IRequestHandler<UpdatePartnerCommand>
  {
    
    public PartnerCommandHandler(PlugAndPlayContext ctx, ILogger<PartnerCommandHandler> logger) : base(ctx, logger)
    {
      
    }

    protected override Task<Model.Partner> LoadForUpdate(int id)
    {
      return ctx.Partner.FirstOrDefaultAsync(a => a.Id == id);
    }

    protected override void CopyValues(UpdatePartnerCommand request, Model.Partner item)
    {

       
        
	        item.Naziv = request.naziv;
	    
	    
        
	        item.Oib = request.oIB;
	    
	    
        
	        item.Adresa = request.adresa;
	    
	    
        
	        item.MjestoId = request.mjestoId;
	    
	    
        
	        item.Agencija = request.agencija;
	    
	    
        
	        item.Aktivan = request.aktivan;
	    
	    
        
	        item.Izvoz = request.izvoz;
	    
	    
        
	        item.Racun = request.račun;
	    
	    
        
	        item.Pdv = request.pDV;
	    
	    
        
	        item.Valuta = request.valuta;
	    
	    
        
	        item.PrimarniKontaktId = request.primarniKontaktId;
	    
	    
        
	        item.Eracun = request.eRacun;
	    
	    
        
	        item.EracunEmail = request.eRacunEmail;
	    
	    
        
	        item.Telefon = request.telefon;
	    
	    
        
	        item.Uvjet = request.uvjet;
	    
	    
        
	        item.Napomena = request.napomena;
	    
	    
       
	    
	    
        
	        item.Limit = request.limit;
	    
	    
        
	        item.Realizirano = request.realizirano;
	    
	    
        
	        item.Naplaceno = request.naplaceno;
	    
	    
        
	        item.Duguje = request.duguje;
	    
	    
        
	        item.Odgoda = request.odgoda;
	    
	    
        
	        item.Bonitet = request.bonitet;
	    
	    
        
	        item.NapomenaUvjet = request.napomenaUvjet;
	    
	    

        
      
    }

    protected override Model.Partner CreateItem(AddPartnerCommand request) => new Model.Partner
    {
      Id=request.Id,
      
        
	        Naziv = request.naziv,
	    
	    
        
	        Oib = request.oIB,
	    
	    
        
	        Adresa = request.adresa,
	    
	    
        
	        MjestoId = request.mjestoId,
	    
	    
        
	        Agencija = request.agencija,
	    
	    
        
	        Aktivan = request.aktivan,
	    
	    
        
	        Izvoz = request.izvoz,
	    
	    
        
	        Racun = request.račun,
	    
	    
        
	        Pdv = request.pDV,
	    
	    
        
	        Valuta = request.valuta,
	    
	    
        
	        PrimarniKontaktId = request.primarniKontaktId,
	    
	    
        
	        Eracun = request.eRacun,
	    
	    
        
	        EracunEmail = request.eRacunEmail,
	    
	    
        
	        Telefon = request.telefon,
	    
	    
        
	        Uvjet = request.uvjet,
	    
	    
        
	        Napomena = request.napomena,
	    
	    
	    
	    
        
	        Limit = request.limit,
	    
	    
        
	        Realizirano = request.realizirano,
	    
	    
        
	        Naplaceno = request.naplaceno,
	    
	    
        
	        Duguje = request.duguje,
	    
	    
        
	        Odgoda = request.odgoda,
	    
	    
        
	        Bonitet = request.bonitet,
	    
	    
        
	        NapomenaUvjet = request.napomenaUvjet,
	    
	    

        
    };  
  }
}

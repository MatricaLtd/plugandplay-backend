using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlugAndPlay.Contracting.Commands;
using PlugAndPlay.Dal.Model;
using System.Threading.Tasks;

namespace PlugAndPlay.Dal.CommandHandlers
{
  public class MjestoCommandHandler : GenericCommandHandler<Model.Mjesto, AddMjestoCommand, UpdateMjestoCommand, DeleteMjestoCommand>,
    IRequestHandler<DeleteMjestoCommand>, IRequestHandler<AddMjestoCommand, int>, IRequestHandler<UpdateMjestoCommand>
  {
    
    public MjestoCommandHandler(PlugAndPlayContext ctx, ILogger<MjestoCommandHandler> logger) : base(ctx, logger)
    {
      
    }

    protected override Task<Model.Mjesto> LoadForUpdate(int id)
    {
      return ctx.Mjesto.FirstOrDefaultAsync(a => a.Id == id);
    }

    protected override void CopyValues(UpdateMjestoCommand request, Model.Mjesto item)
    {

       
        
	        item.PostanskiBroj = request.postanskiBroj;
	    
	    
        
	        item.Naziv = request.naziv;
	    
	    
        
	        item.DrzavaId = request.drzavaId;
	    
	    

        
      
    }

    protected override Model.Mjesto CreateItem(AddMjestoCommand request) => new Model.Mjesto
    {
      Id=request.Id,
      
        
	        PostanskiBroj = request.postanskiBroj,
	    
	    
        
	        Naziv = request.naziv,
	    
	    
        
	        DrzavaId = request.drzavaId,
	    
	    

        
    };  
  }
}

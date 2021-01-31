using System;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.Contracting.Commands
{
  public class AddStavkaPopustCommand: AddCommand
  {
    public int Id { get; set; }
		
        
	    public decimal agePopust { get; set; }
	    
	    
        
	    public decimal ageIznos { get; set; }
	    
	    
        
	    public decimal avansPopust { get; set; }
	    
	    
        
	    public decimal avansIznos { get; set; }
	    
	    

		
	    public int PonudaId { get; set; }
	    
  }
}

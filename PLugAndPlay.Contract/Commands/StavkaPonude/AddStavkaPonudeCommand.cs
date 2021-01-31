using System;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.Contracting.Commands
{
  public class AddStavkaPonudeCommand: AddCommand
  {
    public int Id { get; set; }
		
        
	    
	    
        
	    public string opis { get; set; }
	    
	    
        
	    public decimal količina { get; set; }
	    
	    
        
	    public decimal jediničnaCijena { get; set; }
	    
	    
        
	    public decimal cijena { get; set; }
	    
	    
        
	    public decimal popust { get; set; }
	    
	    
        
	    public decimal iznos { get; set; }
	    
	    

		
	    public int PonudaId { get; set; }
	    
  }
}

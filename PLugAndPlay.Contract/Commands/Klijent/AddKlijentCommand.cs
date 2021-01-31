using System;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.Contracting.Commands
{
  public class AddKlijentCommand: AddCommand
  {
    public int Id { get; set; }
		
        
	    public string naziv { get; set; }
	    
	    
        
	    public int partnerId { get; set; }
	    
	    
        
	    public int primarniKontaktId { get; set; }
	    
	    
        
	    public string napomena { get; set; }
	    
	    
        
	    public int kontaktiId { get; set; }
	    
	    
        
	    public string adresa { get; set; }
	    
	    
        
	    public int mjestoId { get; set; }
	    
	    

		
  }
}

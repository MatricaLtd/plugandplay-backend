using System;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.Contracting.Commands
{
  public class AddMjestoCommand: AddCommand
  {
    public int Id { get; set; }
		
        
	    public string postanskiBroj { get; set; }
	    
	    
        
	    public string naziv { get; set; }
	    
	    
        
	    public int drzavaId { get; set; }
	    
	    

		
  }
}

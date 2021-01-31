using System;

using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.Contracting.Commands
{
  public class UpdateUgovorCommand: UpdateCommand
  {
		
        
	    public string naziv { get; set; }
	    
	    
        
	    public int godina { get; set; }
	    
	    
        
	    public bool aktivan { get; set; }
	    
	    
        
	    public decimal realizirano { get; set; }
	    
	    
        
	    public decimal naplaćeno { get; set; }
	    
	    
        
	    public string valuta { get; set; }
	    
	    
        
	    public int valutaPlaćanja { get; set; }
	    
	    
        
	    public bool aVB { get; set; }
	    
	    
        
	    public decimal commit { get; set; }
	    
	    
        
	    public decimal agePopust { get; set; }
	    
	    
        
	    public decimal ugovorFlatPopust { get; set; }
	    
	    
        
	    public decimal ugovorKoličinaPopust { get; set; }
	    
	    
        
	    public decimal avansKoličina { get; set; }
	    
	    
        
	    public string napomena { get; set; }
	    
	    
        
	    public byte[] filename { get; set; }
	    
	    
        
	    public int klijentId { get; set; }
	    
	    
        
	    public int partnerId { get; set; }
	    
	    

		
  }
}


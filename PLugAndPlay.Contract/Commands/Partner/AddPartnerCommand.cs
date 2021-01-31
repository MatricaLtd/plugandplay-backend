using System;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.Contracting.Commands
{
  public class AddPartnerCommand: AddCommand
  {
    public int Id { get; set; }
		
        
	    public string naziv { get; set; }
	    
	    
        
	    public string oIB { get; set; }
	    
	    
        
	    public string adresa { get; set; }
	    
	    
        
	    public int mjestoId { get; set; }
	    
	    
        
	    public bool agencija { get; set; }
	    
	    
        
	    public bool aktivan { get; set; }
	    
	    
        
	    public bool izvoz { get; set; }
	    
	    
        
	    public string račun { get; set; }
	    
	    
        
	    public bool pDV { get; set; }
	    
	    
        
	    public string valuta { get; set; }
	    
	    
        
	    public int primarniKontaktId { get; set; }
	    
	    
        
	    public bool eRacun { get; set; }
	    
	    
        
	    public string eRacunEmail { get; set; }
	    
	    
        
	    public string telefon { get; set; }
	    
	    
        
	    public string uvjet { get; set; }
	    
	    
        
	    public string napomena { get; set; }
	    
	    
        
	    public int kontaktiId { get; set; }
	    
	    
        
	    public decimal limit { get; set; }
	    
	    
        
	    public decimal realizirano { get; set; }
	    
	    
        
	    public decimal naplaceno { get; set; }
	    
	    
        
	    public decimal duguje { get; set; }
	    
	    
        
	    public int odgoda { get; set; }
	    
	    
        
	    public string bonitet { get; set; }
	    
	    
        
	    public string napomenaUvjet { get; set; }
	    
	    

		
  }
}

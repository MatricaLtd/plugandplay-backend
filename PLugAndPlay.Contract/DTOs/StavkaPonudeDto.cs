using System;

namespace PlugAndPlay.Contracting.DTOs
{
  public class StavkaPonudeDto : IHasIntegerId
  {
    public int Id { get; set; }
	
   
	public string opis { get; set; }
	
	
    
	public decimal kolicina { get; set; }
	
	
    
	public decimal jedinicnaCijena { get; set; }
	
	
    
	public decimal cijena { get; set; }
	
	
    
	public decimal popust { get; set; }
	
	
    
	public decimal iznos { get; set; }
	
	

	
	public int PonudaId { get; set; }
	
  }
}

using System;

namespace PlugAndPlay.Contracting.DTOs
{
  public class KontaktDto : IHasIntegerId
  {
    public int Id { get; set; }
	
    
	public bool aktivan { get; set; }
	
	
    
	public string prefiks { get; set; }
	
	
    
	public string ime { get; set; }
	
	
    
	public string prezime { get; set; }
	
	
    
	public string funkcija { get; set; }
	
	
    
	public string email { get; set; }
	
	
    
	public string telefon { get; set; }
	
	
    
	public string jezik { get; set; }
	
	
    
	public string napomena { get; set; }
	
	

	
	public int? KlijentId { get; set; }

		public int? PartnerId { get; set; }

	}
}

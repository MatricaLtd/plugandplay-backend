using System;

namespace PlugAndPlay.Contracting.DTOs
{
  public class KlijentDto : IHasIntegerId
  {
    public int Id { get; set; }
	
    
	public string naziv { get; set; }
	
	
    
	public int partnerId { get; set; }

		public string partnerName { get; set; }



		public int primarniKontaktId { get; set; }
	
	
    
	public string napomena { get; set; }
	
	
    
	public int kontaktiId { get; set; }
	
	
    
	public string adresa { get; set; }
	
	
    
	public int mjestoId { get; set; }

		public string mjestoName { get; set; }




	}
}

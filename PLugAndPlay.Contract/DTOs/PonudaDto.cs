using PlugAndPlay.Contracting.Security;
using System;

namespace PlugAndPlay.Contracting.DTOs
{
  public class PonudaDto : IHasIntegerId
  {
    public int Id { get; set; }
	
    
	public string broj { get; set; }
	
	
    
	public string status { get; set; }
	
	
    
	public DateTimeOffset statusDatum { get; set; }
	
	
    
	public UserDto statusUser { get; set; }
	
	
    
	public DateTimeOffset datumKreiranja { get; set; }
	
	
    
	public UserDto vlasnikUser { get; set; }
	
	
    
	public int valutaPlaćanja { get; set; }
	
	
    
	public DateTimeOffset startDatum { get; set; }
	
	
    
	public DateTimeOffset endDatum { get; set; }
	
	
    
	public string oIB { get; set; }
	
	
    
	public string brand { get; set; }
	
	
    
	public bool izvoz { get; set; }
	
	
    
	public string valuta { get; set; }
	
	
    
	public string napomena { get; set; }
	
	
    
	public decimal ukupno { get; set; }
	
	
    
	public bool pDV { get; set; }
	
	
    
	public decimal zaPlatiti { get; set; }
	
	
    
	public int stavkaId { get; set; }
	
	
    
	public int stavkePopustaId { get; set; }
	
	
    
	public int ugovorId { get; set; }

		public string ugovorName { get; set; }





		public int klijentId { get; set; }

		public string klijentName { get; set; }



		public int partnerId { get; set; }

		public string partnerName { get; set; }




	}
}

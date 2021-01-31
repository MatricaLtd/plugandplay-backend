using System;

namespace PlugAndPlay.Contracting.DTOs
{
  public class MjestoDto : IHasIntegerId
  {
    public int Id { get; set; }
	
    
	public string postanskiBroj { get; set; }
	
	
    
	public string naziv { get; set; }
	
	
    
	public int drzavaId { get; set; }
	public string drzavaName { get; set; }




	}
}

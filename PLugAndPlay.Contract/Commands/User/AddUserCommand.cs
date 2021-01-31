using System;
using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.Contracting.Commands
{
  public class AddUserCommand: AddCommand
  {
    public int UserId { get; set; }
		
        
	    public string Name { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Password { get; set; }




	}
}

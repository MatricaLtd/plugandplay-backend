using System;

using PlugAndPlay.Contracting.DTOs;

namespace PlugAndPlay.Contracting.Commands
{
  public class UpdateUserCommand: UpdateCommand
  {

		public string Name { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Password { get; set; }

	}
}


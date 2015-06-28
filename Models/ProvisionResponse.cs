using System.Collections.Generic;
using System;

namespace Shared.Models
{
	public class ProvisionResponse
	{
		public Dictionary<string, string> Config { get; set; }
		public Guid Id { get; set; }
		public string Message { get; set; }		
	}
}
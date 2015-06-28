using System.Collections.Generic;
using System;

namespace Shared.Models
{
	public class ProvisionRequest
	{
		public string CallbackUrl { get; set; }
		public Dictionary<string, string> Options { get; set; }
		public Guid Uuid { get; set; }
	}
}
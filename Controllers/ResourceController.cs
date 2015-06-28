using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Shared.Models;
using System;

namespace Shares.Web
{
	[Route("heroku/resources")]
	[Authorize()]
	public class ResourceController : Controller
	{
		[HttpPost]
		public IActionResult Create([FromBody] ProvisionRequest provisionRequest)
		{
			return Json(new ProvisionResponse {
				Config = provisionRequest.Options,
				Id = provisionRequest.Uuid,
			});
		}

		[HttpPut]
		public IActionResult Update()
		{
			return new HttpStatusCodeResult(422);
		}

		[HttpDelete]
		[Route("{id:guid}")]
		public IActionResult Destroy(Guid id)
		{
			return new HttpStatusCodeResult(204);
		}
	}
}

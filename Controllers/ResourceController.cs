using Microsoft.AspNet.Mvc;

namespace MvcSample.Web
{
    [Route("heroku/resources")]
    public class ResourceController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Content("foo");
        }
    }
}

using Microsoft.AspNet.Mvc;

namespace MvcSample.Web
{
    public class ResourceController : Controller
    {
        public IActionResult Index()
        {
            return Content("foo");
        }
    }
}

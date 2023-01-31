using Microsoft.AspNetCore.Mvc;

namespace Elearning.Web.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{id?}")]
        public IActionResult Index(int id = 500)
        {
            ViewBag.Code = id;
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;

namespace Fiver.Api.Filtering.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Get", "Movies");
        }
    }
}

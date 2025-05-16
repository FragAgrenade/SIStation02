using Microsoft.AspNetCore.Mvc;

namespace sistation.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/HomePage/Index.cshtml");
        }
    }
}

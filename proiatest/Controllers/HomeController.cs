using Microsoft.AspNetCore.Mvc;

namespace proiatest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

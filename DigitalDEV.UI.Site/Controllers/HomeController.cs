using Microsoft.AspNetCore.Mvc;

namespace DigitalDEV.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

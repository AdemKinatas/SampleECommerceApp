using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
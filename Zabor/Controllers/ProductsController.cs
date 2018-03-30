using Microsoft.AspNetCore.Mvc;

namespace Zabor.Controllers
{
    public class ProductsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Doors()
        {
            return View();
        }

        public IActionResult Gates()
        {
            return View();
        }
        public IActionResult Forge()
        {
            return View();
        }
    }
}
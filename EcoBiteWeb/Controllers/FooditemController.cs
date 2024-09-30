using Microsoft.AspNetCore.Mvc;

namespace EcoBiteWeb.Controllers
{
    public class FooditemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

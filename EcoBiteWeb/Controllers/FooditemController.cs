using EcoBiteWeb.Data;
using EcoBiteWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcoBiteWeb.Controllers
{
    public class FooditemController : Controller
    {
        private readonly ApplicationDbContext _db;
        public FooditemController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Fooditem> objFooditemList = _db.Fooditems.ToList();
            return View(objFooditemList);
        }
    }
}

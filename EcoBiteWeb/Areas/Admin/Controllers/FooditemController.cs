using EcoBiteBook.DataAccess.Data;
using EcoBiteBook.DataAccess.Repository.IRepository;
using EcoBiteBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcoBiteBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FooditemController : Controller
    {
        private readonly IUnitOfWorks _unitOfWork;
        public FooditemController(IUnitOfWorks unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Fooditem> objFooditemList = _unitOfWork.Fooditem.GetAll().ToList();
            return View(objFooditemList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Fooditem obj)
        {
            if (string.IsNullOrEmpty(obj.Description))
            {
                ModelState.AddModelError("Description", "Description cannot be null or empty");
                return View(obj);
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.Fooditem.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Fooditem added successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Fooditem? fooditemFromDb = _unitOfWork.Fooditem.Get(u => u.FooditemId == id);
            if (fooditemFromDb == null)
            {
                return NotFound();
            }
            return View(fooditemFromDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Fooditem obj)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.Fooditem.Update(obj);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Fooditem? fooditemFromDb = _unitOfWork.Fooditem.Get(u => u.FooditemId == id);
            if (fooditemFromDb == null)
            {
                return NotFound();
            }
            return View(fooditemFromDb);
        }
        [HttpPost, ActionName("Delete")]

        public IActionResult DeletePOST(int? id)
        {
            Fooditem? obj = _unitOfWork.Fooditem.Get(u => u.FooditemId == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Fooditem.Remove(obj);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}

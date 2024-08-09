using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetStore.Data;
using PetStore.Models;

namespace PetStore.Controllers
{
    public class AdminController : Controller
    {
        private MyContext _context;
        public AdminController(MyContext context) {  _context = context; }
        public IActionResult Index(int? categoryId)
        {
            var animals = _context.Animals.AsQueryable();

            if (categoryId.HasValue)
            {
                animals = animals.Where(a => a.CategoryId == categoryId);
            }
            var CategoriesVB = _context.Categories?.ToList();
            ViewBag.Categories = new SelectList(CategoriesVB, "CategoryId", "Name");
            return View(animals.ToList());
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _context.Categories.Select(x => new {x.Name, x.CategoryId}).ToList();
            var animal = _context.Animals.Include(x => x.Comments).FirstOrDefault(x => x.AnimalId == id);
            return View(animal);
        }

        [HttpPost]
        public IActionResult SaveEdit([Bind("AnimalId,Name,Age,ImagePath,Description,CategoryId")] Animal animal)
        {
            if (ModelState.IsValid)
            {
                _context.Update(animal);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name", animal.CategoryId);
            return View(animal);
        }

        public IActionResult Delete(int id)
        {
            var animal = _context.Animals.FirstOrDefault(x => x.AnimalId == id);
            _context.Animals.Remove(animal);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Name,Age,ImagePath,Description,CategoryId")] Animal animal)
        {
            if (_context.Animals.Any(x => x.Name == animal.Name)) { return BadRequest("Animal alredy exist, go back to try again"); }
            if (ModelState.IsValid)
            {
                _context.Add(animal);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name", animal.CategoryId);
            return View(animal);
        }
    }
}

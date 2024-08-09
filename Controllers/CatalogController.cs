using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetStore.Data;

namespace PetStore.Controllers
{
    public class CatalogController : Controller
    {
        private MyContext _context;
        public CatalogController(MyContext context) { _context = context; }
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
    }
}

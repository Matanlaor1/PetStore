using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetStore.Data;

namespace PetStore.Controllers
{
    public class AnimalController : Controller
    {
        private MyContext _context;
        public AnimalController(MyContext context) { _context = context; }
        public IActionResult Index(int id)
        {
            //var animal = _context.Animals.FirstOrDefault(x => x.AnimalId == id);
            var animal = _context.Animals.Include(x => x.Comments).FirstOrDefault(x => x.AnimalId == id);
            if (animal == null)
            {
                string response = "Animal Not Found";
                return Content(response , "text/plain");
            }
            ViewBag.CategoryName = _context.Categories.FirstOrDefault(x => x.CategoryId == animal.CategoryId);
            return View(animal);
        }
    }
}

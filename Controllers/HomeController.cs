using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetStore.Data;

namespace PetStore.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context) { _context = context; }
        public IActionResult Index()
        {
            var animalsWithComments = _context.Animals?.Include(x => x.Comments).ToList();

            var topAnimalsWithComments = animalsWithComments?
            .Select(a => new
            {
                Animal = a,
                CommentsCount = a.Comments != null ? a.Comments.Count() : 0,
                Comments = a.Comments
            })
             .OrderByDescending(a => a.CommentsCount)
             .Take(2)
             .Select(a => a.Animal)
             .ToList();

            ViewBag.Animals = topAnimalsWithComments;
            return View();
        }
    }
}

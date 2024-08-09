using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetStore.Data;
using PetStore.Models;
using System.ComponentModel.Design;

namespace PetStore.Controllers
{
    public class CommentController : Controller
    {
        private MyContext _context;
        public CommentController(MyContext context) { _context = context; }

        [HttpPost]
        public IActionResult AddComment(string content, int animalid)
        {
            
            if (ModelState.IsValid)
            {
                var newComment = new Comment { AnimalId = animalid, CommentId = Comment.commentID++, Content = content };
                _context.Comments.Add(newComment);

                _context.SaveChanges();
                return RedirectToAction("Index", "Animal", new { id = animalid });
            }

            var animal1 = _context.Animals.FirstOrDefault(x => x.AnimalId == animalid);
            return RedirectToAction("Index", "Animal", animal1.AnimalId);
        }

    }
}

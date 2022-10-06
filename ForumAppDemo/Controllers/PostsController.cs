using ForumAppDemo.Data;
using Microsoft.AspNetCore.Mvc;

namespace ForumAppDemo.Controllers
{
    public class PostsController : Controller
    {
        private readonly ForumAppDbContext context;

        public PostsController(ForumAppDbContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {


            return View();
        }
    }
}

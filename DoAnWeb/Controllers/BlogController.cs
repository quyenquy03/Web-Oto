using DoAnWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoAnWeb.Controllers
{
    public class BLogController : Controller
    {
            private readonly DataContext _context;

            public BLogController(DataContext context)
            {
                _context = context;
            }
            public IActionResult Index()
             {
            return View();
             }
        [Route("/blog-{slug}-{id:long}.html", Name = "BlogDetails")]


        public IActionResult BlogDetails(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var blog = _context.Blogs
                .FirstOrDefault(b => (b.BlogId == id) && (b.IsActive == true));
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);

        }
    }
}


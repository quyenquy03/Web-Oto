using Microsoft.AspNetCore.Mvc;

namespace DoAnWeb.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

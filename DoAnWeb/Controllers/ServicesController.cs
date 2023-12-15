using Microsoft.AspNetCore.Mvc;

namespace DoAnWeb.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

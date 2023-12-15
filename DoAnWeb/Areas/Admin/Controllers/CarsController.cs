using Microsoft.AspNetCore.Mvc;

namespace DoAnWeb.Areas.Admin.Controllers;

public class CarsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
using Microsoft.AspNetCore.Mvc;

namespace DoAnWeb.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

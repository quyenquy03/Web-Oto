using DoAnWeb.Context;
using Microsoft.AspNetCore.Mvc;

namespace DoAnWeb.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class BlogController : Controller
	{
		private readonly MyDbContext _dbContext;
		public BlogController(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}

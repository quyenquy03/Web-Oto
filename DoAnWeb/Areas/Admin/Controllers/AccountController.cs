using DoAnWeb.Context;
using Microsoft.AspNetCore.Mvc;

namespace DoAnWeb.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AccountController : Controller
	{
		private readonly MyDbContext _dbContext;
		public AccountController(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}

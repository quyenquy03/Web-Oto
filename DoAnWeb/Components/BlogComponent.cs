using DoAnWeb.Context;
using DoAnWeb.Models;
using Microsoft.AspNetCore.Mvc;


namespace DoAnWeb.Components
{
	[ViewComponent(Name = "Blog")]
	public class BlogComponent : ViewComponent
	{
		private readonly MyDbContext _context;
		public BlogComponent(MyDbContext context)
		{
			_context = context;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var listofBlog = (from b in _context.Blogs
							  where (b.IsActive == true) && (b.Status == 1)
							  select b).ToList();
			return await Task.FromResult((IViewComponentResult)View("Default", listofBlog));
		}
	}
}

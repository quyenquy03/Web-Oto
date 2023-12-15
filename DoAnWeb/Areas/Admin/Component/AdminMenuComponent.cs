using DoAnWeb.Models;
using Microsoft.AspNetCore.Mvc;


namespace DoAnWeb.Areas.Admin.Component
{
    [ViewComponent(Name = "AdminMenu")]
    public class AdminMenuComponent : ViewComponent
    {
        private readonly DataContext _context;
        public AdminMenuComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var adlist = (from ad in _context.AdminMenus
                              where (ad.IsActive == true)
                              select ad).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", adlist));
        }
    }
}

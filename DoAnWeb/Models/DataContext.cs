
using DoAnWeb.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
namespace DoAnWeb.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Menu> Menus { get; set; }  
        public DbSet<Car> Cars { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<AdminMenu> AdminMenus { get; set; }

    }
}

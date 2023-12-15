using System;
using System.Collections.Generic;

namespace DoAnWeb.Models
{
    public partial class Menu
    {
        public Menu()
        {
            Blogs = new HashSet<Blog>();
        }

        public long MenuId { get; set; }
        public string? MenuName { get; set; }
        public bool? IsActive { get; set; }
        public string? ControllerName { get; set; }
        public string? ActionName { get; set; }
        public int? Levels { get; set; }
        public int? ParentId { get; set; }
        public string? Link { get; set; }
        public int? MenuOrder { get; set; }
        public int? Position { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}

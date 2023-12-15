using System;
using System.Collections.Generic;

namespace DoAnWeb.Models
{
    public partial class ViewBlogMenu
    {
        public long BlogId { get; set; }
        public string? Title { get; set; }
        public string? Adstract { get; set; }
        public string? Contents { get; set; }
        public string? Images { get; set; }
        public string? Link { get; set; }
        public string? Author { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
        public int? BlogOrder { get; set; }
        public long? MenuId { get; set; }
        public int? Status { get; set; }
        public long Expr1 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DoAnWeb.Models
{
    public partial class Service
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Descripttion { get; set; }
        public bool? IsActive { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DoAnWeb.Models
{
    public partial class Contact
    {
        public long ContactId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
    }
}

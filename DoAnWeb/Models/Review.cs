using System;
using System.Collections.Generic;

namespace DoAnWeb.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public long? UserId { get; set; }
        public int? CarId { get; set; }
        public string? Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime? Date { get; set; }

        public virtual Car? Car { get; set; }
        public virtual User? User { get; set; }
    }
}

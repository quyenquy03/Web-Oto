using System;
using System.Collections.Generic;

namespace DoAnWeb.Models
{
    public partial class Car
    {
        public Car()
        {
            CarImages = new HashSet<CarImage>();
            Orders = new HashSet<Order>();
            Reviews = new HashSet<Review>();
        }

        public int CarId { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public string? Color { get; set; }
        public decimal? PricePerDay { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<CarImage> CarImages { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}

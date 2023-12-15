using System;
using System.Collections.Generic;

namespace DoAnWeb.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            Reviews = new HashSet<Review>();
        }

        public long UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? FullName { get; set; }
        public int? LocationId { get; set; }
        public int? PhoneNumber { get; set; }
        public int? RoleId { get; set; }

        public virtual Location? Location { get; set; }
        public virtual Role? Role { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}

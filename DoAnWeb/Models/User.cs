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
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? FullName { get; set; }
        public int? Phone { get; set; }
        public int RoleId { get; set; }
        public string? Address { get; set; }
        public string? Avatar { get; set; }
        public bool? IsBlocked { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}

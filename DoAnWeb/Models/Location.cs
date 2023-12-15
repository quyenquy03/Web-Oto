using System;
using System.Collections.Generic;

namespace DoAnWeb.Models
{
    public partial class Location
    {
        public Location()
        {
            Users = new HashSet<User>();
        }

        public int LocationId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

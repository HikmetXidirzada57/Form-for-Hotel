using System;
using System.Collections.Generic;

#nullable disable

namespace Hotelform.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            UserToRols = new HashSet<UserToRol>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UserToRol> UserToRols { get; set; }
    }
}

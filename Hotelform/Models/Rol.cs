using System;
using System.Collections.Generic;

#nullable disable

namespace Hotelform.Models
{
    public partial class Rol
    {
        public Rol()
        {
            UserToRols = new HashSet<UserToRol>();
        }

        public int RolId { get; set; }
        public string RolName { get; set; }

        public virtual ICollection<UserToRol> UserToRols { get; set; }
    }
}

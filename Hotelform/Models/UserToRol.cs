using System;
using System.Collections.Generic;

#nullable disable

namespace Hotelform.Models
{
    public partial class UserToRol
    {
        public int UserToRolsId { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }

        public virtual Rol Role { get; set; }
        public virtual User User { get; set; }
    }
}

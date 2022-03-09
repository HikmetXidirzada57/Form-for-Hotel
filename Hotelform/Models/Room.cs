using System;
using System.Collections.Generic;

#nullable disable

namespace Hotelform.Models
{
    public partial class Room
    {
        public Room()
        {
            Orders = new HashSet<Order>();
        }

        public int RoomId { get; set; }
        public int? RoomtypeId { get; set; }
        public int? RoomNumber { get; set; }
        public int? FloorId { get; set; }

        public virtual Floor Floor { get; set; }
        public virtual RoomType Roomtype { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public int RoomId { get; set; }
        public List<OrderList> OrderLists { get; set; }
        public Room room { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.Models
{
    public class OrderList
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]

        public int ProductId { get; set; }
        [Required]

        public int Count { get; set; }
        [Required]

        public double Price { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}
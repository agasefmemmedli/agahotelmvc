using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Adi Daxil edin!")]
        [MinLength(5, ErrorMessage = "Minimum 5 herif olmalidi")]
        [MaxLength(30, ErrorMessage = "Maximum 5 herif olmalidi")]

        public string Name { get; set; }


        [Required(ErrorMessage = "Kateqoriyani secin edin!")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Qiymeti daxil edin!")]

        public double Price { get; set; }

        [Required(ErrorMessage = "Sayi daxil edin!")]

        public int Count { get; set; }

        public ProductCategory Category { get; set; }

        public List<OrderList> OrderLists { get; set; }

    }
}
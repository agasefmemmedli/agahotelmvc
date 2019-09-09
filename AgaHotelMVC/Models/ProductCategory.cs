using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Adi Daxil edin!")]
        [MinLength(3, ErrorMessage = "Minimum 3 herif olmalidi")]
        [MaxLength(30, ErrorMessage = "Maximum 12 herif olmalidi")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Adi Daxil edin!")]
        [MinLength(3, ErrorMessage = "Minimum 3 herif olmalidi")]
        [MaxLength(30, ErrorMessage = "Maximum 12 herif olmalidi")]
        public string IdName { get; set; }


        public List<Product> Products { get; set; }
    }
}
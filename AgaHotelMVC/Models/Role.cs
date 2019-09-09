using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Rolu Daxil edin!")]
        [MinLength(4, ErrorMessage = "Minimum 4 herif olmalidi")]
        [MaxLength(30, ErrorMessage = "Maximum 30 herif olmalidi")]
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
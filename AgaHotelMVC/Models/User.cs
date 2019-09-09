using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Adi Daxil edin!")]
        [MinLength(5, ErrorMessage = "Minimum 5 herif olmalidi")]
        [MaxLength(30, ErrorMessage = "Maximum 30 herif olmalidi")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Rolu Secin edin!")]
        public int RoleId { get; set; }
        [Required(ErrorMessage = "E-poctu daxil edin!")]
        [MinLength(5, ErrorMessage = "Minimum 5 herif olmalidi")]
        [MaxLength(30, ErrorMessage = "Maximum 30 herif olmalidi")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Parolu daxil edin!")]
        [MinLength(5, ErrorMessage = "Minimum 5 herif olmalidi")]
        [MaxLength(30, ErrorMessage = "Maximum 30 herif olmalidi")]
        public string Password { get; set; }
        [Required]

        public string Tocken { get; set; }
        public Role Role { get; set; }
        public List<Booking> Bookings { get; set; }

    }
}
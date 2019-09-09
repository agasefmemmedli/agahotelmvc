using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Adi Daxil edin!")]
        [MinLength(5,ErrorMessage = "Minimum 5 herif olmalidi")]
        [MaxLength(30, ErrorMessage = "Maximum 30 herif olmalidi")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Nomreni Daxil edin!")]
        [MinLength(12, ErrorMessage = "Minimum 12 herif olmalidi")]
        [MaxLength(12, ErrorMessage = "Maximum 12 herif olmalidi")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Pasport melumatlarını Daxil edin!")]
        [MinLength(11, ErrorMessage = "Minimum 11 herif olmalidi")]
        [MaxLength(11, ErrorMessage = "Maximum 11 herif olmalidi")]
        public string  PersonIdentification { get; set; }

        [Required(ErrorMessage = "E-poctu Daxil edin!")]
        [MinLength(5, ErrorMessage = "Minimum 5 herif olmalidi")]
        [MaxLength(50, ErrorMessage = "Maximum 50 herif olmalidi")]
        public string Email { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
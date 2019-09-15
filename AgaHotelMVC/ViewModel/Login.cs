using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Mailinizi yazın")]
        [MaxLength(50, ErrorMessage = "Mailinizi maksimum 50 xarakter ola bilər.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Parolu yazın")]
        [MaxLength(30, ErrorMessage = "Parol maksimum 30 xarakter ola bilər.")]
        public string Password { get; set; }
    }
}
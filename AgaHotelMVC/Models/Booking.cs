using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Müştərini seçin!")]
        public int CustomerId { get; set; }
        [Required]

        public int UserId { get; set; }

        [Required(ErrorMessage = "Otağı seçin!")]
        public int RoomId { get; set; }
        [Required]

        public bool Status { get; set; }

        [Required(ErrorMessage = "Tarixi secin")]
        public DateTime CheckIn { get; set; }
        [Required(ErrorMessage = "Tarixi secin")]
        public DateTime CheckOut { get; set; }
        [Required]
        public int Price { get; set; }
        public Customer Customer { get; set; }
        public User User { get; set; }
        public Room Room { get; set; }


    }
}
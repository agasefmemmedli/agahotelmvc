using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.Models
{

    public enum BedType{ Single, Twin, Double , Triple };
    public class Room
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nömrəni Daxil edin!")]
        public int Number { get; set; }

        [Required(ErrorMessage = "Qiyməti Daxil edin!")]

        public double Price { get; set; }

        [Required(ErrorMessage = "Boyuk Adamların tutumun Daxil edin!")]

        public int PersonCapacity { get; set; }

        [Required(ErrorMessage = "Uşaq tutumun Daxil edin!")]

        public int ChildCapacity { get; set; }

        [Required(ErrorMessage = "Yataq tipin Seçin!")]

        public BedType BedType { get; set; }


        [Required(ErrorMessage = "Ətraflı məlumatı Daxil edin!")]
        [MinLength(5, ErrorMessage = "Minimum 5 herif olmalidi")]
        [MaxLength(100, ErrorMessage = "Maximum 100 herif olmalidi")]

        public string Desc { get; set; }

        [Required(ErrorMessage = "Şəkil əlavə edin!")]

        public string Photo { get; set; }
        public List<Order> Orders { get; set; }
        public List<Booking> Bookings { get; set; }

        [NotMapped]
        public HttpPostedFileBase File { get; set; }

    }
}
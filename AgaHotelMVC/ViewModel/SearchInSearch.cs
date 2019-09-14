using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.ViewModel
{
    public class SearchInSearch
    {
        [Required(ErrorMessage ="Giriş tarixini secin")]
        public DateTime CheckIn { get; set; }

        [Required(ErrorMessage = "Cixiş tarixini secin")]
        public DateTime CheckOut { get; set; }
        public int Person { get; set; }
        public int Child { get; set; }

    }
}
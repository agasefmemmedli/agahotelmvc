using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.ViewModel
{
    public class SearchList
    {
        public Nullable<DateTime> ChechIn { get; set; }

        public Nullable<DateTime> CheckOut { get; set; }

        public int? Person { get; set; }
        public int? Child { get; set; }

        [Required]
        public int Page { get; set; }
    }
}
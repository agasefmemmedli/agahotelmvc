using AgaHotelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.ViewModel
{
    public class SearchPage
    {
        public List<Customer> customer  { get; set; }

        public List<Room> room { get; set; }
    }
}
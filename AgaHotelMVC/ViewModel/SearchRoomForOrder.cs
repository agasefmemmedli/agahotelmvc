using AgaHotelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.ViewModel
{
    public class SearchRoomForOrder
    {
        
        public SearchForRoom SearchForRooms { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Customer> Customers { get; set; }


    }
}
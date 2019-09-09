using AgaHotelMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.Data
{
    public class HotelContext:DbContext
    {
        public HotelContext() : base("HotelContext")
        {

        }
        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderList> OrderLists { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }








    }
}
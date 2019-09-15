namespace AgaHotelMVC.Migrations
{
    using AgaHotelMVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Helpers;

    internal sealed class Configuration : DbMigrationsConfiguration<AgaHotelMVC.Data.HotelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AgaHotelMVC.Data.HotelContext context)
        {
            User user = new User
            {
                FullName = "Yolchu Nasib",
                Email = "Yolchu@gmail.com",
                Password = "admin",
                Role = Role.Admin
            };

            context.Users.Add(user);
            context.SaveChanges();

            User user2 = new User
            {
                FullName = "Agasef Memmedli",
                Email = "mmaries221@gmail.com",
                Password = "admin",
                Role = Role.Reception
            };

            context.Users.Add(user2);
            context.SaveChanges();
            User user3 = new User
            {
                FullName = "Behruz Ehmedov",
                Email = "baxa@gmail.com",
                Password = "admin",
                Role = Role.Restoran,
                
            };

            context.Users.Add(user3);
            context.SaveChanges();
        }
    }
}

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
           
        }
    }
}

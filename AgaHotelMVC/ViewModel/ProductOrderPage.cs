using AgaHotelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgaHotelMVC.ViewModel
{
    public class ProductOrderPage
    {
        public List<Customer> customer { get; set; }

        public List<Product> product { get; set; }
        public List<ProductCategory> productCategories { get; set; }


    }
}
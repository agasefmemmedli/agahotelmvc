using AgaHotelMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgaHotelMVC.Controllers
{
    public class RestoranController : BaseController
    {
        // GET: Restoran
        public ActionResult NewOrder()
        {
            ProductOrderPage product = new ProductOrderPage
            {
                product = _context.Products.Include("Category").ToList(),
                customer = _context.Customers.ToList(),
                productCategories = _context.ProductCategories.ToList()
            };
            return View(product);
        }
        public ActionResult Orders()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
      
    }
}
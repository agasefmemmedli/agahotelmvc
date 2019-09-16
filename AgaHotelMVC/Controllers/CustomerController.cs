using AgaHotelMVC.Helper;
using AgaHotelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgaHotelMVC.Controllers
{
    [Auth]

    public class CustomerController : BaseController
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> cs = _context.Customers.ToList();
            return View(cs);
        }


        #region Customer Crud
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
                return View(customer);
        }


      



        public ActionResult UpdateCustomer(int Id)
        {
            Customer customer = _context.Customers.FirstOrDefault(u => u.Id == Id);
            if (!ModelState.IsValid)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }
        #endregion
    }
}
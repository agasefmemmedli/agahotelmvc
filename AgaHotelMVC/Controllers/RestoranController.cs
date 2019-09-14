using AgaHotelMVC.Models;
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
        public ActionResult NewOrder(string txt=null)
        {
            ProductOrderPage product = new ProductOrderPage();
            if (txt == null|| txt=="")
            {

                product.product = _context.Products.Include("Category").ToList();
                   
            }
            else {
                product.product = _context.Products.Include("Category").Where(p=>p.Name.Contains(txt)).ToList();

            }


            product.customer = _context.Customers.ToList();
            product.productCategories = _context.ProductCategories.ToList();
            return View(product);
        }

        public ActionResult NewOrderSearch(string txt)
        {
            ProductOrderPage product = new ProductOrderPage();
            product.product = _context.Products.Include("Category").Where(p => p.Name.Contains(txt)).ToList();
            product.customer = _context.Customers.ToList();
            product.productCategories = _context.ProductCategories.ToList();
            return PartialView("_NewOrderProductList", product);
        }

        public ActionResult Orders()
        {
            return View();
        }
        public ActionResult Products()
        {

            List<Product> products = _context.Products.Include("Category").ToList();

            return View(products);
        }
        public ActionResult ProductsSearch(string txt)
        {

            List<Product> products = _context.Products.Include("Category").Where(p =>p.Name.ToString().Contains(txt)).ToList();

            return PartialView("_ProductList", products);
        }



        public ActionResult AddProduct()
        {
            ViewBag.Category = _context.ProductCategories.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            if (_context.Products.Any(p => p.Name == product.Name))
            {
                ModelState.AddModelError("Name", "Bu Adda məhsul artiq var");

            }
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();

                return RedirectToAction("products", "restoran");
            }
            ViewBag.Category = _context.ProductCategories.ToList();

            return View(product);
        }
        public ActionResult UpdateProduct(int Id)
        {
            Product product = _context.Products.Find(Id);

            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.Category = _context.ProductCategories.ToList();

            return View(product);
        }


        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("products");
            }
            ViewBag.Category = _context.ProductCategories.ToList();
            return View(product);
        }


        public ActionResult DeleteProduct(int Id)
        {
            Product product = _context.Products.FirstOrDefault(p => p.Id == Id);
            if (product == null)
            {
                return HttpNotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("products");
        }

        public ActionResult AddToList(int Id)
        {
            Product pr = _context.Products.Find(Id);
            if (pr == null)
            {
                return HttpNotFound();
            }
            return PartialView("_NewOrderProductInvoice", pr);
        }
    }
}
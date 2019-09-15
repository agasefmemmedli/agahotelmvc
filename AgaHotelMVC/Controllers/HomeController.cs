using AgaHotelMVC.Data;
using AgaHotelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AgaHotelMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly HotelContext _context = new HotelContext();
        [HttpGet]

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            User user = _context.Users.FirstOrDefault(u => u.Email == login.Email);
            if (user == null || user.Password!=login.Password)
            {
                ModelState.AddModelError("Password", "Login ve ya parol səhfdi.");
                return View();
            }
            user.Tocken = Guid.NewGuid().ToString();
            _context.SaveChanges();
            Response.Cookies["Tocken"].Value = user.Tocken;
            Response.Cookies["Tocken"].Expires = DateTime.Now.AddDays(1);
            return RedirectToAction("index", "main");
        }

    }
}
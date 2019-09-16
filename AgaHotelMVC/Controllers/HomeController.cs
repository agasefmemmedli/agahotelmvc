using AgaHotelMVC.Data;
using AgaHotelMVC.Models;
using AgaHotelMVC.ViewModel;
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
        protected readonly HotelContext _context;

        public HomeController()
        {
            _context = new HotelContext();
        }
            [HttpGet]

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login loginUsr)
        {
            if (ModelState.IsValid)
            {
                User user = _context.Users.FirstOrDefault(u => u.Email == loginUsr.Email);
                if (user != null)
                {
                    if (user.Password == loginUsr.Password)
                    {
                        Session["UserLogin"] = true;
                        Session["UserId"] = user.Id;
                        user.Tocken = Session["UserId"].ToString();
                        _context.SaveChanges();
                        return RedirectToAction("Index", "Main");


                    }
                }

                ModelState.AddModelError("Summary", "Email or password incorrect");
            }

            return View(loginUsr);
           
        }

    }
}
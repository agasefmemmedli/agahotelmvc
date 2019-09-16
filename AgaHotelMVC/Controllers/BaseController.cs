using AgaHotelMVC.Data;
using AgaHotelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgaHotelMVC.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected readonly HotelContext _context;
        public BaseController()
        {
            _context = new HotelContext();


            //string Tocken = Session["UserId"].ToString();
            //User user = _context.Users.FirstOrDefault(u => u.Tocken == Tocken);
            //ViewBag.User = user;

        }
    }
}

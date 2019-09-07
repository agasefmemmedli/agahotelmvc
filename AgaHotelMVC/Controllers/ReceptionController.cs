using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgaHotelMVC.Controllers
{
    public class ReceptionController : Controller
    {
        // GET: Reception
        public ActionResult NewOrder()
        {
            return View();
        }
        public ActionResult Rooms()
        {
            return View();
        }
        public ActionResult Orders()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgaHotelMVC.Controllers
{
    public class RestoranController : Controller
    {
        // GET: Restoran
        public ActionResult NewOrder()
        {
            return View();
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
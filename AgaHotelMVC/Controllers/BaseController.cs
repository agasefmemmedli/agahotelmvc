using AgaHotelMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgaHotelMVC.Controllers
{
    public class BaseController : Controller
    {
        protected readonly HotelContext _context;

        public BaseController()
        {
            _context = new HotelContext();



        }
    }
}
﻿using AgaHotelMVC.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgaHotelMVC.Controllers
{
    [Auth]
    public class MainController : BaseController
    {

        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
    }
}
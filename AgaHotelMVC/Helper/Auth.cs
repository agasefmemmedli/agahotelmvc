using AgaHotelMVC.Data;
using AgaHotelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgaHotelMVC.Helper
{
    public class Auth : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["UserLogin"] == null)
            {
                filterContext.Result = new RedirectResult("~/home");
            }

            base.OnActionExecuting(filterContext);
        }
    }
    
}
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
        private HotelContext context;
        public Auth()
        {
            context = new HotelContext();
        }


        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            if (HttpContext.Current.Request.Cookies["Tocken"] == null)
            {
                string tocken = HttpContext.Current.Request.Cookies["Tocken"].ToString();
                User user = context.Users.FirstOrDefault(u => u.Tocken == tocken);
                if (user == null)
                {
                    filterContext.Result = new RedirectResult("/home/login");
                    return;
                }
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;
using TestUngDung.Common;
using TestUngDung.Areas.admin;

namespace TestUngDung.Areas.admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
            {
                var session = (LoginModel)Session[Constants.USER_SESSION];
                if (session == null)
                {
                    filterContext.Result = new RedirectToRouteResult(new
                        System.Web.Routing.RouteValueDictionary(new { controller = "Login", action = "Index", Areas = "Admin" }));
                }
                base.OnActionExecuted(filterContext);
            }
        protected void SetAlert(string message, string type)
        {
            TempData["AlertMessage"] = message;
            if (type == "success")
            {
                TempData["AlertType"] = "alert-success";
            }
            else if (type == "warning")
            {
                TempData["AlertType"] = "alert-warning";
            }
            else if (type == "error")
            {
                TempData["AlertType"] = "alert-danger";
            }
        }
    }
    
}
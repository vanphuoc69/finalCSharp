using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestUngDung.Common;
using TestUngDung.Areas.admin;
using System.Web.Mvc;


namespace TestUngDung.Areas.admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: admin/Home
        public ActionResult Index()
        {
            var session = (LoginModel)Session[Constants.USER_SESSION];
            if (session == null) { return RedirectToAction("Index", "Login"); }
            return View();
        }
        public ActionResult Logout()
        {
            Session[Constants.USER_SESSION] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}
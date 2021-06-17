using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUngDung.DAO;

namespace TestUngDung.Areas.client.Controllers
{
    public class HomeController : Controller
    {
        // GET: client/Home
        public ActionResult Index()
        {
            ViewBag.List = new ProductDAO().ListAll();
            return View();
        }
    }
}
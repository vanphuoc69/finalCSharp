using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelEF.DAO;
using ModelEF.Model;
using PagedList;
using TestUngDung.DAO;

namespace TestUngDung.Areas.admin.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: admin/Category
        public ActionResult Index(int page = 1, int pagesize = 6)
        {
            var thing = new CategoryDAO();
            var model = thing.ListAll();
            return View(model.ToPagedList(page, pagesize));
        }
        [HttpPost]
        public ActionResult Index(string searchString, int page = 1, int pagesize = 6)
        {
            var thing = new CategoryDAO();
            var model = thing.ListWhereAll(searchString, page, pagesize);
            ViewBag.SearchString = searchString;
            return View(model.ToPagedList(page, pagesize));
        }

        //[HttpGet]
        //public ActionResult Create(string user)
        //{
        //    var dao = new CategoryDAO();
        //    var result = dao.Find(user);
        //    if (result != null)
        //        return View(result);
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Create(Category category)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var dao = new CategoryDAO();
        //        var result = dao.Insert(category);
        //        if (result != null)
        //        {
        //            SetAlert("Thêm mới danh mục thành công.", "success");
        //            return RedirectToAction("Index", "Category");
        //        }
        //        else
        //        {
        //            SetAlert("Thêm mới danh mục không thành công.", "error");
        //        }
        //    }
        //    return View();

        //}
        [HttpDelete]
        public ActionResult Delete(string id)
        {
            var dao = new CategoryDAO().Delete(id);
            return RedirectToAction("Index");
        }

    }
}
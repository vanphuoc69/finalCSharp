using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelEF.Model;
using ModelEF.DAO;
using PagedList;
using TestUngDung.DAO;

namespace TestUngDung.Areas.admin.Controllers
{
    public class ProductController : BaseController
    {
        // GET: admin/Product
        public ActionResult Index(int page = 1, int pagesize = 5)
        {
            var thing = new ProductDAO();
            var model = thing.ListAll();
            return View(model.ToPagedList(page, pagesize));
        }
        [HttpPost]
        public ActionResult Index(string searchString, int page = 1, int pagesize = 5)
        {
            var thing = new ProductDAO();
            var model = thing.ListWhereAll(searchString, page, pagesize);
            ViewBag.SearchString = searchString;
            return View(model.ToPagedList(page, pagesize));
        }
        
        public ActionResult Detail()
        {
            ViewBag.RelatedProducts = new ProductDAO().ListAll();
            return View();
        }
        public void SetViewBag(long? selectedID = null)
        {
            var dao = new CategoryDAO();
            ViewBag.CategoryID = new SelectList(dao.ListAll(), "CategoryID", "Name",
            selectedID);
        }
        [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                var dao = new ProductDAO();
                long id = dao.Insert(product);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm Sản phẩm thành công.");
                }
            }
            SetViewBag();
            return View("Create");
        }
        //[HttpGet]
        //public ActionResult Edit(int id)
        //{
        //    var dao = new ProductDAO();
        //    var product = dao.ViewDetail(id);
        //    SetViewBag(product.CategoryID);
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Edit(Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var dao = new ProductDAO();
        //        var id = dao.Update(product);
        //        if (id)
        //        {
        //            return RedirectToAction("Index", "Product");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Chỉnh Sản phẩm thành công.");
        //        }
        //    }
        //    SetViewBag(product.CategoryID);
        //    return View();
        //}
        //[HttpDelete]
        //public ActionResult Delete(string id)
        //{
        //    var product = new ProductDAO().Delete(id);
        //    return RedirectToAction("Index");
        //}



    }
}
using ModelEF.DAO;
using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUngDung.Common;
using PagedList;

namespace TestUngDung.Areas.admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: admin/User
        //public ActionResult Index(int page = 1, int pagesize = 5)
        //{
        //    var user = new UserDAO();
        //    var model = user.ListAll();
        //    return View(model.ToPagedList(page, pagesize));
        //}
        //[HttpPost]
        public ActionResult Index(string searchString, int page = 1, int pagesize = 5)
        {
            var user = new UserDAO();
            var model = user.ListWhereAll(searchString, page, pagesize);
            ViewBag.SearchString = searchString;
            return View(model.ToPagedList(page, pagesize));
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserAccount user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                var pass = Encryptor.EncryptMD5(user.Password);
                user.Password = pass;
                var db = new MaiVanPhuocContext();
                if (db.UserAccounts.Any(x => x.UserName == user.UserName))
                {
                    ModelState.AddModelError("", "Tên đăng nhập này đã tồn tại");

                }
                else
                {
                    long id = dao.Insert(user);
                    if (id > 0)
                    {
                        return RedirectToAction("Index", "User");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm user không thành công.");
                    }
                }

            }
            return View("Create");
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var model = new UserDAO();
            model.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
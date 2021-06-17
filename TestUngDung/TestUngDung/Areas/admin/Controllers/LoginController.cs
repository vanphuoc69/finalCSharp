﻿using ModelEF.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUngDung.Areas.admin;

namespace TestUngDung.Areas.admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                var result = dao.login(user.UserName,Common.Encryptor.EncryptMD5 (user.Password));
                if (result == 1)
                {
                    //ModelState.AddModelError("", "Đăng nhập thành công!!");
                    Session.Add( TestUngDung.Common.Constants.USER_SESSION, user);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không thành công!!");
                }
            }
            
            return View("Index");
        }
    }
}
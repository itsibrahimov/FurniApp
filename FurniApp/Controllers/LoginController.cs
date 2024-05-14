using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FurniApp.Controllers
{
    public class LoginController : Controller
    {
        AdminManager sp = new AdminManager(new EfAdminDal());
        // GET: Admin
        [AllowAnonymous]
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult AdminLogin(Admin p)
        {
            Context c = new Context();
            var admininfo = c.Admins.FirstOrDefault(x => x.Name == p.Name && x.Password == p.Password);
            if (admininfo != null)
            {
                FormsAuthentication.SetAuthCookie(admininfo.Name, false);
                Session["UserName"] = admininfo.Name.ToString();
                return RedirectToAction("AdminShopList", "Shop");
            }
            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult UserLogin()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult UserLogin(Admin p)
        {
            Context c = new Context();
            var userinfo = c.Admins.FirstOrDefault(x => x.Name == p.Name && x.Password == p.Password);
            if (userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.Name, false);
                Session["UserName"] = userinfo.Name.ToString();
                return RedirectToAction("Index", "Shop");
            }
            else
            {
                return RedirectToAction("UserLogin", "Login");
            }
        }

    }
}
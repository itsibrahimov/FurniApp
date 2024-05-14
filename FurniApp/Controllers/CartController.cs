using BusinessLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurniApp.Controllers
{
    public class CartController : Controller
    {
        CartManager cm = new CartManager(new EfCartDal());
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CartList()
        {
            var cartlist = cm.GetList();
            return View(cartlist);
        }
        [HttpGet]
        public ActionResult CartAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CartAdd(Cart id)
        {
            cm.TAdd(id);
            return RedirectToAction("CartList");
        }
    }
}
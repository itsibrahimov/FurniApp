using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using EntityLayer;
using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurniApp.Controllers
{
    public class ShopController : Controller
    {
        ShopManager sp = new ShopManager(new EfShopDal());

        // GET: Shop
        public ActionResult Index()
        {
           return View();
        }

        public PartialViewResult ShopList(int page = 1)
        {
           var shoplist = sp.GetList().ToPagedList(page, 3);
            return PartialView(shoplist);
        }

        public PartialViewResult Footer()
        {
            return PartialView();
        }

        public PartialViewResult MailSubscribe()
        {
            return PartialView();
        }
        public ActionResult AdminShopList()
        {
            var shoplist = sp.GetList();
            return View(shoplist);
        }
        [HttpGet]
        public ActionResult AddNewShop()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewShop(Shop s)
        {
            sp.TAdd(s);
            return RedirectToAction("AdminShopList");
        }
        public ActionResult ShopDelete(int id)
        {
            sp.ShopStatusFalseSp(id);
            return RedirectToAction("AdminShopList");
        }
        public ActionResult ShopStatusTrue(int id)
        {
            sp.ShopStatusTrueSp(id);
            return RedirectToAction("AdminShopList");
            
        }
        [HttpGet]
        public ActionResult ShopUpdates(int id)
        {
            Shop shop = sp.GetByID(id);
            return View(shop);
        }

        [HttpPost]
        public ActionResult ShopUpdates(Shop x) 
        {
                sp.ShopUpdate(x);
                return RedirectToAction("AdminShopList");
        }
    }
}
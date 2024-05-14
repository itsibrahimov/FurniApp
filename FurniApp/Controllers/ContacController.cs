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
    public class ContacController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        // GET: Contac
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        public PartialViewResult SendMessage(Contact a)
        {
            cm.TAdd(a);
            return PartialView();
        }
    }
}
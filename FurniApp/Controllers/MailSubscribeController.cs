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
    [AllowAnonymous]
    public class MailSubscribeController : Controller
    {
        MailSubscribeManager ms = new MailSubscribeManager(new EfMailSubscribeDal());
        // GET: MailSubscribe

        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddMail(MailSubscribe t)
        {
            ms.TAdd(t);
            return PartialView();
        }
    }
}
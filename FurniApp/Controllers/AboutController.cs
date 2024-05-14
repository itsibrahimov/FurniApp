using BusinessLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurniApp.Controllers
{
    public class AboutController : Controller
    {
        OurTeamManager ot = new OurTeamManager(new EfOurTeamDal());
        // GET: About
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult OurTeamAdd()
        {
            return PartialView();
        }

        public ActionResult OurTeamList()
        {
            var teamlist = ot.GetList();
            return View(teamlist);
        }
    }
}
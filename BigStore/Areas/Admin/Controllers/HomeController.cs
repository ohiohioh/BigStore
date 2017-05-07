using BigStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigStore.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BigStoreEntities dc = new BigStoreEntities();
            ViewBag.storeName = dc.adm_Store.Where(s => s.Id == "AdBest").Select(x => x.Name).FirstOrDefault();

            return View("_Index");
        }

        public ActionResult LeftNavbar()
        {
            return PartialView("_LeftNavbar");
            //
        }
    }
}
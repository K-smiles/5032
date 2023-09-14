using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTVisionCluu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About CTVision.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact.";

            return View();
        }
    }
}
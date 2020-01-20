using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationApp17._01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { //home/index
            ViewBag.User ="Andrei";
            return View();
        }

        public ActionResult About()
        { //home/About
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {//home/Contact
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
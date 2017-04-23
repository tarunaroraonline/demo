using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CiCdDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            // Adding a comment 
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            // Adding more comments 
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
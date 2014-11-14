using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GorkhalisFavorite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Little info here";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Gorkhalis";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Gorkahlis contact";

            return View();
        }
    }
}

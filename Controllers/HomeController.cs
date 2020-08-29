using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TryaTutytor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Header()
        {


            return View();
        }
        public ActionResult Footer()
        {


            return View();
        }

        public ActionResult Tutor_login()
        {


            return View();
        }
        
        public ActionResult Student_login()
        {


            return View();
        }
        public ActionResult Student_register()
        {


            return View();
        }
        public ActionResult Tutor_register()
        {


            return View();
        }
        public ActionResult About_us()
        {


            return View();
        }
        public ActionResult Tutor()
        {


            return View();
        }
        public ActionResult Contact_us()
        {


            return View();
        }
    }
}
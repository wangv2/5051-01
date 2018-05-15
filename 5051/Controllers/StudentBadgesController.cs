using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5051.Controllers
{
    public class StudentBadgesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string id=null)
        {
            var myStudentID = "";
            if (!string.IsNullOrEmpty(id))
            {
                myStudentID = id;
            }

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
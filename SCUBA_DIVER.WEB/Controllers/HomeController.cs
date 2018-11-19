using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SCUBA_DIVER.Models;
using SCUBA_DIVER.DAL;

namespace SCUBA_DIVER.WEB.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Classes()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Classes(ContactInfo forminfo)
        {
            ContactInfoManager mgr = new ContactInfoManager();
            mgr.AddContactInfo(forminfo);
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Certifications()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
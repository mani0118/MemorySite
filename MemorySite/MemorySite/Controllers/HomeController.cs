using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemorySite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string code)
        {
            if (string.IsNullOrEmpty(code))
                return View();
            string vTrueCode = string.Empty;
            try
            {
                vTrueCode = System.Configuration.ConfigurationManager.AppSettings["SSHLOVECODE"];
            }
            catch (Exception ex)
            {
                return View();
            }
            if (code.Equals(vTrueCode))
                return RedirectToAction("Picture", "Home");
            return View();
        }

        public ActionResult Nav()
        {
            return View();
        }

        public ActionResult Picture()
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
    }
}
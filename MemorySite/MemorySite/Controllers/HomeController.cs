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
            {
                Session["IsAuthorized"] = "T";
                return RedirectToAction("Picture", "Home");
            }
            return View();
        }

        public ActionResult Picture()
        {
            if (Session["IsAuthorized"] == null || 
                string.IsNullOrEmpty(Session["IsAuthorized"].ToString())||
                !"T".Equals(Session["IsAuthorized"].ToString()))
                return RedirectToAction("Index", "Home");
            return View();
        }
        public ActionResult Heart()
        {
            if (Session["IsAuthorized"] == null ||
                string.IsNullOrEmpty(Session["IsAuthorized"].ToString()) ||
                !"T".Equals(Session["IsAuthorized"].ToString()))
                return RedirectToAction("Index", "Home");
            return View();
        }

    }
}
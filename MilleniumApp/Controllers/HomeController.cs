using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MilleniumApp.Models;

namespace MilleniumApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult Index(string name, string address)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Summary", new { name, address });
            }

            return View();
        }

        public ActionResult Summary(string name, string address)
        {
            Person person = new Person() { Nickname = name, EmailAddress = address};
            return View(person);
        }

        public ActionResult Culture(bool? culture)
        {
            if (culture != null)
            {
                if ((bool)culture)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                    Session["culture"] = "en-GB";
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
                    Session["culture"] = "pl-PL";
                }
            }
            return View("index", new Person());
        }
    }
}
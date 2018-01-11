using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seminar_chr.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult seminars()
        {
            return View();
        }
        public ActionResult courses()
        {
            return View();
        }
    }
}
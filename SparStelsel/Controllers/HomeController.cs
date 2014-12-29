using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SparStelsel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        [Authorize(Roles="admin, cashadmin, selfcashier")]
        [AutoLogOffActionFilter]
        public ActionResult Home()
        {
            return View();
        }
    }
}

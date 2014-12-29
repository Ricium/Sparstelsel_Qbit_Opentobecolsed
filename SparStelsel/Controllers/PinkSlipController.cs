using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SparStelsel.Controllers
{
    [AutoLogOffActionFilter]
    public class PinkSlipController : Controller
    {
        //
        // GET: /PinkSlip/

        public ActionResult Index()
        {
            return View();
        }

    }
}

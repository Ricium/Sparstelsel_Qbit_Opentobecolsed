using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SparStelsel.Models;
using Telerik.Web.Mvc;
using System.IO;
using Telerik.Web.Mvc.Extensions;

namespace SparStelsel.Controllers
{
    public class MoneyController : Controller
    {
        DropDownRepository DDRep = new DropDownRepository();
        CashMovementRepository CMRep = new CashMovementRepository();
        PickUpRepository PRep = new PickUpRepository();
        KwikPayRepository KRep = new KwikPayRepository();
        InstantMoneyRepository IRep = new InstantMoneyRepository();
        FNBRepository FNBRep = new FNBRepository();

        public ActionResult Index()
        {
            return View();
        }

    }
}

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
    [AutoLogOffActionFilter]
    public class InstantMoneyController : Controller
    {
        //
        // GET: /InstantMoney/

        //Repository
        InstantMoneyRepository IRep = new InstantMoneyRepository();
        DropDownRepository DDRep = new DropDownRepository();

        //List
        // List SupplierType
        [GridAction]
        public ActionResult _ListInstantMoneys()
        {
            return View(new GridModel(IRep.GetAllInstantMoney()));
        }


        //Functions


        // CashBox 
        public ActionResult InstantMoneys()
        {
            ViewData["InstantMoneyType"] = DDRep.GetInstantMoneyType();
            return View();
        }

        //Add CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertInstantMoneys(InstantMoney ins)
        {
            //...Insert Object
            InstantMoney ins2 = IRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(IRep.GetAllInstantMoney()));
        }
        //Update CashBox
        [GridAction]
        public ActionResult _UpdateInstantMoneys(InstantMoney ins)
        {
            //...Update Object
            InstantMoney ins2 = IRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(IRep.GetAllInstantMoney()));
        }
        //Remove CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveInstantMoneys(int id)
        {
            //...Update Object
            string ins = IRep.GetInstantMoney(id).ToString();
            IRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(IRep.GetAllInstantMoney()));
        }

    }
}

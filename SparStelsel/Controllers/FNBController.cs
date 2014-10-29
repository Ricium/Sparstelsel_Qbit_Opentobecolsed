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
    public class FNBController : Controller
    {
        //
        // GET: /FNB/
        //Repository
        FNBRepository FNBRep = new FNBRepository();
        DropDownRepository DDRep = new DropDownRepository();

        //List
        // List SupplierType
        [GridAction]
        public ActionResult _ListElectronicFunds()
        {
            return View(new GridModel(FNBRep.GetAllFNB()));
        }


        //Functions


        // CashBox 
        public ActionResult FNBs()
        {
            ViewData["FBNType"] = DDRep.GetFNBType();
            return View();
        }

        //Add CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertFNBs(FNB ins)
        {
            //...Insert Object
            FNB ins2 = FNBRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(FNBRep.GetAllFNB()));
        }
        //Update CashBox
        [GridAction]
        public ActionResult _UpdateFNBs(FNB ins)
        {
            //...Update Object
            FNB ins2 = FNBRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(FNBRep.GetAllFNB()));
        }
        //Remove CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveFNBs(int id)
        {
            //...Update Object
            string ins = FNBRep.GetFNB(id).ToString();
            FNBRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(FNBRep.GetAllFNB()));
        }

    }
}

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
    public class ElectronicFundsController : Controller
    {
        //
        // GET: /ElectronicFunds/
        //Repository
        ElectronicFundRepository ERep = new ElectronicFundRepository();
        DropDownRepository DDRep = new DropDownRepository();

        //List
        // List SupplierType
        [GridAction]
        public ActionResult _ListElectronicFunds()
        {
            return View(new GridModel(ERep.GetAllElectronicFund()));
        }


        //Functions


        // CashBox 
        public ActionResult ElectronicFunds()
        {
            ViewData["ElectronicType"] = DDRep.GetElectronicFundTypeList();
            return View();
        }

        //Add CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertElectronicFunds(ElectronicFund ins)
        {
            //...Insert Object
            ElectronicFund ins2 = ERep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(ERep.GetAllElectronicFund()));
        }
        //Update CashBox
        [GridAction]
        public ActionResult _UpdateElectronicFunds(ElectronicFund ins)
        {
            //...Update Object
            ElectronicFund ins2 = ERep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(ERep.GetAllElectronicFund()));
        }
        //Remove CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveElectronicFunds(int id)
        {
            //...Update Object
            string ins = ERep.GetElectronicFund(id).ToString();
            ERep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(ERep.GetAllElectronicFund()));
        }


    }
}

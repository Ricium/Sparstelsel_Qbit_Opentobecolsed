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
    public class CashierController : Controller
    {
        //
        DropDownRepository DDRep = new DropDownRepository();
        CashMovementRepository CMRep = new CashMovementRepository();
        PickUpRepository PRep = new PickUpRepository();
        CashierRepository CRep = new CashierRepository();
        // GET: /Cashier/
        [GridAction]
        public ActionResult _ListCashier()
        {
            return View(new GridModel(CRep.GetAllCashier()));
        }


        //Functions


        // CashBox 
        public ActionResult Cashier()
        {
            ViewData["Company"] = DDRep.GetCompanyList();
            List<string> test = new List<string>();
      
            return View();
        }

        public ActionResult CashierCashUp()
        {
            return View();
        }

        //Add CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertCashier(Cashier ins)
        {
            //...Insert Object
            Cashier ins2 = CRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(CRep.GetAllCashier()));
        }
        //Update CashBox
        [GridAction]
        public ActionResult _UpdateCashier(Cashier ins)
        {
            //...Update Object
            Cashier ins2 = CRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(CRep.GetAllCashier()));
        }
        //Remove CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveCashier(int id)
        {
            CRep.Remove(id);

            //...Repopulate Grid...
            return View(new GridModel(CRep.GetAllCashier()));
        }
    }
}

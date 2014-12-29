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
    public class CashController : Controller
    {
        //
        // GET: /CashBox/
        //Repository
        CashBoxRepository CBRep = new CashBoxRepository();
        CashMovementRepository CMRep = new CashMovementRepository();
        DropDownRepository DDRep = new DropDownRepository();
        CoinMovementRepository CIMRep = new CoinMovementRepository();

        //List
        // List SupplierType
        [GridAction]
        public ActionResult _ListCashBoxs()
        {
            return View(new GridModel(CBRep.GetAllCashBox()));
        }
        [GridAction]
        public ActionResult _ListCashMovements()
        {
            return View(new GridModel(CMRep.GetAllCashMovement()));
        }
        [GridAction]
        public ActionResult _ListCoinMovements()
        {
            return View(new GridModel(CIMRep.GetAllCoinMovement()));
        }

        //Functions


        // CashBox 
        public ActionResult CashBoxs()
        {
            ViewData["MovementType"] = DDRep.GetMovementTypeList();
            return View();
        }

        //Add CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertCashBoxs(CashBox ins)
        {
            //...Insert Object
            CashBox ins2 = CBRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(CBRep.GetAllCashBox()));
        }
        //Update CashBox
        [GridAction]
        public ActionResult _UpdateCashBoxs(CashBox ins)
        {
            //...Update Object
            CashBox ins2 = CBRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(CBRep.GetAllCashBox()));
        }
        //Remove CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveCashBoxs(int id)
        {
            //...Update Object
            string ins = CBRep.GetCashBox(id).ToString();
            CBRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(CBRep.GetAllCashBox()));
        }



        // Cashmovements
        public ActionResult CashMovements()
        {
            ViewData["CashType"] = DDRep.GetCashTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            return View();
        }

        //Add CashMovements
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertCashMovements(CashMovement ins)
        {
            //...Insert Object
            CashMovement ins2 = CMRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovement()));
        }
        //Update CashMovements
        [GridAction]
        public ActionResult _UpdateCashMovements(CashMovement ins)
        {
            //...Update Object
            CashMovement ins2 = CMRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovement()));
        }
        //Remove CashMovements
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveCashMovements(int id)
        {
            //...Update Object
            string ins = CMRep.GetCashMovement(id).ToString();
            CMRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovement()));
        }

        // Coinmovements
        public ActionResult CoinMovements()
        {
            ViewData["CashType"] = DDRep.GetCashTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            return View();
        }

        //Add CashMovements
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertCoinmovements(CoinMovement ins)
        {
            //...Insert Object
            CoinMovement ins2 = CIMRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(CIMRep.GetAllCoinMovement()));
        }
        //Update CashMovements
        [GridAction]
        public ActionResult _UpdateCoinmovements(CoinMovement ins)
        {
            //...Update Object
            CoinMovement ins2 = CIMRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(CIMRep.GetAllCoinMovement()));
        }
        //Remove CashMovements
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveCoinmovements(int id)
        {
            //...Update Object
            string ins = CIMRep.GetCoinMovement(id).ToString();
            CIMRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(CIMRep.GetAllCoinMovement()));
        }
    }
}

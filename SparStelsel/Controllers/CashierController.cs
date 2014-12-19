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
            //...Update Object
            string ins = CRep.GetCashier(id).ToString();
            CRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(CRep.GetAllCashier()));
        }



        public ActionResult CashMovements()
        {
            ViewData["CashType"] = DDRep.GetCashTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            return View();
        }

        [HttpPost]
        public ActionResult InsertCashMovement(CashEntry ins)
        {
            return null;
        }

        //Add CashMovementsKwikPay
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertCashMovements(CashMovementKwikPay ins)
        {
            CashMovement z = new CashMovement();

            z.ActualDate = ins.ActualDate;
            z.Amount = ins.Amount;
            z.CashMovementID = ins.CashMovementID;
            z.MoneyUnitID = 0;
            z.CashTypeID = 1;//For Cards

            CashMovement ins2 = CMRep.Insert(z);
            String user = HttpContext.User.ToString();
            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetCashMovementsPerCashType(1,user)));
        }
        //Update CashMovementsKwikPay
        [GridAction]
        public ActionResult _UpdateCashMovements(CashMovementKwikPay ins)
        {
            CashMovement z = new CashMovement();
            //...Update Object
            z.ActualDate = ins.ActualDate;
            z.Amount = ins.Amount;
            z.CashMovementID = ins.CashMovementID;
            z.MoneyUnitID = 0;
            z.CashTypeID = 1;// For Cards

            CashMovement ins2 = CMRep.Update(z);
            String user = HttpContext.User.ToString();
            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetCashMovementsPerCashType(1,user)));
        }
        //Remove CashMovementsKwikPay
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveCashMovements(int id)
        {
            //...Update Object
            string ins = CMRep.GetCashMovement(id).ToString();
            CMRep.Remove(ins);
            String user = HttpContext.User.ToString();
            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetCashMovementsPerCashType(1,user)));
        }




        [GridAction]
        public ActionResult _ListPickUps()
        {
            return View(new GridModel(PRep.GetAllPickUp()));
        }

        // PickUps kwikpay
        public ActionResult PickUps()
        {
            ViewData["CashType"] = DDRep.GetCashTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            return View();
        }

        //Add PickUps kwikpay
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertPickUps(PickUp ins)
        {
            //...Insert Object
            ins.CashTypeID = 1;//Change to 


            PickUp ins2 = PRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(PRep.GetAllPickUp()));
        }
        //Update PickUps kwikpay
        [GridAction]
        public ActionResult _UpdatePickUps(PickUp ins)
        {
            //...Update Object
            PickUp ins2 = PRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(PRep.GetAllPickUp()));
        }
        //Remove PickUps kwikpay
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemovePickUps(int id)
        {
            //...Update Object
            string ins = PRep.GetPickUp(id).ToString();
            PRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(PRep.GetAllPickUp()));
        }


    }
}

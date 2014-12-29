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
    public class MoneyController : Controller
    {
        DropDownRepository DDRep = new DropDownRepository();
        MoneyRepository MRep = new MoneyRepository();
        CashMovementRepository CashRep = new CashMovementRepository();
        ElectronicFundRepository ELRep = new ElectronicFundRepository();
        PickUpRepository PickRep = new PickUpRepository();
        CashReconciliationRepository CRRep = new CashReconciliationRepository();
        InstantMoneyRepository ImRep = new InstantMoneyRepository();
        FNBRepository FNBRep = new FNBRepository();
        KwikPayRepository KwikRep = new KwikPayRepository();
        TransitRepository TransRep = new TransitRepository();
        CashBoxRepository CBRep = new CashBoxRepository();
        CoinMovementRepository CoinRep = new CoinMovementRepository();
        CashOfficeRepository CORep = new CashOfficeRepository();

        public ActionResult CashUp()
        {
            ViewData["Employees"] = DDRep.GetEmployeeList();
            ViewData["Movements"] = DDRep.GetMovementTypeList();
            ViewData["ElectronicType"] = DDRep.GetElectronicFundTypeList();
            ViewData["ReconciliationTypeID"] = DDRep.GetCashReconList();
            ViewData["InstantMoneyType"] = DDRep.GetInstantMoneyType();
            ViewData["FNBType"] = DDRep.GetFNBType();
            ViewData["KwikPayType"] = DDRep.GetKwikPayType();
            return View();
        }

        [GridAction]
        public JsonResult _ListCash()
        {
            return Json(new GridModel(MRep.GetCashMovements()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertCash(FormCollection ins)
        {
            CashMovement c5 = new CashMovement();
            c5.MovementTypeID = Convert.ToInt32(ins["Movement"]);
            c5.MoneyUnitID = 1; // 5c
            c5.Amount = Convert.ToDecimal(ins["r005"]) * (decimal)0.05;
            c5.ActualDate = Convert.ToDateTime(ins["cashDate"]);
            c5.EmployeeID = Convert.ToInt32(ins["Employee"]);
            c5.UserTypeID = 1;
            c5 = CashRep.Insert(c5);

            CashMovement c10 = new CashMovement();
            c10.MovementTypeID = Convert.ToInt32(ins["Movement"]);
            c10.MoneyUnitID = 2; // 10c
            c10.Amount = Convert.ToDecimal(ins["r010"]) * (decimal)(0.10);
            c10.ActualDate = Convert.ToDateTime(ins["cashDate"]);
            c10.EmployeeID = Convert.ToInt32(ins["Employee"]);
            c10.UserTypeID = 1;
            c10 = CashRep.Insert(c10);

            CashMovement c20 = new CashMovement();
            c20.MovementTypeID = Convert.ToInt32(ins["Movement"]);
            c20.MoneyUnitID = 3; // 20c
            c20.Amount = Convert.ToDecimal(ins["r020"]) * (decimal)(0.20);
            c20.ActualDate = Convert.ToDateTime(ins["cashDate"]);
            c20.EmployeeID = Convert.ToInt32(ins["Employee"]);
            c20.UserTypeID = 1;
            c20 = CashRep.Insert(c20);

            CashMovement c50 = new CashMovement();
            c50.MovementTypeID = Convert.ToInt32(ins["Movement"]);
            c50.MoneyUnitID = 4; // 50c
            c50.Amount = Convert.ToDecimal(ins["r050"]) * (decimal)(0.5);
            c50.ActualDate = Convert.ToDateTime(ins["cashDate"]);
            c50.EmployeeID = Convert.ToInt32(ins["Employee"]);
            c50.UserTypeID = 1;
            c50 = CashRep.Insert(c50);

            CashMovement R1 = new CashMovement();
            R1.MovementTypeID = Convert.ToInt32(ins["Movement"]);
            R1.MoneyUnitID = 5; // R1
            R1.Amount = Convert.ToDecimal(ins["r1"]) * (decimal)(1.00);
            R1.ActualDate = Convert.ToDateTime(ins["cashDate"]);
            R1.EmployeeID = Convert.ToInt32(ins["Employee"]);
            R1.UserTypeID = 1;
            R1 = CashRep.Insert(R1);

            CashMovement R2 = new CashMovement();
            R2.MovementTypeID = Convert.ToInt32(ins["Movement"]);
            R2.MoneyUnitID = 6; // R2
            R2.Amount = Convert.ToDecimal(ins["r2"]) * (decimal)(2.00);
            R2.ActualDate = Convert.ToDateTime(ins["cashDate"]);
            R2.EmployeeID = Convert.ToInt32(ins["Employee"]);
            R2.UserTypeID = 1;
            R2 = CashRep.Insert(R2);

            CashMovement R5 = new CashMovement();
            R5.MovementTypeID = Convert.ToInt32(ins["Movement"]);
            R5.MoneyUnitID = 7; // R5
            R5.Amount = Convert.ToDecimal(ins["r5"]) * (decimal)(5.00);
            R5.ActualDate = Convert.ToDateTime(ins["cashDate"]);
            R5.EmployeeID = Convert.ToInt32(ins["Employee"]);
            R5.UserTypeID = 1;
            R5 = CashRep.Insert(R5);

            CashMovement R10 = new CashMovement();
            R10.MovementTypeID = Convert.ToInt32(ins["Movement"]);
            R10.MoneyUnitID = 8; // R10
            R10.Amount = Convert.ToDecimal(ins["r10"]) * (decimal)(10.00);
            R10.ActualDate = Convert.ToDateTime(ins["cashDate"]);
            R10.EmployeeID = Convert.ToInt32(ins["Employee"]);
            R10.UserTypeID = 1;
            R10 = CashRep.Insert(R10);

            CashMovement R20 = new CashMovement();
            R20.MovementTypeID = Convert.ToInt32(ins["Movement"]);
            R20.MoneyUnitID = 9; // R20
            R20.Amount = Convert.ToDecimal(ins["r20"]) * (decimal)(20.00);
            R20.ActualDate = Convert.ToDateTime(ins["cashDate"]);
            R20.EmployeeID = Convert.ToInt32(ins["Employee"]);
            R20.UserTypeID = 1;
            R20 = CashRep.Insert(R20);

            CashMovement R50 = new CashMovement();
            R50.MovementTypeID = Convert.ToInt32(ins["Movement"]);
            R50.MoneyUnitID = 10; // R50
            R50.Amount = Convert.ToDecimal(ins["r50"]) * (decimal)(50.00);
            R50.ActualDate = Convert.ToDateTime(ins["cashDate"]);
            R50.EmployeeID = Convert.ToInt32(ins["Employee"]);
            R50.UserTypeID = 1;
            R50 = CashRep.Insert(R50);

            CashMovement R100 = new CashMovement();
            R100.MovementTypeID = Convert.ToInt32(ins["Movement"]);
            R100.MoneyUnitID = 11; // R100
            R100.Amount = Convert.ToDecimal(ins["r100"]) * (decimal)(100.00);
            R100.ActualDate = Convert.ToDateTime(ins["cashDate"]);
            R100.EmployeeID = Convert.ToInt32(ins["Employee"]);
            R100.UserTypeID = 1;
            R100 = CashRep.Insert(R100);

            CashMovement R200 = new CashMovement();
            R200.MovementTypeID = Convert.ToInt32(ins["Movement"]);
            R200.MoneyUnitID = 12; // R200
            R200.Amount = Convert.ToDecimal(ins["r200"]) * (decimal)(200.00);
            R200.ActualDate = Convert.ToDateTime(ins["cashDate"]);
            R200.EmployeeID = Convert.ToInt32(ins["Employee"]);
            R200.UserTypeID = 1;
            R200 = CashRep.Insert(R200);

            //...Repopulate Grid...
            return Json(new GridModel(MRep.GetCashMovements()));
        }


        [GridAction]
        public JsonResult _ListElectronic()
        {
            return Json(new GridModel(ELRep.GetAllElectronicFund()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertElectronic(ElectronicFund ins)
        {


            ElectronicFund ins2 = ELRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ELRep.GetAllElectronicFund()));
        }

        [GridAction]
        public JsonResult _UpdateElectronic(ElectronicFund ins)
        {


            ElectronicFund ins2 = ELRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ELRep.GetAllElectronicFund()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _RemoveElectronic(int id)
        {
            //...Update Object
           
            ELRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(ELRep.GetAllElectronicFund()));
        }

        [GridAction]
        public JsonResult _ListPickup()
        {
            return Json(new GridModel(PickRep.GetAllPickUp()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertPickup(PickUp ins)
        {
            PickUp ins2 = PickRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(PickRep.GetAllPickUp()));
        }

        [GridAction]
        public JsonResult _UpdatePickup(PickUp ins)
        {
            PickUp ins2 = PickRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(PickRep.GetAllPickUp()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _RemovePickup(int id)
        {
            //...Update Object
            PickRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(PickRep.GetAllPickUp()));
        }


        [GridAction]
        public JsonResult _ListRecon()
        {
            return Json(new GridModel(CRRep.GetAllCashReconcilation()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertRecon(CashReconciliation ins)
        {
            CashReconciliation ins2 = CRRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(CRRep.GetAllCashReconcilation()));
        }

        [GridAction]
        public JsonResult _UpdateRecon(CashReconciliation ins)
        {
            CashReconciliation ins2 = CRRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(CRRep.GetAllCashReconcilation()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _RemoveRecon(int id)
        {
            //...Update Object
            CRRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(CRRep.GetAllCashReconcilation()));
        }

        [GridAction]
        public JsonResult _ListInstantMoney()
        {
            return Json(new GridModel(ImRep.GetAllInstantMoney()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertInstantMoney(InstantMoney ins)
        {
            InstantMoney ins2 = ImRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ImRep.GetAllInstantMoney()));
        }

        [GridAction]
        public JsonResult _UpdateInstantMoney(InstantMoney ins)
        {
            InstantMoney ins2 = ImRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ImRep.GetAllInstantMoney()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _RemoveInstantMoney(int id)
        {
            //...Update Object
            ImRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(ImRep.GetAllInstantMoney()));
        }

        [GridAction]
        public JsonResult _ListFNB()
        {
            return Json(new GridModel(FNBRep.GetAllFNB()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertFNB(FNB ins)
        {
            FNB ins2 = FNBRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(FNBRep.GetAllFNB()));
        }

        [GridAction]
        public JsonResult _UpdateFNB(FNB ins)
        {
            FNB ins2 = FNBRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(FNBRep.GetAllFNB()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _RemoveFNB(int id)
        {
            //...Update Object
            FNBRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(FNBRep.GetAllFNB()));
        }

        [GridAction]
        public JsonResult _ListKwikPay()
        {
            return Json(new GridModel(KwikRep.GetAllKwikPay()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertKwikPay(KwikPay ins)
        {
            KwikPay ins2 = KwikRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(KwikRep.GetAllKwikPay()));
        }

        [GridAction]
        public JsonResult _UpdateKwikPay(KwikPay ins)
        {
            KwikPay ins2 = KwikRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(KwikRep.GetAllKwikPay()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _RemoveKwikPay(int id)
        {
            //...Update Object
            KwikRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(KwikRep.GetAllKwikPay()));
        }



        public ActionResult Transits()
        {
            ViewData["TransitType"] = DDRep.GetTransitType();
            return View();
        }

        [GridAction]
        public JsonResult _ListTransit()
        {
            return Json(new GridModel(TransRep.GetAllTransit()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertTransit(Transit ins)
        {
            Transit ins2 = TransRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(TransRep.GetAllTransit()));
        }

        [GridAction]
        public JsonResult _UpdateTransit(Transit ins)
        {
            Transit ins2 = TransRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(TransRep.GetAllTransit()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _RemoveTransit(int id)
        {
            //...Update Object
            TransRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(TransRep.GetAllTransit()));
        }

        public ActionResult Cashbox()
        {
            ViewData["CashboxType"] = DDRep.GetCashboxType();
            return View();
        }

        [GridAction]
        public JsonResult _ListCashbox()
        {
            return Json(new GridModel(CBRep.GetAllCashBox()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertCashbox(CashBox ins)
        {
            CashBox ins2 = CBRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(CBRep.GetAllCashBox()));
        }

        [GridAction]
        public JsonResult _UpdateCashbox(CashBox ins)
        {
            CashBox ins2 = CBRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(CBRep.GetAllCashBox()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _RemoveCashbox(int id)
        {
            //...Update Object
            CBRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(CBRep.GetAllCashBox()));
        }

        public ActionResult CoinMovement()
        {
            ViewData["CoinMovementType"] = DDRep.GetCoinMovementType();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            return View();
        }

        [GridAction]
        public JsonResult _ListCoinMovement()
        {
            return Json(new GridModel(CoinRep.GetAllCoinMovement()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertCoinMovement(CoinMovement ins)
        {
            CoinMovement ins2 = CoinRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(CoinRep.GetAllCoinMovement()));
        }

        [GridAction]
        public JsonResult _UpdateCoinMovement(CoinMovement ins)
        {
            CoinMovement ins2 = CoinRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(CoinRep.GetAllCoinMovement()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _RemoveCoinMovement(int id)
        {
            //...Update Object
            CoinRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(CoinRep.GetAllCoinMovement()));
        }

        public ActionResult CashOffice()
        {
            ViewData["CashOfficeType"] = DDRep.GetCashOfficeType();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            ViewData["CashStatus"] = DDRep.GetCashOfficeStatusList();
            return View();
        }

        [GridAction]
        public JsonResult _ListCashOffice()
        {
            return Json(new GridModel(CORep.GetAllCashOffice()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertCashOffice(CashOffice ins)
        {
            CashOffice ins2 = CORep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(CORep.GetAllCashOffice()));
        }

        [GridAction]
        public JsonResult _UpdateCashOffice(CashOffice ins)
        {
            CashOffice ins2 = CORep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(CORep.GetAllCashOffice()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _RemoveCashOffice(int id)
        {
            //...Update Object
            CORep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(CORep.GetAllCashOffice()));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SparStelsel.Models;
using Telerik.Web.Mvc;
using System.IO;
using Telerik.Web.Mvc.Extensions;
using System.Globalization;

namespace SparStelsel.Controllers
{
    [AutoLogOffActionFilter]
    public class MoneyController : Controller
    {
        #region Repositories
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
        MoneyUnitRepository MuRep = new MoneyUnitRepository();
        ReportRepository RepRep = new ReportRepository();
        #endregion

        public ActionResult CashUp()
        {
            ViewData["Employees"] = DDRep.GetEmployeeList();
            ViewData["Movements"] = DDRep.GetMovementTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            ViewData["ElectronicType"] = DDRep.GetElectronicFundTypeList();
            ViewData["ReconciliationTypeID"] = DDRep.GetCashReconList();
            ViewData["InstantMoneyType"] = DDRep.GetInstantMoneyType();
            ViewData["FNBType"] = DDRep.GetFNBType();
            ViewData["KwikPayType"] = DDRep.GetKwikPayType();
            ViewData["TransitType"] = DDRep.GetTransitType();
            ViewData["CoinMovementType"] = DDRep.GetCoinMovementType();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            ViewData["CashboxType"] = DDRep.GetCashboxType();
            return View();
        }

        #region Cashier Live Report
        public ActionResult CashierStatus()
        {
            return View();
        }

        [GridAction]
        public JsonResult _ListCashierStatus()
        {
            return Json(new GridModel(MRep.GetCashMovementsReport()));
        }
        #endregion

        #region Cash
        [GridAction]
        public JsonResult _ListCash()
        {
            return Json(new GridModel(MRep.GetCashMovements()));
        }

        public ActionResult _MultipleCashMovements()
        {
            ViewData["Employees"] = DDRep.GetEmployeeList();
            ViewData["Movements"] = DDRep.GetMovementTypeList();
            ViewData["TransitType"] = DDRep.GetTransitType();

            CashMovementMultiple ins = new CashMovementMultiple();
            ins.Movements = new List<CashMovement>();
            
            for(int i = 1; i <= 12; i++)
            {                
                ins.Movements.Add(new CashMovement());
                ins.Movements[i - 1].MoneyUnitID = i;
                ins.Movements[i - 1].moneyunit = MuRep.GetMoneyUnitString(i);
            }

            return PartialView(ins);
        }

        [HttpPost]
        public ActionResult _InsertMultipleCash(CashMovementMultiple ins)
        {
            for (int i = 0; i < 12; i++)
            {
                ins.Movements[i].ActualDate = ins.ActualDate;
                ins.Movements[i].MovementTypeID = ins.MovementTypeID;
                ins.Movements[i].EmployeeID = ins.EmployeeID;
                ins.Movements[i].Amount = ins.Movements[i].Count * MuRep.GetMoneyUnitValue(ins.Movements[i].MoneyUnitID);
                ins.Movements[i] = CashRep.Insert(ins.Movements[i]);
            }

            return null;
        }

        

        [GridAction]
        public JsonResult _UpdateCash(CashMovement ins)
        {
            ins.Amount = ins.Count * MuRep.GetMoneyUnitValue(ins.MoneyUnitID);
            CashMovement ins2 = CashRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(MRep.GetCashMovements()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _DeleteCash(int id)
        {
            //...Update Object
            CashRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(MRep.GetCashMovements()));
        }
        #endregion

        #region Electronic Funds
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
        #endregion

        #region Pickups
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
        #endregion

        #region Reconciliations
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
        #endregion

        #region Instant Money
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
        #endregion

        #region FNB
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
        #endregion

        #region KwikPay
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
        #endregion

        #region Transits
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
        #endregion

        #region Cashbox
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
        #endregion

        #region Coin Movements
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
        #endregion

        #region Cash Office
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
        #endregion

        #region Sigma Cashup
        public ActionResult CashierDayEnd()
        {
            ViewData["Employees"] = DDRep.GetEmployeeList();
            ViewData["Movements"] = DDRep.GetMovementTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            ViewData["ElectronicType"] = DDRep.GetElectronicFundTypeList();
            ViewData["ReconciliationTypeID"] = DDRep.GetCashReconList();
            ViewData["InstantMoneyType"] = DDRep.GetInstantMoneyType();
            ViewData["FNBType"] = DDRep.GetFNBType();
            ViewData["KwikPayType"] = DDRep.GetKwikPayType();

            CashMovementMultiple ins = new CashMovementMultiple();
            ins.Movements = new List<CashMovement>();

            for (int i = 1; i <= 12; i++)
            {
                ins.Movements.Add(new CashMovement());
                ins.Movements[i - 1].MoneyUnitID = i;
                ins.Movements[i - 1].moneyunit = MuRep.GetMoneyUnitString(i);
                ins.MovementTypeID = 1;
            }

            CashierDayEnd model = new CashierDayEnd();
            model.CashMovements = ins;
            model.SigmaSale = new CashReconciliation();
            model.SigmaSale.ReconciliationTypeID = 3;
            model.SigmaSale.MovementTypeID = 1;
            model.ElectronicFund = new ElectronicFund();
            model.ElectronicFund.MovementTypeID = 1;

            return View(model);
        }

        [HttpPost]
        public ActionResult _InsertMultipleCashCashier(CashierDayEnd ins)
        {
            decimal total = 0;

            for (int i = 0; i < 12; i++)
            {
                ins.CashMovements.Movements[i].ActualDate = ins.CashMovements.ActualDate;
                ins.CashMovements.Movements[i].MovementTypeID = ins.CashMovements.MovementTypeID;
                ins.CashMovements.Movements[i].EmployeeID = ins.CashMovements.EmployeeID;
                ins.CashMovements.Movements[i].Amount = ins.CashMovements.Movements[i].Count * MuRep.GetMoneyUnitValue(ins.CashMovements.Movements[i].MoneyUnitID);
                ins.CashMovements.Movements[i] = CashRep.Insert(ins.CashMovements.Movements[i]);

                if (ins.CashMovements.Movements[i].CashMovementID != 0)
                {
                    total = total + ins.CashMovements.Movements[i].Amount;
                }
            }

            return Content(total.ToString(), "text/html");
        }

        [HttpPost]
        public ActionResult _InsertElectronicFromMulti(CashierDayEnd ins)
        {
            //ins.ElectronicFund.ActualDate = ins.ActualDate;
            //ins.ElectronicFund.EmployeeID = ins.EmployeeID;
            ElectronicFund ins2 = ELRep.Insert(ins.ElectronicFund);

            if(ins2.ElectronicFundID != 0)
            {
                return Content(ins2.Total.ToString(), "text/html");
            }
            else
            {
                return Content("0", "text/html");
            }
            
        }

        [HttpPost]
        public ActionResult _SigmaCashier(CashierDayEnd ins)
        {
            CashReconciliation ins2 = CRRep.InsertMultiple(ins.SigmaSale);

            if(ins2.CashReconciliationID != 0)
            {
                return Content(ins2.Amount.ToString(), "text/html");
            }
            else
            {
                return Content("0", "text/html");
            }
            
        }

        [HttpPost]
        public ActionResult _CashierDayEndReportShow(CashierDayEnd ins)
        {
            ins.Report = RepRep.GetCashierReport(ins.ReportActualDate, ins.ReportEmployeeID);
            return PartialView("_CashierDayEndReport",ins);
        }

        [HttpPost]
        public ActionResult _CashierDayEndReportPDF(int ReportEmployeeID, DateTime ReportActualDate)
        {
            CashierDayEnd report = new CashierDayEnd();
            report.Report = RepRep.GetCashierReport(ReportActualDate, ReportEmployeeID);

            return new Rotativa.ViewAsPdf("SigmaSalesReport", report);
        }

        #endregion

        #region Cashier Kwikpay
        public ActionResult CashierKwikpay()
        {
            ViewData["Employees"] = DDRep.GetEmployeeList();
            ViewData["Movements"] = DDRep.GetMovementTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            ViewData["ElectronicType"] = DDRep.GetElectronicFundTypeListC();
            ViewData["ReconciliationTypeID"] = DDRep.GetCashReconList();
            ViewData["InstantMoneyType"] = DDRep.GetInstantMoneyTypeC();
            ViewData["FNBType"] = DDRep.GetFNBType();
            ViewData["KwikPayType"] = DDRep.GetKwikPayType();

            CashMovementMultiple ins = new CashMovementMultiple();
            ins.Movements = new List<CashMovement>();

            for (int i = 1; i <= 12; i++)
            {
                ins.Movements.Add(new CashMovement());
                ins.Movements[i - 1].MoneyUnitID = i;
                ins.Movements[i - 1].moneyunit = MuRep.GetMoneyUnitString(i);
                ins.MovementTypeID = 3;
            }

            CashierKwikpay model = new CashierKwikpay();
            model.CashMovements = ins;
            model.ElectronicFund = new ElectronicFund();
            model.ElectronicFund.MovementTypeID = 3;
            model.KiwkPay = new KwikPay();
            

            return View(model);
        }

        [HttpPost]
        public ActionResult _InsertMultipleCashCashierKwikpay(CashierKwikpay ins)
        {
            decimal total = 0;

            for (int i = 0; i < 12; i++)
            {
                ins.CashMovements.Movements[i].ActualDate = ins.CashMovements.ActualDate;
                ins.CashMovements.Movements[i].MovementTypeID = ins.CashMovements.MovementTypeID;
                ins.CashMovements.Movements[i].EmployeeID = ins.CashMovements.EmployeeID;
                ins.CashMovements.Movements[i].Amount = ins.CashMovements.Movements[i].Count * MuRep.GetMoneyUnitValue(ins.CashMovements.Movements[i].MoneyUnitID);
                ins.CashMovements.Movements[i] = CashRep.Insert(ins.CashMovements.Movements[i]);

                if (ins.CashMovements.Movements[i].CashMovementID != 0)
                {
                    total = total + ins.CashMovements.Movements[i].Amount;
                }
            }

            return Content(total.ToString(), "text/html");
        }

        [HttpPost]
        public ActionResult _InsertElectronicFromMultiKwikpay(CashierKwikpay ins)
        {
            //ins.ElectronicFund.ActualDate = ins.ActualDate;
            //ins.ElectronicFund.EmployeeID = ins.EmployeeID;
            ElectronicFund ins2 = ELRep.Insert(ins.ElectronicFund);

            if (ins2.ElectronicFundID != 0)
            {
                return Content(ins2.Total.ToString(), "text/html");
            }
            else
            {
                return Content("0", "text/html");
            }

        }

        [HttpPost]
        public ActionResult _InsertKwikpayFromMultiKwikpay(CashierKwikpay ins)
        {
            //ins.KiwkPay.ActualDate = ins.ActualDate;
            //ins.KiwkPay.EmployeeID = ins.EmployeeID.ToString();
            KwikPay ins2 = KwikRep.Insert(ins.KiwkPay);

            if (ins2.KwikPayID != 0)
            {
                return Content(ins2.Amount.ToString(), "text/html");
            }
            else
            {
                return Content("0", "text/html");
            }

        }

        [HttpPost]
        public ActionResult _CashierKwikPayReportShow(CashierKwikpay ins)
        {
            ins.Report = RepRep.GetCashierKwikpayReport(ins.ReportActualDate, ins.ReportEmployeeID);
            return PartialView("_CashierKwikPayReport", ins);
        }

        [HttpPost]
        public ActionResult _KwikpayDayEndReportPDF(int ReportEmployeeID, DateTime ReportActualDate)
        {
            CashierKwikpayReport report = new CashierKwikpayReport();
            report = RepRep.GetCashierKwikpayReport(ReportActualDate, ReportEmployeeID);

            return new Rotativa.ViewAsPdf("KwikpayReport", report);
        }
        #endregion 

        #region Instant Money
        public ActionResult CashierInstantMoney()
        {
            ViewData["Employees"] = DDRep.GetEmployeeList();
            ViewData["Movements"] = DDRep.GetMovementTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            ViewData["ElectronicType"] = DDRep.GetElectronicFundTypeListC();
            ViewData["ReconciliationTypeID"] = DDRep.GetCashReconList();
            ViewData["InstantMoneyType"] = DDRep.GetInstantMoneyTypeC();
            ViewData["FNBType"] = DDRep.GetFNBType();
            ViewData["KwikPayType"] = DDRep.GetKwikPayType();

            CashMovementMultiple ins = new CashMovementMultiple();
            ins.Movements = new List<CashMovement>();

            for (int i = 1; i <= 12; i++)
            {
                ins.Movements.Add(new CashMovement());
                ins.Movements[i - 1].MoneyUnitID = i;
                ins.Movements[i - 1].moneyunit = MuRep.GetMoneyUnitString(i);
                ins.MovementTypeID = 4;
            }

            CashierInstantMoney model = new CashierInstantMoney();
            model.CashMovements = ins;
            model.ElectronicFund = new ElectronicFund();
            model.ElectronicFund.MovementTypeID = 4;
            model.InstantMoney = new InstantMoney();


            return View(model);
        }

        [HttpPost]
        public ActionResult _InsertMultipleCashCashierInstantMoney(CashierInstantMoney ins)
        {
            decimal total = 0;

            for (int i = 0; i < 12; i++)
            {
                ins.CashMovements.Movements[i].ActualDate = ins.CashMovements.ActualDate;
                ins.CashMovements.Movements[i].MovementTypeID = ins.CashMovements.MovementTypeID;
                ins.CashMovements.Movements[i].EmployeeID = ins.CashMovements.EmployeeID;
                ins.CashMovements.Movements[i].Amount = ins.CashMovements.Movements[i].Count * MuRep.GetMoneyUnitValue(ins.CashMovements.Movements[i].MoneyUnitID);
                ins.CashMovements.Movements[i] = CashRep.Insert(ins.CashMovements.Movements[i]);

                if (ins.CashMovements.Movements[i].CashMovementID != 0)
                {
                    total = total + ins.CashMovements.Movements[i].Amount;
                }
            }

            return Content(total.ToString(), "text/html");
        }

        [HttpPost]
        public ActionResult _InsertElectronicFromMultiInstantMoney(CashierInstantMoney ins)
        {
            //ins.ElectronicFund.ActualDate = ins.ActualDate;
            //ins.ElectronicFund.EmployeeID = ins.EmployeeID;
            ElectronicFund ins2 = ELRep.Insert(ins.ElectronicFund);

            if (ins2.ElectronicFundID != 0)
            {
                return Content(ins2.Total.ToString(), "text/html");
            }
            else
            {
                return Content("0", "text/html");
            }

        }

        [HttpPost]
        public ActionResult _InsertInstantMoneyFromMultiInstantMoney(CashierInstantMoney ins)
        {
            //ins.KiwkPay.ActualDate = ins.ActualDate;
            //ins.KiwkPay.EmployeeID = ins.EmployeeID.ToString();
            InstantMoney ins2 = ImRep.Insert(ins.InstantMoney);

            if (ins2.InstantMoneyID != 0)
            {
                return Content(ins2.Amount.ToString(), "text/html");
            }
            else
            {
                return Content("0", "text/html");
            }

        }

        [HttpPost]
        public ActionResult _CashierInstantMoneyReport(CashierInstantMoney ins)
        {
            ins.Report = RepRep.GetCashierInstantMoneyReport(ins.ReportActualDate, ins.ReportEmployeeID);
            return PartialView("_CashierInstantMoneyReport", ins);
        }

        [HttpPost]
        public ActionResult _IMDayEndReportPDF(int ReportEmployeeID, DateTime ReportActualDate)
        {
            CashierInstantMoneyReport report = new CashierInstantMoneyReport();
            report = RepRep.GetCashierInstantMoneyReport(ReportActualDate, ReportEmployeeID);

            return new Rotativa.ViewAsPdf("IMReport", report);
        }
        #endregion

        #region Cashier FNB
        public ActionResult CashierFNB()
        {
            ViewData["Employees"] = DDRep.GetEmployeeList();
            ViewData["Movements"] = DDRep.GetMovementTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            ViewData["ElectronicType"] = DDRep.GetElectronicFundTypeListC();
            ViewData["ReconciliationTypeID"] = DDRep.GetCashReconList();
            ViewData["InstantMoneyType"] = DDRep.GetInstantMoneyType();
            ViewData["FNBType"] = DDRep.GetFNBType();
            ViewData["KwikPayType"] = DDRep.GetKwikPayType();

            CashMovementMultiple ins = new CashMovementMultiple();
            ins.Movements = new List<CashMovement>();

            for (int i = 1; i <= 12; i++)
            {
                ins.Movements.Add(new CashMovement());
                ins.Movements[i - 1].MoneyUnitID = i;
                ins.Movements[i - 1].moneyunit = MuRep.GetMoneyUnitString(i);
                ins.MovementTypeID = 2;
            }

            CashierFNB model = new CashierFNB();
            model.CashMovements = ins;
            model.ElectronicFund = new ElectronicFund();
            model.ElectronicFund.MovementTypeID = 2;
            model.FNB = new FNB();


            return View(model);
        }

        [HttpPost]
        public ActionResult _InsertMultipleCashCashierFNB(CashierFNB ins)
        {
            decimal total = 0;

            for (int i = 0; i < 12; i++)
            {
                ins.CashMovements.Movements[i].ActualDate = ins.CashMovements.ActualDate;
                ins.CashMovements.Movements[i].MovementTypeID = ins.CashMovements.MovementTypeID;
                ins.CashMovements.Movements[i].EmployeeID = ins.CashMovements.EmployeeID;
                ins.CashMovements.Movements[i].Amount = ins.CashMovements.Movements[i].Count * MuRep.GetMoneyUnitValue(ins.CashMovements.Movements[i].MoneyUnitID);
                ins.CashMovements.Movements[i] = CashRep.Insert(ins.CashMovements.Movements[i]);

                if (ins.CashMovements.Movements[i].CashMovementID != 0)
                {
                    total = total + ins.CashMovements.Movements[i].Amount;
                }
            }

            return Content(total.ToString(), "text/html");
        }

        [HttpPost]
        public ActionResult _InsertElectronicFromMultiFNB(CashierFNB ins)
        {
            //ins.ElectronicFund.ActualDate = ins.ActualDate;
            //ins.ElectronicFund.EmployeeID = ins.EmployeeID;
            ElectronicFund ins2 = ELRep.Insert(ins.ElectronicFund);

            if (ins2.ElectronicFundID != 0)
            {
                return Content(ins2.Total.ToString(), "text/html");
            }
            else
            {
                return Content("0", "text/html");
            }

        }

        [HttpPost]
        public ActionResult _InsertFNBFromMultiFNB(CashierFNB ins)
        {
            //ins.KiwkPay.ActualDate = ins.ActualDate;
            //ins.KiwkPay.EmployeeID = ins.EmployeeID.ToString();
            FNB ins2 = FNBRep.Insert(ins.FNB);

            if (ins2.FNBID != 0)
            {
                return Content(ins2.Amount.ToString(), "text/html");
            }
            else
            {
                return Content("0", "text/html");
            }

        }

        [HttpPost]
        public ActionResult _CashierFNBReportShow(CashierFNB ins)
        {
            ins.Report = RepRep.GetCashierFNBReport(ins.ReportActualDate, ins.ReportEmployeeID);
            return PartialView("_CashierFNBReportShow", ins);
        }

        [HttpPost]
        public ActionResult _FNBDayEndReportPDF(int ReportEmployeeID, DateTime ReportActualDate)
        {
            CashierFNBReport report = new CashierFNBReport();
            report = RepRep.GetCashierFNBReport(ReportActualDate, ReportEmployeeID);

            return new Rotativa.ViewAsPdf("FNBReport", report);
        }
        #endregion
    }
}

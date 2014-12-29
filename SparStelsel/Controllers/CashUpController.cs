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
    public class CashUpController : Controller
    {
        //
        // GET: /CashUp/
        /*DropDownRepository DDRep = new DropDownRepository();
        CashMovementRepository CMRep = new CashMovementRepository();
        PickUpRepository PRep = new PickUpRepository();
        KwikPayRepository KRep = new KwikPayRepository();
        InstantMoneyRepository IRep = new InstantMoneyRepository();
        FNBRepository FNBRep = new FNBRepository();
        //Views
        public ActionResult Kwikpay()
        {
            return View();
        }
        public ActionResult InstantMoney()
        {
            return View();
        }
        public ActionResult FNB()
        {
            return View();
        }




        //Functions
        [GridAction]
        public ActionResult _ListCashMovements()
        {
            String user = HttpContext.User.ToString();
            return View(new GridModel(CMRep.GetCashMovementsPerCashType(1,user)));
        }
        // Cashmovements
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
            
            z.ActualDate = DateTime.Now;
            z.Amount = ins.Amount;
            z.CashMovementID = ins.CashMovementID;
            z.MoneyUnitID = 0;
            z.MovementTypeID = 1;//For Cards
            
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
            String  user = HttpContext.User.ToString();
            string ins = CMRep.GetCashMovement(id).ToString();
            CMRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetCashMovementsPerCashType(1,user)));
        }


        //Pick Ups kwikpay
       
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
        public ActionResult _InsertPickUps(FormCollection ins)
        {
            //...Insert Object
            //ins.CashTypeID = 1;//Change to 
            

           // PickUp ins2 = PRep.Insert(ins);

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


        //Cheques kwikpay
        [GridAction]
        public ActionResult _ListCashMovementsC()
        {
            String user = HttpContext.User.ToString();
            return View(new GridModel(CMRep.GetCashMovementsPerCashType(2,user)));
        }
        // Cheques kwikpay
        public ActionResult CashMovementsC()
        {
            ViewData["CashType"] = DDRep.GetCashTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            return View();
        }

        //Add Cheques kwikpay
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertCashMovementsC(CashMovementKwikPay ins)
        {
            CashMovement z = new CashMovement();
            //...Update Object
            z.ActualDate = DateTime.Now;
            z.Amount = ins.Amount;
            z.CashMovementID = ins.CashMovementID;
            z.MoneyUnitID = 0;
            z.MovementTypeID = 2;//For cheques
            CashMovement ins2 = CMRep.Insert(z);
            //...Repopulate Grid...
    String  user = HttpContext.User.ToString();

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetCashMovementsPerCashType(2,user)));
        }
        //Update Cheques kwikpay
        [GridAction]
        public ActionResult _UpdateCashMovementsC(CashMovementKwikPay ins)
        {
            CashMovement z = new CashMovement();
            //...Update Object
            z.ActualDate = ins.ActualDate;
            z.Amount = ins.Amount;
            z.CashMovementID = ins.CashMovementID;
            z.MoneyUnitID = 0;
            z.MovementTypeID = 2;//For cheques
            CashMovement ins2 = CMRep.Update(z);
            String user = HttpContext.User.ToString();
            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetCashMovementsPerCashType(2, user)));
        }
        //Remove Cheques kwikpay
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveCashMovementsC(int id)
        {
            //...Update Object
            string ins = CMRep.GetCashMovement(id).ToString();
            CMRep.Remove(ins);
            String user = HttpContext.User.ToString();
            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetCashMovementsPerCashType(2,user)));
        }




        //Functions
        [GridAction]
        public ActionResult _ListKwikPays()
        {
            return View(new GridModel(KRep.GetAllKwikPay()));
        }
        // Cashmovements
        public ActionResult KwikPays()
        {

            ViewData["KwikPayType"] = DDRep.GetKwikPayType();
            return View();
        }

        //Add CashMovementsKwikPay
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertKwikPays(KwikPay ins)
        {
            int a = 0;
            a++;
            
            KwikPay ins2 = KRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(KRep.GetAllKwikPay()));
        }
        //Update CashMovementsKwikPay
        [GridAction]
        public ActionResult _UpdateKwikPays(KwikPay ins)
        {
         

            KwikPay ins2 = KRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(KRep.GetAllKwikPay()));
        }
        //Remove CashMovementsKwikPay
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveKwikPays(int id)
        {
            //...Update Object
            string ins = KRep.GetKwikPay(id).ToString();
            KRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(KRep.GetAllKwikPay()));
        }























        //Functions
        [GridAction]
        public ActionResult _ListCashMovementInstantMoney()
        {
            return View(new GridModel(CMRep.GetAllCashMovement()));
        }
        // Cashmovements
        public ActionResult CashMovementInstantMoney()
        {
            ViewData["CashType"] = DDRep.GetCashTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            return View();
        }

        //Add CashMovementsInstantMoney
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertCashMovementInstantMoney(CashMovementInstantMoney ins)
        {
            CashMovement z = new CashMovement();

            z.ActualDate = ins.ActualDate;
            z.Amount = ins.Amount;
            z.CashMovementID = ins.CashMovementID;
            z.MoneyUnitID = 0;
            z.CashTypeID = 1;//For Cards

            CashMovement ins2 = CMRep.Insert(z);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovement()));
        }
        //Update CashMovementsInstantMoney
        [GridAction]
        public ActionResult _UpdateCashMovementInstantMoney(CashMovementInstantMoney ins)
        {
            CashMovement z = new CashMovement();
            //...Update Object
            z.ActualDate = ins.ActualDate;
            z.Amount = ins.Amount;
            z.CashMovementID = ins.CashMovementID;
            z.MoneyUnitID = 0;
            z.CashTypeID = 1;// For Cards

            CashMovement ins2 = CMRep.Update(z);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovement()));
        }
        //Remove CashMovementsInstantMoney
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveCashMovementInstantMoney(int id)
        {
            //...Update Object
            string ins = CMRep.GetCashMovement(id).ToString();
            CMRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovement()));
        }






        //Cheques InstantMoney
        [GridAction]
        public ActionResult _ListCashMovementInstantMoneyC()
        {
            return View(new GridModel(CMRep.GetAllCashMovementC()));
        }
        // Cheques InstantMoney
        public ActionResult CashMovementInstantMoneyC()
        {
            ViewData["CashType"] = DDRep.GetCashTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            return View();
        }

        //Add Cheques InstantMoney
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertCashMovementInstantMoneyC(CashMovementInstantMoney ins)
        {
            CashMovement z = new CashMovement();

            z.ActualDate = ins.ActualDate;
            z.Amount = ins.Amount;
            z.CashMovementID = ins.CashMovementID;
            z.MoneyUnitID = 0;
            z.MovementTypeID = 2;//For cheques

            CashMovement ins2 = CMRep.Insert(z);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovementC()));
        }
        //Update Cheques InstantMoney
        [GridAction]
        public ActionResult _UpdateCashMovementInstantMoneyC(CashMovementInstantMoney ins)
        {
            CashMovement z = new CashMovement();
            //...Update Object
            z.ActualDate = ins.ActualDate;
            z.Amount = ins.Amount;
            z.CashMovementID = ins.CashMovementID;
            z.MoneyUnitID = 0;
            z.CashTypeID = 2;//For cheques

            CashMovement ins2 = CMRep.Update(z);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovementC()));
        }
        //Remove Cheques InstantMoney
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveCashMovementInstantMoneyC(int id)
        {
            //...Update Object
            string ins = CMRep.GetCashMovement(id).ToString();
            CMRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovementC()));
        }


        //Pick Ups InstantMoney

        [GridAction]
        public ActionResult _ListPickUpInstantMoney()
        {
            return View(new GridModel(PRep.GetAllPickUp()));
        }

        // PickUps kwikpay
        public ActionResult PickUpInstantMoney()
        {
            ViewData["CashType"] = DDRep.GetCashTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            return View();
        }

        //Add PickUps InstantMoney
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertPickUpInstantMoney(PickUp ins)
        {
            //...Insert Object
            ins.CashTypeID = 1;//Change to 


            PickUp ins2 = PRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(PRep.GetAllPickUp()));
        }
        //Update PickUps InstantMoney
        [GridAction]
        public ActionResult _UpdatePickUpInstantMoney(PickUp ins)
        {
            //...Update Object
            PickUp ins2 = PRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(PRep.GetAllPickUp()));
        }
        //Remove PickUps InstantMoney
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemovePickUpInstantMoney(int id)
        {
            //...Update Object
            string ins = PRep.GetPickUp(id).ToString();
            PRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(PRep.GetAllPickUp()));
        }

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


















        //Functions
        [GridAction]
        public ActionResult _ListCashMovementFNB()
        {
            return View(new GridModel(CMRep.GetAllCashMovement()));
        }
        // Cashmovements
        public ActionResult CashMovementFNB()
        {
            ViewData["CashType"] = DDRep.GetCashTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            return View();
        }

        //Add CashMovementsInstantMoney
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertCashMovementFNB(CashMovementFNB ins)
        {
            CashMovement z = new CashMovement();

            z.ActualDate = ins.ActualDate;
            z.Amount = ins.Amount;
            z.CashMovementID = ins.CashMovementID;
            z.MoneyUnitID = 0;
            z.MovementTypeID = 1;//For Cards

            CashMovement ins2 = CMRep.Insert(z);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovement()));
        }
        //Update CashMovementsInstantMoney
        [GridAction]
        public ActionResult _UpdateCashMovementFNB(CashMovementFNB ins)
        {
            CashMovement z = new CashMovement();
            //...Update Object
            z.ActualDate = ins.ActualDate;
            z.Amount = ins.Amount;
            z.CashMovementID = ins.CashMovementID;
            z.MoneyUnitID = 0;
            z.CashTypeID = 1;// For Cards

            CashMovement ins2 = CMRep.Update(z);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovement()));
        }
        //Remove CashMovementsInstantMoney
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveCashMovementFNB(int id)
        {
            //...Update Object
            string ins = CMRep.GetCashMovement(id).ToString();
            CMRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovement()));
        }






        //Cheques InstantMoney
        [GridAction]
        public ActionResult _ListCashMovementFNBC()
        {
            return View(new GridModel(CMRep.GetAllCashMovementC()));
        }
        // Cheques InstantMoney
        public ActionResult CashMovementFNBC()
        {
            ViewData["CashType"] = DDRep.GetCashTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            return View();
        }

        //Add Cheques InstantMoney
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertCashMovementFNBC(CashMovementFNB ins)
        {
            CashMovement z = new CashMovement();

            z.ActualDate = ins.ActualDate;
            z.Amount = ins.Amount;
            z.CashMovementID = ins.CashMovementID;
            z.MoneyUnitID = 0;
            z.CashTypeID = 2;//For cheques

            CashMovement ins2 = CMRep.Insert(z);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovementC()));
        }
        //Update Cheques InstantMoney
        [GridAction]
        public ActionResult _UpdateCashMovementFNBC(CashMovementFNB ins)
        {
            CashMovement z = new CashMovement();
            //...Update Object
            z.ActualDate = ins.ActualDate;
            z.Amount = ins.Amount;
            z.CashMovementID = ins.CashMovementID;
            z.MoneyUnitID = 0;
            z.MovementTypeID = 2;//For cheques

            CashMovement ins2 = CMRep.Update(z);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovementC()));
        }
        //Remove Cheques InstantMoney
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveCashMovementFNBC(int id)
        {
            //...Update Object
            string ins = CMRep.GetCashMovement(id).ToString();
            CMRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(CMRep.GetAllCashMovementC()));
        }


        //Pick Ups InstantMoney

        [GridAction]
        public ActionResult _ListPickUpFNB()
        {
            return View(new GridModel(PRep.GetAllPickUp()));
        }

        // PickUps kwikpay
        public ActionResult PickUpFNB()
        {
            ViewData["CashType"] = DDRep.GetCashTypeList();
            ViewData["MoneyUnit"] = DDRep.GetMoneyUnitList();
            return View();
        }

        //Add PickUps InstantMoney
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertPickUpFNB(FormCollection ins)
        {
            //...Insert Object
            //ins.CashTypeID = 1;//Change to 


            //PickUp ins2 = PRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(PRep.GetAllPickUp()));
        }
        //Update PickUps InstantMoney
        [GridAction]
        public ActionResult _UpdatePickUpFNB(PickUp ins)
        {
            //...Update Object
            PickUp ins2 = PRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(PRep.GetAllPickUp()));
        }
        //Remove PickUps InstantMoney
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemovePickUpFNB(int id)
        {
            //...Update Object
            string ins = PRep.GetPickUp(id).ToString();
            PRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(PRep.GetAllPickUp()));
        }

        [GridAction]
        public ActionResult _ListFNBs()
        {
            return View(new GridModel(FNBRep.GetAllFNB()));
        }


        //Functions


        // CashBox 
        public ActionResult FNBs()
        {
            ViewData["FNBType"] = DDRep.GetFNBType();
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
    }*/
    }
}

﻿using System;
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
    public class MaintenanceController : Controller
    {
            //
            // GET: /Maintenance/

            //Repository
        CashTypeRepository CashRep = new CashTypeRepository();
        CommentTypeRepository CommentRep = new CommentTypeRepository();
        GRVTypeRepository GRVRep = new GRVTypeRepository();
        InstantMoneyTypeRepository InstantMoneyRep = new InstantMoneyTypeRepository();
        KwikPayTypeRepository KwikPayRep = new KwikPayTypeRepository();
        MoneyUnitRepository MoneyUnitRep = new MoneyUnitRepository();
        MovementTypeRepository MovementRep = new MovementTypeRepository();
        UserTypeRepository UserRep = new UserTypeRepository();


            //Lists
                //List Cash Types
        [GridAction]
        public ActionResult _ListCashTypes()
        {
            return View(new GridModel(CashRep.GetAllCashType()));
        }

                //List Comment Types
        [GridAction]
        public ActionResult _ListCommentTypes()
        {
            return View(new GridModel(CommentRep.GetAllCommentType()));
        }

                //List GRV Types
        [GridAction]
        public ActionResult _ListGRVTypes()
        {
            return View(new GridModel(GRVRep.GetAllGRVType()));
        }

                //List Instant Money Types
        [GridAction]
        public ActionResult _ListInstantMoneyTypes()
        {
            return View(new GridModel(InstantMoneyRep.GetAllInstantMoneyType()));
        }

                //List Instant Money Types
        [GridAction]
        public ActionResult _ListKwikPayTypes()
        {
            return View(new GridModel(KwikPayRep.GetAllKwikPayType()));
        }

                //List MoneyUnit
        [GridAction]
        public ActionResult _ListMoneyUnits()
        {
            return View(new GridModel(MoneyUnitRep.GetAllMoneyUnit()));
        }

                //List MoneyUnit
        [GridAction]
        public ActionResult _ListMovementTypes()
        {
            return View(new GridModel(MovementRep.GetAllMovementType()));
        }
                //List UserType
        [GridAction]
        public ActionResult _ListUserTypes()
        {
            return View(new GridModel(UserRep.GetAllUserType()));
        }

        //Functions
            // CashType 
        public ActionResult CashTypes()
        { 
            return View();
        }
    
            //Add Cash Type
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertCashTypes(CashType ins)
        {
                //...Insert Object
            CashType ins2 = CashRep.Insert(ins);

                //...Repopulate Grid...
            return View(new GridModel(CashRep.GetAllCashType()));
        }
            //Update Cash Type
        [GridAction]
        public ActionResult _UpdateCashTypes(CashType ins)
        {
                //...Update Object
            CashType ins2 = CashRep.Update(ins);

                //...Repopulate Grid...
            return View(new GridModel(CashRep.GetAllCashType()));
        }
            //Remove CashType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveCashTypes(int id)
        {
                //...Update Object
            string ins = CashRep.GetCashType(id).ToString();
           CashRep.Remove(ins);

                //...Repopulate Grid...
           return View(new GridModel(CashRep.GetAllCashType()));
        }



            // CommentType 
        public ActionResult CommentTypes()
        {
            return View();
        }

            //Add CommentType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertCommentTypes(CommentType ins)
        {
                //...Insert Object
            CommentType ins2 = CommentRep.Insert(ins);

                //...Repopulate Grid...
            return View(new GridModel(CommentRep.GetAllCommentType()));
        }
            //Update CommentType
        [GridAction]
        public ActionResult _UpdateCommentTypes(CommentType ins)
        {
                //...Update Object
            CommentType ins2 = CommentRep.Update(ins);

                //...Repopulate Grid...
            return View(new GridModel(CommentRep.GetAllCommentType()));
        }
            //Remove CommentType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveCommentTypes(int id)
        {
                //...Update Object
            string ins = CommentRep.GetCommentType(id).ToString();
            CommentRep.Remove(ins);

                //...Repopulate Grid...
            return View(new GridModel(CommentRep.GetAllCommentType()));
        }


            // GRVType 
        public ActionResult GRVTypes()
        {
            return View();
        }

            //Add CommentType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertGRVTypes(GRVType ins)
        {
                //...Insert Object
            GRVType ins2 = GRVRep.Insert(ins);

                //...Repopulate Grid...
            return View(new GridModel(GRVRep.GetAllGRVType()));
        }
            //Update CommentType
        [GridAction]
        public ActionResult _UpdateGRVTypes(GRVType ins)
        {
                //...Update Object
            GRVType ins2 = GRVRep.Update(ins);

                //...Repopulate Grid...
            return View(new GridModel(GRVRep.GetAllGRVType()));
        }
            //Remove CommentType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveGRVTypes(int id)
        {
                //...Update Object
            string ins = GRVRep.GetGRVType(id).ToString();
            GRVRep.Remove(ins);

                //...Repopulate Grid...
            return View(new GridModel(GRVRep.GetAllGRVType()));
        }



            // InstantMoneyType 
        public ActionResult InstantMoneyTypes()
        {
            return View();
        }

        //Add InstantMoneyType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertInstantMoneyTypes(InstantMoneyType ins)
        {
                //...Insert Object
            InstantMoneyType ins2 = InstantMoneyRep.Insert(ins);

                //...Repopulate Grid...
            return View(new GridModel(InstantMoneyRep.GetAllInstantMoneyType()));
        }
        //Update InstantMoneyType
        [GridAction]
        public ActionResult _UpdateInstantMoneyTypes(InstantMoneyType ins)
        {
                //...Update Object
            InstantMoneyType ins2 = InstantMoneyRep.Update(ins);

                //...Repopulate Grid...
            return View(new GridModel(InstantMoneyRep.GetAllInstantMoneyType()));
        }
        //Remove InstantMoneyType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveInstantMoneyTypes(int id)
        {
                //...Update Object
            string ins = InstantMoneyRep.GetInstantMoneyType(id).ToString();
            InstantMoneyRep.Remove(ins);

                //...Repopulate Grid...
            return View(new GridModel(InstantMoneyRep.GetAllInstantMoneyType()));
        }


        // KwikPayType 
        public ActionResult KwikPayTypes()
        {
            return View();
        }

        //Add KwikPayType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertKwikPayTypes(KwikPayType ins)
        {
            //...Insert Object
            KwikPayType ins2 = KwikPayRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(KwikPayRep.GetAllKwikPayType()));
        }
        //Update KwikPayType
        [GridAction]
        public ActionResult _UpdateKwikPayTypes(KwikPayType ins)
        {
            //...Update Object
            KwikPayType ins2 = KwikPayRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(KwikPayRep.GetAllKwikPayType()));
        }
        //Remove KwikPayType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveKwikPayTypes(int id)
        {
            //...Update Object
            string ins = KwikPayRep.GetKwikPayType(id).ToString();
            KwikPayRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(KwikPayRep.GetAllKwikPayType()));
        }


        // MoneyUnit 
        public ActionResult MoneyUnits()
        {
            return View();
        }

        //Add MoneyUnit
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertMoneyUnits(MoneyUnit ins)
        {
            //...Insert Object
            MoneyUnit ins2 = MoneyUnitRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(MoneyUnitRep.GetAllMoneyUnit()));
        }
        //Update MoneyUnit
        [GridAction]
        public ActionResult _UpdateMoneyUnits(MoneyUnit ins)
        {
            //...Update Object
            MoneyUnit ins2 = MoneyUnitRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(MoneyUnitRep.GetAllMoneyUnit()));
        }
        //Remove MoneyUnit
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveMoneyUnits(int id)
        {
            //...Update Object
            string ins = MoneyUnitRep.GetMoneyUnit(id).ToString();
            MoneyUnitRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(MoneyUnitRep.GetAllMoneyUnit()));
        }

        // MovementType 
        public ActionResult MovementTypes()
        {
            return View();
        }

        //Add MovementType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertMovementTypes(MovementType ins)
        {
            //...Insert Object
            MovementType ins2 = MovementRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(MovementRep.GetAllMovementType()));
        }
        //Update MovementType
        [GridAction]
        public ActionResult _UpdateMovementTypes(MovementType ins)
        {
            //...Update Object
            MovementType ins2 = MovementRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(MovementRep.GetAllMovementType()));
        }
        //Remove MovementType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveMovementTypes(int id)
        {
            //...Update Object
            string ins = MovementRep.GetMovementType(id).ToString();
            MovementRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(MovementRep.GetAllMovementType()));
        }

        // UserType 
        public ActionResult UserTypes()
        {
            return View();
        }

        //Add MovementType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertUserTypes(UserType ins)
        {
            //...Insert Object
            UserType ins2 = UserRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(UserRep.GetAllUserType()));
        }
        //Update MovementType
        [GridAction]
        public ActionResult _UpdateUserTypes(UserType ins)
        {
            //...Update Object
            UserType ins2 = UserRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(UserRep.GetAllUserType()));
        }
        //Remove MovementType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveUserTypes(int id)
        {
            //...Update Object
            string ins = UserRep.GetUserType(id).ToString();
            UserRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(UserRep.GetAllUserType()));
        }
    }
}
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
    public class SupplierController : Controller
    {
        //
        // GET: /Supplier/

        //Repository
        SupplierTypeRepository SupplierTRep = new SupplierTypeRepository();
        SupplierRepository SupplierRep = new SupplierRepository();
        DropDownRepository DDRep = new DropDownRepository();

        //List
            // List SupplierType
        [GridAction]
        public ActionResult _ListSupplierTypes()
        {
            return View(new GridModel(SupplierTRep.GetAllSupplierType()));
        }
            //List Supplier
        [GridAction]
        public ActionResult _ListSuppliers()
        {
            return View(new GridModel(SupplierRep.GetAllSupplier()));
        }

        //Functions
        // SupplierType 
        public ActionResult SupplierTypes()
        {
            return View();
        }

        //Add SupplierType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertSupplierTypes(SupplierType ins)
        {
            //...Insert Object
            SupplierType ins2 = SupplierTRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(SupplierTRep.GetAllSupplierType()));
        }
        //Update SupplierType
        [GridAction]
        public ActionResult _UpdateSupplierTypes(SupplierType ins)
        {
            //...Update Object
            SupplierType ins2 = SupplierTRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(SupplierTRep.GetAllSupplierType()));
        }
        //Remove SupplierType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveSupplierTypes(int id)
        {
            //...Update Object
            string ins = SupplierTRep.GetSupplierType(id).ToString();
            SupplierTRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(SupplierTRep.GetAllSupplierType()));
        }


        // Supplier 
        public ActionResult Suppliers()
        {
            ViewData["SupplierType"] = DDRep.GetSupplierTypeList();            
            return View();
        }

        //Add SupplierType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertSupplier(Supplier ins)
        {
            //...Insert Object
            Supplier ins2 = SupplierRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(SupplierRep.GetAllSupplier()));
        }
        //Update SupplierType
        [GridAction]
        public JsonResult _UpdateSupplier(Supplier ins)
        {
            //...Update Object
            Supplier ins2 = SupplierRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(SupplierRep.GetAllSupplier()));
        }
        //Remove SupplierType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _RemoveSupplier(int id)
        {
            //...Update Object
            SupplierRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(SupplierRep.GetAllSupplier()));
        }
    }
}

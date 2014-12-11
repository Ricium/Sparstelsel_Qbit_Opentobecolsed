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
    public class FillerController : Controller
    {
        SupplierTypeRepository SupplierTRep = new SupplierTypeRepository();
        SupplierRepository SupplierRep = new SupplierRepository();
        DropDownRepository DDRep = new DropDownRepository();

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

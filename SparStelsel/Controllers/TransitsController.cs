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
    public class TransitsController : Controller
    {
        //
        // GET: /Transit/
        //Repository
        TransitRepository TRep = new TransitRepository();
        //List
        [GridAction]
        public ActionResult _ListTransits()
        {
            return View(new GridModel(TRep.GetAllTransit()));
        }


        //Functions
        public ActionResult Transits()
        {

            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertTransits(Transit ins)
        {
            //...Insert Object
            Transit ins2 = TRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(TRep.GetAllTransit()));
        }
        //Update SupplierType
        [GridAction]
        public ActionResult _UpdateTransits(Transit ins)
        {
            //...Update Object
            Transit ins2 = TRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(TRep.GetAllTransit()));
        }
        //Remove SupplierType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveTransits(int id)
        {
            //...Update Object
            string ins = TRep.GetTransit(id).ToString();
            TRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(TRep.GetAllTransit()));
        }

    }
}

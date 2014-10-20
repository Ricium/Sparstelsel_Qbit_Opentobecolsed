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
    public class GRVController : Controller
    {
        //
        // GET: /GRV/

        //Repository
        GRVListRepository GRVRep = new GRVListRepository();
        DropDownRepository DDRep = new DropDownRepository();

        //Lists
        [GridAction]
        public ActionResult _ListGRVLists()
        {
            return View(new GridModel(GRVRep.GetAllGRVList()));
        }

     
        //Functions
        public ActionResult GRVLists()
        {
            ViewData["SupplierType"] = DDRep.GetSupplierTypeList();
            ViewData["SupplierID"] = DDRep.GetSupplierList();
            ViewData["GRVType"] = DDRep.GetGRVTypeList();
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertGRVLists(GRVList ins)
        {
            //...Insert Object
            GRVList ins2 = GRVRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(GRVRep.GetAllGRVList()));
        }
        //Update SupplierType
        [GridAction]
        public ActionResult _UpdateGRVLists(GRVList ins)
        {
            //...Update Object
            GRVList ins2 = GRVRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(GRVRep.GetAllGRVList()));
        }
        //Remove SupplierType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveGRVLists(int id)
        {
            //...Update Object
            string ins = GRVRep.GetGRVList(id).ToString();
            GRVRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(GRVRep.GetAllGRVList()));
        }
    }
}

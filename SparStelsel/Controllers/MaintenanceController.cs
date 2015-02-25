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
    public class MaintenanceController : Controller
    {
            //
            // GET: /Maintenance/

            //Repository
        CashTypeRepository CashRep = new CashTypeRepository();
        CommentRepository CRep = new CommentRepository();

            //Lists
                //List Cash Types
        [GridAction]
        public ActionResult _ListCashTypes()
        {
            return View(new GridModel(CashRep.GetAllCashType()));
        }

        [GridAction]
        public ActionResult _ListComment()
        {
            return View(new GridModel(CRep.GetAllComment()));
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
        public JsonResult _InsertCashTypes(CashType ins)
        {
                //...Insert Object
            CashType ins2 = CashRep.Insert(ins);

                //...Repopulate Grid...
            return Json(new GridModel(CashRep.GetAllCashType()));
        }
            //Update Cash Type
        [GridAction]
        public JsonResult _UpdateCashTypes(CashType ins)
        {
                //...Update Object
            CashType ins2 = CashRep.Update(ins);

                //...Repopulate Grid...
            return Json(new GridModel(CashRep.GetAllCashType()));
        }
            //Remove CashType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveCashTypes(int id)
        {
                //...Update Object
           CashRep.Remove(id);

                //...Repopulate Grid...
           return View(new GridModel(CashRep.GetAllCashType()));
        }

        // Comment 
        public ActionResult Comment()
        {
            return View();
        }
        //Add Comment
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertComment(Comment ins)
        {
            //...Insert Object
            ins.CommentTypeID = 0;
            Comment ins2 = CRep.Insert(ins);
           
            //...Repopulate Grid...
            return Json(new GridModel(CRep.GetAllComment()));
        }
        //Update Comment
        [GridAction]
        public JsonResult _UpdateComment(Comment ins)
        {
            //...Update Object
            ins.CommentTypeID = 0;
            Comment ins2 = CRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(CRep.GetAllComment()));
        }
        //Remove Comment
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveComment(int id)
        {
            //...Update Object
 
            CRep.Remove(id);

            //...Repopulate Grid...
            return View(new GridModel(CRep.GetAllComment()));
        }
    }
}

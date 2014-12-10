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
    public class OrdersController : Controller
    {
        //
        // GET: /Orders/
        //Repository
        OrderRepository ORep = new OrderRepository();
        DropDownRepository DDRep = new DropDownRepository();
        SupplierRepository SRep = new SupplierRepository();
        //List
        // List SupplierType
        [GridAction]
        public ActionResult _ListOrders(string Pink = "")
        {
            return View(new GridModel(ORep.GetAllOrder(Pink)));
        }


        //Functions


        // CashBox 
        public ActionResult Orders()
        {
            ViewData["Supllier"] = DDRep.GetSupplierList();
            ViewData["Comments"] = DDRep.GetCommentList();
           
            return View();
        }

        //Add CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertOrders(Order ins)
        {
            //...Insert Object
            Order ins2 = ORep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ORep.GetAllOrder()));
        }
        //Update CashBox
        [GridAction]
        public JsonResult _UpdateOrders(Order ins)
        {
            //...Update Object
            Order ins2 = ORep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ORep.GetAllOrder()));
        }
        //Remove CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveOrders(int id)
        {
            ORep.Remove(id);

            //...Repopulate Grid...
            return View(new GridModel(ORep.GetAllOrder()));
        }
    }
}

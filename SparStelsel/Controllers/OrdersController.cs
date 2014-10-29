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

        //List
        // List SupplierType
        [GridAction]
        public ActionResult _ListOrders()
        {
            return View(new GridModel(ORep.GetAllOrder()));
        }


        //Functions


        // CashBox 
        public ActionResult Orders()
        {
            ViewData["Supllier"] = DDRep.GetSupplierList();
            ViewData["SupllierType"] = DDRep.GetSupplierTypeList();
           
            return View();
        }

        //Add CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertOrders(Order ins)
        {
            //...Insert Object
            Order ins2 = ORep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(ORep.GetAllOrder()));
        }
        //Update CashBox
        [GridAction]
        public ActionResult _UpdateOrders(Order ins)
        {
            //...Update Object
            Order ins2 = ORep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(ORep.GetAllOrder()));
        }
        //Remove CashBox
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveOrders(int id)
        {
            //...Update Object
            string ins = ORep.GetOrders(id).ToString();
            ORep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(ORep.GetAllOrder()));
        }
    }
}

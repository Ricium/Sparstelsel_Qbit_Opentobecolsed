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
    public class ProductsController : Controller
    {
        #region Repositories
        ProductRepository ProdRep = new ProductRepository();
        DropDownRepository DDRep = new DropDownRepository();
        #endregion

        #region Ajax Calls
        [GridAction]
        public JsonResult _ListProducts()
        {
            return Json(new GridModel(ProdRep.GetAllProduct()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertProducts(Product ins)
        {
            //...Insert Object
            ins.Total = ins.BTW + ins.Price;
            Product ins2 = ProdRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ProdRep.GetAllProduct()));
        }

        [GridAction]
        public JsonResult _UpdateProducts(Product ins)
        {
            //...Update Object
            ins.Total = ins.BTW + ins.Price;
            Product ins2 = ProdRep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ProdRep.GetAllProduct()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _RemoveProducts(int id)
        {
            ProdRep.Remove(id);

            //...Repopulate Grid...
            return Json(new GridModel(ProdRep.GetAllProduct()));
        }

        #endregion

        public ActionResult Products()
        {
            ViewData["Supplier"] = DDRep.GetSupplierList();
            return View();
        }        
    }
}

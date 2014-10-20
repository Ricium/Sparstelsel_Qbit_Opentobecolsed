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
    public class ProductsController : Controller
    {
        //
        // GET: /Product/

        // Repository
        ProductRepository ProdRep = new ProductRepository();
        //List
            //ProductList
        [GridAction]
        public ActionResult _ListProducts()
        {
            return View(new GridModel(ProdRep.GetAllProduct()));
        }

        //Functions
        public ActionResult Products()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertProducts(Product ins)
        {
            //...Insert Object
            Product ins2 = ProdRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(ProdRep.GetAllProduct()));
        }
        //Update SupplierType
        [GridAction]
        public ActionResult _UpdateProducts(Product ins)
        {
            //...Update Object
            Product ins2 = ProdRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(ProdRep.GetAllProduct()));
        }
        //Remove SupplierType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveProducts(int id)
        {
            //...Update Object
            string ins = ProdRep.GetProduct(id).ToString();
            ProdRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(ProdRep.GetAllProduct()));
        }
    }
}

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
    public class OrdersController : Controller
    {
        //
        // GET: /Orders/
        //Repository
        OrderRepository ORep = new OrderRepository();
        DropDownRepository DDRep = new DropDownRepository();
        SupplierRepository SRep = new SupplierRepository();
        ReportRepository reportrepo = new ReportRepository();
        ProductRepository PRep = new ProductRepository();

        //List
        // List SupplierType
        [GridAction]
        public ActionResult _ListOrders(string Suffix = "", string Pink = "", string Supplier = "", string From = "", string To = "", string Comment = "")
        {
            return View(new GridModel(ORep.GetAllOrder(Suffix, Pink, Supplier, DDRep.TelerikDateToString(From), DDRep.TelerikDateToString(To), Comment)));
        }

        [HttpPost]
        public ActionResult _OrderGridExport(string Suffix = "", string Pink = "", string Supplier = "", string From = "", string To = "", string Comment = "")
        {
            List<Order> report = ORep.GetAllOrder(Suffix, Pink, Supplier, DDRep.TelerikDateToString(From), DDRep.TelerikDateToString(To), Comment);
            StringWriter sw = new StringWriter();
            sw.WriteLine("\"Pink Slip Number\",\"Order Date\",\"Expected Delivery Date\", \"Amount\", \"Supplier\", \"Comment\", \"Suffix\"");

            string name = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=Orders_" + name + ".csv");
            Response.ContentType = "text/csv";

            foreach (Order ex in report)
            {
                sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\"",
                                           ex.PinkSlipNumber.ToString()
                                           , ex.OrderDate.ToShortDateString()
                                           , ex.ExpectedDeliveryDate.ToString()
                                           , ex.Amount.ToString()
                                           , ex.supplier.ToString()
                                           , ex.ordercomment.ToString()
                                           , ex.Suffix.ToString()
                                          ));
            }

            Response.Write(sw.ToString());
            Response.End();

            return null;
        }


        public ActionResult Orders()
        {
            ViewData["SupllierWithAll"] = DDRep.GetSupplierListWithAll();
            ViewData["Supllier"] = DDRep.GetSupplierList();
            ViewData["CommentsWithAll"] = DDRep.GetCommentListWithAll();
            ViewData["Comments"] = DDRep.GetCommentList();
           
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertOrders(Order ins)
        {
            //...Insert Object
            if (ORep.GetOrder(ins.PinkSlipNumber).OrderID == 0)
            {
                Order ins2 = ORep.Insert(ins);
            }
                   

            //...Repopulate Grid...
            return Json(new GridModel(ORep.GetAllOrder()));
        }

        [GridAction]
        public JsonResult _UpdateOrders(Order ins)
        {
            //...Update Object
            Order ins2 = ORep.Update(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ORep.GetAllOrder()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveOrders(int id)
        {
            ORep.Remove(id);

            //...Repopulate Grid...
            return View(new GridModel(ORep.GetAllOrder()));
        }

        public ActionResult OrdervsGRVReport()
        {
            ViewData["Month"] = reportrepo.GetMonthNameSelectList();
            ViewData["Year"] = reportrepo.GetYearSelectList();
            return View(new DateTimeFromToQuery());
        }

        [HttpPost]
        public ActionResult GetOrdervsGRVReport(DateTimeFromToQuery ins)
        {

            List<OrdervsGRVReport> report = reportrepo.GetOrdervsGRVReport(ins);

            StringWriter sw = new StringWriter();
            sw.WriteLine("\"Day\",\"Date\",\"Order Total\",\"Friday Total\",\"GRV Total\",\"Friday Total\"");

            string name = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=OrdervsGRV_" + name + ".csv");
            Response.ContentType = "text/csv";

            foreach (OrdervsGRVReport ex in report)
            {
                sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\"",
                                           ex.Day
                                           , ex.Date
                                           , ex.OrderTotal
                                           , ex.FridayOrderTotal
                                           , ex.GRVTotal
                                           , ex.FridayGRVTotal));
            }

            //Response.ClearContent();
            //Response.AddHeader("content-disposition", "attachment;filename=MemberDetailReport_" + GroupName + "_" + name + ".zip");
            //Response.ContentType = "application/zip";

            Response.Write(sw.ToString());

            Response.End();

            return null;
        }

        #region Orders with Products
        [GridAction]
        public ActionResult _ListProductOrders(string Suffix = "", string Pink = "", string Supplier = "", string From = "", string To = "", string Comment = "")
        {
            return View(new GridModel(ORep.GetAllProductOrders(Suffix, Pink, Supplier, DDRep.TelerikDateToString(From), DDRep.TelerikDateToString(To), Comment)));
        }

        [GridAction]
        public ActionResult _ListProduct(int OrderId)
        {
            return View(new GridModel(ORep.GetOrderProductsPerOrder(OrderId)));
        }        

        public ActionResult ProductOrders()
        {
            ViewData["Supllier"] = DDRep.GetSupplierList();
            ViewData["Comments"] = DDRep.GetCommentList();
            return View();
        }

        public ActionResult _LoadOrder()
        {
            ViewData["Supllier"] = DDRep.GetSupplierList();
            ViewData["Comments"] = DDRep.GetCommentList();
            return PartialView(new Order());
        }

        [HttpPost]
        public ActionResult _InsertProductOrder(Order ins)
        {
            ins = ORep.Insert(ins);
            return RedirectToAction("ProductOrder", new { OrderId = ins.OrderID });
        }

        public ActionResult ProductOrder(int OrderId)
        {
            Order ins = ORep.GetOrders(OrderId);

            ViewData["Supllier"] = DDRep.GetSupplierList();
            ViewData["Comments"] = DDRep.GetCommentList();
            ViewData["OrderId"] = OrderId;
            ViewData["Products"] = DDRep.GetProductsList(ins.SupplierID);
            
            return View(ins);
        }

        public ActionResult _GetProductPrice(int ProductId)
        {
            return Content(PRep.GetProduct(ProductId).Total.ToString(), "text");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public JsonResult _InsertProduct(OrderProduct ins)
        {
            //...Insert Object
            ins.StatusID = false;
            ins = ORep.InsertOrderProduct(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ORep.GetOrderProductsPerOrder(ins.OrderID)));
        }

        [GridAction]
        public JsonResult _UpdateProduct(OrderProduct ins)
        {
            //...Update Object
            ins = ORep.UpdateOrderProduct(ins);

            //...Repopulate Grid...
            return Json(new GridModel(ORep.GetOrderProductsPerOrder(ins.OrderID)));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveProduct(int id)
        {
            OrderProduct ins = ORep.GetOrderProducts(id);
            ORep.RemoveOrderProduct(id);

            //...Repopulate Grid...
            return Json(new GridModel(ORep.GetOrderProductsPerOrder(ins.OrderID)));
        }

        [HttpPost]
        public ActionResult _ProcessProductOrder(Order ins)
        {
            List<OrderProduct> products = ORep.GetOrderProductsPerOrder(ins.OrderID);
            decimal total = 0;
            foreach(OrderProduct product in products)
            {
                total += (product.Price * product.Quantity);
            }

            ins.Amount = total;
            ins = ORep.Update(ins);
            ORep.ProcessProductOrder(ins.OrderID);

            return RedirectToAction("ProductOrders");

        }

        #endregion
    }
}

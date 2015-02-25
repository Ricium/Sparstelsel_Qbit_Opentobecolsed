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
using System.Text;

namespace SparStelsel.Controllers
{
    [AutoLogOffActionFilter]
    public class PaymentController : Controller
    {

        ProofOfPaymentRepository POPRep = new ProofOfPaymentRepository();
        DropDownRepository DDRep = new DropDownRepository();
        SupplierRepository SupRep = new SupplierRepository();

        [GridAction]
        public ActionResult _ListProofOfPayments()
        {
            return View(new GridModel(POPRep.GetAllProofOfPayment()));
        }

        public ActionResult ProofOfPayments()
        {
            ViewData["SupplierID"] = DDRep.GetSupplierList();
            ViewData["CashTypeID"] = DDRep.GetCashTypeList();
            //ViewData["Invoices"] = DDRep.GetAutoCompleteInvoiceNumbers();
            return View();
        }

        public ActionResult _CheckSupplierType(int SupplierId)
        {
            Supplier ins = SupRep.GetSupplier(SupplierId);
            return Content(ins.suppliertypeid2, "text/plain");
        }
        
        public ActionResult _GetInvoiceNumbers(int? SupplierId)
        {
            List<string> InvoiceNumbers = DDRep.GetAutoCompleteInvoiceNumbers((int)SupplierId);
            return new JsonResult { Data = (IEnumerable<String>)InvoiceNumbers };
        }

        public JsonResult _Insert(ProofOfPayment ins)
        {
            if(ins.InvoiceNumber != null)
            {
                //...Remove Supplier from Invoice Number
                List<string> suppliers = DDRep.GetSupplierNameList();
                SupplierInvoiceSplit split = POPRep.RemoveSupplierFormInvoiceNumber(ins.InvoiceNumber, suppliers);
                ins.InvoiceNumber = split.InvoiceNumber;
                ins.SupplierID = split.SupplierId.ToString();
            }     
            else
            {
                ins.InvoiceNumber = SupRep.GetSupplier(Convert.ToInt32(ins.SupplierID)).Suppliers + " Payment";
            }
            
            //...Insert Object
            ProofOfPayment ins2 = POPRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(POPRep.GetAllProofOfPayment()));
        }

        [GridAction]
        public ActionResult _UpdateProofOfPayments(ProofOfPayment ins)
        {
            if (ins.InvoiceNumber != null)
            {
                //...Remove Supplier from Invoice Number
                List<string> suppliers = DDRep.GetSupplierNameList();
                SupplierInvoiceSplit split = POPRep.RemoveSupplierFormInvoiceNumber(ins.InvoiceNumber, suppliers);
                ins.InvoiceNumber = split.InvoiceNumber;
                ins.SupplierID = split.SupplierId.ToString();
            }
            else
            {
                ins.InvoiceNumber = SupRep.GetSupplier(Convert.ToInt32(ins.SupplierID)).Suppliers + " Payment";
            }

            //...Update Object
            ProofOfPayment ins2 = POPRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(POPRep.GetAllProofOfPayment()));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveProofOfPayments(int id)
        {
            //...Update Object
            POPRep.Remove(id);

            //...Repopulate Grid...
            return View(new GridModel(POPRep.GetAllProofOfPayment()));
        }


    }
}

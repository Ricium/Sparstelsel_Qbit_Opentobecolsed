﻿using System;
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
    public class PaymentController : Controller
    {

        ProofOfPaymentRepository POPRep = new ProofOfPaymentRepository();
        DropDownRepository DDRep = new DropDownRepository();

        [GridAction]
        public ActionResult _ListProofOfPayments()
        {
            return View(new GridModel(POPRep.GetAllProofOfPayment()));
        }

        public ActionResult ProofOfPayments()
        {
            ViewData["SupplierID"] = DDRep.GetSupplierList();
            ViewData["CashTypeID"] = DDRep.GetCashTypeList();
            ViewData["Invoices"] = DDRep.GetAutoCompleteInvoiceNumbers();
            return View();
        }

        public JsonResult _Insert(ProofOfPayment ins)
        {
            //...Insert Object
            ProofOfPayment ins2 = POPRep.Insert(ins);

            //...Repopulate Grid...
            return Json(new GridModel(POPRep.GetAllProofOfPayment()));
        }

        [GridAction]
        public ActionResult _UpdateProofOfPayments(ProofOfPayment ins)
        {
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

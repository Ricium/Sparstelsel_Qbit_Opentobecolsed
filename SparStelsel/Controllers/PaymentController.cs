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
    public class PaymentController : Controller
    {
        //
        // GET: /Payment/

        //Repository
        ProofOfPaymentRepository POPRep = new ProofOfPaymentRepository();
        DropDownRepository DDRep = new DropDownRepository();
        //List
        [GridAction]
        public ActionResult _ListProofOfPayments()
        {
            return View(new GridModel(POPRep.GetAllProofOfPayment()));
        }

      
        //Functions
        public ActionResult ProofOfPayments()
        {
            ViewData["SupplierType"] = DDRep.GetSupplierTypeList();
            ViewData["SupplierID"] = DDRep.GetSupplierList();
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertProofOfPayments(ProofOfPayment ins)
        {
            //...Insert Object
            ProofOfPayment ins2 = POPRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(POPRep.GetAllProofOfPayment()));
        }
        //Update SupplierType
        [GridAction]
        public ActionResult _UpdateProofOfPayments(ProofOfPayment ins)
        {
            //...Update Object
            ProofOfPayment ins2 = POPRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(POPRep.GetAllProofOfPayment()));
        }
        //Remove SupplierType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveProofOfPayments(int id)
        {
            //...Update Object
            string ins = POPRep.GetProofOfPayment(id).ToString();
            POPRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(POPRep.GetAllProofOfPayment()));
        }

    }
}

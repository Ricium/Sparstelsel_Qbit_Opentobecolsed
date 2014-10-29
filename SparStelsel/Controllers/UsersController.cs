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
    public class UsersController : Controller
    {
        //
        // GET: /Users/

        //Repository
        UserRepository URep = new UserRepository();
        UserTypeRepository UTRep = new UserTypeRepository();
        DropDownRepository DDRep = new DropDownRepository();
        CommentRepository CRep = new CommentRepository();
        //List
        [GridAction]
        public ActionResult _ListUsers()
        {
            return View(new GridModel(URep.GetAllUser()));
        }
        [GridAction]
        public ActionResult _ListComments()
        {
            return View(new GridModel(CRep.GetAllComment()));
        }

        //Functions
        public ActionResult Users()
        {
            ViewData["UserType"] = DDRep.GetUserTypeList();
           
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertUsers(User ins)
        {
            //...Insert Object
            User ins2 = URep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(URep.GetAllUser()));
        }
        //Update SupplierType
        [GridAction]
        public ActionResult _UpdateUsers(User ins)
        {
            //...Update Object
            User ins2 = URep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(URep.GetAllUser()));
        }
        //Remove SupplierType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveUsers(int id)
        {
            //...Update Object
            string ins = URep.GetUser(id).ToString();
            URep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(URep.GetAllUser()));
        }

        public ActionResult Comments()
        {
            ViewData["CommentType"] = DDRep.GetCommentTypeList();

            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertComments(Comment ins)
        {
            //...Insert Object
            Comment ins2 = CRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(CRep.GetAllComment()));
        }
        //Update SupplierType
        [GridAction]
        public ActionResult _UpdateComments(Comment ins)
        {
            //...Update Object
            Comment ins2 = CRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(CRep.GetAllComment()));
        }
        //Remove SupplierType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveComments(int id)
        {
            //...Update Object
            string ins = CRep.GetComment(id).ToString();
            CRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(CRep.GetAllComment()));
        }
    }
}

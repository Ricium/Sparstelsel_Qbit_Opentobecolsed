using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SparStelsel.Models;
using Telerik.Web.Mvc;
using System.IO;
using Telerik.Web.Mvc.Extensions;
using System.Data.OleDb;
using System.Text;
using System.Data;

namespace SparStelsel.Controllers
{
    public class GRVController : Controller
    {
        //
        // GET: /GRV/

        //Repository
        GRVListRepository GRVRep = new GRVListRepository();
        DropDownRepository DDRep = new DropDownRepository();

        //Lists
        [GridAction]
        public ActionResult _ListGRVLists()
        {
            return View(new GridModel(GRVRep.GetAllGRVList()));
        }

     
        //Functions
        public ActionResult GRVLists()
        {
            ViewData["SupplierType"] = DDRep.GetSupplierTypeList();
            ViewData["SupplierID"] = DDRep.GetSupplierList();
            ViewData["GRVType"] = DDRep.GetGRVTypeList();
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _InsertGRVLists(GRVList ins)
        {
            //...Insert Object
            GRVList ins2 = GRVRep.Insert(ins);

            //...Repopulate Grid...
            return View(new GridModel(GRVRep.GetAllGRVList()));
        }
        //Update SupplierType
        [GridAction]
        public ActionResult _UpdateGRVLists(GRVList ins)
        {
            //...Update Object
            GRVList ins2 = GRVRep.Update(ins);

            //...Repopulate Grid...
            return View(new GridModel(GRVRep.GetAllGRVList()));
        }
        //Remove SupplierType
        [AcceptVerbs(HttpVerbs.Post)]
        [GridAction]
        public ActionResult _RemoveGRVLists(int id)
        {
            //...Update Object
            string ins = GRVRep.GetGRVList(id).ToString();
            GRVRep.Remove(ins);

            //...Repopulate Grid...
            return View(new GridModel(GRVRep.GetAllGRVList()));
        }

        public ActionResult ImportGRVList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ImportFromExcel(FormCollection ins)
        {

            if (Request != null)
            {
                HttpPostedFileBase file = Request.Files["grv"];

                string extension = System.IO.Path.GetExtension(file.FileName);
                string path1 = string.Format("{0}/{1}", Server.MapPath("~/Includes/Files/"), Request.Files[0].FileName);
                if (System.IO.File.Exists(path1))
                    System.IO.File.Delete(path1);

                Request.Files[0].SaveAs(path1);

                //...Create connection string to Excel work book
                string excelConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path1 + ";Persist Security Info=False;Extended Properties=\"Excel 12.0;IMEX=1\"";

                //...Create Connection to Excel work book
                OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);

                //...Create OleDbCommand to fetch data from Excel
                OleDbCommand cmd = new OleDbCommand("Select * from [Sheet1$]", excelConnection);

                //...Open Connection to File...
                excelConnection.Open();
                OleDbDataReader dReader;
                dReader = cmd.ExecuteReader();

                //...Read-in Strings from file...
                StringBuilder values = new StringBuilder();

                //...Excel data...
                List<string> columns = new List<string>();
                List<List<string>> data = new List<List<string>>();

                //...Get Data...
                DataTable dataTable = new DataTable();
                dataTable.Load(dReader);

                //...Get Row Data....
                foreach (DataRow row in dataTable.Rows)
                {
                    var rowValue = row.ItemArray;
                    values.Clear();

                    List<string> rowData = new List<string>();

                    for (int i = 0; i < rowValue.Length; i++)
                    {
                        if (!rowValue[i].ToString().Trim().Equals(""))
                            rowData.Add(rowValue[i].ToString().Trim());
                        else
                            rowData.Add("");
                    }

                    data.Add(rowData);
                }

                //...Close File Connection...
                excelConnection.Close();

                //...Set Data to Model List
                List<GRVList> list = GRVRep.setData(data);

                //...Save List to Database...
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] = GRVRep.Insert(list[i]);
                }

                //...Display Imported Values
                return RedirectToAction("GRVLists");
            }

            return RedirectToAction("GRVLists");
            //return RedirectToAction("MemberImport");
        }
    }
}

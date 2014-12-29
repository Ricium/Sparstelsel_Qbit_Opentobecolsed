using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Web;
using System.Web.Security;
using System.Globalization;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SparStelsel.Models
{
    public class DropDownRepository
    {
        public List<SelectListItem> GetSupplierTypeList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT * FROM l_SupplierType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["SupplierType"].ToString();
                    result.Value = drI["SupplierTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetProductsList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT ProductID,Product FROM t_Product", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["Product"].ToString();
                    result.Value = drI["ProductID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetSupplierList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();

        
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT SupplierID,Supplier FROM t_Supplier WHERE Removed=0 ORDER BY Supplier", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["Supplier"].ToString();
                    result.Value = drI["SupplierID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetSupplierListWithAll()
        {
            List<SelectListItem> obj = new List<SelectListItem>();
            SelectListItem all = new SelectListItem();
            all.Selected = true;
            all.Value = "";
            all.Text = "All";
            obj.Add(all);


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT SupplierID,Supplier FROM t_Supplier WHERE Removed=0 ORDER BY Supplier", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["Supplier"].ToString();
                    result.Value = drI["SupplierID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetSupplierListWithSpecialAll()
        {
            List<SelectListItem> obj = new List<SelectListItem>();
            SelectListItem all = new SelectListItem();
            all.Selected = true;
            all.Value = "%";
            all.Text = "All";
            obj.Add(all);


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT SupplierID,Supplier FROM t_Supplier WHERE Removed=0 ORDER BY Supplier", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["Supplier"].ToString();
                    result.Value = drI["SupplierID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetDISupplierList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT SupplierID,Supplier FROM t_Supplier s inner join l_SupplierType t on s.SupplierTypeID = t.SupplierTypeID and t.SupplierType = 'DI' WHERE s.Removed = 0 ORDER BY Supplier", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["Supplier"].ToString();
                    result.Value = drI["SupplierID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetCashTypeList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT CashTypeID,CashType FROM l_CashType where Removed=0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["CashType"].ToString();
                    result.Value = drI["CashTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetCashTypeListWithSpecialAll()
        {
            List<SelectListItem> obj = new List<SelectListItem>();
            SelectListItem all = new SelectListItem();
            all.Selected = true;
            all.Value = "%";
            all.Text = "All";
            obj.Add(all);

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT CashTypeID,CashType FROM l_CashType where Removed=0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["CashType"].ToString();
                    result.Value = drI["CashTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        /*public List<SelectListItem> GetSupplierListAddedAll()
        {
            List<SelectListItem> obj = new List<SelectListItem>();
            SelectListItem all = new SelectListItem();
            all.Selected = true;
            all.Text = "All";
            all.Value = "";

            obj.Add(all);

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT SupplierID,Supplier FROM t_Supplier", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["Supplier"].ToString();
                    result.Value = drI["SupplierID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }*/

        public List<SelectListItem> GetGRVTypeList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT GRVTypeID,GRVType FROM l_GRVType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["GRVType"].ToString();
                    result.Value = drI["GRVTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }
        public List<SelectListItem> GetUserTypeList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT UserTypeID,UserType FROM l_UserType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["UserType"].ToString();
                    result.Value = drI["UserTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }



        public List<SelectListItem> GetCashTypeList1()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT CashTypeID,CashType FROM l_CashType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["CashType"].ToString();
                    result.Value = drI["CashTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }
        public List<SelectListItem> GetMoneyUnitList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT MoneyUnitID,MoneyUnit FROM l_MoneyUnit", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["MoneyUnit"].ToString();
                    result.Value = drI["MoneyUnitID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetCommentList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT * FROM t_Comment WHERE Removed=0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["Comment"].ToString();
                    result.Value = drI["CommentID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetCommentListWithAll()
        {
            List<SelectListItem> obj = new List<SelectListItem>();
            SelectListItem all = new SelectListItem();
            all.Selected = true;
            all.Value = "";
            all.Text = "All";
            obj.Add(all);


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT * FROM t_Comment WHERE Removed=0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["Comment"].ToString();
                    result.Value = drI["CommentID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetCommentTypeList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT * FROM l_CommentType where Removed=0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["CommentType"].ToString();
                    result.Value = drI["CommentTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetElectronicFundTypeList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT ElectronicTypeID,ElectronicType FROM l_ElectronicType where Removed=0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["ElectronicType"].ToString();
                    result.Value = drI["ElectronicTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetCashReconList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT ReconciliationTypeID,Reconciliation FROM l_ReconciliationType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["Reconciliation"].ToString();
                    result.Value = drI["ReconciliationTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }


        public List<SelectListItem> GetEmployeeList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();

            string[] roles = Roles.GetRolesForUser(HttpContext.Current.Session["Username"].ToString());          

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            if (roles.Contains("admin") || roles.Contains("cashadmin"))
            {
                cmdI = new SqlCommand("SELECT EmployeeID,Name FROM Employee where Removed=0", con);
            }
            else
            {
                cmdI = new SqlCommand("SELECT EmployeeID,Name FROM Employee where Removed=0 and ModifiedBy='" + HttpContext.Current.Session["Username"].ToString()+"'", con);
            }

            
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["Name"].ToString();
                    result.Value = drI["EmployeeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetMovementTypeList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT MovementTypeID,MovementType FROM l_MovementType where Removed=0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["MovementType"].ToString();
                    result.Value = drI["MovementTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetFNBType()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT FNBTypeID,FNBType FROM l_FNBType where Removed=0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["FNBType"].ToString();
                    result.Value = drI["FNBTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }


        public List<SelectListItem> GetInstantMoneyType()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT InstantMoneyTypeID,InstantMoneyType FROM l_InstantMoneyType where Removed=0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["InstantMoneyType"].ToString();
                    result.Value = drI["InstantMoneyTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetKwikPayType()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT KwikPayTypeID,KwikPayType FROM l_KwikPayType where Removed=0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["KwikPayType"].ToString();
                    result.Value = drI["KwikPayTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetCompanyList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT * FROM Company WHERE CompanyId IN ("+HttpContext.Current.Session["Companies"].ToString()+")", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["CompanyName"].ToString();
                    result.Value = drI["CompanyID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetTransitType()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT * FROM l_TransitType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["TransitType"].ToString();
                    result.Value = drI["TransitTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetCashboxType()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT * FROM l_CashboxType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["CashboxType"].ToString();
                    result.Value = drI["CashboxTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetCoinMovementType()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT * FROM l_CoinMovementType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["CoinMovementType"].ToString();
                    result.Value = drI["CoinMovementTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetCashOfficeType()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT * FROM l_CashOfficeType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["CashOfficeType"].ToString();
                    result.Value = drI["CashOfficeTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetCashOfficeStatusList()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            SelectListItem s = new SelectListItem();
            s.Text = "Sealed";
            s.Value = "1";

            SelectListItem o = new SelectListItem();
            o.Text = "Opened";
            o.Value = "2";

            SelectListItem n = new SelectListItem();
            n.Text = "N/A";
            n.Value = "3";

            list.Add(s);
            list.Add(o);
            list.Add(n);

            return list;
        }

        public string GetCashOfficeStatus(int stat)
        {
            switch (stat)
            {
                case 1: return "Sealed"; 
                case 2: return "Opened"; 
                case 3: return "N/A";
                default: return "N/A";
            }
        }

        public List<string> GetAutoCompleteInvoiceNumbers()
        {
            List<string> obj = new List<string>();

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("Select DISTINCT g.InvoiceNumber from t_GRVList g left join t_ProofOfPayment p "
                    + " on g.InvoiceNumber = p.InvoiceNumber where COALESCE(p.InvoiceNumber,0) = 0  and g.Removed=0 order by g.InvoiceNumber ", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    obj.Add(drI["InvoiceNumber"].ToString());
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public string TelerikDateToString(string teledate)
        {
            if (teledate.Equals("") || teledate.Equals("null"))
            {
                return "";
            }
            else
            {
                string Month = MMMtoMM(teledate.Substring(4, 3));
                string Day = teledate.Substring(8, 2);
                string Year = teledate.Substring(11, 4);
                return Year + "-" + Month + "-" + Day;
            }
        }

        public string MMMtoMM(string MMM)
        {
            string ret = "";
            switch (MMM)
            {
                case "Jan": ret = "01"; break;
                case "Feb": ret = "02"; break;
                case "Mar": ret = "03"; break;
                case "Apr": ret = "04"; break;
                case "May": ret = "05"; break;
                case "Jun": ret = "06"; break;
                case "Jul": ret = "07"; break;
                case "Aug": ret = "08"; break;
                case "Sep": ret = "09"; break;
                case "Oct": ret = "10"; break;
                case "Nov": ret = "11"; break;
                case "Dec": ret = "12"; break;
            }

            return ret;
        }
    }
}
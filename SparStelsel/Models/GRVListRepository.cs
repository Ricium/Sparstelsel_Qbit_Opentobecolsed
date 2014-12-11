using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class GRVListRepository
    {
        private SupplierRepository suprep = new SupplierRepository();

        public GRVList GetGRVList(int GRVListID)
        {
            //...Create New Instance of Object...
            GRVList ins = new GRVList();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM GRVList WHERE GRVListID =" + GRVListID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.GRVListID = Convert.ToInt32(drI["GRVListID"]);
                    ins.InvoiceNumber = Convert.ToString(drI["InvoiveNumber"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.Number = Convert.ToInt32(drI["Number"]);
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]);
                    ins.PinkSlipNumber = Convert.ToString(drI["PinkSlipNumber"]);
                    ins.GRVDate = Convert.ToDateTime(drI["GRVDate"]);
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["ExcludingVat"]);
                    ins.IncludingVat = Convert.ToDecimal(drI["IncludingVat"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.GRVTypeID = Convert.ToInt32(drI["GRVTypeID"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return ins;
        }

        public List<GRVList> GetAllGRVList()
        {
            //...Create New Instance of Object...
            List<GRVList> list = new List<GRVList>();
            GRVList ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_GRVList", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new GRVList();
                    ins.GRVListID = Convert.ToInt32(drI["GRVListID"]);
                    ins.InvoiceNumber = Convert.ToString(drI["InvoiceNumber"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.Number = Convert.ToInt32(drI["Number"]);
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]);
                    ins.PinkSlipNumber = Convert.ToString(drI["PinkSlipNumber"]);
                    ins.GRVDate = Convert.ToDateTime(drI["GRVDate"]);
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["ExcludingVat"]);
                    ins.IncludingVat = Convert.ToDecimal(drI["IncludingVat"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.GRVTypeID = Convert.ToInt32(drI["GRVTypeID"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<GRVList> GetAllGRVList(string InvoiceNumber, string PinkSlipNumber, string Supplier, string From, string To)
        {
            //...Create New Instance of Object...
            List<GRVList> list = new List<GRVList>();
            GRVList ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            if (From.Equals(""))
                From = "1900-01-01";

            if (To.Equals(""))
                To = "2100-01-01";

            //...SQL Commands...
            if (Supplier.Equals(""))
            {
                cmdI = new SqlCommand("SELECT G.*, S.Supplier FROM t_GRVList G INNER JOIN t_Supplier S ON G.SupplierID = S.SupplierID "
                            + "WHERE G.InvoiceNumber LIKE '%" + InvoiceNumber
                            + "' AND G.PinkSlipNumber LIKE '%" + PinkSlipNumber + "'"
                            + " AND G.GRVDate >= '" + From + "'"
                            + " AND G.GRVDate <= '" + To + "'", con);
            }
            else
            {
                cmdI = new SqlCommand("SELECT G.*, S.Supplier FROM t_GRVList G INNER JOIN t_Supplier S ON G.SupplierID = S.SupplierID "
                            + "WHERE G.InvoiceNumber LIKE '%" + InvoiceNumber
                            + "' AND G.PinkSlipNumber LIKE '%" + PinkSlipNumber + "'"
                            + " AND G.SupplierID =" + Supplier
                            + " AND G.GRVDate >= '" + From + "'"
                            + " AND G.GRVDate <= '" + To + "'", con);
            }
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();
            

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new GRVList();
                    ins.GRVListID = Convert.ToInt32(drI["GRVListID"]);
                    ins.InvoiceNumber = Convert.ToString(drI["InvoiceNumber"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.Number = Convert.ToInt32(drI["Number"]);
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]);
                    ins.PinkSlipNumber = Convert.ToString(drI["PinkSlipNumber"]);
                    ins.GRVDate = Convert.ToDateTime(drI["GRVDate"]);
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["ExcludingVat"]);
                    ins.IncludingVat = Convert.ToDecimal(drI["IncludingVat"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.GRVTypeID = Convert.ToInt32(drI["GRVTypeID"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.SupplierDetails = drI["Supplier"].ToString();
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<GRVListImport> GetAllGRVList(int BatchId)
        {
            //...Create New Instance of Object...
            List<GRVListImport> list = new List<GRVListImport>();
            GRVListImport ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM temp_GRVList WHERE BatchId=" + BatchId, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new GRVListImport();
                    ins.GRVListID = Convert.ToInt32(drI["GRVListID"]);
                    ins.InvoiceNumber = Convert.ToString(drI["InvoiceNumber"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.Number = Convert.ToInt32(drI["Number"]);
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]);
                    ins.PinkSlipNumber = Convert.ToString(drI["PinkSlipNumber"]);
                    ins.GRVDate = Convert.ToDateTime(drI["GRVDate"]);
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["ExcludingVat"]);
                    ins.IncludingVat = Convert.ToDecimal(drI["IncludingVat"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.GRVTypeID = Convert.ToInt32(drI["GRVTypeID"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.hasError = Convert.ToBoolean(drI["hasError"]);
                    ins.SupplierDetails = Convert.ToString(drI["SupplierDetails"]);
                    ins.Suppliers = ins.SupplierDetails;
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<GRVListImport> GetAllGRVList(bool check)
        {
            //...Create New Instance of Object...
            List<GRVListImport> list = new List<GRVListImport>();
            GRVListImport ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM temp_GRVList", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new GRVListImport();
                    ins.GRVListID = Convert.ToInt32(drI["GRVListID"]);
                    ins.InvoiceNumber = Convert.ToString(drI["InvoiceNumber"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.Number = Convert.ToInt32(drI["Number"]);
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]);
                    ins.PinkSlipNumber = Convert.ToString(drI["PinkSlipNumber"]);
                    ins.GRVDate = Convert.ToDateTime(drI["GRVDate"]);
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["ExcludingVat"]);
                    ins.IncludingVat = Convert.ToDecimal(drI["IncludingVat"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.GRVTypeID = Convert.ToInt32(drI["GRVTypeID"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.hasError = Convert.ToBoolean(drI["hasError"]);
                    ins.SupplierDetails = Convert.ToString(drI["SupplierDetails"]);
                    ins.Suppliers = ins.SupplierDetails;
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<GRVList> GetGRVListsPerGRVType(int GRVTypeID)
        {
            //...Create New Instance of Object...
            List<GRVList> list = new List<GRVList>();
            GRVList ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_GRVList WHERE GRVTypeID = " + GRVTypeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new GRVList();
                    ins.GRVListID = Convert.ToInt32(drI["GRVListID"]);
                    ins.InvoiceNumber = Convert.ToString(drI["InvoiveNumber"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.Number = Convert.ToInt32(drI["Number"]);
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]);
                    ins.PinkSlipNumber = Convert.ToString(drI["PinkSlipNumber"]);
                    ins.GRVDate = Convert.ToDateTime(drI["GRVDate"]);
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["ExcludingVat"]);
                    ins.IncludingVat = Convert.ToDecimal(drI["IncludingVat"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.GRVTypeID = Convert.ToInt32(drI["GRVTypeID"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<GRVList> GetGRVListsPerSupplier(int SupplierID)
        {
            //...Create New Instance of Object...
            List<GRVList> list = new List<GRVList>();
            GRVList ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_GRVList WHERE SupplierID = " + SupplierID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new GRVList();
                    ins.GRVListID = Convert.ToInt32(drI["GRVListID"]);
                    ins.InvoiceNumber = Convert.ToString(drI["InvoiveNumber"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.Number = Convert.ToInt32(drI["Number"]);
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]);
                    ins.PinkSlipNumber = Convert.ToString(drI["PinkSlipNumber"]);
                    ins.GRVDate = Convert.ToDateTime(drI["GRVDate"]);
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["ExcludingVat"]);
                    ins.IncludingVat = Convert.ToDecimal(drI["IncludingVat"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.GRVTypeID = Convert.ToInt32(drI["GRVTypeID"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<GRVList> GetGRVListsPerSupplierType(int SupplierTypeID)
        {
            //...Create New Instance of Object...
            List<GRVList> list = new List<GRVList>();
            GRVList ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_GRVList WHERE SupplierTypeID = " + SupplierTypeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new GRVList();
                    ins.GRVListID = Convert.ToInt32(drI["GRVListID"]);
                    ins.InvoiceNumber = Convert.ToString(drI["InvoiveNumber"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.Number = Convert.ToInt32(drI["Number"]);
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]);
                    ins.PinkSlipNumber = Convert.ToString(drI["PinkSlipNumber"]);
                    ins.GRVDate = Convert.ToDateTime(drI["GRVDate"]);
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["ExcludingVat"]);
                    ins.IncludingVat = Convert.ToDecimal(drI["IncludingVat"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.GRVTypeID = Convert.ToInt32(drI["GRVTypeID"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public GRVList ConvertToOther(GRVListImport ins)
        {
            GRVList ret = new GRVList();
            ret.CompanyID = ins.CompanyID;
            ret.CreatedDate = ins.CreatedDate;
            ret.ExcludingVat = ins.ExcludingVat;
            ret.GRVDate = ins.GRVDate;
            ret.GRVTypeID = ins.GRVTypeID;
            ret.IncludingVat = ins.IncludingVat;
            ret.InvoiceDate = ins.InvoiceDate;
            ret.InvoiceNumber = ins.InvoiceNumber;
            ret.ModifiedBy = ins.ModifiedBy;
            ret.ModifiedDate = ins.ModifiedDate;
            ret.Number = ins.Number;
            ret.PayDate = ins.PayDate;
            ret.PinkSlipNumber = ins.PinkSlipNumber;
            ret.StateDate = ins.StateDate;
            ret.SupplierID = ins.SupplierID;

            return ret;
        }

        public GRVList Insert(GRVList ins)
        {
            //...Get User and Date Data...
             string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
             int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
             string strTrx = "GRVListIns_" + EmployeeId;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();

            //...Command Interface...
            SqlCommand cmdI = con.CreateCommand();
            SqlTransaction trx;
            trx = con.BeginTransaction(strTrx);
            cmdI.Connection = con;
            cmdI.Transaction = trx;

            try
            {
                //...Insert Record...
                cmdI.CommandText = StoredProcedures.GRVListInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@GRVListID", ins.GRVListID);             
                cmdI.Parameters.AddWithValue("@InvoiceNumber", ins.InvoiceNumber);
                cmdI.Parameters.AddWithValue("@StateDate", ins.StateDate);
                cmdI.Parameters.AddWithValue("@Number", ins.Number);
                cmdI.Parameters.AddWithValue("@PayDate", ins.PayDate);
                cmdI.Parameters.AddWithValue("@PinkSlipNumber", ins.PinkSlipNumber);
                cmdI.Parameters.AddWithValue("@GRVDate", ins.GRVDate);
                cmdI.Parameters.AddWithValue("@InvoiceDate", ins.InvoiceDate);
                cmdI.Parameters.AddWithValue("@ExcludingVat", ins.ExcludingVat);
                cmdI.Parameters.AddWithValue("@IncludingVat", ins.IncludingVat);
                cmdI.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                cmdI.Parameters.AddWithValue("@GRVTypeID", ins.GRVTypeID);
                cmdI.Parameters.AddWithValue("@SupplierID", ins.SupplierID);
                cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
                cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
                cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);
                cmdI.Parameters.AddWithValue("@Removed", ins.Removed);
               
                //...Return new ID
                ins.GRVListID = (int)cmdI.ExecuteScalar();

                trx.Commit();
                cmdI.Connection.Close();
            }
            catch (SqlException ex)
            {
                if (trx != null) trx.Rollback();
            }
            finally
            {
                //Check for close and respond accordingly
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
                //Clean up
                con.Dispose();
                cmdI.Dispose();
                trx.Dispose();
            }
            return ins;
        }

        public GRVList InsertTemp(GRVList ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
            string strTrx = "GRVListIns_" + EmployeeId;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();

            //...Command Interface...
            SqlCommand cmdI = con.CreateCommand();
            SqlTransaction trx;
            trx = con.BeginTransaction(strTrx);
            cmdI.Connection = con;
            cmdI.Transaction = trx;

            try
            {
                //...Insert Record...
                cmdI.CommandText = StoredProcedures.GRVTempInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@GRVListID", ins.GRVListID);             
                cmdI.Parameters.AddWithValue("@InvoiceNumber", ins.InvoiceNumber);
                cmdI.Parameters.AddWithValue("@StateDate", ins.StateDate);
                cmdI.Parameters.AddWithValue("@Number", ins.Number);
                cmdI.Parameters.AddWithValue("@PayDate", ins.PayDate);
                cmdI.Parameters.AddWithValue("@PinkSlipNumber", ins.PinkSlipNumber);
                cmdI.Parameters.AddWithValue("@GRVDate", ins.GRVDate);
                cmdI.Parameters.AddWithValue("@InvoiceDate", ins.InvoiceDate);
                cmdI.Parameters.AddWithValue("@ExcludingVat", ins.ExcludingVat);
                cmdI.Parameters.AddWithValue("@IncludingVat", ins.IncludingVat);
                cmdI.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                cmdI.Parameters.AddWithValue("@GRVTypeID", ins.GRVTypeID);
                cmdI.Parameters.AddWithValue("@SupplierID", ins.SupplierID);
                cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
                cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
                cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);
                cmdI.Parameters.AddWithValue("@Removed", ins.Removed);
                cmdI.Parameters.AddWithValue("@BatchId", ins.BatchId);
                cmdI.Parameters.AddWithValue("@hasError", ins.hasError);
                cmdI.Parameters.AddWithValue("@SupplierDetails", ins.SupplierDetails);

                //...Return new ID
                ins.GRVListID = (int)cmdI.ExecuteScalar();

                trx.Commit();
                cmdI.Connection.Close();
            }
            catch (SqlException ex)
            {
                if (trx != null) trx.Rollback();
            }
            finally
            {
                //Check for close and respond accordingly
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
                //Clean up
                con.Dispose();
                cmdI.Dispose();
                trx.Dispose();
            }
            return ins;
        }

        public GRVImport Insert(GRVImport ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
            string strTrx = "GRVImportIns_" + EmployeeId;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();

            //...Command Interface...
            SqlCommand cmdI = con.CreateCommand();
            SqlTransaction trx;
            trx = con.BeginTransaction(strTrx);
            cmdI.Connection = con;
            cmdI.Transaction = trx;

            try
            {
                //...Insert Record...
                cmdI.CommandText = StoredProcedures.GRVImportInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;       
                cmdI.Parameters.AddWithValue("@FileName", ins.FileName);
                cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
                cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);
                
                ins.BatchId = (int)cmdI.ExecuteScalar();

                trx.Commit();
                cmdI.Connection.Close();
            }
            catch (SqlException ex)
            {
                if (trx != null) trx.Rollback();
            }
            finally
            {
                //Check for close and respond accordingly
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
                //Clean up
                con.Dispose();
                cmdI.Dispose();
                trx.Dispose();
            }
            return ins;
        }

        public GRVList Update(GRVList ins)
        {
            //...Get User and Date Data...
             string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
             int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();
            SqlCommand cmdI = con.CreateCommand();
            cmdI.Connection = con;

            //...Update Record...
            cmdI.Parameters.Clear();
            cmdI.CommandText = StoredProcedures.GRVListUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@GRVListID", ins.GRVListID);
            cmdI.Parameters.AddWithValue("@InvoiceNumber", ins.InvoiceNumber);
            cmdI.Parameters.AddWithValue("@StateDate", ins.StateDate);
            cmdI.Parameters.AddWithValue("@Number", ins.Number);
            cmdI.Parameters.AddWithValue("@PayDate", ins.PayDate);
            cmdI.Parameters.AddWithValue("@PinkSlipNumber", ins.PinkSlipNumber);
            cmdI.Parameters.AddWithValue("@GRVDate", ins.GRVDate);
            cmdI.Parameters.AddWithValue("@InvoiceDate", ins.InvoiceDate);
            cmdI.Parameters.AddWithValue("@ExcludingVat", ins.ExcludingVat);
            cmdI.Parameters.AddWithValue("@IncludingVat", ins.IncludingVat);
            cmdI.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
            cmdI.Parameters.AddWithValue("@GRVTypeID", ins.GRVTypeID);
            cmdI.Parameters.AddWithValue("@SupplierID", ins.SupplierID);
            cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
            cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
            cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);
         

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public GRVListImport UpdateTemp(GRVListImport ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();
            SqlCommand cmdI = con.CreateCommand();
            cmdI.Connection = con;

            //...Update Record...
            cmdI.Parameters.Clear();
            cmdI.CommandText = StoredProcedures.GRVTempUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@GRVListID", ins.GRVListID);
            cmdI.Parameters.AddWithValue("@SupplierID", ins.SupplierID);
            cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
            cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);
            cmdI.Parameters.AddWithValue("@hasError", ins.hasError);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int GRVListID)
        {
            //...Get User and Date Data...
            //string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            //int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();
            SqlCommand cmdI = con.CreateCommand();
            cmdI.Connection = con;

            //...Update Record...
            cmdI.Parameters.Clear();
            cmdI.CommandText = StoredProcedures.GRVListRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@GRVListID", GRVListID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string GRVListIds)
        {
            List<int> RemoveIds = GRVListIds.Split(',').ToList().Select(int.Parse).ToList();

            //...Get Date and Current User
            //string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            //int UserId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();
            SqlCommand cmdI = con.CreateCommand();
            cmdI.Connection = con;

            foreach (int ID in RemoveIds)
            {
                //...Remove Record...
                cmdI.Parameters.Clear();
                cmdI.CommandText = StoredProcedures.GRVListRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@GRVListID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        }

        public void RemoveTemp(int id)
        {
            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("DELETE FROM temp_GRVList WHERE GRVListID = "+id, con);
            cmdI.Connection.Open();
            cmdI.ExecuteNonQuery();

            //...Close Connections...
            con.Close();
        }

        public int checkInt(string check)
        {
            int parser = 0;
            int.TryParse(check, out parser);
            return parser;
        }

        public decimal checkDecimal(string check)
        {
            decimal parser = 0;
            decimal.TryParse(check, out parser);
            return parser;
        }

        public int GetSupplierByName(string Name)
        {
            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_Supplier WHERE Supplier ='" + Name + "'", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            int ret = 0;

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ret = Convert.ToInt32(drI["SupplierID"]);                    
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return ret;
        }

        public DateTime GetFirstFriday(DateTime date)
        {
            int offset = ((5 - (int)date.DayOfWeek) < 0) ? (int)date.DayOfWeek : (5 - (int)date.DayOfWeek);

            return date.AddDays(offset);            
        }

        public DateTime GetPaymentDate(int SupplierId, DateTime InvoiceDate)
        {
            Supplier sup = suprep.GetSupplier(SupplierId);

            /*
             * Execpt for direct
             * First Friday from GRV + Supplier Term
             */

            // If paydate sunday = move to monday

            DateTime Ret = (sup.SupplierID == 0) ? DateTime.Now : InvoiceDate; 
            Ret = (sup.FromFriday) ? GetFirstFriday(Ret).AddDays(checkInt(sup.Term)) : Ret.AddDays(checkInt(sup.Term));
                        
            return Ret;
        }

        public List<GRVList> setData(List<List<string>> data, int BatchId)
        {
            int count = 1;
            List<GRVList> lst = new List<GRVList>();

            DateTime parse;

            foreach (List<string> row in data)
            {
                GRVList imp = new GRVList();
                imp.BatchId = BatchId;

                imp.InvoiceNumber = row[0];                                              //...String
                //imp.Number = checkInt(row[1]);                                           //...Int
                imp.GRVTypeID = (row[2].Equals("GRV")) ? 1 : 2;                         //..Int
             // GRV Unique
                imp.Number = checkInt(row[3]);                                           //...Int
                //imp.PinkSlipNumber = row[4];                                            //...String
                imp.PinkSlipNumber = row[5];                                            //...String
                imp.GRVDate = (DateTime.TryParse(row[6], out parse)) ? Convert.ToDateTime(row[6]) : DateTime.MaxValue;      //...Date
                imp.InvoiceDate = (DateTime.TryParse(row[7], out parse)) ? Convert.ToDateTime(row[7]) : DateTime.MaxValue;  //...Date
                imp.SupplierID = GetSupplierByName(row[8]);
                imp.SupplierDetails = row[8];
                imp.ExcludingVat = checkDecimal(row[9]);
                imp.IncludingVat = checkDecimal(row[11]);
                imp.StateDate = DateTime.Now;
                imp.PayDate = GetPaymentDate(imp.SupplierID, imp.InvoiceDate);

                imp.hasError = (imp.SupplierID == 0) ? true : false;

                //...Add to return list
                lst.Add(imp);
            }

            return lst;
        }

        public List<GRVImport> GetAllGRVImports()
        {
            //...Create New Instance of Object...
            List<GRVImport> list = new List<GRVImport>();
            GRVImport ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_GRVImport", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new GRVImport();
                    ins.BatchId = Convert.ToInt32(drI["BatchID"]);
                    ins.FileName = Convert.ToString(drI["FileName"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();
            
            //...Return...
            return list;
        }

        public void UpdateImports()
        {
            List<GRVListImport> all = GetAllGRVList(true);

            foreach (GRVListImport imp in all)
            {
                if (imp.SupplierID == 0)
                {
                    if (GetSupplierByName(imp.SupplierDetails) != 0)
                    {
                        int supid = GetSupplierByName(imp.SupplierDetails);
                        imp.SupplierID = supid;
                        imp.PayDate = GetPaymentDate(imp.SupplierID, imp.InvoiceDate);
                        imp.hasError = false;
                        GRVListImport imp2 = UpdateTemp(imp);
                    }
                }
            }
        }
    }
}
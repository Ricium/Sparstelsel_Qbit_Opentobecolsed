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
                    ins.InvoiceNumber = Convert.ToChar(drI["InvoiveNumber"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.Number = Convert.ToChar(drI["Number"]);
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]);
                    ins.PinkSlipNumber = Convert.ToChar(drI["PinkSlipNumber"]);
                    ins.GRVDate = Convert.ToDateTime(drI["GRVDate"]);
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["ExcludingVat"]);
                    ins.IncludingVat = Convert.ToDecimal(drI["IncludingVat"]);
                    ins.GRVTypeID = Convert.ToInt32(drI["GRVTypeID"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
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
                    ins.InvoiceNumber = Convert.ToChar(drI["InvoiceNumber"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.Number = Convert.ToChar(drI["Number"]);
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]);
                    ins.GRVDate = Convert.ToDateTime(drI["GRVDate"]);
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["ExcludingVat"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["IncludingVat"]);
                    ins.GRVTypeID = Convert.ToInt32(drI["GRVTypeID"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
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
                    ins.InvoiceNumber = Convert.ToChar(drI["InvoiceNumber"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.Number = Convert.ToChar(drI["Number"]);
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]);
                    ins.GRVDate = Convert.ToDateTime(drI["GRVDate"]);
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["ExcludingVat"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["IncludingVat"]);
                    ins.GRVTypeID = Convert.ToInt32(drI["GRVTypeID"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
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
                    ins.InvoiceNumber = Convert.ToChar(drI["InvoiceNumber"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.Number = Convert.ToChar(drI["Number"]);
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]);
                    ins.GRVDate = Convert.ToDateTime(drI["GRVDate"]);
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["ExcludingVat"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["IncludingVat"]);
                    ins.GRVTypeID = Convert.ToInt32(drI["GRVTypeID"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
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
                    ins.InvoiceNumber = Convert.ToChar(drI["InvoiceNumber"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.Number = Convert.ToChar(drI["Number"]);
                    ins.PayDate = Convert.ToDateTime(drI["PayDate"]);
                    ins.GRVDate = Convert.ToDateTime(drI["GRVDate"]);
                    ins.InvoiceDate = Convert.ToDateTime(drI["InvoiceDate"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["ExcludingVat"]);
                    ins.ExcludingVat = Convert.ToDecimal(drI["IncludingVat"]);
                    ins.GRVTypeID = Convert.ToInt32(drI["GRVTypeID"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public GRVList Insert(GRVList ins)
        {
            //...Get User and Date Data...
            // string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            // int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
            // string strTrx = "GRVListIns_" + EmployeeId;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();

            //...Command Interface...
            SqlCommand cmdI = con.CreateCommand();
            SqlTransaction trx;
            // trx = con.BeginTransaction(strTrx);
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
                cmdI.Parameters.AddWithValue("@GRVTypeID", ins.GRVTypeID);
                cmdI.Parameters.AddWithValue("@SupplierID", ins.SupplierID);
                cmdI.Parameters.AddWithValue("@SupplierTypeID", ins.SupplierTypeID);
               
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

        public GRVList Update(GRVList ins)
        {
            //...Get User and Date Data...
            // string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            // int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);

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
            cmdI.Parameters.AddWithValue("@GRVTypeID", ins.GRVTypeID);
            cmdI.Parameters.AddWithValue("@SupplierID", ins.SupplierID);
            cmdI.Parameters.AddWithValue("@SupplierTypeID", ins.SupplierTypeID);

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
    }
}
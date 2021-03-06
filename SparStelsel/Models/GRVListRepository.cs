﻿using System;
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
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
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
            cmdI = new SqlCommand("SELECT * FROM t_GRVList WHERE Removed=0", con);
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
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
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

        public List<GRVList> GetAllGRVList(string PinkSlipNumber)
        {
            //...Create New Instance of Object...
            List<GRVList> list = new List<GRVList>();
            GRVList ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_GRVList WHERE PinkSlipNumber = '" + PinkSlipNumber + "'", con);
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
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
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
                            + " AND G.GRVDate <= '" + To + "' AND G.Removed=0", con);
            }
            else
            {
                cmdI = new SqlCommand("SELECT G.*, S.Supplier FROM t_GRVList G INNER JOIN t_Supplier S ON G.SupplierID = S.SupplierID "
                            + "WHERE G.InvoiceNumber LIKE '%" + InvoiceNumber
                            + "' AND G.PinkSlipNumber LIKE '%" + PinkSlipNumber + "'"
                            + " AND G.SupplierID =" + Supplier
                            + " AND G.GRVDate >= '" + From + "'"
                            + " AND G.GRVDate <= '" + To + "' AND G.Removed=0", con);
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
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.SupplierDetails = drI["Supplier"].ToString();

                    if (drI["ExpectedPayDate"] == DBNull.Value)
                    {
                        ins.ExpectedPayDate = DateTime.MinValue;
                    }
                    else
                    {
                        ins.ExpectedPayDate = Convert.ToDateTime(drI["ExpectedPayDate"]);
                    }
                    
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
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
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
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
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
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
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
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
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
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
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
            ret.PayDate = GetPaymentDate(ins.SupplierID, ins.GRVDate);
            ret.PinkSlipNumber = ins.PinkSlipNumber;
            ret.StateDate = ins.StateDate;
            ret.SupplierID = ins.SupplierID;
            ret.ExpectedPayDate = GetExpectedPayDate(ins.PinkSlipNumber, ins.SupplierID);

            return ret;
        }

        public GRVList Insert(GRVList ins)
        {
            //...Get User and Date Data...
             string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
              string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);
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
                cmdI.Parameters.AddWithValue("@ExpectedPayDate", ins.ExpectedPayDate);
               
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
             string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);
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

            if (ins.PayDate == DateTime.MinValue)
            {
                ins.PayDate = DateTime.Now;
            }

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
             string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);
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
              string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);

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
            cmdI.Parameters.AddWithValue("@ExpectedPayDate", ins.ExpectedPayDate);
         

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void UpdateStateDate(DateTime Statedate, string InvoiceNumber, int SupplierID, int GRVTypeId)
        {
            //...Create New Instance of Object...
            List<GRVList> list = new List<GRVList>();
            GRVList ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("Update t_GRVList set StateDate= '"+Statedate+"'Where InvoiceNumber='"+InvoiceNumber+"' and SupplierID ='"+SupplierID+"' And GRVTypeID='"+GRVTypeId+"'" , con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Close Connections...
            drI.Close();
            con.Close();


        }

        public GRVList UpdateFromImport(GRVList ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();
            SqlCommand cmdI = con.CreateCommand();
            cmdI.Connection = con;

            //...Update Record...
            cmdI.Parameters.Clear();
            cmdI.CommandText = StoredProcedures.GRVListUpdateImport;
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
            cmdI.Parameters.AddWithValue("@ExpectedPayDate", ins.ExpectedPayDate);


            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public GRVListImport UpdateTemp(GRVListImport ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
             string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);

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
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);

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
            cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
            cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);
            cmdI.Parameters.AddWithValue("@Remove", 1);

            cmdI.ExecuteNonQuery();
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
            cmdI = new SqlCommand("SELECT TOP 1 SupplierID FROM t_Supplier WHERE Supplier ='" + Name + "' AND Removed = 0 ORDER BY SupplierID", con);
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

        public bool CheckGRVDuplicate(string Number)
        {
            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT GRVListID FROM t_GRVList WHERE Number ='" + Number + "' AND Removed = 0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            bool ret = false;

            //...Retrieve Data...
            if (drI.HasRows)
            {
                    ret = true; 
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

        public DateTime GetPaymentDate(int SupplierId, DateTime GRVDate)
        {
            if (GRVDate == null)
            {
                return  DateTime.MinValue;
            }
            else
            {
                Supplier sup = suprep.GetSupplier(SupplierId);

                /*
                 * Execpt for direct
                 * First Friday from GRV + Supplier Term
                 */

                // If paydate sunday = move to monday

                DateTime Ret = (sup.SupplierID == 0) ? DateTime.MinValue : GRVDate;
                Ret = (sup.FromFriday) ? GetFirstFriday(Ret).AddDays(checkInt(sup.Term)) : Ret.AddDays(checkInt(sup.Term));

                return Ret;
            }

           
        }

        public DateTime GetExpectedPayDate(string PinkSlip, int SupplierId)
        {
            OrderRepository orderrep = new OrderRepository();
            Order order = orderrep.GetOrder(PinkSlip);

            if(order.OrderID == 0)
            {
                return DateTime.Now;
            }
            else
            {
                return GetPaymentDate(SupplierId, order.ExpectedDeliveryDate);
            }

            
        }

        public List<GRVList> setData(IQueryable<GRVExcel> data, int BatchId)
        {
            List<GRVList> lst = new List<GRVList>();

            DateTime parse;
            int count = 0;
            foreach (GRVExcel row in data)
            {
                //if (!CheckGRVDuplicate(row.Number.ToString()))
                //{
                    GRVList imp = new GRVList();
                    imp.BatchId = BatchId;

                    imp.InvoiceNumber = row.InvNo;
                    count++;

                    if (row.Typ == null) { row.Typ = "CLM"; }
                    imp.GRVTypeID = (row.Typ.Equals("GRV")) ? 1 : 2;
                    imp.Number = row.Number;

                    imp.PinkSlipNumber = row.GRVBook;
                    imp.GRVDate = (DateTime.TryParse(row.GRVDate, out parse)) ? Convert.ToDateTime(row.GRVDate) : DateTime.Now;
                    imp.InvoiceDate = (DateTime.TryParse(row.InvDate, out parse)) ? Convert.ToDateTime(row.InvDate) : imp.GRVDate;
                    imp.SupplierID = GetSupplierByName(row.SupplierName);
                    imp.SupplierDetails = row.SupplierName;
                    imp.ExcludingVat = checkDecimal(row.ExclVAT);
                    imp.IncludingVat = checkDecimal(row.InclVAT);
                    imp.StateDate = new DateTime(1900, 1, 1);
                    imp.PayDate = GetPaymentDate(imp.SupplierID, imp.GRVDate);

                    imp.hasError = (imp.SupplierID == 0) ? true : false;

                    //...Add to return list
                    lst.Add(imp);
                //}
            }

            return lst;
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
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
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
                        imp.PayDate = GetPaymentDate(imp.SupplierID, imp.GRVDate);
                        imp.hasError = false;
                        GRVListImport imp2 = UpdateTemp(imp);
                    }
                }
            }
        }

    }
}
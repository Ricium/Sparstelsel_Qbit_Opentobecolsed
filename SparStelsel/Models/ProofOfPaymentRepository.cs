using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SparStelsel.Models
{
    public class ProofOfPaymentRepository
    {
        public ProofOfPayment GetProofOfPayment(int ProofOfPaymentID)
        {
            //...Create New Instance of Object...
            ProofOfPayment ins = new ProofOfPayment();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_ProofOfPayment WHERE ProofOfPaymentID =" + ProofOfPaymentID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.ProofOfPaymentID = Convert.ToInt32(drI["ProofOfPaymentID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.PaymentDescription = Convert.ToString(drI["PaymentDescription"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.Amount = Convert.ToInt32(drI["Amount"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.InvoiceNumber = drI["InvoiceNumber"].ToString();
                    ins.CashTypeID = Convert.ToInt32(drI["CashTypeID"]);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return ins;
        }

        public List<ProofOfPayment> GetAllProofOfPayment()
        {
            //...Create New Instance of Object...
            List<ProofOfPayment> list = new List<ProofOfPayment>();
            ProofOfPayment ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT pop.*,c.CashType FROM t_ProofOfPayment pop inner join l_CashType c on pop.CashTypeID = c.CashTypeID WHERE pop.Removed = 0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new ProofOfPayment();
                    ins.ProofOfPaymentID = Convert.ToInt32(drI["ProofOfPaymentID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.PaymentDescription = Convert.ToString(drI["PaymentDescription"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.Amount = Convert.ToInt32(drI["Amount"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.InvoiceNumber = drI["InvoiceNumber"].ToString();
                    ins.CashTypeID = Convert.ToInt32(drI["CashTypeID"]);
                    ins.cashtype = drI["CashType"].ToString();
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<ProofOfPayment> GetProofOfPaymentsPerSupplier(int SupplierID)
        {
            //...Create New Instance of Object...
            List<ProofOfPayment> list = new List<ProofOfPayment>();
            ProofOfPayment ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_ProofOfPayment WHERE SupplierID = " + SupplierID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new ProofOfPayment();
                    ins.ProofOfPaymentID = Convert.ToInt32(drI["ProofOfPaymentID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.PaymentDescription = Convert.ToString(drI["PaymentDescription"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.Amount = Convert.ToInt32(drI["Amount"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.InvoiceNumber = drI["InvoiceNumber"].ToString();
                    ins.CashTypeID = Convert.ToInt32(drI["CashTypeID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<ProofOfPayment> GetProofOfPaymentsPerSupplierType(int SupplierTypeID)
        {
            //...Create New Instance of Object...
            List<ProofOfPayment> list = new List<ProofOfPayment>();
            ProofOfPayment ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_ProofOfPayment WHERE SupplierTypeID = " + SupplierTypeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new ProofOfPayment();
                    ins.ProofOfPaymentID = Convert.ToInt32(drI["ProofOfPaymentID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.PaymentDescription = Convert.ToString(drI["PaymentDescription"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.Amount = Convert.ToInt32(drI["Amount"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.InvoiceNumber = drI["InvoiceNumber"].ToString();
                    ins.CashTypeID = Convert.ToInt32(drI["CashTypeID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public ProofOfPayment Insert(ProofOfPayment ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
             string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);
            string strTrx = "ProofOfPaymentIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.ProofOfPaymentInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@ProofOfPaymentID", ins.ProofOfPaymentID);             
                cmdI.Parameters.AddWithValue("@ActualDate", ins.ActualDate);
                cmdI.Parameters.AddWithValue("@PaymentDescription", ins.PaymentDescription);
                cmdI.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
                cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
                cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
               cmdI.Parameters.AddWithValue("@ModifiedBy",EmployeeId);
                cmdI.Parameters.AddWithValue("@Removed", ins.Removed);
                cmdI.Parameters.AddWithValue("@InvoiceNumber", ins.InvoiceNumber);
                cmdI.Parameters.AddWithValue("@CashTypeID", ins.CashTypeID);

                //...Return new ID
                ins.ProofOfPaymentID = (int)cmdI.ExecuteScalar();

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

        public ProofOfPayment Update(ProofOfPayment ins)
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
            cmdI.CommandText = StoredProcedures.ProofOfPaymentUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@ProofOfPaymentID", ins.ProofOfPaymentID);
            cmdI.Parameters.AddWithValue("@ActualDate", ins.ActualDate);
            cmdI.Parameters.AddWithValue("@PaymentDescription", ins.PaymentDescription);
            cmdI.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
            cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
            cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
            cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
           cmdI.Parameters.AddWithValue("@ModifiedBy",EmployeeId);
            cmdI.Parameters.AddWithValue("@InvoiceNumber", ins.InvoiceNumber);
            cmdI.Parameters.AddWithValue("@CashTypeID", ins.CashTypeID);
    

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int ProofOfPaymentID)
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
            cmdI.CommandText = StoredProcedures.ProofOfPaymentRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@ProofOfPaymentID", ProofOfPaymentID);
            cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
            cmdI.Parameters.AddWithValue("@ModifiedBy", 1);
            cmdI.Parameters.AddWithValue("@Removed", 1);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string ProofOfPaymentIds)
        {
            List<int> RemoveIds = ProofOfPaymentIds.Split(',').ToList().Select(int.Parse).ToList();

            //...Get Date and Current User
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            int UserId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);

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
                cmdI.CommandText = StoredProcedures.ProofOfPaymentRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@ProofOfPaymentID", ID);
                cmdI.ExecuteNonQuery();
            }


            cmdI.Connection.Close();
        }

       
    }

   
}
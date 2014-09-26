using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class CashReconcilationRepository
    {
        public CashReconcilation GetCashReconcilation(int CashReconcilationID)
        {
            //...Create New Instance of Object...
            CashReconcilation ins = new CashReconcilation();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashReconcilation WHERE CashReconcilationId =" + CashReconcilationID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.CashReconcilationID = Convert.ToInt32(drI["CashReconcilationID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ReconcilationTypeID = Convert.ToInt32(drI["ReconcilationTypeID"]);
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.EmployeeTypeID = Convert.ToInt32(drI["EmployeeTypeID"]);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return ins;
        }

        public List<CashReconcilation> GetAllCashReconcilation()
        {
            //...Create New Instance of Object...
            List<CashReconcilation> list = new List<CashReconcilation>();
            CashReconcilation ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashReconcilation", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new CashReconcilation();
                    ins.CashReconcilationID = Convert.ToInt32(drI["CashReconcilationID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ReconcilationTypeID = Convert.ToInt32(drI["ReconcilationTypeID"]);
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.EmployeeTypeID = Convert.ToInt32(drI["EmployeeTypeID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<CashReconcilation> GetCashReconcilationsPerEmployee(int EmployeeId)
        {
            //...Create New Instance of Object...
            List<CashReconcilation> list = new List<CashReconcilation>();
            CashReconcilation ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashReconcilation WHERE EmployeeID = " + EmployeeId, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new CashReconcilation();
                    ins.CashReconcilationID = Convert.ToInt32(drI["CashReconcilationID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ReconcilationTypeID = Convert.ToInt32(drI["ReconcilationTypeID"]);
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.EmployeeTypeID = Convert.ToInt32(drI["EmployeeTypeID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<CashReconcilation> GetCashReconcilationsPerType(int CashReconcilationID)
        {
            //...Create New Instance of Object...
            List<CashReconcilation> list = new List<CashReconcilation>();
            CashReconcilation ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashReconcilation WHERE CashReconcilationID = " + CashReconcilationID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new CashReconcilation();
                    ins.CashReconcilationID = Convert.ToInt32(drI["CashReconcilationID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ReconcilationTypeID = Convert.ToInt32(drI["ReconcilationTypeID"]);
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.EmployeeTypeID = Convert.ToInt32(drI["EmployeeTypeID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public CashReconcilation Insert(CashReconcilation ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
            string strTrx = "CashReconcilationIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.CashReconcilationInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@CashReconcilationID", ins.CashReconcilationID);             
                cmdI.Parameters.AddWithValue("@ActualDate", ins.ActualDate);
                cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
                cmdI.Parameters.AddWithValue("@ReconcilationTypeID", ins.ReconcilationTypeID);
                cmdI.Parameters.AddWithValue("@EmployeeID", EmployeeId);
                cmdI.Parameters.AddWithValue("@EmployeeTypeID", ins.EmployeeTypeID);

                //...Return new ID
                ins.CashReconcilationID = (int)cmdI.ExecuteScalar();

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

        public CashReconcilation Update(CashReconcilation ins)
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
            cmdI.CommandText = StoredProcedures.CashReconcilationUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@CashReconcilationID", ins.CashReconcilationID);
            cmdI.Parameters.AddWithValue("@ActualDate", ins.ActualDate);
            cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
            cmdI.Parameters.AddWithValue("@ReconcilationTypeID", ins.ReconcilationTypeID);
            cmdI.Parameters.AddWithValue("@EmployeeID", EmployeeId);
            cmdI.Parameters.AddWithValue("@EmployeeTypeID", ins.EmployeeTypeID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int CashReconcilationID)
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
            cmdI.CommandText = StoredProcedures.CashReconcilationRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@CashReconcilationID", CashReconcilationID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string CashReconcilationIds)
        {
            List<int> RemoveIds = CashReconcilationIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.CashReconcilationRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@CashReconcilationID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        } 
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class CashTypeRepository
    {
        public CashType GetCashType(int CashTypeID)
        {
            //...Create New Instance of Object...
            CashType ins = new CashType();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM l_CashType WHERE CashTypeID =" + CashTypeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.CashTypeID = Convert.ToInt32(drI["CashTypeID"]);
                    ins.CashTypes = Convert.ToString(drI["CashType"]);
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

        public List<CashType> GetAllCashType()
        {
            //...Create New Instance of Object...
            List<CashType> list = new List<CashType>();
            CashType ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM l_CashType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new CashType();
                    ins.CashTypeID = Convert.ToInt32(drI["CashTypeID"]);
                    ins.CashTypes = Convert.ToString(drI["CashType"]);
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

        public CashType Insert(CashType ins)
        {
            //...Get User and Date Data...
             string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
              string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);
             string strTrx = "CashTypeIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.CashTypeInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@CashTypeID", ins.CashTypeID);             
                cmdI.Parameters.AddWithValue("@CashType", ins.CashTypes);
                cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
                cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
                cmdI.Parameters.AddWithValue("@ModifiedBy", 1);
                cmdI.Parameters.AddWithValue("@Removed", ins.Removed);

                //...Return new ID
                ins.CashTypeID = (int)cmdI.ExecuteScalar();

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

        public CashType Update(CashType ins)
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
            cmdI.CommandText = StoredProcedures.CashTypeUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@CashTypeID", ins.CashTypeID);
            cmdI.Parameters.AddWithValue("@CashType", ins.CashTypes);
            cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
            cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
            cmdI.Parameters.AddWithValue("@ModifiedBy", 1);
   

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int CashTypeID)
        {
            //...Get User and Date Data...
            //string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            // string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();
            SqlCommand cmdI = con.CreateCommand();
            cmdI.Connection = con;

            //...Update Record...
            cmdI.Parameters.Clear();
            cmdI.CommandText = StoredProcedures.CashTypeRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@CashTypeID", CashTypeID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string CashTypeIds)
        {
            List<int> RemoveIds = CashTypeIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.CashTypeRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@CashTypeID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        }
    }
}
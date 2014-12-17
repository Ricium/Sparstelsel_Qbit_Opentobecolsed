using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class BudgetRepository
    {
        public Budget GetBudget(int BudgetID)
        {
            //...Create New Instance of Object...
            Budget ins = new Budget();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM l_Budget WHERE BudgetID =" + BudgetID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.BudgetID = Convert.ToInt32(drI["BudgetID"]);
                    ins.BudgetDate = Convert.ToDateTime(drI["BudgetDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
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

        public List<Budget> GetAllBudget()
        {
            //...Create New Instance of Object...
            List<Budget> list = new List<Budget>();
            Budget ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM l_Budget", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Budget();
                    ins.BudgetID = Convert.ToInt32(drI["BudgetID"]);
                    ins.BudgetDate = Convert.ToDateTime(drI["BudgetDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
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

        public Budget Insert(Budget ins)
        {
            //...Get User and Date Data...
             string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
              string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);
             string strTrx = "BudgetIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.BudgetInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@BudgetID", ins.BudgetID);             
                cmdI.Parameters.AddWithValue("@BudgetDate", ins.BudgetDate);
                cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
                cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
                cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
                cmdI.Parameters.AddWithValue("@ModifiedBy", 1);
                cmdI.Parameters.AddWithValue("@Removed", ins.Removed);

                //...Return new ID
                ins.BudgetID = (int)cmdI.ExecuteScalar();

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

        public Budget Update(Budget ins)
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
            cmdI.CommandText = StoredProcedures.BudgetUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@BudgetID", ins.BudgetID);
            cmdI.Parameters.AddWithValue("@BudgetDate", ins.BudgetDate);
            cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
            cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
            cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
            cmdI.Parameters.AddWithValue("@ModifiedBy", 1);
         

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int BudgetID)
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
            cmdI.CommandText = StoredProcedures.BudgetRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@BudgetID", BudgetID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string BudgetIds)
        {
            List<int> RemoveIds = BudgetIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.BudgetRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@BudgetID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        } 
    }
}
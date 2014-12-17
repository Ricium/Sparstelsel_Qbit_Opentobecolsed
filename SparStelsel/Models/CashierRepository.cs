using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class CashierRepository
    {
        public Cashier GetCashier(int EmployeeID)
        {
            //...Create New Instance of Object...
            Cashier ins = new Cashier();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM Employee WHERE EmployeeID =" + EmployeeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.CashierID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.Name = Convert.ToString(drI["Name"]);
                    ins.Surname = drI["Surname"].ToString();
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

        public List<Cashier> GetAllCashier()
        {
            //...Create New Instance of Object...
            List<Cashier> list = new List<Cashier>();
            Cashier ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM Employee", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Cashier();
                    ins.CashierID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.Name = Convert.ToString(drI["Name"]);
                    ins.Surname = drI["Surname"].ToString();
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

        public Cashier Insert(Cashier ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            int UserID = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
            string strTrx = "CashierIns_" + UserID;

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
                cmdI.CommandText = StoredProcedures.CashierInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@CashierID", ins.CashierID);             
                cmdI.Parameters.AddWithValue("@Name", ins.Name);
                cmdI.Parameters.AddWithValue("@Surname", ins.Surname);
                cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
                cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
                cmdI.Parameters.AddWithValue("@ModifiedBy", UserID);
                cmdI.Parameters.AddWithValue("@Removed", ins.Removed);


                //...Return new ID
                ins.CashierID = (int)cmdI.ExecuteScalar();

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

        public Cashier Update(Cashier ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            int UserID = Convert.ToInt32(HttpContext.Current.Session["UserID"]);

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();
            SqlCommand cmdI = con.CreateCommand();
            cmdI.Connection = con;

            //...Update Record...
            cmdI.Parameters.Clear();
            cmdI.CommandText = StoredProcedures.CashierUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@EmployeeID", ins.CashierID);
            cmdI.Parameters.AddWithValue("@Name", ins.Name);
            cmdI.Parameters.AddWithValue("@Surname", ins.Surname);
            cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
            cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
            cmdI.Parameters.AddWithValue("@ModifiedBy", UserID);
            cmdI.Parameters.AddWithValue("@Removed", ins.Removed);


            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int CashierID)
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
            cmdI.CommandText = StoredProcedures.CashierRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@EmployeeID", CashierID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string CashierIds)
        {
            List<int> RemoveIds = CashierIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.CashierRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@EmployeeID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        } 
    }
}
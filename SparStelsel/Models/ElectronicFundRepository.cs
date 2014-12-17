using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class ElectronicFundRepository
    {
        public ElectronicFund GetElectronicFund(int ElectronicFundID)
        {
            //...Create New Instance of Object...
            ElectronicFund ins = new ElectronicFund();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_ElectronicFund WHERE ElectronicFundId =" + ElectronicFundID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.ElectronicFundID = Convert.ToInt32(drI["ElectronicFundID"]);
                    ins.ElectronicFunds = Convert.ToString(drI["ElectronicFunds"]);
                    ins.Total = Convert.ToDecimal(drI["Total"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.ElectronicTypeID = Convert.ToInt32(drI["ElectronicTypeID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
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

        public List<ElectronicFund> GetAllElectronicFund()
        {
            //...Create New Instance of Object...
            List<ElectronicFund> list = new List<ElectronicFund>();
            ElectronicFund ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT ef.*,et.ElectronicType FROM t_ElectronicFund ef inner join l_ElectronicType et on ef.ElectronicTypeID=et.ElectronicTypeID", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new ElectronicFund();
                    ins.ElectronicFundID = Convert.ToInt32(drI["ElectronicFundID"]);
                    ins.ElectronicFunds = Convert.ToString(drI["ElectronicFunds"]);
                    ins.Total = Convert.ToDecimal(drI["Total"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.ElectronicTypeID = Convert.ToInt32(drI["ElectronicTypeID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
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

        public List<ElectronicFund> GetElectronicFundsPerElectronicType(int ElectronicTypeID)
        {
            //...Create New Instance of Object...
            List<ElectronicFund> list = new List<ElectronicFund>();
            ElectronicFund ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_ElectronicFund WHERE ElectronicTypeID = " + ElectronicTypeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new ElectronicFund();
                    ins.ElectronicFundID = Convert.ToInt32(drI["ElectronicFundID"]);
                    ins.ElectronicFunds = Convert.ToString(drI["ElectronicFunds"]);
                    ins.Total = Convert.ToDecimal(drI["Total"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.ElectronicTypeID = Convert.ToInt32(drI["ElectronicTypeID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
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

        public List<ElectronicFund> GetElectronicFundsPerEmployee(int EmployeeID)
        {
            //...Create New Instance of Object...
            List<ElectronicFund> list = new List<ElectronicFund>();
            ElectronicFund ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_ElectronicFund WHERE EmployeeID = " + EmployeeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new ElectronicFund();
                    ins.ElectronicFundID = Convert.ToInt32(drI["ElectronicFundID"]);
                    ins.ElectronicFunds = Convert.ToString(drI["ElectronicFunds"]);
                    ins.Total = Convert.ToDecimal(drI["Total"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.ElectronicTypeID = Convert.ToInt32(drI["ElectronicTypeID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
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

        public List<ElectronicFund> GetElectronicFundsPerType(int UserTypeID)
        {
            //...Create New Instance of Object...
            List<ElectronicFund> list = new List<ElectronicFund>();
            ElectronicFund ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_ElectronicFund WHERE UserTypeID = " + UserTypeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new ElectronicFund();
                    ins.ElectronicFundID = Convert.ToInt32(drI["ElectronicFundID"]);
                    ins.ElectronicFunds = Convert.ToString(drI["ElectronicFunds"]);
                    ins.Total = Convert.ToDecimal(drI["Total"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.ElectronicTypeID = Convert.ToInt32(drI["ElectronicTypeID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
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

        public ElectronicFund Insert(ElectronicFund ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
             string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);
            string strTrx = "ElectronicFundIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.ElectronicFundInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@ElectronicFundID", ins.ElectronicFundID);             
                cmdI.Parameters.AddWithValue("@ElectronicFunds", ins.ElectronicFunds);
                cmdI.Parameters.AddWithValue("@Total", ins.Total);
                cmdI.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                cmdI.Parameters.AddWithValue("@EmployeeID", ins.EmployeeID);
                cmdI.Parameters.AddWithValue("@ElectronicTypeID", ins.ElectronicTypeID);
                cmdI.Parameters.AddWithValue("@UserID", ins.UserID);
                cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
                cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
                cmdI.Parameters.AddWithValue("@ModifiedBy", 1);
                cmdI.Parameters.AddWithValue("@Removed", ins.Removed);

                //...Return new ID
                ins.ElectronicFundID = (int)cmdI.ExecuteScalar();

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

        public ElectronicFund Update(ElectronicFund ins)
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
            cmdI.CommandText = StoredProcedures.ElectronicFundUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@ElectronicFundID", ins.ElectronicFundID);
            cmdI.Parameters.AddWithValue("@ElectronicFunds", ins.ElectronicFunds);
            cmdI.Parameters.AddWithValue("@Total", ins.Total);
            cmdI.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
            cmdI.Parameters.AddWithValue("@EmployeeID", ins.EmployeeID);
            cmdI.Parameters.AddWithValue("@ElectronicTypeID", ins.ElectronicTypeID);
            cmdI.Parameters.AddWithValue("@UserID", ins.UserID);
            cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
            cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
            cmdI.Parameters.AddWithValue("@ModifiedBy", 1);
          

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int ElectronicFundID)
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
            cmdI.CommandText = StoredProcedures.ElectronicFundRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@ElectronicFundID", ElectronicFundID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string ElectronicFundIds)
        {
            List<int> RemoveIds = ElectronicFundIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.ElectronicFundRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@ElectronicFundID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        }
    }
}
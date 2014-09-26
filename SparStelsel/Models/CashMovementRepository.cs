using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class CashMovementRepository
    {
        public CashMovement GetCashMovement(int CashMovementID)
        {
            //...Create New Instance of Object...
            CashMovement ins = new CashMovement();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashMovement WHERE CashMovementId =" + CashMovementID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.CashMovementID = Convert.ToInt32(drI["CashMovementID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.CashTypeID = Convert.ToInt32(drI["CashTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
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

        public List<CashMovement> GetAllCoinMovement()
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashMovement", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new CashMovement();
                    ins.CashMovementID = Convert.ToInt32(drI["CashMovementID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.CashTypeID = Convert.ToInt32(drI["CashTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
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

        public List<CashMovement> GetCashMovementsPerEmployee(int EmployeeId)
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashMovement WHERE EmployeeID = " + EmployeeId, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new CashMovement();
                    ins.CashMovementID = Convert.ToInt32(drI["CashMovementID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.CashTypeID = Convert.ToInt32(drI["CashTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
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

        public List<CashMovement> GetCashMovementsPerType(int CashMovementID)
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CoinMovement WHERE CoinMovementID = " + CoinMovementID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new CashMovement();
                    ins.CashMovementID = Convert.ToInt32(drI["CashMovementID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.CashTypeID = Convert.ToInt32(drI["CashTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
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

        public CashMovement Insert(CashMovement ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
            string strTrx = "CashMovementIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.CashMovementInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@CashMovementID", ins.CashMovementID);             
                cmdI.Parameters.AddWithValue("@ActualDate", ins.ActualDate);
                cmdI.Parameters.AddWithValue("@ModifiedDate", ins.ModifiedDate);
                cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
                cmdI.Parameters.AddWithValue("@CashTypeID", ins.CashTypeID);
                cmdI.Parameters.AddWithValue("@MoneyUnitID", ins.MoneyUnitID);
                cmdI.Parameters.AddWithValue("@EmployeeID", ins.EmployeeID);
                cmdI.Parameters.AddWithValue("@EmployeeTypeID", ins.EmployeeTypeID);

                //...Return new ID
                ins.CashMovementID = (int)cmdI.ExecuteScalar();

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

        public CashMovement Update(CashMovement ins)
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
            cmdI.CommandText = StoredProcedures.CashMovementUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@CashMovementID", ins.CashMovementID);
            cmdI.Parameters.AddWithValue("@ActualDate", ins.ActualDate);
            cmdI.Parameters.AddWithValue("@ModifiedDate", ins.ModifiedDate);
            cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
            cmdI.Parameters.AddWithValue("@CashTypeID", ins.CashTypeID);
            cmdI.Parameters.AddWithValue("@MoneyUnitID", ins.MoneyUnitID);
            cmdI.Parameters.AddWithValue("@EmployeeID", ins.EmployeeID);
            cmdI.Parameters.AddWithValue("@EmployeeTypeID", ins.EmployeeTypeID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int CashMovementID)
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
            cmdI.CommandText = StoredProcedures.CashMovementRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@CashMovementID", CashMovementID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string CashMovementIds)
        {
            List<int> RemoveIds = CashMovementIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.CashMovementRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@CashMovementID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        }
    }
}
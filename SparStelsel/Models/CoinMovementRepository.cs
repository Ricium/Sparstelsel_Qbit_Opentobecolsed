using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class CoinMovementRepository
    {
        public CoinMovement GetCoinMovement(int CoinMovementID)
        {
            //...Create New Instance of Object...
            CoinMovement ins = new CoinMovement();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CoinMovement WHERE CoinMovementId =" + CoinMovementID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.CoinMovementID = Convert.ToInt32(drI["CoinMovementID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.MovementTypeID = Convert.ToInt32(drI["MovementTypeID"]);
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

        public List<CoinMovement> GetAllCoinMovement()
        {
            //...Create New Instance of Object...
            List<CoinMovement> list = new List<CoinMovement>();
            CoinMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CoinMovement", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new CoinMovement();
                    ins.CoinMovementID = Convert.ToInt32(drI["CoinMovementID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.MovementTypeID = Convert.ToInt32(drI["MovementTypeID"]);
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

        public List<CoinMovement> GetCoinMovementsPerEmployee(int EmployeeId)
        {
            //...Create New Instance of Object...
            List<CoinMovement> list = new List<CoinMovement>();
            CoinMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CoinMovement WHERE EmployeeID = " + EmployeeId, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new CoinMovement();
                    ins.CoinMovementID = Convert.ToInt32(drI["CoinMovementID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.MovementTypeID = Convert.ToInt32(drI["MovementTypeID"]);
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

        public List<CoinMovement> GetCoinMovementsPerType(int CoinMovementID)
        {
            //...Create New Instance of Object...
            List<CoinMovement> list = new List<CoinMovement>();
            CoinMovement ins;

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
                    ins = new CoinMovement();
                    ins.CoinMovementID = Convert.ToInt32(drI["CoinMovementID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.MovementTypeID = Convert.ToInt32(drI["MovementTypeID"]);
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

        public CoinMovement Insert(CoinMovement ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
            string strTrx = "CoinMovementIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.CoinMovementInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@InstantMoneyID", ins.InstantMoneyID);             
                cmdI.Parameters.AddWithValue("@ActualDate", ins.ActualDate);
                cmdI.Parameters.AddWithValue("@ModifiedDate", ins.ModifiedDate);
                cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
                cmdI.Parameters.AddWithValue("@MovementTypeID", ins.MovementTypeID);
                cmdI.Parameters.AddWithValue("@MoneyUnitID", ins.MoneyUnitID);
                cmdI.Parameters.AddWithValue("@EmployeeID", ins.EmployeeID);
                cmdI.Parameters.AddWithValue("@EmployeeTypeID", ins.EmployeeTypeID);

                //...Return new ID
                ins.CoinMovementID = (int)cmdI.ExecuteScalar();

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

        public CoinMovement Update(CoinMovement ins)
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
            cmdI.CommandText = StoredProcedures.CoinMovementUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@CoinMovementID", ins.CoinMovementID);
            cmdI.Parameters.AddWithValue("@ActualDate", ins.ActualDate);
            cmdI.Parameters.AddWithValue("@ModifiedDate", ins.ModifiedDate);
            cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
            cmdI.Parameters.AddWithValue("@MovementTypeID", ins.MovementTypeID);
            cmdI.Parameters.AddWithValue("@MoneyUnitID", ins.MoneyUnitID);
            cmdI.Parameters.AddWithValue("@EmployeeID", ins.EmployeeID);
            cmdI.Parameters.AddWithValue("@EmployeeTypeID", ins.EmployeeTypeID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int CoinMovementID)
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
            cmdI.CommandText = StoredProcedures.CoinMovementRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@CoinMovementID", CoinMovementID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string CoinMovementIds)
        {
            List<int> RemoveIds = CoinMovementIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.CoinMovementRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@CoinMovementID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        } 
    }
}
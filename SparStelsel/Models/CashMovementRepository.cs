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
            cmdI = new SqlCommand("SELECT * FROM t_CashMovement WHERE CashMovementID =" + CashMovementID, con);
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
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.MovementTypeID = Convert.ToInt32(drI["MovementTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return ins;
        }

        public List<CashMovement> GetAllCashMovement()
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT cm.*,m.MoneyUnit,mt.MovementType FROM t_CashMovement cm inner join l_MoneyUnit m on cm.MoneyUnitID=m.MoneyUnitID inner join l_MovementType mt on cm.MovementTypeID=mt.MovementTypeID", con);
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
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.MovementTypeID = Convert.ToInt32(drI["MovementTypeID"]);
                    ins.movementtype = drI["MovementType"].ToString();
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                    ins.moneyunit = drI["MoneyUnit"].ToString();
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<CashMovement> GetCashMovementsPerCashType(int MovementTypeID, string UserID)
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashMovement WHERE MovementTypeID = " + MovementTypeID + " Where Removed=0 and UserID= " + UserID, con);
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
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.MovementTypeID = Convert.ToInt32(drI["MovementTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                   
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<CashMovement> MoneyUnit(int MoneyUnitID)
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashMovement WHERE MoneyUnitID = " + MoneyUnitID, con);
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
                    ins.MovementTypeID = Convert.ToInt32(drI["MovementTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<CashMovement> GetCashMovementsPerEmployee(int EmployeeID)
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashMovement WHERE EmployeeID = " + EmployeeID, con);
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
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.MovementTypeID = Convert.ToInt32(drI["MovementTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);

                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<CashMovement> GetCashMovementsPerEmployee(int EmployeeID, DateTime date)
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashMovement WHERE EmployeeID = " + EmployeeID + " AND ActualDate = '" + date.ToShortDateString() + "' AND Removed=0", con);
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
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.MovementTypeID = Convert.ToInt32(drI["MovementTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }
        public List<CashMovement> GetCashMovementsPerEmployee(int EmployeeID, DateTime date,int MovementTypeID)
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashMovement WHERE EmployeeID = " + EmployeeID + " AND ActualDate = '" + date.ToShortDateString() + "'AND MovementTypeID ='"+MovementTypeID+"'  AND Removed=0", con);
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
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.MovementTypeID = Convert.ToInt32(drI["MovementTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<CashMovement> GetCashMovementsPerEmployeeType(int UserTypeID)
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashMovement WHERE UserTypeID = " + UserTypeID, con);
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
                    ins.MovementTypeID = Convert.ToInt32(drI["MovementTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
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
            string UserID = HttpContext.Current.Session["Username"].ToString();
            string strTrx = "CashMovementIns_" + UserID;

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
                cmdI.Parameters.AddWithValue("@ActualDate", ins.ActualDate);
                cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
                cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
                cmdI.Parameters.AddWithValue("@EmployeeID", ins.EmployeeID);
                cmdI.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                cmdI.Parameters.AddWithValue("@CompanyID", 0);
                cmdI.Parameters.AddWithValue("@MovementTypeID", ins.MovementTypeID);
                cmdI.Parameters.AddWithValue("@MoneyUnitID", ins.MoneyUnitID);
                cmdI.Parameters.AddWithValue("@UserID", 0);
                cmdI.Parameters.AddWithValue("@ModifiedBy", UserID);
                cmdI.Parameters.AddWithValue("@Removed", 0);

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
            string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);

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
            cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
            cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
            cmdI.Parameters.AddWithValue("@EmployeeID", ins.EmployeeID);
            cmdI.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
            cmdI.Parameters.AddWithValue("@CompanyID", 0);
            cmdI.Parameters.AddWithValue("@MovementTypeID", ins.MovementTypeID);
            cmdI.Parameters.AddWithValue("@MoneyUnitID", ins.MoneyUnitID);
            cmdI.Parameters.AddWithValue("@UserID", 0);
            cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int CashMovementID)
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
            cmdI.CommandText = StoredProcedures.CashMovementRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@CashMovementID", CashMovementID);
            cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);
            cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        
    }
}
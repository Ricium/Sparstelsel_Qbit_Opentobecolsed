using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class MoneyRepository
    {
        private MoneyUnitRepository murep = new MoneyUnitRepository();

        public List<Cash> GetCashMovementsOld()
        {
            //...Create New Instance of Object...
            List<Cash> list = new List<Cash>();
            Cash ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("select c.ActualDate, e.Name, m.MovementType "
                    + " ,COALESCE(SUM(c.Amount),0) as Cash "
                    + ",( "
                    + "	select COALESCE(SUM(p.Amount),0) from t_PickUp p  "
                    + "	where p.ActualDate = c.ActualDate "
                    + "	and p.Removed = 0 "
                    + "	and p.EmployeeID = c.EmployeeID "
                    + ") as Pickups "
                    + ",( "
                    + "	select COALESCE(SUM(el.Total),0) from t_ElectronicFund el  "
                    + "	where el.ActualDate = c.ActualDate "
                    + "	and el.Removed = 0 "
                    + "	and el.EmployeeID = c.EmployeeID "
                    + ") as Electronic "
                    + ",( "
                    + "	select COALESCE(SUM(r.Amount),0) from t_CashReconciliation r  "
                    + "	where r.ActualDate = c.ActualDate "
                    + "	and r.Removed = 0 "
                    + "	and r.EmployeeID = c.EmployeeID "
                    + ") as Recons "
                    + "from t_CashMovement c "
                    + "inner join l_MovementType m on c.MovementTypeID = m.MovementTypeID "
                    + "inner join Employee e on c.EmployeeID = e.EmployeeID  "
                    + "where c.Removed = 0 "
                    + "group by c.ActualDate, c.EmployeeID, e.Name, m.MovementType", con);

            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Cash();
                    ins.Date = Convert.ToDateTime(drI["ActualDate"]);
                    ins.EmployeeName = drI["Name"].ToString();
                    ins.TotalDeclared = Convert.ToDecimal(drI["TotalDeclared"]);
                    ins.CashExpected = Convert.ToDecimal(drI["CashExpected"]);
                    ins.TotalExpected = Convert.ToDecimal(drI["TotalExpected"]);
                    ins.CashOver = Convert.ToDecimal(drI["CashOver"]);
                    ins.MovementType = drI["MovementType"].ToString();
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<Cash> GetCashMovementsReport()
        {
            //...Create New Instance of Object...
            List<Cash> list = new List<Cash>();
            Cash ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand();
            cmdI.CommandTimeout = 540;
            cmdI.Connection = con;
            cmdI.CommandText = "f_Admin_Report_CashOver";
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;

            cmdI.Connection.Open();

            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Cash();
                    ins.Date = Convert.ToDateTime(drI["ActualDate"]);
                    ins.EmployeeName = drI["Name"].ToString();
                    ins.TotalDeclared = Convert.ToDecimal(drI["TotalDeclared"]);
                    ins.CashExpected = Convert.ToDecimal(drI["CashExpected"]);
                    ins.TotalExpected = Convert.ToDecimal(drI["TotalExpected"]);
                    ins.CashOver = Convert.ToDecimal(drI["CashOver"]);
                    ins.MovementType = drI["MovementType"].ToString();
                    list.Add(ins);
                }
            }

            //...Close Connections...
            cmdI.Connection.Close();
            con.Dispose();

            list = list.OrderBy(o => o.Date).ToList();
            //...Return...
            return list;
        }

        public List<CashMovement> GetCashMovements()
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT cm.*, mu.MoneyUnit, mt.MovementType, (e.Name + ' ' + e.Surname) as Employee "
            + " FROM t_CashMovement cm INNER JOIN l_MoneyUnit mu on cm.MoneyUnitID = mu.MoneyUnitID "
            + " INNER JOIN l_MovementType mt ON cm.MovementTypeID = mt.MovementTypeID "
            + " INNER JOIN Employee e on cm.EmployeeID = e.EmployeeID "
            + " WHERE cm.Removed = 0", con);

            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new CashMovement();
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.CashMovementID = Convert.ToInt32(drI["CashMovementID"]);
                    ins.employee = drI["Employee"].ToString();
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.moneyunit = drI["MoneyUnit"].ToString();
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                    ins.movementtype = drI["MovementType"].ToString();
                    ins.MovementTypeID = Convert.ToInt32(drI["MovementTypeID"]);
                    ins.ModifiedBy = drI["ModifiedBy"].ToString();
                    ins.Count = (int)(ins.Amount / murep.GetMoneyUnitValue(ins.MoneyUnitID));
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
            cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
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

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }
    }
}
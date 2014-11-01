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
                    ins.CashTypeID = Convert.ToInt32(drI["CashTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.UserTypeID = Convert.ToInt32(drI["UserTypeID"]);
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
            cmdI = new SqlCommand("SELECT cm.*,m.MoneyUnit,ct.CashType FROM t_CashMovement cm inner join l_MoneyUnit m on cm.MoneyUnitID=m.MoneyUnitID inner join l_CashType ct on cm.CashTypeID=ct.CashTypeID", con);
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
                    ins.cashtype = drI["CashType"].ToString();
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                    ins.moneyunit = drI["MoneyUnit"].ToString();
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.UserTypeID = Convert.ToInt32(drI["UserTypeID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<CashMovement> GetCashMovementsPerCashType(int CashTypeID)
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashMovement WHERE CashTypeID = " + CashTypeID, con);
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
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.UserTypeID = Convert.ToInt32(drI["UserTypeID"]);
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
                    ins.CashTypeID = Convert.ToInt32(drI["CashTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.UserTypeID = Convert.ToInt32(drI["UserTypeID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<CashMovement> GetCashMovementsPerEmployee(int UserID)
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_CashMovement WHERE UserID = " + UserID, con);
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
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.UserTypeID = Convert.ToInt32(drI["UserTypeID"]);
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
                    ins.CashTypeID = Convert.ToInt32(drI["CashTypeID"]);
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.UserTypeID = Convert.ToInt32(drI["UserTypeID"]);
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
            int UserID = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
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
                cmdI.Parameters.AddWithValue("@CashTypeID", ins.CashTypeID);
                cmdI.Parameters.AddWithValue("@MoneyUnitID", ins.MoneyUnitID);
                cmdI.Parameters.AddWithValue("@UserID", UserID);
                cmdI.Parameters.AddWithValue("@UserTypeID",0);

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
            cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
            cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
            cmdI.Parameters.AddWithValue("@CashTypeID", ins.CashTypeID);
            cmdI.Parameters.AddWithValue("@MoneyUnitID", ins.MoneyUnitID);
            cmdI.Parameters.AddWithValue("@UserID", EmployeeId);
        

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




        public List<CashMovement> GetAllCashMovementC()
        {
            //...Create New Instance of Object...
            List<CashMovement> list = new List<CashMovement>();
            CashMovement ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT cm.*,m.MoneyUnit,ct.CashType FROM t_CashMovement cm inner join l_MoneyUnit m on cm.MoneyUnitID=m.MoneyUnitID inner join l_CashType ct on cm.CashTypeID=ct.CashTypeID where cm.CashTypeID = 2", con);
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
                    ins.cashtype = drI["CashType"].ToString();
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                    ins.moneyunit = drI["MoneyUnit"].ToString();
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.UserTypeID = Convert.ToInt32(drI["UserTypeID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }
    }
}
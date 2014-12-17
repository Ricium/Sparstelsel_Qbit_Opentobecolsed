using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class MoneyUnitRepository
    {
        public MoneyUnit GetMoneyUnit(int MoneyUnitID)
        {
            //...Create New Instance of Object...
            MoneyUnit ins = new MoneyUnit();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM l_MoneyUnit WHERE MoneyUnitID =" + MoneyUnitID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                    ins.MoneyUnits = Convert.ToString(drI["MoneyUnit"]);
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

        public List<MoneyUnit> GetAllMoneyUnit()
        {
            //...Create New Instance of Object...
            List<MoneyUnit> list = new List<MoneyUnit>();
            MoneyUnit ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM l_MoneyUnit", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new MoneyUnit();
                    ins.MoneyUnitID = Convert.ToInt32(drI["MoneyUnitID"]);
                    ins.MoneyUnits = Convert.ToString(drI["MoneyUnit"]);
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

        public MoneyUnit Insert(MoneyUnit ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
             string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);
            string strTrx = "MoneyUnitIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.MoneyUnitInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@MoneyUnitID", ins.MoneyUnitID);             
                cmdI.Parameters.AddWithValue("@MoneyUnit", ins.MoneyUnits);
                cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
                cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
                cmdI.Parameters.AddWithValue("@ModifiedBy", 1);
                cmdI.Parameters.AddWithValue("@Removed", ins.Removed);

                //...Return new ID
                ins.MoneyUnitID = (int)cmdI.ExecuteScalar();

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

        public MoneyUnit Update(MoneyUnit ins)
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
            cmdI.CommandText = StoredProcedures.MoneyUnitUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@MoneyUnitID", ins.MoneyUnitID);
            cmdI.Parameters.AddWithValue("@MoneyUnit", ins.MoneyUnits);
            cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
            cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
            cmdI.Parameters.AddWithValue("@ModifiedBy", 1);
           


            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int MoneyUnitID)
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
            cmdI.CommandText = StoredProcedures.MoneyUnitRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@MoneyUnitID", MoneyUnitID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string MoneyUnitIds)
        {
            List<int> RemoveIds = MoneyUnitIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.MoneyUnitRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@MoneyUnitID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        }  
    }
}
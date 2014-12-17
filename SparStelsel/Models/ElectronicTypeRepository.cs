using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class ElectronicTypeRepository
    {
        public ElectronicType GetElectronicType(int ElectronicTypeID)
        {
            //...Create New Instance of Object...
            ElectronicType ins = new ElectronicType();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM ElectronicType WHERE ElectronicTypeID =" + ElectronicTypeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.ElectronicTypeID = Convert.ToInt32(drI["ElectronicTypeID"]);
                    ins.ElectronicTypes = Convert.ToString(drI["ElectronicType"]);
                    ins.ElectronicTypes = Convert.ToString(drI["ElectronicTypeDescription"]);
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

        public List<ElectronicType> GetAllElectronicType()
        {
            //...Create New Instance of Object...
            List<ElectronicType> list = new List<ElectronicType>();
            ElectronicType ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM l_ElectronicType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new ElectronicType();
                    ins.ElectronicTypeID = Convert.ToInt32(drI["ElectronicTypeID"]);
                    ins.ElectronicTypes = Convert.ToString(drI["ElectronicType"]);
                    ins.ElectronicTypes = Convert.ToString(drI["ElectronicTypeDescription"]);
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

        public ElectronicType Insert(ElectronicType ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
             string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);
            string strTrx = "ElectronicTypeIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.ElectronicTypeInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@ElectronicTypeID", ins.ElectronicTypeID);             
                cmdI.Parameters.AddWithValue("@ElectronicType", ins.ElectronicTypes);
                cmdI.Parameters.AddWithValue("@ElectronicTypeDescription", ins.ElectronicTypeDescription);
                cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
                cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
                cmdI.Parameters.AddWithValue("@ModifiedBy", 1);
                cmdI.Parameters.AddWithValue("@Removed", ins.Removed);

                //...Return new ID
                ins.ElectronicTypeID = (int)cmdI.ExecuteScalar();

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

        public ElectronicType Update(ElectronicType ins)
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
            cmdI.CommandText = StoredProcedures.ElectronicTypeUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@ElectronicTypeID", ins.ElectronicTypeID);
            cmdI.Parameters.AddWithValue("@ElectronicType", ins.ElectronicTypes);
            cmdI.Parameters.AddWithValue("@ElectronicTypeDescription", ins.ElectronicTypeDescription);
            cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
            cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
            cmdI.Parameters.AddWithValue("@ModifiedBy", 1);
         

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int ElectronicTypeID)
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
            cmdI.CommandText = StoredProcedures.ElectronicTypeRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@ElectronicTypeID", ElectronicTypeID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string ElectronicTypeIds)
        {
            List<int> RemoveIds = ElectronicTypeIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.ElectronicTypeRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@ElectronicTypeID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        } 
    }
}
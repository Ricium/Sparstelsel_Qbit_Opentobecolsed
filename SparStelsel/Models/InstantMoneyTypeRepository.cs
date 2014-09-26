using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class InstantMoneyTypeRepository
    {
        public InstantMoneyType GetInstantMoneyType(int InstantMoneyTypeID)
        {
            //...Create New Instance of Object...
            InstantMoneyType ins = new InstantMoneyType();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM InstantMoneyType WHERE InstantMoneyTypeID =" + InstantMoneyTypeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.InstantMoneyTypeID = Convert.ToInt32(drI["InstantMoneyTypeID"]);
                    ins.InstantMoneyType = Convert.ToChar(drI["InstantMoneyType"]);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return ins;
        }

        public List<InstantMoneyType> GetAllInstantMoneyType()
        {
            //...Create New Instance of Object...
            List<InstantMoneyType> list = new List<InstantMoneyType>();
            InstantMoneyType ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM l_InstantMoneyType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new InstantMoneyType();
                    ins.InstantMoneyTypeID = Convert.ToInt32(drI["InstantMoneyTypeID"]);
                    ins.InstantMoneyType = Convert.ToChar(drI["InstantMoneyType"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public InstantMoneyType Insert(InstantMoneyType ins)
        {
            //...Get User and Date Data...
            // string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            // int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
            // string strTrx = "KwikPayIns_" + EmployeeId;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();

            //...Command Interface...
            SqlCommand cmdI = con.CreateCommand();
            SqlTransaction trx;
            // trx = con.BeginTransaction(strTrx);
            cmdI.Connection = con;
            cmdI.Transaction = trx;

            try
            {
                //...Insert Record...
                cmdI.CommandText = StoredProcedures.InstantMoneyTypeInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@InstantMoneyTypeID", ins.InstantMoneyTypeID);             
                cmdI.Parameters.AddWithValue("@InstantMoneyType", ins.InstantMoneyType);

                //...Return new ID
                ins.InstantMoneyTypeID = (int)cmdI.ExecuteScalar();

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

        public InstantMoneyType Update(InstantMoneyType ins)
        {
            //...Get User and Date Data...
            // string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            // int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();
            SqlCommand cmdI = con.CreateCommand();
            cmdI.Connection = con;

            //...Update Record...
            cmdI.Parameters.Clear();
            cmdI.CommandText = StoredProcedures.InstantMoneyTypeUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@InstantMoneyTypeID", ins.InstantMoneyTypeID);
            cmdI.Parameters.AddWithValue("@InstantMoneyType", ins.InstantMoneyType);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int InstantMoneyTypeID)
        {
            //...Get User and Date Data...
            //string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            //int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();
            SqlCommand cmdI = con.CreateCommand();
            cmdI.Connection = con;

            //...Update Record...
            cmdI.Parameters.Clear();
            cmdI.CommandText = StoredProcedures.InstantMoneyTypeRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@InstantMoneyTypeID", InstantMoneyTypeID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string InstantMoneyTypeIds)
        {
            List<int> RemoveIds = InstantMoneyTypeIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.InstantMoneyTypeRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@InstantMoneyTypeID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        } 
    }
}
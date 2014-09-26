using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class CommentTypeRepository
    {
        public CommentType GetCommentType(int CommentTypeID)
        {
            //...Create New Instance of Object...
            CommentType ins = new CommentType();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM l_CommentType WHERE CommentTypeID =" + CommentTypeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.CommentTypeID = Convert.ToInt32(drI["CommentTypeID"]);
                    ins.CommentType = Convert.ToChar(drI["CommentType"]);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return ins;
        }

        public List<CommentType> GetAllCommentType()
        {
            //...Create New Instance of Object...
            List<CommentType> list = new List<CommentType>();
            CommentType ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM l_CommentType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new CommentType();
                    ins.CommentTypeID = Convert.ToInt32(drI["CommentTypeID"]);
                    ins.CommentType = Convert.ToChar(drI["CommentType"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public CommentType Insert(CommentType ins)
        {
            //...Get User and Date Data...
            // string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            // int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
            // string strTrx = "CommentTypeIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.CommentTypeInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@CommentTypeID", ins.CommentTypeID);             
                cmdI.Parameters.AddWithValue("@CommentType", ins.CommentType);

                //...Return new ID
                ins.CommentTypeID = (int)cmdI.ExecuteScalar();

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

        public CommentType Update(CommentType ins)
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
            cmdI.CommandText = StoredProcedures.CommentTypeUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@CommentTypeID", ins.CommentTypeID);
            cmdI.Parameters.AddWithValue("@CommentType", ins.CommentType);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int CommentTypeID)
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
            cmdI.CommandText = StoredProcedures.CommentTypeRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@CommentTypeID", CommentTypeID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string CommentTypeIds)
        {
            List<int> RemoveIds = CommentTypeIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.CommentTypeRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@CommentTypeID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        } 
    }
}
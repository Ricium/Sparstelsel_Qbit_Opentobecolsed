using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class UserRepository
    {
        public User GetUser(int UserID)
        {
            //...Create New Instance of Object...
            User ins = new User();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM User WHERE UserID =" + UserID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.UserName = Convert.ToChar(drI["UserName"]);
                    ins.UserSurname = Convert.ToChar(drI["UserSurname"]);
                    ins.ID = Convert.ToChar(drI["ID"]);
                    ins.UserCell = Convert.ToChar(drI["UserCell"]);
                    ins.UserEmail = Convert.ToChar(drI["UserEmail"]);
                    ins.UserTypeID = Convert.ToInt32(drI["UserTypeID"]);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return ins;
        }

        public List<User> GetAllUser()
        {
            //...Create New Instance of Object...
            List<User> list = new List<User>();
            User ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_User", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new User();
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.UserName = Convert.ToChar(drI["UserName"]);
                    ins.UserSurname = Convert.ToChar(drI["UserSurname"]);
                    ins.ID = Convert.ToChar(drI["ID"]);
                    ins.UserCell = Convert.ToChar(drI["UserCell"]);
                    ins.UserEmail = Convert.ToChar(drI["UserEmail"]);
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

        public List<User> GetUsersPerUser(int UserTypeID)
        {
            //...Create New Instance of Object...
            List<User> list = new List<User>();
            User ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_User WHERE UserTypeID = " + UserTypeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new User();
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.UserName = Convert.ToChar(drI["UserName"]);
                    ins.UserSurname = Convert.ToChar(drI["UserSurname"]);
                    ins.ID = Convert.ToChar(drI["ID"]);
                    ins.UserCell = Convert.ToChar(drI["UserCell"]);
                    ins.UserEmail = Convert.ToChar(drI["UserEmail"]);
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

        public User Insert(User ins)
        {
            //...Get User and Date Data...
            // string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            // int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
            // string strTrx = "UserIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.UserInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@UserID", ins.UserID);             
                cmdI.Parameters.AddWithValue("@UserName", ins.UserName);
                cmdI.Parameters.AddWithValue("@UserSurname", ins.UserSurname);
                cmdI.Parameters.AddWithValue("@ID", ins.ID);
                cmdI.Parameters.AddWithValue("@UserCell", ins.UserCell);
                cmdI.Parameters.AddWithValue("@UserEmail", ins.UserEmail);
                cmdI.Parameters.AddWithValue("@UserTypeID", ins.UserTypeID);

                //...Return new ID
                ins.UserID = (int)cmdI.ExecuteScalar();

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

        public User Update(User ins)
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
            cmdI.CommandText = StoredProcedures.UserUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@UserID", ins.UserID);
            cmdI.Parameters.AddWithValue("@UserName", ins.UserName);
            cmdI.Parameters.AddWithValue("@UserSurname", ins.UserSurname);
            cmdI.Parameters.AddWithValue("@ID", ins.ID);
            cmdI.Parameters.AddWithValue("@UserCell", ins.UserCell);
            cmdI.Parameters.AddWithValue("@UserEmail", ins.UserEmail);
            cmdI.Parameters.AddWithValue("@UserTypeID", ins.UserTypeID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int UserID)
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
            cmdI.CommandText = StoredProcedures.UserRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@UserID", UserID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string UserIds)
        {
            List<int> RemoveIds = UserIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.UserRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@UserID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class OrderRepository
    {
        public Order MovementType(int OrderID)
        {
            //...Create New Instance of Object...
            Order ins = new Order();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM MovementType WHERE OrderID =" + OrderID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.OrderID = Convert.ToInt32(drI["MovementTypeID"]);
                    ins.OrderDate = Convert.ToDateTime(drI["OrderDate"]);
                    ins.ExspectedDeliveryDate = Convert.ToDateTime(drI["ExspectedDeliveryDate"]);
                    ins.Amount = Convert.ToChar(drI["Amount"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
                    ins.EmployeeTypeID = Convert.ToInt32(drI["EmployeeTypeID"]);
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.CommentID = Convert.ToInt32(drI["CommentID"]);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return ins;
        }

        public List<Order> GetAllOrder()
        {
            //...Create New Instance of Object...
            List<Order> list = new List<Order>();
            Order ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_Order", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Order();
                    ins.OrderID = Convert.ToInt32(drI["OrderID"]);
                    ins.OrderDate = Convert.ToDateTime(drI["OrderDate"]);
                    ins.ExspectedDeliveryDate = Convert.ToDateTime(drI["ExspectedDeliveryDate"]);
                    ins.Amount = Convert.ToChar(drI["Amount"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
                    ins.EmployeeTypeID = Convert.ToInt32(drI["EmployeeTypeID"]);
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.CommentID = Convert.ToInt32(drI["CommentID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<Order> GetOrdersPerSupplier(int SupplierID)
        {
            //...Create New Instance of Object...
            List<Order> list = new List<Order>();
            Order ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_Order WHERE SupplierID = " + SupplierID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Order();
                    ins.OrderID = Convert.ToInt32(drI["OrderID"]);
                    ins.OrderDate = Convert.ToDateTime(drI["OrderDate"]);
                    ins.ExspectedDeliveryDate = Convert.ToDateTime(drI["ExspectedDeliveryDate"]);
                    ins.Amount = Convert.ToChar(drI["Amount"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
                    ins.EmployeeTypeID = Convert.ToInt32(drI["EmployeeTypeID"]);
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.CommentID = Convert.ToInt32(drI["CommentID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<Order> GetOrdersPerSupplierType(int SupplierTypeID)
        {
            //...Create New Instance of Object...
            List<Order> list = new List<Order>();
            Order ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_Order WHERE SupplierTypeID = " + SupplierTypeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Order();
                    ins.OrderID = Convert.ToInt32(drI["OrderID"]);
                    ins.OrderDate = Convert.ToDateTime(drI["OrderDate"]);
                    ins.ExspectedDeliveryDate = Convert.ToDateTime(drI["ExspectedDeliveryDate"]);
                    ins.Amount = Convert.ToChar(drI["Amount"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
                    ins.EmployeeTypeID = Convert.ToInt32(drI["EmployeeTypeID"]);
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.CommentID = Convert.ToInt32(drI["CommentID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<Order> GetOrdersPerEmployeeType(int EmployeeTypeID)
        {
            //...Create New Instance of Object...
            List<Order> list = new List<Order>();
            Order ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_Order WHERE EmployeeTypeID = " + EmployeeTypeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Order();
                    ins.OrderID = Convert.ToInt32(drI["OrderID"]);
                    ins.OrderDate = Convert.ToDateTime(drI["OrderDate"]);
                    ins.ExspectedDeliveryDate = Convert.ToDateTime(drI["ExspectedDeliveryDate"]);
                    ins.Amount = Convert.ToChar(drI["Amount"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
                    ins.EmployeeTypeID = Convert.ToInt32(drI["EmployeeTypeID"]);
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.CommentID = Convert.ToInt32(drI["CommentID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<Order> GetOrdersPerEmployee(int EmployeeID)
        {
            //...Create New Instance of Object...
            List<Order> list = new List<Order>();
            Order ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_Order WHERE EmployeeID = " + EmployeeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Order();
                    ins.OrderID = Convert.ToInt32(drI["OrderID"]);
                    ins.OrderDate = Convert.ToDateTime(drI["OrderDate"]);
                    ins.ExspectedDeliveryDate = Convert.ToDateTime(drI["ExspectedDeliveryDate"]);
                    ins.Amount = Convert.ToChar(drI["Amount"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
                    ins.EmployeeTypeID = Convert.ToInt32(drI["EmployeeTypeID"]);
                    ins.EmployeeID = Convert.ToInt32(drI["EmployeeID"]);
                    ins.CommentID = Convert.ToInt32(drI["CommentID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public Order Insert(Order ins)
        {
            //...Get User and Date Data...
            // string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            // int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
            // string strTrx = "OrderIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.OrderInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@OrderID", ins.OrderID);             
                cmdI.Parameters.AddWithValue("@OrderDate", ins.OrderDate);
                cmdI.Parameters.AddWithValue("@ExspectedDeliveryDate", ins.ExspectedDeliveryDate);
                cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
                cmdI.Parameters.AddWithValue("@SupplierID", ins.SupplierID);
                cmdI.Parameters.AddWithValue("@SupplierTypeID", ins.SupplierTypeID);
                cmdI.Parameters.AddWithValue("@EmployeeTypeID", ins.EmployeeTypeID);
                cmdI.Parameters.AddWithValue("@EmployeeID", ins.EmployeeID);
                cmdI.Parameters.AddWithValue("@CommentID", ins.CommentID);

                //...Return new ID
                ins.OrderID = (int)cmdI.ExecuteScalar();

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

        public Order Update(Order ins)
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
            cmdI.CommandText = StoredProcedures.OrderUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@MovementTypeID", ins.OrderID);
            cmdI.Parameters.AddWithValue("@OrderDate", ins.OrderDate);
            cmdI.Parameters.AddWithValue("@ExspectedDeliveryDate", ins.ExspectedDeliveryDate);
            cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
            cmdI.Parameters.AddWithValue("@SupplierID", ins.SupplierID);
            cmdI.Parameters.AddWithValue("@SupplierTypeID", ins.SupplierTypeID);
            cmdI.Parameters.AddWithValue("@EmployeeTypeID", ins.EmployeeTypeID);
            cmdI.Parameters.AddWithValue("@EmployeeID", ins.EmployeeID);
            cmdI.Parameters.AddWithValue("@CommentID", ins.CommentID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int OrderID)
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
            cmdI.CommandText = StoredProcedures.OrderRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@OrderID", OrderID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string OrderIds)
        {
            List<int> RemoveIds = OrderIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.OrderRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@OrderID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        } 
    }
}
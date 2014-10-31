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
        public Order GetOrders(int OrderID)
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
                    ins.OrderID = Convert.ToInt32(drI["OrderID"]);
                    ins.OrderDate = Convert.ToDateTime(drI["OrderDate"]);
                    ins.ExpectedDeliveryDate = Convert.ToDateTime(drI["ExpectedDeliveryDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.CommentID = Convert.ToInt32(drI["CommentID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
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
            cmdI = new SqlCommand("SELECT o.*,s.Supplier,st.SupplierType FROM t_Order o inner join t_Supplier s on o.SupplierID=s.SupplierID inner join t_SupplierType st on o.SupplierTypeID=st.SupplierTypeID", con);
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
                    ins.ExpectedDeliveryDate = Convert.ToDateTime(drI["ExpectedDeliveryDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.CommentID = Convert.ToInt32(drI["CommentID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
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
                    ins.ExpectedDeliveryDate = Convert.ToDateTime(drI["ExpectedDeliveryDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.CommentID = Convert.ToInt32(drI["CommentID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
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
                    ins.ExpectedDeliveryDate = Convert.ToDateTime(drI["ExpectedDeliveryDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.CommentID = Convert.ToInt32(drI["CommentID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
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

        public List<Order> GetOrdersPerEmployeeType(int UserTypeID)
        {
            //...Create New Instance of Object...
            List<Order> list = new List<Order>();
            Order ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_Order WHERE UserTypeID = " + UserTypeID, con);
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
                    ins.ExpectedDeliveryDate = Convert.ToDateTime(drI["ExpectedDeliveryDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.CommentID = Convert.ToInt32(drI["CommentID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
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

        public List<Order> GetOrdersPerEmployee(int UserID)
        {
            //...Create New Instance of Object...
            List<Order> list = new List<Order>();
            Order ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_Order WHERE UserID = " + UserID, con);
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
                    ins.ExpectedDeliveryDate = Convert.ToDateTime(drI["ExpectedDeliveryDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.UserID = Convert.ToInt32(drI["UserID"]);
                    ins.CommentID = Convert.ToInt32(drI["CommentID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToInt32(drI["ModifiedBy"]);
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

        public Order Insert(Order ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            int EmployeeId = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
            string strTrx = "OrderIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.OrderInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@OrderID", ins.OrderID);             
                cmdI.Parameters.AddWithValue("@OrderDate", ins.OrderDate);
                cmdI.Parameters.AddWithValue("@ExpectedDeliveryDate", ins.ExpectedDeliveryDate);
                cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
                cmdI.Parameters.AddWithValue("@CreatedDate", ins.CreatedDate);
                cmdI.Parameters.AddWithValue("@SupplierID", ins.SupplierID);
                cmdI.Parameters.AddWithValue("@UserID", ins.UserID);
                cmdI.Parameters.AddWithValue("@CommentID", ins.CommentID);
                cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
                cmdI.Parameters.AddWithValue("@ModifiedDate", ins.ModifiedDate);
                cmdI.Parameters.AddWithValue("@ModifiedBy", ins.ModifiedBy);
                cmdI.Parameters.AddWithValue("@Removed", ins.Removed);

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
                 cmdI.Parameters.AddWithValue("@OrderID", ins.OrderID);
                 cmdI.Parameters.AddWithValue("@OrderDate", ins.OrderDate);
                 cmdI.Parameters.AddWithValue("@ExpectedDeliveryDate", ins.ExpectedDeliveryDate);
                 cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
                 cmdI.Parameters.AddWithValue("@CreatedDate", ins.CreatedDate);
                 cmdI.Parameters.AddWithValue("@SupplierID", ins.SupplierID);
                 cmdI.Parameters.AddWithValue("@UserID", ins.UserID);
                 cmdI.Parameters.AddWithValue("@CommentID", ins.CommentID);
                 cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
                 cmdI.Parameters.AddWithValue("@ModifiedDate", ins.ModifiedDate);
                 cmdI.Parameters.AddWithValue("@ModifiedBy", ins.ModifiedBy);
                 cmdI.Parameters.AddWithValue("@Removed", ins.Removed);
                
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
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class SupplierRepository
    {
        public Supplier GetSupplier(int SupplierID)
        {
            //...Create New Instance of Object...
            Supplier ins = new Supplier();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT s.*, st.SupplierType FROM t_Supplier s INNER JOIN l_SupplierType st on s.SupplierTypeID = st.SupplierTypeID WHERE SupplierID =" + SupplierID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.Suppliers = (drI["Supplier"]).ToString();
                    ins.StockCondition = (drI["StockCondition"]).ToString();
                    ins.Term = Convert.ToString(drI["Term"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.FromFriday = Convert.ToBoolean(drI["FromFriday"]);
                    ins.suppliertypeid2 = drI["SupplierType"].ToString();
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return ins;
        }

        public Supplier GetSupplier(string SupplierName)
        {
            //...Create New Instance of Object...
            Supplier ins = new Supplier();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT s.*, st.SupplierType FROM t_Supplier s INNER JOIN l_SupplierType st on s.SupplierTypeID = st.SupplierTypeID WHERE s.Supplier ='" + SupplierName + "'", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.Suppliers = (drI["Supplier"]).ToString();
                    ins.StockCondition = (drI["StockCondition"]).ToString();
                    ins.Term = Convert.ToString(drI["Term"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.FromFriday = Convert.ToBoolean(drI["FromFriday"]);
                    ins.suppliertypeid2 = drI["SupplierType"].ToString();
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return ins;
        }

        public List<Supplier> GetAllSupplier()
        {
            //...Create New Instance of Object...
            List<Supplier> list = new List<Supplier>();
            Supplier ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT s.*,st.SupplierType FROM t_Supplier s inner join l_SupplierType st on s.SupplierTypeID=st.SupplierTypeID where s.Removed = 0 order by s.Supplier", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Supplier();
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.Suppliers = (drI["Supplier"]).ToString();
                    ins.StockCondition = (drI["StockCondition"]).ToString();
                    ins.Term = Convert.ToString(drI["Term"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
                    ins.suppliertypeid2 = drI["SupplierType"].ToString();
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.FromFriday = Convert.ToBoolean(drI["FromFriday"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<Supplier> GetSuppliersPerSupplierType(int SupplierTypeID)
        {
            //...Create New Instance of Object...
            List<Supplier> list = new List<Supplier>();
            Supplier ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_Supplier WHERE SupplierTypeID = " + SupplierTypeID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Supplier();
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.Suppliers = (drI["Supplier"]).ToString();
                    ins.StockCondition = (drI["StockCondition"]).ToString();
                    ins.Term = Convert.ToString(drI["Term"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
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

        public List<Supplier> GetSuppliersPerProduct(int ProductID)
        {
            //...Create New Instance of Object...
            List<Supplier> list = new List<Supplier>();
            Supplier ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_Supplier WHERE ProductID = " + ProductID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Supplier();
                    ins.SupplierID = Convert.ToInt32(drI["SupplierID"]);
                    ins.Suppliers = (drI["Supplier"]).ToString();
                    ins.StockCondition = (drI["StockCondition"]).ToString();
                    ins.Term = Convert.ToString(drI["Term"]);
                    ins.CreatedDate = Convert.ToDateTime(drI["CreatedDate"]);
                    ins.SupplierTypeID = Convert.ToInt32(drI["SupplierTypeID"]);
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

        public Supplier Insert(Supplier ins)
        {
            //...Get User and Date Data...
             string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
             string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);
             string strTrx = "SupplierIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.SupplierInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                //cmdI.Parameters.AddWithValue("@SupplierID", ins.SupplierID);             
                cmdI.Parameters.AddWithValue("@Supplier", ins.Suppliers);
                cmdI.Parameters.AddWithValue("@StockCondition", ins.StockCondition);
                cmdI.Parameters.AddWithValue("@Term", ins.Term);
                cmdI.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                cmdI.Parameters.AddWithValue("@SupplierTypeID", ins.SupplierTypeID);
                cmdI.Parameters.AddWithValue("@CompanyID", 1);
                cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
                cmdI.Parameters.AddWithValue("@ModifiedBy",EmployeeId);
                cmdI.Parameters.AddWithValue("@Removed", ins.Removed);
                cmdI.Parameters.AddWithValue("@FromFriday", ins.FromFriday);

                //...Return new ID
                ins.SupplierID = (int)cmdI.ExecuteScalar();

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

        public Supplier Update(Supplier ins)
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
            cmdI.CommandText = StoredProcedures.SupplierUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@SupplierID", ins.SupplierID);
            cmdI.Parameters.AddWithValue("@Supplier", ins.Suppliers);
            cmdI.Parameters.AddWithValue("@StockCondition", ins.StockCondition);
            cmdI.Parameters.AddWithValue("@Term", ins.Term);
            cmdI.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
            cmdI.Parameters.AddWithValue("@SupplierTypeID", ins.SupplierTypeID);
            cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);
            cmdI.Parameters.AddWithValue("@ModifiedDate",ModifiedDate);
           cmdI.Parameters.AddWithValue("@ModifiedBy",EmployeeId);
        

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int SupplierID)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            int EmployeeId = 1;//Convert.ToInt32(HttpContext.Current.Session["UserID"]);

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();
            SqlCommand cmdI = con.CreateCommand();
            cmdI.Connection = con;

            //...Update Record...
            cmdI.Parameters.Clear();
            cmdI.CommandText = StoredProcedures.SupplierRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@SupplierID", SupplierID);
            cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
	        cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);
            cmdI.Parameters.AddWithValue("@Removed", 1);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public void Remove(string SupplierIds)
        {
            List<int> RemoveIds = SupplierIds.Split(',').ToList().Select(int.Parse).ToList();

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
                cmdI.CommandText = StoredProcedures.SupplierRemove;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@SupplierID", ID);
                cmdI.ExecuteNonQuery();
            }

            cmdI.Connection.Close();
        }

        public int GetSupplierTerm(int SupplierID)
        {
            //...Create New Instance of Object...
            int Term = 0;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT Term FROM t_Supplier WHERE SupplierID =" + SupplierID, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
       
                    Term = Convert.ToInt32(drI["Term"]);

                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return Convert.ToInt32(Term);
        }
    }
}
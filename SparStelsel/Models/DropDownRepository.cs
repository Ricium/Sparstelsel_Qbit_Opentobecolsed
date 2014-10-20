using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Web;
using System.Web.Security;
using System.Globalization;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SparStelsel.Models
{
    public class DropDownRepository
    {
        public List<SelectListItem> GetSupplierTypeList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT SupplierTypeID,SupplierType FROM t_SupplierType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["SupplierType"].ToString();
                    result.Value = drI["SupplierTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetProductsList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT ProductID,Product FROM t_Product", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["Product"].ToString();
                    result.Value = drI["ProductID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }
        public List<SelectListItem> GetSupplierList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();

        
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT SupplierID,Supplier FROM t_Product", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["Supplier"].ToString();
                    result.Value = drI["SupplierID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }

        public List<SelectListItem> GetGRVTypeList()
        {
            List<SelectListItem> obj = new List<SelectListItem>();


            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("SELECT GRVTypeID,GRVType FROM l_GRVType", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    var result = new SelectListItem();
                    result.Text = drI["GRVType"].ToString();
                    result.Value = drI["GRVTypeID"].ToString();
                    obj.Add(result);
                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }
    }
}
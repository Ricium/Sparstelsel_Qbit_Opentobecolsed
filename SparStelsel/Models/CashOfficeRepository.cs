using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class CashOfficeRepository
    {
        DropDownRepository DDRep = new DropDownRepository();

        public CashOffice GetCashOffice(int id)
        {
            CashOffice ins = new CashOffice();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT o.*, m.MoneyUnit, co.CashOfficeType FROM t_CashOffice o inner join l_MoneyUnit m on o.MoneyUnitTypeID = m.MoneyUnitID inner join l_CashOfficeType co on o.CashOfficeTypeID = co.CashOfficeTypeID where o.Removed = 0 and o.CashOfficeID = " + id, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.CashOfficeID = Convert.ToInt32(drI["CashOfficeID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.cashofficetype = drI["CashOfficeType"].ToString();
                    ins.CashOfficeTypeID = Convert.ToInt32(drI["CashOfficeTypeID"]);
                    ins.CashStatus = Convert.ToInt32(drI["CashStatus"]);
                    ins.cashstatusindex = DDRep.GetCashOfficeStatus(ins.CashStatus);
                    ins.moneyunit = drI["MoneyUnit"].ToString();
                    ins.MoneyUnitTypeID = Convert.ToInt32(drI["MoneyUnitTypeID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return ins;
        }

        public List<CashOffice> GetAllCashOffice()
        {
            //...Create New Instance of Object...
            List<CashOffice> list = new List<CashOffice>();
            CashOffice ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT o.*, m.MoneyUnit, co.CashOfficeType FROM t_CashOffice o inner join l_MoneyUnit m on o.MoneyUnitTypeID = m.MoneyUnitID inner join l_CashOfficeType co on o.CashOfficeTypeID = co.CashOfficeTypeID where o.Removed = 0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new CashOffice();
                    ins.CashOfficeID = Convert.ToInt32(drI["CashOfficeID"]);
                    ins.ActualDate = Convert.ToDateTime(drI["ActualDate"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                    ins.cashofficetype = drI["CashOfficeType"].ToString();
                    ins.CashOfficeTypeID = Convert.ToInt32(drI["CashOfficeTypeID"]);
                    ins.CashStatus = Convert.ToInt32(drI["CashStatus"]);
                    ins.cashstatusindex = DDRep.GetCashOfficeStatus(ins.CashStatus);
                    ins.moneyunit = drI["MoneyUnit"].ToString();
                    ins.MoneyUnitTypeID = Convert.ToInt32(drI["MoneyUnitTypeID"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.CompanyID = Convert.ToInt32(drI["CompanyID"]);
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public CashOffice Insert(CashOffice ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            string UserID = HttpContext.Current.Session["Username"].ToString();
            string strTrx = "CashoffIns_" + UserID;
            DropDownRepository ddrep = new DropDownRepository();
            MoneyUnitRepository mRep = new MoneyUnitRepository();
            decimal moneyunit = mRep.GetMoneyUnitValue(ins.MoneyUnitTypeID);
            string cashstatus = ddrep.GetCashOfficeStatus(ins.CashStatus);
            if(cashstatus == "Sealed")
            {
                ins.Amount = ins.Amount;
            }
            else if (cashstatus == "Opened")
            {
                ins.Amount = ins.Amount * moneyunit;
            }
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
                cmdI.CommandText = StoredProcedures.CashOfficeInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;           
                cmdI.Parameters.AddWithValue("@CashOfficeTypeID", ins.CashOfficeTypeID);
                cmdI.Parameters.AddWithValue("@MoneyUnitTypeID", ins.MoneyUnitTypeID); 
                cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
                cmdI.Parameters.AddWithValue("@CashStatus" , ins.CashStatus);
                cmdI.Parameters.AddWithValue("@ModifiedBy", UserID);
                cmdI.Parameters.AddWithValue("@ModifiedDate" , ModifiedDate);
                cmdI.Parameters.AddWithValue("@ActualDate", ins.ActualDate);
                cmdI.Parameters.AddWithValue("@Removed", 0);
                cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);


                //...Return new ID
                ins.CashOfficeID = (int)cmdI.ExecuteScalar();

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

        public CashOffice Update(CashOffice ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            string EmployeeId = HttpContext.Current.Session["Username"].ToString();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            con.Open();
            SqlCommand cmdI = con.CreateCommand();
            cmdI.Connection = con;

            //...Update Record...
            cmdI.Parameters.Clear();
            cmdI.CommandText = StoredProcedures.CashOfficeUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@CashOfficeID", ins.CashOfficeID);
            cmdI.Parameters.AddWithValue("@CashOfficeTypeID", ins.CashOfficeTypeID);
            cmdI.Parameters.AddWithValue("@MoneyUnitTypeID", ins.MoneyUnitTypeID);
            cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
            cmdI.Parameters.AddWithValue("@CashStatus", ins.CashStatus);
            cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);
            cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
            cmdI.Parameters.AddWithValue("@ActualDate", ins.ActualDate);
            cmdI.Parameters.AddWithValue("@Removed", 0);
            cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);


            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public void Remove(int ID)
        {
            CashOffice ins = GetCashOffice(ID);

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
            cmdI.CommandText = StoredProcedures.CashOfficeUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@CashOfficeID", ins.CashOfficeID);
            cmdI.Parameters.AddWithValue("@CashOfficeTypeID", ins.CashOfficeTypeID);
            cmdI.Parameters.AddWithValue("@MoneyUnitTypeID", ins.MoneyUnitTypeID);
            cmdI.Parameters.AddWithValue("@Amount", ins.Amount);
            cmdI.Parameters.AddWithValue("@CashStatus", ins.CashStatus);
            cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);
            cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
            cmdI.Parameters.AddWithValue("@ActualDate", ins.ActualDate);
            cmdI.Parameters.AddWithValue("@Removed", 1);
            cmdI.Parameters.AddWithValue("@CompanyID", ins.CompanyID);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }
    }
}
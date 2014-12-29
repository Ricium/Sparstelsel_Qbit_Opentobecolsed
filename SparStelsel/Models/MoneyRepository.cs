using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class MoneyRepository
    {
        /*
         */

        public List<Cash> GetCashMovementsOld()
        {
            //...Create New Instance of Object...
            List<Cash> list = new List<Cash>();
            Cash ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("select c.ActualDate, e.Name, m.MovementType "
                    + " ,COALESCE(SUM(c.Amount),0) as Cash "
                    + ",( "
                    + "	select COALESCE(SUM(p.Amount),0) from t_PickUp p  "
                    + "	where p.ActualDate = c.ActualDate "
                    + "	and p.Removed = 0 "
                    + "	and p.EmployeeID = c.EmployeeID "
                    + ") as Pickups "
                    + ",( "
                    + "	select COALESCE(SUM(el.Total),0) from t_ElectronicFund el  "
                    + "	where el.ActualDate = c.ActualDate "
                    + "	and el.Removed = 0 "
                    + "	and el.EmployeeID = c.EmployeeID "
                    + ") as Electronic "
                    + ",( "
                    + "	select COALESCE(SUM(r.Amount),0) from t_CashReconciliation r  "
                    + "	where r.ActualDate = c.ActualDate "
                    + "	and r.Removed = 0 "
                    + "	and r.EmployeeID = c.EmployeeID "
                    + ") as Recons "
                    + "from t_CashMovement c "
                    + "inner join l_MovementType m on c.MovementTypeID = m.MovementTypeID "
                    + "inner join Employee e on c.EmployeeID = e.EmployeeID  "
                    + "where c.Removed = 0 "
                    + "group by c.ActualDate, c.EmployeeID, e.Name, m.MovementType", con);

            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Cash();
                    ins.Date = Convert.ToDateTime(drI["ActualDate"]);
                    ins.EmployeeName = drI["Name"].ToString();
                    ins.TotalDeclared = Convert.ToDecimal(drI["TotalDeclared"]);
                    ins.CashExpected = Convert.ToDecimal(drI["CashExpected"]);
                    ins.TotalExpected = Convert.ToDecimal(drI["TotalExpected"]);
                    ins.CashOver = Convert.ToDecimal(drI["CashOver"]);
                    ins.MovementType = drI["MovementType"].ToString();
                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public List<Cash> GetCashMovements()
        {
            //...Create New Instance of Object...
            List<Cash> list = new List<Cash>();
            Cash ins;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand();
            cmdI.CommandTimeout = 540;
            cmdI.Connection = con;
            cmdI.CommandText = "f_Admin_Report_CashOver";
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;

            cmdI.Connection.Open();

            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new Cash();
                    ins.Date = Convert.ToDateTime(drI["ActualDate"]);
                    ins.EmployeeName = drI["Name"].ToString();
                    ins.TotalDeclared = Convert.ToDecimal(drI["TotalDeclared"]);
                    ins.CashExpected = Convert.ToDecimal(drI["CashExpected"]);
                    ins.TotalExpected = Convert.ToDecimal(drI["TotalExpected"]);
                    ins.CashOver = Convert.ToDecimal(drI["CashOver"]);
                    ins.MovementType = drI["MovementType"].ToString();
                    list.Add(ins);
                }
            }

            //...Close Connections...
            cmdI.Connection.Close();
            con.Dispose();

            list = list.OrderBy(o => o.Date).ToList();
            //...Return...
            return list;
        }
    }
}
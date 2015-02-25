using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public struct InvoiceNumberGRVType
    {
        public int GRVTypeId;
        public string InvoiceNumber;
    }

    public class SparReconRepository
    {
        public List<SparInvoiceRecon> GetRecons()
        {
            //...Create New Instance of Object...
            List<SparInvoiceRecon> list = new List<SparInvoiceRecon>();
            SparInvoiceRecon ins;

            int GRVType = 0;
            string GRVInvoice = "";
            decimal GRVAmount = 0;

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("select sr.*, COALESCE(g.IncludingVat,0) as GRVAmount, COALESCE(g.GRVTypeID,0) as GRVGRVType, COALESCE(g.InvoiceNumber,'No') as GRVInvoice "
                                    + " from t_SparRecon sr left join t_GRVList g on sr.InvoiceNumber = g.InvoiceNumber and sr.GRVTypeId = g.GRVTypeID "
            + " where sr.Removed = 0 order by sr.StateDate DESC, sr.SparReconId DESC", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins = new SparInvoiceRecon();
                    ins.SparReconId = Convert.ToInt32(drI["SparReconId"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.InvoiceNumber = drI["InvoiceNumber"].ToString();
                    ins.GRVTypeId = Convert.ToInt32(drI["GRVTypeId"]);
                    ins.CompanyId = Convert.ToInt32(drI["CompanyId"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.SupplierId = Convert.ToInt32(drI["SupplierId"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);

                    GRVInvoice = drI["GRVInvoice"].ToString();
                    GRVType = Convert.ToInt32(drI["GRVGRVType"]);
                    GRVAmount = Convert.ToDecimal(drI["GRVAmount"]);

                    ins.Status = GetReconStatus(ins, GRVAmount, GRVType, GRVInvoice);

                    list.Add(ins);
                }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return list;
        }

        public string GetReconStatus(SparInvoiceRecon ins, decimal GRVAmount, int GRVType, string InvoiceNumber)
        {
            string ret = "Matched";

            if (ins.GRVTypeId == 3)
            {
                ret = "GRV Type not specified in Invoice Recon";
            }
            else
            {
                if (!ins.InvoiceNumber.Equals(InvoiceNumber))
                {
                    ret = "Not matched to GRV";
                }
                else
                {
                    if (ins.GRVTypeId != GRVType)
                    {
                        ret = "GRV Types do not match";
                    }
                    else
                    {
                        if (ins.Amount != GRVAmount)
                        {
                            decimal dif = ins.Amount - GRVAmount;
                            if (dif < 0)
                            {
                                if (GRVAmount < 0)
                                {
                                    ret = "Spar Recon Amount greater than GRV Amount (R" + dif.ToString() + ")";
                                }
                                else
                                {
                                    ret = "GRV Amount greater than Spar Recon Amount (R" + (dif * -1).ToString() + ")";
                                }
                            }
                            else
                            {
                                if (GRVAmount < 0)
                                {
                                    ret = "GRV Amount greater than Spar Recon Amount (R" + (dif * -1).ToString() + ")";
                                }
                                else
                                {
                                    ret = "Spar Recon Amount greater than GRV Amount (R" + dif.ToString() + ")";
                                }
                                
                            }
                        }
                    }
                }
            }
            return ret;
        }

        public string GetReconStatus(decimal ReconAmount, int ReconType, string ReconInvoiceNumber, decimal GRVAmount, int GRVType, string InvoiceNumber)
        {
            string ret = "Matched";

            if (ReconType == 3)
            {
                ret = "GRV Type not specified in Invoice Recon";
            }
            else
            {
                if (!ReconInvoiceNumber.Equals(InvoiceNumber))
                {
                    ret = "Not matched to GRV";
                }
                else
                {
                    if (ReconType != GRVType)
                    {
                        ret = "GRV Types do not match";
                    }
                    else
                    {
                        if (ReconAmount != GRVAmount)
                        {
                            decimal dif = ReconAmount - GRVAmount;
                            if (dif < 0)
                            {
                                if (GRVAmount < 0)
                                {
                                    ret = "Spar Recon Amount greater than GRV Amount (R" + dif.ToString() + ")";
                                }
                                else
                                {
                                    ret = "GRV Amount greater than Spar Recon Amount (R" + (dif * -1).ToString() + ")";
                                }
                            }
                            else
                            {
                                if (GRVAmount < 0)
                                {
                                    ret = "GRV Amount greater than Spar Recon Amount (R" + (dif * -1).ToString() + ")";
                                }
                                else
                                {
                                    ret = "Spar Recon Amount greater than GRV Amount (R" + dif.ToString() + ")";
                                }

                            }
                        }
                    }
                }
            }
            return ret;
        }
            
        

        public SparInvoiceRecon GetRecon(int SparReconId)
        {
            //...Create New Instance of Object...
            SparInvoiceRecon ins = new SparInvoiceRecon();

            //...Database Connection...
            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI;

            //...SQL Commands...
            cmdI = new SqlCommand("SELECT * FROM t_SparRecon s WHERE s.Removed=0 AND s.SparReconId="+SparReconId, con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            //...Retrieve Data...
            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    ins.SparReconId = Convert.ToInt32(drI["SparReconId"]);
                    ins.StateDate = Convert.ToDateTime(drI["StateDate"]);
                    ins.InvoiceNumber = drI["InvoiceNumber"].ToString();
                    ins.GRVTypeId = Convert.ToInt32(drI["GRVTypeId"]);
                    ins.CompanyId = Convert.ToInt32(drI["CompanyId"]);
                    ins.ModifiedDate = Convert.ToDateTime(drI["ModifiedDate"]);
                    ins.ModifiedBy = Convert.ToString(drI["ModifiedBy"]);
                    ins.Removed = Convert.ToBoolean(drI["Removed"]);
                    ins.SupplierId = Convert.ToInt32(drI["SupplierId"]);
                    ins.Amount = Convert.ToDecimal(drI["Amount"]);
                 }
            }

            //...Close Connections...
            drI.Close();
            con.Close();


            //...Return...
            return ins;
        }

        public SparInvoiceRecon Insert(SparInvoiceRecon ins)
        {
            //...Get User and Date Data...
            string ModifiedDate = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            string EmployeeId = Convert.ToString(HttpContext.Current.Session["Username"]);
            string strTrx = "SparReconIns_" + EmployeeId;

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
                cmdI.CommandText = StoredProcedures.SparReconInsert;
                cmdI.CommandType = System.Data.CommandType.StoredProcedure;
                cmdI.Parameters.AddWithValue("@StateDate", ins.StateDate);              // datetime
		        cmdI.Parameters.AddWithValue("@SupplierId", ins.SupplierId);        // int
		        cmdI.Parameters.AddWithValue("@InvoiceNumber", ins.InvoiceNumber);  // varchar(100)
		        cmdI.Parameters.AddWithValue("@Amount", ins.Amount);                //  decimal(18,2)
		        cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);            // varchar(100)
		        cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);        // datetime
		        cmdI.Parameters.AddWithValue("@CompanyId", 1);                      // int
                cmdI.Parameters.AddWithValue("@GRVTypeId", ins.GRVTypeId);          // int	

                //...Return new ID
                ins.SparReconId = (int)cmdI.ExecuteScalar();

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

        public SparInvoiceRecon Update(SparInvoiceRecon ins)
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
            cmdI.CommandText = StoredProcedures.SparReconUpdate;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@SparReconId", ins.SparReconId);      // int
            cmdI.Parameters.AddWithValue("@StateDate", ins.StateDate);              // datetime
            cmdI.Parameters.AddWithValue("@SupplierId", ins.SupplierId);        // int
            cmdI.Parameters.AddWithValue("@InvoiceNumber", ins.InvoiceNumber);  // varchar(100)
            cmdI.Parameters.AddWithValue("@Amount", ins.Amount);                //  decimal(18,2)
            cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);            // varchar(100)
            cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);        // datetime
            cmdI.Parameters.AddWithValue("@CompanyId", 1);                      // int
            cmdI.Parameters.AddWithValue("@GRVTypeId", ins.GRVTypeId);          // int	


            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();

            return ins;

        }

        public InvoiceNumberGRVType FilterInvoiceNumber(string InvoiceNumber)
        {
            InvoiceNumberGRVType data = new InvoiceNumberGRVType();

            if(InvoiceNumber.Contains(" - GRV"))
            {
                data.InvoiceNumber = InvoiceNumber.Replace(" - GRV", "");
                data.GRVTypeId = 1;
            }
            else
            {
                if (InvoiceNumber.Contains(" - CLM"))
                {
                    data.InvoiceNumber = InvoiceNumber.Replace(" - CLM", "");
                    data.GRVTypeId = 2;
                }
                else
                {
                    data.InvoiceNumber = InvoiceNumber;
                    data.GRVTypeId = 3;
                }
            }

            return data;
        }

        public void Remove(int SparReconId)
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
            cmdI.CommandText = StoredProcedures.SparReconRemove;
            cmdI.CommandType = System.Data.CommandType.StoredProcedure;
            cmdI.Parameters.AddWithValue("@SparReconId", SparReconId);
            cmdI.Parameters.AddWithValue("@ModifiedBy", EmployeeId);
            cmdI.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
            cmdI.Parameters.AddWithValue("@Removed", 1);

            cmdI.ExecuteNonQuery();
            cmdI.Connection.Close();
        }

        public List<string> GetAutoCompleteInvoiceNumbers(DateTime date, int SupplierId)
        {
            List<string> obj = new List<string>();

            DataBaseConnection dbConn = new DataBaseConnection();
            SqlConnection con = dbConn.SqlConn();
            SqlCommand cmdI = new SqlCommand("Select g.InvoiceNumber, g.GRVTypeID from t_GRVList g left join t_SparRecon sr on g.InvoiceNumber=sr.InvoiceNumber and g.GRVTypeID = sr.GRVTypeId "
            + " where g.StateDate = '" + date.ToShortDateString() + "' and g.SupplierID = " + SupplierId 
            + " and COALESCE(sr.SparReconId,0) = 0 and g.Removed =0", con);
            cmdI.Connection.Open();
            SqlDataReader drI = cmdI.ExecuteReader();

            if (drI.HasRows)
            {
                while (drI.Read())
                {
                    if (Convert.ToInt16(drI["GRVTypeID"]) == 1)
                    {
                        obj.Add(drI["InvoiceNumber"].ToString() + " - GRV");
                    }
                    else
                    {
                        obj.Add(drI["InvoiceNumber"].ToString() + " - CLM");
                    }

                }
            }
            drI.Close();
            con.Close();
            con.Dispose();

            return obj;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SparStelsel.Models
{
    public class CashierDayEnd
    {
        public DateTime ActualDate { get; set; }
        public int EmployeeID { get; set; }

        public DateTime ReportActualDate { get; set; }
        public int ReportEmployeeID { get; set; }

        public CashMovementMultiple CashMovements { get; set; }
        public ElectronicFund ElectronicFund { get; set; }
        public CashReconciliation SigmaSale { get; set; }
        public CashierDayEndReport Report { get; set; }
    }
}
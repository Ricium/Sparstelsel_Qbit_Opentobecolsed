using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{
    public class YearMonthQuery
    {
        public int Month { get; set; }
        public int Year { get; set; }
    }

    public class DateTimeFromToQuery
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }

    public class NumericalRangeQuery
    {
        public int From { get; set; }
        public int To { get; set; }
    }

    public class OrdervsGRVReport
    {
        public string Day { get; set; }
        public string Date { get; set; }
        public string OrderTotal { get; set; }
        public string FridayOrderTotal { get; set; }
        public string GRVTotal { get; set; }
        public string FridayGRVTotal { get; set; }
    }

    public class PinkslipOrderReport
    {
        public string PinkslipNumber { get; set; }
        public string OrderDate { get; set; }
        public string ExpectedDeliveryDate { get; set; }
        public string OrderTotal { get; set; }
        public string Supplier { get; set; }
    }

    public class PinkslipGRVReport
    {
        public string PinkslipNumber { get; set; }
        public string GRVDate { get; set; }
        public string GRVTotal { get; set; }
        public string OrderTotal { get; set; }
        public string OrderDate { get; set; }
        public string Supplier { get; set; }
    }

    public class PaymentQuery
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string PinkSlip { get; set; }
        public string Paymenthod { get; set; }
        public string Supplier { get; set; }
    }

    public class PaymentReport
    {
        public string InvoiceNumber { get; set; }
        public string PinkSlipNumber { get; set; }
        public string ExpectedPayDate { get; set; }
        public string PayDate { get; set; }
        public string InvoiceDate { get; set; }
        public string StateDate { get; set; }
        public string ActualDate { get; set; }
        public string PaymentDescription { get; set; }
        public string CashType { get; set; }
        public string ExcludingVat { get; set; }
        public string IncludingVat { get; set; }
        public string Amount { get; set; }
        public string Supplier { get; set; }
    }

    public class DayEndCashupQuery
    {
        public DateTime Date { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal PettyCash { get; set; }
        public decimal SigmaCardsExpected { get; set; }
    }

    public class DayEndCashupReport
    {
        public decimal SigmaTotal { get; set; }
        public decimal CounterTotal { get; set; }
        public decimal Change { get; set; }
        public decimal SassaTotal { get; set; }
        public decimal Cashbox { get; set; }
        public decimal Transits { get; set; }
        public decimal ActualCash { get; set; }
        public decimal CashReceived { get; set; }
        public decimal StartUpFloats { get; set; }
        public decimal DeclaredSlips { get; set; }
        public decimal CashDeclared { get; set; }
    }

}
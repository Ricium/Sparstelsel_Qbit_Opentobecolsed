using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SparStelsel.Models
{
    #region BasicQueries
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
    #endregion

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

    public class CashOfficeReport
    {
        public string MoneyUnit { get; set; }
        public decimal Sealed { get; set; }
        public decimal Opened { get; set; }
        public decimal TotalInOffice { get; set; }
        public decimal CashierTotal { get; set; }
        public decimal Drop { get; set; }
        public decimal Pickups { get; set; }
    }

    public class CashierReportQuery
    {
        public int Cashier { get; set; }
        public int CashupType { get; set; }
        public DateTime Date { get; set; }
    }

    public class CashierReport
    {
        public Cashier Cashier { get; set; }
        public List<CashMovement> CashMovements { get; set; }
        public List<ElectronicFund> ElectronicFunds { get; set; }
        public List<PickUp> Pickups { get; set; }
        public List<CashReconciliation> Recons { get; set; }
        public List<InstantMoney> InstantMoney { get; set; }
        public List<FNB> FNB { get; set; }
        public List<KwikPay> KwikPays { get; set; }

        public decimal CashTotal { get; set; }
        public decimal CardsTotal { get; set; }
        public decimal ChequeTotal { get; set; }
        public decimal SassaTotal { get; set; }
        public decimal PickupTotal { get; set; }
        public decimal FloatTotal { get; set; }
        public decimal ExtraFloatTotal { get; set; }
        public decimal SigmaTotal { get; set; }
        public decimal IMFloatTotal { get; set; }
        public decimal IMRecTotal { get; set; }
        public decimal IMPaidTotal { get; set; }
        public decimal FNBRefTotal { get; set; }
        public decimal FNBRetTotal { get; set; }
        public decimal ElecTotal { get; set; }
        public decimal AirTotal { get; set; }
        public decimal AccTotal { get; set; }

        public int CashierId { get; set; }
        public DateTime ReportDate { get; set; }
    }

    public class CashierDayEndReport
    {
        public Cashier Cashier { get; set; }
        public List<CashMovement> CashMovements { get; set; }
        public List<ElectronicFund> ElectronicFunds { get; set; }
        public List<PickUp> Pickups { get; set; }
        public List<CashReconciliation> Recons { get; set; }

        public decimal CashTotal { get; set; }
        public decimal CardsTotal { get; set; }
        public decimal ChequeTotal { get; set; }
        public decimal SassaTotal { get; set; }
        public decimal PickupTotal { get; set; }
        public decimal FloatTotal { get; set; }
        public decimal ExtraFloatTotal { get; set; }
        public decimal SigmaTotal { get; set; }
        
        public int CashierId { get; set; }
        public DateTime ReportDate { get; set; }
    }
    public class CashierKwikpayReport
    {
        public Cashier Cashier { get; set; }
        public List<CashMovement> CashMovements { get; set; }
        public List<ElectronicFund> ElectronicFunds { get; set; }
        public List<PickUp> Pickups { get; set; }
        public List<CashReconciliation> Recons { get; set; }
        public List<KwikPay> Kwikpay { get; set; }

        public decimal CashTotal { get; set; }
        public decimal CardsTotal { get; set; }
        public decimal ChequeTotal { get; set; }
        public decimal SassaTotal { get; set; }
        public decimal PickupTotal { get; set; }
        public decimal FloatTotal { get; set; }
        public decimal ExtraFloatTotal { get; set; }
        public decimal SigmaTotal { get; set; }

        public decimal ElectricityTotal { get; set; }
        public decimal AirTimeTotal { get; set; }
        public decimal AccountPaymentTotal { get; set; }
        public int CashierId { get; set; }
        public DateTime ReportDate { get; set; }
    }

    public class CashierInstantMoneyReport
    {
        public Cashier Cashier { get; set; }
        public List<CashMovement> CashMovements { get; set; }
        public List<ElectronicFund> ElectronicFunds { get; set; }
        public List<PickUp> Pickups { get; set; }
        public List<CashReconciliation> Recons { get; set; }
        public List<InstantMoney> IM { get; set; }

        public decimal CashTotal { get; set; }
        public decimal CardsTotal { get; set; }
        public decimal ChequeTotal { get; set; }
        public decimal SassaTotal { get; set; }
        public decimal PickupTotal { get; set; }
        public decimal FloatTotal { get; set; }
        public decimal ExtraFloatTotal { get; set; }
        public decimal SigmaTotal { get; set; }

      
        public decimal RecievedTotal { get; set; }
        public decimal PaidTotal { get; set; }

        public int CashierId { get; set; }
        public DateTime ReportDate { get; set; }
    }

    public class CashierFNBReport
    {
        public Cashier Cashier { get; set; }
        public List<CashMovement> CashMovements { get; set; }
        public List<ElectronicFund> ElectronicFunds { get; set; }
        public List<FNB> FNBs { get; set; }
        public List<PickUp> Pickups { get; set; }
        public List<CashReconciliation> Recons { get; set; }

        public decimal CashTotal { get; set; }
        public decimal CardsTotal { get; set; }
        public decimal ChequeTotal { get; set; }
        public decimal SassaTotal { get; set; }
        public decimal PickupTotal { get; set; }
        public decimal FloatTotal { get; set; }
        public decimal ExtraFloatTotal { get; set; }
        public decimal ReferenceTotal { get; set; }
        public decimal RefundTotal { get; set; }


        public int CashierId { get; set; }
        public DateTime ReportDate { get; set; }
    }
    public class SparReconReport
    {
        public string GRVInvoiceNumber { get; set; }
        public string StateDate { get; set; }
        public string GRVPayDate { get; set; }
        public string GRVPinkSlipNumber { get; set; }
        public string GRVExVAT { get; set; }
        public string GRVInVAT { get; set; }
        public string GRVType { get; set; }

        public string ReconInvoiceNumber { get; set; }
        public string ReconDate { get; set; }
        public string ReconType { get; set; }
        public string ReconAmount { get; set; }

        public string Supplier { get; set; }
        public string Status { get; set; }
    }

}
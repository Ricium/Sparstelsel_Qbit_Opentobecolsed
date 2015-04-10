<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CashierKwikpay>" %>
<%@ Import Namespace ="SparStelsel" %>
<%@ Import Namespace="SparStelsel.Models" %>
<%@ Import Namespace="SparStelsel.Controllers" %>
<!DOCTYPE html>
<html>
    <head id="Head1" runat="server">
    <title></title>    
    </head>
    <body>
        <fieldset>
            <legend>Totals</legend>
            <table>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.CashTotal) %>
                    </td>
                    <td>R</td>
                    <td style="text-align: right;">
                        <%: Html.DisplayFor(m => m.Report.CashTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.ElectricityTotal) %>
                    </td>
                    <td>R</td>
                    <td style="text-align: right;">
                        <%: Html.DisplayFor(m => m.Report.ElectricityTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.AirTimeTotal) %>
                    </td>
                    <td>R</td>
                    <td style="text-align: right;">
                        <%: Html.DisplayFor(m => m.Report.AirTimeTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.CardsTotal) %>
                    </td>
                    <td>R</td>
                    <td style="text-align: right;">
                        <%: Html.DisplayFor(m => m.Report.CardsTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.ChequeTotal) %>
                    </td>
                    <td>R</td>
                    <td style="text-align: right;">
                        <%: Html.DisplayFor(m => m.Report.ChequeTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.AccountPaymentTotal) %>
                    </td>
                    <td>R</td>
                    <td style="text-align: right;">
                        <%: Html.DisplayFor(m => m.Report.AccountPaymentTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        Day End Total
                    </td>
                    <td>R</td>
                    <td style="text-align: right; width: 75px; border-bottom: double; border-top: solid">
                        <%: Html.DisplayFor(m => m.Report.Final) %>
                    </td>
                </tr>                
            </table>
            <% using (Html.BeginForm("_KwikpayDayEndReportPDF", "Money", FormMethod.Post, new { target = "new" }))
               {%>
            <%: Html.HiddenFor(m => m.ReportEmployeeID)%>
            <%: Html.HiddenFor(m => m.ReportActualDate)%>
            <button type="submit" class="t-button">Print</button>
            <%} %>
        </fieldset>
    </body>    
</html>


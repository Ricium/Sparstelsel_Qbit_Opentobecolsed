<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CashierInstantMoney>" %>
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
                        Start up Float
                    </td>
                    <td>R</td>
                    <td style="text-align: right;">
                        <%: Html.DisplayFor(m => m.Report.FloatTotal) %>
                    </td>
                    </tr>
                <tr>
                <tr>
                    <td>
                        Extra Float
                    </td>
                    <td>R</td>
                    <td style="text-align: right;">
                        <%: Html.DisplayFor(m => m.Report.ExtraFloatTotal) %>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.RecievedTotal) %>
                    </td>
                    <td>R</td>
                    <td style="text-align: right;">
                        <%: Html.DisplayFor(m => m.Report.RecievedTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.PaidTotal) %>
                    </td>
                    <td>R</td>
                    <td style="text-align: right;">
                        <%: Html.DisplayFor(m => m.Report.PaidTotal) %>
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
                        Day End Total
                    </td>
                    <td>R</td>
                    <td style="text-align: right; width: 75px; border-bottom: double; border-top: solid">
                        <%: Html.DisplayFor(m => m.Report.Final) %>
                    </td>
                </tr>


         
            </table>
            <% using (Html.BeginForm("_IMDayEndReportPDF", "Money", FormMethod.Post, new { target = "new" }))
               {%>
            <%: Html.HiddenFor(m => m.ReportEmployeeID)%>
            <%: Html.HiddenFor(m => m.ReportActualDate)%>
            <button type="submit" class="t-button">Print</button>
            <%} %>
        </fieldset>
    </body>    
</html>


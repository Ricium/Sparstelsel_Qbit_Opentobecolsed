<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CashierDayEnd>" %>
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
                    <td>
                        R
                    </td>
                    <td style="text-align:right">
                        <%: Html.DisplayFor(m => m.Report.CashTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.SigmaTotal) %>
                    </td>
                    <td>
                        R
                    </td>
                    <td style="text-align:right">
                        <%: Html.DisplayFor(m => m.Report.SigmaTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.SassaTotal) %>
                    </td>
                    <td>
                        R
                    </td>
                    <td style="text-align:right">
                        <%: Html.DisplayFor(m => m.Report.SassaTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.CardsTotal) %>
                    </td>
                    <td>
                        R
                    </td>
                    <td style="text-align:right">
                        <%: Html.DisplayFor(m => m.Report.CardsTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.ChequeTotal) %>
                    </td>
                    <td>
                        R
                    </td>
                    <td style="text-align:right">
                        <%: Html.DisplayFor(m => m.Report.ChequeTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.PickupTotal) %>
                    </td>
                    <td>
                        R
                    </td>
                    <td style="text-align:right">
                        <%: Html.DisplayFor(m => m.Report.PickupTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.FloatTotal) %>
                    </td>
                    <td>
                        R
                    </td>
                    <td style="text-align:right">
                        <%: Html.DisplayFor(m => m.Report.FloatTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.ExtraFloatTotal) %>
                    </td>
                    <td>
                        R
                    </td>
                    <td style="text-align:right">
                        <%: Html.DisplayFor(m => m.Report.ExtraFloatTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        Day End Total
                    </td>
                    <td>
                        R
                    </td>
                    <td style="text-align:right; border-top:solid; border-bottom:double">
                        <%: Html.DisplayFor(m => m.Report.Final) %>
                    </td>
                </tr>
            </table>
            <% using (Html.BeginForm("_CashierDayEndReportPDF", "Money", FormMethod.Post, new { target = "new" }))
               {%>
            <%: Html.HiddenFor(m => m.ReportEmployeeID)%>
            <%: Html.HiddenFor(m => m.ReportActualDate)%>
            <button type="submit" class="t-button">Print</button>
            <%} %>
        </fieldset>
    </body>    
</html>


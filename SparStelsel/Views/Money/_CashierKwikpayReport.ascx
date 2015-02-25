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
                    <td>
                        <%: Html.DisplayFor(m => m.Report.CashTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.ElectricityTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.ElectricityTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.AirTimeTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.AirTimeTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.CardsTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.CardsTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.ChequeTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.ChequeTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.AccountPaymentTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.AccountPaymentTotal) %>
                    </td>
                </tr>
                
            </table>
        </fieldset>
    </body>    
</html>


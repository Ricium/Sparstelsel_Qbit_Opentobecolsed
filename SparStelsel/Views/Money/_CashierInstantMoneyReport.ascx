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
                    <td>
                        <%: Html.DisplayFor(m => m.Report.CashTotal) %>
                    </td>
                </tr>
                                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.FloatTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.FloatTotal) %>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.RecievedTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.RecievedTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.PaidTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.PaidTotal) %>
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


         
            </table>
        </fieldset>
    </body>    
</html>


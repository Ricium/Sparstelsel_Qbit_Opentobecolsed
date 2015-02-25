<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CashierFNB>" %>
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
                        <%: Html.LabelFor(m => m.Report.ReferenceTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.ReferenceTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.RefundTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.RefundTotal) %>
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


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
                        <%: Html.DisplayFor(m => m.Report.CashTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.SigmaTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.SigmaTotal) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.Report.SassaTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.SassaTotal) %>
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
                        <%: Html.LabelFor(m => m.Report.PickupTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.PickupTotal) %>
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
                        <%: Html.LabelFor(m => m.Report.ExtraFloatTotal) %>
                    </td>
                    <td>
                        <%: Html.DisplayFor(m => m.Report.ExtraFloatTotal) %>
                    </td>
                </tr>
            </table>
        </fieldset>
    </body>    
</html>


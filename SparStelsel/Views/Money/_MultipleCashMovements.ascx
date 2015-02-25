<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CashMovementMultiple>" %>
<%@ Import Namespace ="SparStelsel" %>
<%@ Import Namespace="SparStelsel.Models" %>
<%@ Import Namespace="SparStelsel.Controllers" %>

<!DOCTYPE html>
<html>
    <head id="Head1" runat="server">
    <title></title>    
    </head>
        <body>
            
            <form id="MultipleCashMovementsForm" method="post">
                <table>
                    <tr>
                        <td>
                           Cashier
                        </td>
                        <td>
                             <%: Html.Telerik().DropDownListFor(m => m.EmployeeID).BindTo((IEnumerable<SelectListItem>)ViewData["Employees"]) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           Date
                        </td>
                        <td>
                             <%: Html.Telerik().DatePickerFor(m=>m.ActualDate).Value(DateTime.Today).TodayButton() %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           Movement
                        </td>
                        <td>
                             <%: Html.Telerik().DropDownListFor(m => m.MovementTypeID).BindTo((IEnumerable<SelectListItem>)ViewData["Movements"]) %>
                        </td>
                    </tr>

                    <% for (int i = 0; i < Model.Movements.Count; i++ )
                       {
                           %>
                    <tr>
                        <td>
                            <%: Html.DisplayFor(c => c.Movements[i].moneyunit) %>
                            <%: Html.HiddenFor(c => c.Movements[i].MoneyUnitID) %>
                        </td>
                        <td>
                            <%: Html.Telerik().IntegerTextBoxFor(c => c.Movements[i].Count).MinValue(0)%>
                        </td>
                    </tr>
                    <% } %>
                    </table>           
            
            </form>
            <button id="SubmitMultipleCashMovements" onclick="InsertMultipeCashMovements()" class="t_button">Save</button>
        </body>
</html>

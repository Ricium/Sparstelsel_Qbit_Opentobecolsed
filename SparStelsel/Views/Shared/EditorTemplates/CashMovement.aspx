<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CashMovement>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Cash Movement</title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.CashMovementID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <%: Html.LabelFor(m => m.EmployeeID) %>
                        </td>
                        <td>
                             <%: Html.Telerik().DropDownListFor(m => m.EmployeeID).BindTo((IEnumerable<SelectListItem>)ViewData["Employees"]) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.ActualDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.ActualDate).Value(DateTime.Now).TodayButton() %>
                            <%: Html.ValidationMessageFor(m => m.ActualDate) %>
                        </td>
                    </tr>
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.MovementTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.MovementTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["Movements"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.MovementTypeID) %>
                        </td>
                    </tr> 
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.MoneyUnitID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.MoneyUnitID).BindTo((IEnumerable<SelectListItem>) ViewData["MoneyUnit"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.MoneyUnitID) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Count) %>
                        </td>
                        <td>
                            <%: Html.Telerik().IntegerTextBoxFor(m => m.Count) %>
                            <%: Html.ValidationMessageFor(m => m.Count) %>
                        </td>
                    </tr>                                    

                </table>


    
</body>
</html>

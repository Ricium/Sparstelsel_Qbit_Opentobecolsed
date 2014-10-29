<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CashMovement>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>CashMovements </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.CashMovementID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.ActualDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.ActualDate) %>
                            <%: Html.ValidationMessageFor(m => m.ActualDate) %>
                        </td>
                    </tr>
                                        <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Amount) %>
                        </td>
                        <td>
                            <%: Html.Telerik().CurrencyTextBoxFor(m => m.Amount) %>
                            <%: Html.ValidationMessageFor(m => m.Amount) %>
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
                               
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.CashTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.CashTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["CashType"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.CashTypeID) %>
                        </td>
                    </tr> 
                    <tr>
                                     

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

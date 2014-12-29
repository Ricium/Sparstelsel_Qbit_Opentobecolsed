<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CashBox>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>CashBoxs </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.CashBoxID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.ActualDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.ActualDate).Value(DateTime.Today).TodayButton() %>
                            <%: Html.ValidationMessageFor(m => m.ActualDate) %>
                        </td>
                    </tr>
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.MovementTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.MovementTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["CashboxType"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.MovementTypeID) %>
                        </td>
                    </tr> 
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Amount) %>
                        </td>
                        <td>
                            <%: Html.Telerik().CurrencyTextBoxFor(m => m.Amount).CurrencySymbol("R") %>
                            <%: Html.ValidationMessageFor(m => m.Amount) %>
                        </td>
                    </tr> 
                </table>
    
</body>
</html>

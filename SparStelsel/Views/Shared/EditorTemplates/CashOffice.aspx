<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CashOffice>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Cash Office </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.CashOfficeID) %>
                        </td>
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
                           <%: Html.LabelFor(m => m.CashOfficeTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.CashOfficeTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["CashOfficeType"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.CashOfficeTypeID) %>
                        </td>
                    </tr> 
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.MoneyUnitTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.MoneyUnitTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["MoneyUnit"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.MoneyUnitTypeID) %>
                        </td>
                    </tr> 
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.CashStatus)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.CashStatus).BindTo((IEnumerable<SelectListItem>) ViewData["CashStatus"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.CashStatus) %>
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

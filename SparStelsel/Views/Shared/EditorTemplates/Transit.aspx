<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Transit>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Transit </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.TransitID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.ActualDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.ActualDate).Value(DateTime.Today).TodayButton() %>
                            <%: Html.ValidationMessageFor(m => m.ActualDate) %>
                        </td>
                    </tr>
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.TransitTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.TransitTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["TransitType"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.TransitTypeID) %>
                        </td>
                    </tr> 
                    <tr>
                         <tr>
                        <td>
                            <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.Amount) %>
                        </td>
                        <td>
                            <%: Html.Telerik().CurrencyTextBoxFor(m => m.Amount).CurrencySymbol("R") %>
                            <%: Html.ValidationMessageFor(m => m.Amount) %>
                        </td>
                    </tr>

                </table>

    
</body>
</html>

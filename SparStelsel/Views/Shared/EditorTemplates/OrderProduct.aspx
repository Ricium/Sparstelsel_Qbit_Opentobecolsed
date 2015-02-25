<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<OrderProduct>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Product Select</title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>
   
    <table>
        <tr>
            <td>
                <%: Html.HiddenFor(m => m.OrderID, new { value = ViewData["OrderId"].ToString()}) %>
            </td>
            <td>
                <%: Html.HiddenFor(m => m.StatusID) %>
                <%: Html.HiddenFor(m => m.OrderProductID) %>
            </td>
        </tr>
        <tr>
            <td>
                <%: Html.LabelFor(m => m.ProductID) %>
            </td>
            <td>
                <%: Html.Telerik().DropDownListFor(m => m.ProductID)
                .BindTo((IEnumerable<SelectListItem>) ViewData["Products"]).HtmlAttributes(new { style = "width: 250px" })
                .ClientEvents(e => e.OnChange("GetProduct"))
                .Placeholder("Please Select a Product")%>
            </td>
        </tr>
        <tr>
            <td>
                <%: Html.LabelFor(m => m.Quantity) %>
            </td>
            <td>
                <%: Html.Telerik().IntegerTextBoxFor(m => m.Quantity).MinValue(0) %>
            </td>
        </tr>
        <tr>
            <td>
                <%: Html.LabelFor(m => m.Price) %>
            </td>
            <td>
                <%: Html.Telerik().CurrencyTextBoxFor(m => m.Price).CurrencySymbol("R") %>
            </td>
        </tr>
    </table>
</body>
</html>

<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Order>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Orders </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.OrderID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.OrderDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.OrderDate) %>
                            <%: Html.ValidationMessageFor(m => m.OrderDate) %>
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
                           <%: Html.LabelFor(m => m.SupplierID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.SupplierID).BindTo((IEnumerable<SelectListItem>) ViewData["Supplier"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.SupplierID) %>
                        </td>
                    </tr> 
                    <tr>
                               
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.SupplierTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.SupplierTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["SupplierType"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.SupplierTypeID) %>
                        </td>
                    </tr> 
                    <tr>
                                     

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

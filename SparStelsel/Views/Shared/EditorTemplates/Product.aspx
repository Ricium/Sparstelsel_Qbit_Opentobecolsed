<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Product>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Product</title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.ProductID) %>
                            <%: Html.HiddenFor(m => m.Total) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Products) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Products) %>
                            <%: Html.ValidationMessageFor(m => m.Products) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.ProductDescription) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.ProductDescription) %>
                            <%: Html.ValidationMessageFor(m => m.ProductDescription) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Quantity) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Quantity) %>
                            <%: Html.ValidationMessageFor(m => m.Quantity) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.BTW) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.BTW) .MinValue(0) %>
                            <%: Html.ValidationMessageFor(m => m.BTW) %>
                        </td>
                    </tr>                    
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Price) %>
                        </td>
                        <td>
                           R <%: Html.TextBoxFor(m => m.Price) %>
                            <%: Html.ValidationMessageFor(m => m.Price) %>
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
                                     

                </table>


    
</body>
</html>

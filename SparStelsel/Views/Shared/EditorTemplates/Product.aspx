<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Product>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Product </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.ProductID) %>
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
                           <%: Html.LabelFor(m => m.BTW) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.BTW) %>
                            <%: Html.ValidationMessageFor(m => m.BTW) %>
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
                           <%: Html.LabelFor(m => m.Price) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Price) %>
                            <%: Html.ValidationMessageFor(m => m.Price) %>
                        </td>
                    </tr>
                                                                                                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Total) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Total) %>
                            <%: Html.ValidationMessageFor(m => m.Total) %>
                        </td>
                    </tr>
               
                  
                                     

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

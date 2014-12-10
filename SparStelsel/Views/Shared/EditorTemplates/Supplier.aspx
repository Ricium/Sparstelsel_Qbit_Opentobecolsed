<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Supplier>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Supplier </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.SupplierID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Suppliers) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Suppliers) %>
                            <%: Html.ValidationMessageFor(m => m.Suppliers) %>
                        </td>
                    </tr>
                                        <tr>
                        <td>
                           <%: Html.LabelFor(m => m.StockCondition) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.StockCondition) %>
                            <%: Html.ValidationMessageFor(m => m.StockCondition) %>
                        </td>
                    </tr>
                                                            <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Term) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Term) %>
                            <%: Html.ValidationMessageFor(m => m.Term) %>
                        </td>
                    </tr>
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
                     <td>
                           <%: Html.LabelFor(m => m.FromFriday)%>
                        </td>
                        <td>
                           <%: Html.CheckBoxFor(m => m.FromFriday)%>
                        </td>
                    </tr> 
               
                  
                                     

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

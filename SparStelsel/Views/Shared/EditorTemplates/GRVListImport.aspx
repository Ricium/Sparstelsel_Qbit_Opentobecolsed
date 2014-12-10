<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<GRVListImport>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Select Supplier</title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>
   <% using (Html.BeginForm("SelectSupplier", "GRV", FormMethod.Post))
  { %>
    <%: Html.HiddenFor(m => m.GRVListID) %> 
   <%: Html.HiddenFor(m => m.BatchId) %> 
    
    <table>
        <tr style="vertical-align:top">
            <td>
                <table>
                    <tr>
                        <td>
                            <strong>Select Supplier From List:</strong>
                        </td>
                    </tr>
                    <tr>
                        <td>                           
                                
                                 <table>
                                     <tr>
                                         <td><%: Html.Telerik().DropDownListFor(m => m.SupplierID).BindTo((IEnumerable<SelectListItem>)ViewData["Suppliers"]).Placeholder("Select Supplier").SelectedIndex(0).HtmlAttributes(new { style = "width: 250px" }) %></td>
                                     </tr>
                                 </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td >
                <table style="border-left:solid;border-width:1px">
                    <tr>
                        <td>
                            <strong>Add New Supplier:</strong>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Suppliers) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Suppliers)%>
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
                           <%: Html.Telerik().DropDownListFor(m => m.SupplierTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["SupplierType"]).HtmlAttributes(new { style = "width: 100px" }).SelectedIndex(0).Placeholder("Select Type")%>
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
                             <% } %>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>  
</body>
</html>

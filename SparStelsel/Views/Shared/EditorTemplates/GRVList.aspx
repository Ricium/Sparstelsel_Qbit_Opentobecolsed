<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<GRVList>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>GRV</title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.GRVListID) %>
                        </td>
                        <td><%: Html.HiddenFor(m => m.PayDate) %></td>
                        <td><%: Html.HiddenFor(m => m.CreatedDate) %></td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.InvoiceNumber) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.InvoiceNumber) %>
                            <%: Html.ValidationMessageFor(m => m.InvoiceNumber) %>
                        </td>
                    </tr>
                                        <tr>
                        <td>
                           <%: Html.LabelFor(m => m.StateDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.StateDate) %>
                            <%: Html.ValidationMessageFor(m => m.StateDate) %>
                        </td>
                    </tr>
  
                                                            <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Number) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Number) %>
                            <%: Html.ValidationMessageFor(m => m.Number) %>
                        </td>
                    </tr>

    

                                                            <tr>
                        <td>
                           <%: Html.LabelFor(m => m.PinkSlipNumber) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.PinkSlipNumber) %>
                            <%: Html.ValidationMessageFor(m => m.PinkSlipNumber) %>
                        </td>
                    </tr>

                    
                                                                                <tr>
                        <td>
                           <%: Html.LabelFor(m => m.GRVDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.GRVDate) %>
                            <%: Html.ValidationMessageFor(m => m.GRVDate) %>
                        </td>
                    </tr>

                                                                                            <tr>
                        <td>
                           <%: Html.LabelFor(m => m.InvoiceDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.InvoiceDate) %>
                            <%: Html.ValidationMessageFor(m => m.InvoiceDate) %>
                        </td>
                    </tr>

                                                                                                                <tr>
                        <td>
                           <%: Html.LabelFor(m => m.ExcludingVat) %>
                        </td>
                        <td>
                          R  <%: Html.TextBoxFor(m => m.ExcludingVat) %>
                            <%: Html.ValidationMessageFor(m => m.ExcludingVat) %>
                        </td>
                   
                                                                                                                     </tr>

                                                                                                                                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.IncludingVat) %>
                        </td>
                        <td>
                           R  <%: Html.TextBoxFor(m => m.IncludingVat) %>
                            <%: Html.ValidationMessageFor(m => m.IncludingVat) %>
                        </td>
                    </tr>
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.SupplierID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.SupplierID).BindTo((IEnumerable<SelectListItem>) ViewData["SupplierID"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.SupplierID) %>
                        </td>
                    </tr> 
                                                                                <tr>
                        <td>
                           <%: Html.LabelFor(m => m.ExpectedPayDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.ExpectedPayDate) %>
                            <%: Html.ValidationMessageFor(m => m.ExpectedPayDate) %>
                        </td>
                    </tr>
                               
                  
                                     

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

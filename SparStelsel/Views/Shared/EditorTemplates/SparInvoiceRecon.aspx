<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<SparInvoiceRecon>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Payment</title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.SparReconId) %>
                        </td>
                        <td>
                            <%: Html.HiddenFor(m => m.GRVTypeId) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.GRVDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.GRVDate).Value(DateTime.Today).TodayButton()  %>
                            <%: Html.ValidationMessageFor(m => m.GRVDate) %>
                        </td>
                    </tr>
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.SupplierId)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.SupplierId).BindTo((IEnumerable<SelectListItem>) ViewData["Suppliers"])
                                .HtmlAttributes(new { style = "width: 300px" }) %>
                            <%: Html.ValidationMessageFor(model => model.SupplierId) %>
                        </td>
                    </tr>
                     <tr>
                        <td>
                           <%: Html.LabelFor(m => m.InvoiceNumber) %>
                        </td>
                        <td>
                            
                            <%: Html.Telerik().AutoCompleteFor(m => m.InvoiceNumber) 
                                .DataBinding(d => d.Ajax().Select("_GetInvoices", "SparRecon"))
                                .AutoFill(true).Filterable(f => f.FilterMode(AutoCompleteFilterMode.Contains))
                                .Enable(true).HtmlAttributes(new { style = "width: 300px" })
                                .ClientEvents(e => e.OnDataBinding("onAutoCompleteDataBinding").OnClose("onAutoComplete"))
                                
                                %>
                            <%: Html.ValidationMessageFor(m => m.InvoiceNumber) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <%: Html.RadioButton("GRV", "GRV", false, new { onChange = "SelectRadio(1)" })%> GRV
                        </td>
                        <td>
                            <%: Html.RadioButton("CLM","CLM", false, new { onChange = "SelectRadio(2)" }) %> CLM
                        </td>
                    </tr>
                   <tr>
                     <td>
                           <%: Html.LabelFor(m => m.Amount)%>
                        </td>
                        <td>
                          R <%: Html.TextBoxFor(m => m.Amount)%>
                            <%: Html.ValidationMessageFor(model => model.Amount) %>
                        </td>
                    </tr>   
                                       <tr>
                     <td>
                           <%: Html.LabelFor(m => m.PaidAmount)%>
                        </td>
                        <td>
                          R <%: Html.TextBoxFor(m => m.PaidAmount)%>
                            <%: Html.ValidationMessageFor(model => model.PaidAmount) %>
                        </td>
                    </tr> 
                 </table>    
</body>
</html>

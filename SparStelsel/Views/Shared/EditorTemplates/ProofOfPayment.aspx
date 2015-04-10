
<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<ProofOfPayment>" %>
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
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.ProofOfPaymentID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.ActualDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.ActualDate).Value(DateTime.Today).TodayButton()  %>
                            <%: Html.ValidationMessageFor(m => m.ActualDate) %>
                        </td>
                    </tr>
                   
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.PaymentDescription) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.PaymentDescription) %>
                            <%: Html.ValidationMessageFor(m => m.PaymentDescription) %>
                        </td>
                    </tr>
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.SupplierID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.SupplierID).BindTo((IEnumerable<SelectListItem>) ViewData["SupplierID"])
                                    .HtmlAttributes(new { style = "width: 250px" }).ClientEvents(e => e.OnChange("OpenInvoices")) %>
                            <%: Html.ValidationMessageFor(model => model.SupplierID) %>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <div id="Invoiceload" style="display: none;">
                                <table>
                                    <tr>
                                        <td>
                                           <%: Html.LabelFor(m => m.InvoiceNumber) %>
                                        </td>
                                        <td>                            
                                            <%: Html.Telerik().AutoCompleteFor(m => m.InvoiceNumber) 
                                                .DataBinding(d => d.Ajax().Select("_GetInvoiceNumbers", "Payment"))
                                                .ClientEvents(e => e.OnDataBinding("CheckSupplier"))
                                                .AutoFill(true).Filterable(f => f.FilterMode(AutoCompleteFilterMode.StartsWith))
                                                .Enable(true).HtmlAttributes(new { style = "width: 300px" }) %>
                                            <%: Html.ValidationMessageFor(m => m.InvoiceNumber) %>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                     

                                                                <tr>
                     <td>
                           <%: Html.LabelFor(m => m.Amount)%>
                        </td>
                        <td>
                           R <%: Html.TextBoxFor(m => m.Amount) %>
                            <%: Html.ValidationMessageFor(model => model.Amount) %>
                        </td>
                    </tr>            
 
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.CashTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.CashTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["CashTypeID"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.CashTypeID) %>
                        </td>
                    </tr>
                  
                                     

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

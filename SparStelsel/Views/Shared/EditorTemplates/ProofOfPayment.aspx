<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<ProofOfPayment>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>ProofOfPayment </title>
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
                            <%: Html.Telerik().DatePickerFor(m => m.ActualDate) %>
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
                           <%: Html.LabelFor(m => m.InvoiceNumber) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.InvoiceNumber) %>
                            <%: Html.ValidationMessageFor(m => m.InvoiceNumber) %>
                        </td>
                    </tr>

                                                                <tr>
                     <td>
                           <%: Html.LabelFor(m => m.Amount)%>
                        </td>
                        <td>
                           <%: Html.Telerik().CurrencyTextBoxFor(m => m.Amount).CurrencySymbol("R")%>
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

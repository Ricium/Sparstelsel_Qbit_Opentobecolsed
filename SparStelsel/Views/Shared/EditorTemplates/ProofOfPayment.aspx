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
                           <%: Html.LabelFor(m => m.ModifiedDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.ModifiedDate) %>
                            <%: Html.ValidationMessageFor(m => m.ModifiedDate) %>
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
                           <%: Html.Telerik().DropDownListFor(m => m.SupplierID).BindTo((IEnumerable<SelectListItem>) ViewData["SupplierID"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.SupplierID) %>
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
 
                    <tr>
                  
                                     

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

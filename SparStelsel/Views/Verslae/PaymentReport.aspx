<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PaymentQuery>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Report
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Payment Report</h3>
   <% using (Html.BeginForm("GetPaymentReport", "Verslae", FormMethod.Post))
       { %>
        <table>
            <tr>
                <td>
                    Select Payments From:
                </td>
                <td>
                    <%: Html.Telerik().DatePickerFor(m => m.FromDate) %>
                </td>
                <td>
                    Up To:
                </td>
                <td>
                    <%: Html.Telerik().DatePickerFor(m => m.ToDate) %>
                </td>
            </tr>
            <tr>
                <td>
                    Invoice Number:
                </td>
                <td>
                    <%: Html.TextBoxFor(m => m.InvoiceNumber) %>
                </td>
                <td>
                    Pink Slip Number:
                </td>
                <td>
                    <%: Html.TextBoxFor(m => m.PinkSlip) %>
                </td>
            </tr>
            <tr>
                <td>
                    Supplier:
                </td>
                <td>
                    <%: Html.Telerik().DropDownListFor(m => m.Supplier).BindTo(ViewData["Supllier"]  as IEnumerable<SelectListItem>) %>
                </td>
                <td>
                    Payment Method:
                </td>
                <td>
                    <%: Html.Telerik().DropDownListFor(m => m.Paymenthod).BindTo(ViewData["CashType"]  as IEnumerable<SelectListItem>) %>
                </td>
            </tr>
        </table>
       <button type="submit" class="t-button">Get Report</button>      
    <% } %>

</asp:Content>
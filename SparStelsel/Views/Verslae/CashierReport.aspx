<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CashierReportQuery>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Report
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Cashier Report</h3>
   <% using (Html.BeginForm("GetCashierReport", "Verslae", FormMethod.Post))
       { %>
        <table>
            <tr>
                <td>
                    Select Cashier:
                </td>
                <td>
                    <%: Html.Telerik().DropDownListFor(m => m.Cashier).BindTo((IEnumerable<SelectListItem>)ViewData["Cashiers"]).Placeholder("Employee") %>
                </td>
            </tr>
            <tr>
                <td>
                    Select Date:
                </td>
                <td>
                    <%: Html.Telerik().DatePickerFor(m => m.Date).Value(DateTime.Today) %>
                </td>
            </tr>
        </table>
       <button type="submit" class="t-button">Get Report</button>      
    <% } %>

</asp:Content>
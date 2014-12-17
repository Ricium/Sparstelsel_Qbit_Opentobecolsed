<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<DateTimeFromToQuery>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Report
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Order vs GRV Report</h3>
   <% using (Html.BeginForm("GetOrdersExpectedDateReport", "Verslae", FormMethod.Post))
       { %>
        <table>
            <tr>
                <td>
                    Select Orders For:
                </td>
                <td>
                    <%: Html.Telerik().DatePickerFor(m => m.From) %>
                </td>
            </tr>
        </table>
       <button type="submit" class="t-button">Get Report</button>      
    <% } %>

</asp:Content>
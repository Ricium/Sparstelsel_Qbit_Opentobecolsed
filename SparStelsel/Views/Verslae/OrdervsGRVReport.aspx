<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<DateTimeFromToQuery>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Report
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Order vs GRV Report</h3>
   <% using (Html.BeginForm("GetOrdervsGRVReport", "Verslae", FormMethod.Post))
       { %>
        <table>
            <tr>
                <td>
                    From Date:
                </td>
                <td>
                    <%: Html.Telerik().DatePickerFor(m => m.From) %>
                </td>
            </tr>
            <tr>
                <td>
                    To Date:
                </td>
                <td>
                    <%: Html.Telerik().DatePickerFor(m => m.To) %>
                </td>
            </tr>
        </table>
       <button type="submit" class="t-button">Get Report</button>
      
    <% } %>

</asp:Content>
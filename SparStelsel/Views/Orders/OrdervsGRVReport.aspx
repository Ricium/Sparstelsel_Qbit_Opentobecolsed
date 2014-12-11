<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<YearMonthQuery>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Report
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Order vs GRV Report</h3>
   <% using (Html.BeginForm("GetOrdervsGRVReport", "Orders", FormMethod.Post))
       { %>
        <table>
            <tr>
                <td>
                    <%: Html.LabelFor(m => m.Month) %>
                </td>
                <td>
                    <%: Html.Telerik().DropDownListFor(m => m.Month).BindTo((IEnumerable<SelectListItem>)ViewData["Month"]) %>
                </td>
            </tr>
            <tr>
                <td>
                    <%: Html.LabelFor(m => m.Year) %>
                </td>
                <td>
                    <%: Html.Telerik().DropDownListFor(m => m.Year).BindTo((IEnumerable<SelectListItem>)ViewData["Year"]) %>
                </td>
            </tr>
        </table>
       <button type="submit" class="t-button">Get Report</button>
      
    <% } %>

</asp:Content>
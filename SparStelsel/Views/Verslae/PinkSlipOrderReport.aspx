<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NumericalRangeQuery>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Report
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Order vs GRV Report</h3>
   <% using (Html.BeginForm("GetPinkslipOrderReport", "Verslae", FormMethod.Post))
       { %>
        <table>
            <tr>
                <td>
                    From Pinkslip Number:
                </td>
                <td>
                    <%: Html.Telerik().IntegerTextBoxFor(m => m.From).MinValue(0) %>
                </td>
            </tr>
            <tr>
                <td>
                    To Pinkslip Number:
                </td>
                <td>
                    <%: Html.Telerik().IntegerTextBoxFor(m => m.To).MinValue(0)  %>
                </td>
            </tr>
        </table>
       <button type="submit" class="t-button">Get Report</button>
      
    <% } %>

</asp:Content>
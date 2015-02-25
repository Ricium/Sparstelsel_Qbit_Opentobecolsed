<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace ="SparStelsel" %>
<%@ Import Namespace="SparStelsel.Models" %>
<%@ Import Namespace="SparStelsel.Controllers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Cashier Status
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <table>
        <tr>
            <td>
             <%
                
                 Html.Telerik().Grid<Cash>()
                      .Name("Cash")
                      .DataKeys(d => d.Add("EmployeeName"))
                      .Columns(columns =>
                      {
                          columns.Bound(model => model.Date).Format("{0:yyyy/MM/dd}");
                          columns.Bound(model => model.EmployeeName);
                          columns.Bound(model => model.MovementType);
                          columns.Bound(model => model.TotalDeclared).Format("{0:c}");
                          columns.Bound(model => model.TotalExpected).Format("{0:c}");
                          columns.Bound(model => model.CashExpected).Format("{0:c}");
                          columns.Bound(model => model.CashOver).Format("{0:c}");
                      })
                      .DataBinding(dataBinding =>
                      {
                          dataBinding.Ajax()
                                     .Select("_ListCashierStatus", "Money");
                      })

                      .Pageable(paging => paging.PageSize(50))
                      .Sortable()
                      .Scrollable(scrolling => scrolling.Height(250))
                      .Render();             
                 %>
            </td>
        </tr>
    </table>
</asp:Content>



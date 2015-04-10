<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Cash Office
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <table>
        <tr>
            <td>
                <h2>
                     Cash Office
                </h2>
            </td>
        </tr>
        <tr>
            <td>
             <%
                
                 Html.Telerik().Grid<CashOffice>()
                    .Name("CashOfficeGrid")
                    .DataKeys(keys => keys.Add(s => s.CashOfficeID))
                    .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Cash Office Movement"))
                    .Columns(columns =>
                    {

                        columns.Bound(model => model.ActualDate).Format("{0:yyyy/MM/dd}");                        
                        columns.Bound(model => model.cashofficetype);
                        columns.Bound(model => model.moneyunit);
                        columns.Bound(model => model.Amount).Format("{0:c}");
                        columns.Bound(model => model.cashstatusindex);
                        columns.Bound(model => model.ModifiedDate).Format("{0:yyyy/MM/dd}");
                                               
                   
                            columns.Command(commands =>
                            {
                                commands.Edit().ButtonType(GridButtonType.ImageAndText).Text("Update");
                            }).Title("").Width(90);
                        
                      
                            columns.Command(commands =>
                            {
                                commands.Delete().ButtonType(GridButtonType.ImageAndText).Text("Delete");
                            }).Title("").Width(90);
                        
                    })
                    .DataBinding(dataBinding =>
                    {
                        dataBinding.Ajax()
                                   .Select("_ListCashOffice", "Money")
                                   .Insert("_InsertCashOffice", "Money")
                                   .Update("_UpdateCashOffice", "Money")
                                   .Delete("_RemoveCashOffice", "Money");
                    })

                    .Pageable(paging => paging.PageSize(50))
                    .Sortable()
                    .Scrollable(scrolling => scrolling.Height(250))
                    .Editable(editing => editing.Mode(GridEditMode.PopUp))
                    .Filterable()
                    .Render();
             
                 %>
            </td>
        </tr>
    </table>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   GRV Import
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <table>
        <tr>
            <td>
                <h2>
                     GRV Import: <%: ViewData["BatchId"] %>
                </h2>
            </td>
        </tr>
        <tr>
            <td>
                <%: Html.ActionLink("Process", "GRVImportProcess", "GRV", new { BatchId = ViewData["BatchId"] }, null)%> 
            </td>
        </tr>
        <tr>
            <td>
             <%
                
                 Html.Telerik().Grid<GRVListImport>()
                    .Name("GRVLists")
                    .DataKeys(keys => keys.Add(s => s.GRVListID))
                    .Columns(columns =>
                    {

                    
                        columns.Bound(model => model.InvoiceNumber).Width(110);
                        columns.Bound(model => model.Number).Width(60);
                        columns.Bound(model => model.PayDate).Width(100).Format("{0:yyyy/MM/dd}");
                        columns.Bound(model => model.PinkSlipNumber).Width(110);
                        columns.Bound(model => model.GRVDate).Width(80).Format("{0:yyyy/MM/dd}");
                        columns.Bound(model => model.InvoiceDate).Width(100).Format("{0:yyyy/MM/dd}");
                        columns.Bound(model => model.SupplierDetails);
                        columns.Bound(model => model.hasError).Width(80);
                        

                        columns.Command(commands =>
                        {
                            commands.Edit().ButtonType(GridButtonType.ImageAndText).Text("Update");
                        }).Title("").Width(100);
                    })
                    .DataBinding(dataBinding =>
                    {
                        dataBinding.Ajax()
                                   .Select("_ListGRVBatch", "GRV", new { BatchId = (int)ViewData["BatchId"] })
                                   .Update("_AddSupplier", "GRV");
                    })

                    .Pageable(paging => paging.PageSize(50))
                    .Sortable()
                    .Scrollable(scrolling => scrolling.Height(250))
                    .Editable(editing => editing.Mode(GridEditMode.PopUp))
                    .Render();                 
                 
                
             
                 %>
            </td>
        </tr>
    </table>
</asp:Content>


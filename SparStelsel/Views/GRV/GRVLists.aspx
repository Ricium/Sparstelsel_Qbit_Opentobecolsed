<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   GRVLists
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <table>
        <tr>
            <td>
                <h2>
                     GRVLists
                </h2>
            </td>
        </tr>
        <tr>
            <td>
             <%
                
                 Html.Telerik().Grid<GRVList>()
                    .Name("GRVLists")
                    .DataKeys(keys => keys.Add(s => s.GRVListID))
                    .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add GRVList"))
                    .Columns(columns =>
                    {

                        columns.Bound(model => model.GRVListID);
                        columns.Bound(model => model.InvoiceNumber);
                        columns.Bound(model => model.StateDate);
                        columns.Bound(model => model.Number);
                        columns.Bound(model => model.PayDate);
                        columns.Bound(model => model.PinkSlipNumber);
                        columns.Bound(model => model.GRVDate);
                        columns.Bound(model => model.InvoiceDate);
                        columns.Bound(model => model.ExcludingVat);
                        columns.Bound(model => model.IncludingVat);
                        columns.Bound(model => model.GRVTypeID);
                        columns.Bound(model => model.SupplierID);
                                          
                   
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
                                   .Select("_ListGRVLists", "GRV")
                                   .Insert("_InsertGRVLists", "GRV")
                                   .Update("_UpdateGRVLists", "GRV")
                                   .Delete("_RemoveGRVLists", "GRV");
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


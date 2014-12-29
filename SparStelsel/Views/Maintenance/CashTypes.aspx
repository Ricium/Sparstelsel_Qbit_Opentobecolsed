<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Payment Types
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <table>
        <tr>
            <td>
                <h2>
                     Payment Types
                </h2>
            </td>
        </tr>
        <tr>
            <td>
             <%
                
                     Html.Telerik().Grid<CashType>()
                    .Name("CashTypes")
                    .DataKeys(keys => keys.Add(s => s.CashTypeID))
                    .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Payment Type"))
                    .Columns(columns =>
                    {

                         columns.Bound(model => model.CashTypes).Title("Payment Type");
                        
                   
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
                                   .Select("_ListCashTypes", "Maintenance")
                                   .Insert("_InsertCashTypes", "Maintenance")
                                   .Update("_UpdateCashTypes", "Maintenance")
                                   .Delete("_RemoveCashTypes", "Maintenance");
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


<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Comment
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <table>
        <tr>
            <td>
                <h2>
                     Comments
                </h2>
            </td>
        </tr>
        <tr>
            <td>
             <%
                
                     Html.Telerik().Grid<Comment>()
                    .Name("Comments")
                    .DataKeys(keys => keys.Add(s => s.CommentID))
                    .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Comment"))
                    .Columns(columns =>
                    {

                        columns.Bound(model => model.Comments).Title("Comment");
                      
                        
                   
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
                                   .Select("_ListComment", "Maintenance")
                                   .Insert("_InsertComment", "Maintenance")
                                   .Update("_UpdateComment", "Maintenance")
                                   .Delete("_RemoveComment", "Maintenance");
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


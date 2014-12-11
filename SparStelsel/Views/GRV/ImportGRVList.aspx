<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   GRV List Import
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <% using (Html.BeginForm("ImportFromExcel", "GRV", FormMethod.Post, new { enctype = "multipart/form-data" }))
       { %>
         <table>
             <tr>
                 <td>Excel file</td>
                 <td><input class="t-button" type="file"  id="files" name="grv" /></td>
                 <td><input class="t-button" type="submit" id="Submit" name="Submit" value="Submit"/></td>
             </tr>
         </table>
     <% } %>

            </td>
        </tr>
        <tr>
            <td>
<%     Html.Telerik().Grid<GRVImport>()
                    .Name("GRVImports")
                    .DataKeys(keys => keys.Add(s => s.BatchId))
                    .Columns(columns =>
                    {
                        columns.Bound(model => model.BatchId);
                        columns.Bound(model => model.FileName);
                        columns.Bound(model => model.ModifiedDate);
                        columns.Bound(model => model.ModifiedBy);                     
                        
                   
                            columns.Command(commands =>
                            {
                                commands.Custom("Update").ButtonType(GridButtonType.ImageAndText).Text("Update").Action("_UpdateImport","GRV");
                            }).Title("").Width(90);                       
                      
                        
                    })
                    .DataBinding(dataBinding =>
                    {
                        dataBinding.Ajax()
                                   .Select("_ListImports", "GRV");
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


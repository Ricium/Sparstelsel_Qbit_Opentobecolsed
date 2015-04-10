<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>
<%@ Import Namespace ="SparStelsel" %>
<%@ Import Namespace="SparStelsel.Models" %>
<%@ Import Namespace="SparStelsel.Controllers" %>
<!DOCTYPE html>
<html>
    <head id="Head1" runat="server">
    <title></title>    
    </head>
        <body>
             <table>
        <tr>
            <td>
             <%
                
                 Html.Telerik().Grid<InstantMoney>()
                      .Name("InstantMoneys")
                      .DataKeys(keys => keys.Add(s => s.InstantMoneyID))
                      .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Instant Money"))
                      .Columns(columns =>
                      {
                          columns.Bound(model => model.EmployeeID);
                          columns.Bound(model => model.instantmoneytype);
                          columns.Bound(model => model.ActualDate);
                          columns.Bound(model => model.Amount);   
                          
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
                                     .Select("_ListInstantMoney", "Money")
                                     .Insert("_InsertInstantMoney", "Money")
                                     .Update("_UpdateInstantMoney", "Money")
                                     .Delete("_RemoveInstantMoney", "Money");
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

        </body>
    
</html>


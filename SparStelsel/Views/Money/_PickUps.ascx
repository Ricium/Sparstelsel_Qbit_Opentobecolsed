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
                
                 Html.Telerik().Grid<PickUp>()
                      .Name("Pickups")
                      .DataKeys(keys => keys.Add(s => s.PickUpID))
                      .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Pick Up"))
                      .Columns(columns =>
                      {
                          columns.Bound(model => model.employee);
                          columns.Bound(model => model.movementtype);
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
                                     .Select("_ListPickUp", "Money")
                                     .Insert("_InsertPickUp", "Money")
                                     .Update("_UpdatePickUp", "Money")
                                     .Delete("_RemovePickUp", "Money");
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

        </body>
    
</html>


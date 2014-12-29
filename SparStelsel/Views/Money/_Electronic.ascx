<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CurrentUser>" %>
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
                
                 Html.Telerik().Grid<ElectronicFund>()
                      .Name("ElectronicFunds")
                      .DataKeys(keys => keys.Add(s => s.ElectronicFundID))
                      .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Electronic Fund"))
                      .Columns(columns =>
                      {
                          columns.Bound(model => model.MovementTypeID);
                          columns.Bound(model => model.ActualDate);
                          columns.Bound(model => model.employee);
                          columns.Bound(model => model.electronictype);
                          columns.Bound(model => model.Total);
          


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
                                     .Select("_ListElectronic", "Money")
                                     .Insert("_InsertElectronic", "Money")
                                     .Update("_UpdateElectronic", "Money")
                                     .Delete("_RemoveElectronic", "Money");
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


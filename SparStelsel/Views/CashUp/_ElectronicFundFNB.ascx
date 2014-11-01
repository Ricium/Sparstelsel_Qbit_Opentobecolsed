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
                <h2>
                     Cards
                </h2>
            </td>
        </tr>
        <tr>
            <td>
             <%
                
                 Html.Telerik().Grid<CashMovementFNB>()
                      .Name("CashMovements")
                      .DataKeys(keys => keys.Add(s => s.CashMovementID))
                      .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Cards"))
                      .Columns(columns =>
                      {

                          columns.Bound(model => model.CashMovementID).ReadOnly();
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
                                     .Select("_ListCashMovementFNB", "CashUp")
                                     .Insert("_InsertCashMovementFNB", "CashUp")
                                     .Update("_UpdateCashMovementFNB", "CashUp")
                                     .Delete("_RemoveCashMovementFNB", "CashUp");
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
            <table>
        <tr>
            <td>
                <h2>
                     Cheques
                </h2>
            </td>
        </tr>
        <tr>
            <td>
             <%
                
                 Html.Telerik().Grid<CashMovementFNB>()
                      .Name("CashMovementsC")
                      .DataKeys(keys => keys.Add(s => s.CashMovementID))
                      .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Cheques"))
                      .Columns(columns =>
                      {

                          columns.Bound(model => model.CashMovementID).ReadOnly();
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
                                     .Select("_ListCashMovementFNBC", "CashUp")
                                     .Insert("_InsertCashMovementFNBC", "CashUp")
                                     .Update("_UpdateCashMovementFNBC", "CashUp")
                                     .Delete("_RemoveCashMovementFNBC", "CashUp");
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


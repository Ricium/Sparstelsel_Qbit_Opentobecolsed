﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>
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
                
                 Html.Telerik().Grid<CashMovement>()
                      .Name("CashMovements")
                      .DataKeys(d => d.Add(s => s.CashMovementID))
                      .ToolBar(p => p.Template("<button type='button' class='t-button' id='InsertMultipleCashMovements' onclick='LoadMultipleCashMovements()'>Insert Day-end Cash</button>"))
                      .Columns(columns =>
                      {
                          columns.Bound(model => model.ActualDate).Format("{0:yyyy/MM/dd}");
                          columns.Bound(model => model.employee);
                          columns.Bound(model => model.movementtype);
                          columns.Bound(model => model.moneyunit);
                          columns.Bound(model => model.Amount).Format("{0:c}");
                          columns.Bound(model => model.ModifiedDate).Format("{0:yyyy/MM/dd}");
                          columns.Bound(model => model.ModifiedBy);

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
                                     .Select("_ListCash", "Money")
                                     .Update("_UpdateCash", "Money")
                                     .Delete("_DeleteCash", "Money");
                                     //.Insert("_InsertCash", "Money");
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


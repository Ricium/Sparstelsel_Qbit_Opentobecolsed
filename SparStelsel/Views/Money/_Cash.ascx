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
                
                 Html.Telerik().Grid<Cash>()
                      .Name("Cash")
                      .DataKeys(d => d.Add("EmployeeName"))
                      .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Cash Movement"))
                      .Columns(columns =>
                      {
                          columns.Bound(model => model.Date).Format("{0:yyyy/MM/dd}");
                          columns.Bound(model => model.EmployeeName);
                          columns.Bound(model => model.MovementType);
                          columns.Bound(model => model.TotalDeclared).Format("{0:c}");
                          columns.Bound(model => model.TotalExpected).Format("{0:c}");
                          columns.Bound(model => model.CashExpected).Format("{0:c}");
                          columns.Bound(model => model.CashOver).Format("{0:c}");
                      })
                      .DataBinding(dataBinding =>
                      {
                          dataBinding.Ajax()
                                     .Select("_ListCash", "Money")
                                     .Insert("_InsertCash", "Money");
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


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
             <%
                
                 Html.Telerik().Grid<KwikPay>()
                      .Name("KwikPays")
                      .DataKeys(keys => keys.Add(s => s.KwikPayID))
                      .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Kwik Pay"))
                      .Columns(columns =>
                      {

                          columns.Bound(model => model.EmployeeID);
                          columns.Bound(model => model.kwikpaytype);
                          columns.Bound(model => model.ActualDate).Format("{0:yyyy/MM/dd}");
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
                                     .Select("_ListKwikPay", "Money")
                                     .Insert("_InsertKwikPay", "Money")
                                     .Update("_UpdateKwikPay", "Money")
                                     .Delete("_RemoveKwikPay", "Money");
                      })

                      .Pageable(paging => paging.PageSize(50))
                      .Sortable()
                      .Scrollable(scrolling => scrolling.Height(250))
                      .Editable(editing => editing.Mode(GridEditMode.PopUp))
                      .Filterable()
                      .Render();
                 
                 
                 
                
             
                 %>
        </body>
    
</html>


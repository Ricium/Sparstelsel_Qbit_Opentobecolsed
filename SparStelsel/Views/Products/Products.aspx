﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Product Maintenance
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <table>
        <tr>
            <td>
                <h2>
                     Products
                </h2>
            </td>
        </tr>
        <tr>
            <td>
             <%
                
                 Html.Telerik().Grid<Product>()
                    .Name("Products")
                    .DataKeys(keys => keys.Add(s => s.ProductID))
                    .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Product"))
                    .Columns(columns =>
                    {
                        columns.Bound(model => model.Products);
                        columns.Bound(model => model.ProductDescription);
                        columns.Bound(model => model.Quantity);
                        columns.Bound(model => model.BTW).Format("{0:c}");                        
                        columns.Bound(model => model.Price).Format("{0:c}");
                        columns.Bound(model => model.Total).Format("{0:c}");
                        columns.Bound(model => model.supplier);
                        
                   
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
                                   .Select("_ListProducts", "Products")
                                   .Insert("_InsertProducts", "Products")
                                   .Update("_UpdateProducts", "Products")
                                   .Delete("_RemoveProducts", "Products");
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


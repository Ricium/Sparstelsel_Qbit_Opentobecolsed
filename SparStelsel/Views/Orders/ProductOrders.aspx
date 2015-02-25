<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Orders
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script>
    function LoadProductOrder()
    {

        $.ajax({
            type: 'POST',
            url: '/Orders/_LoadOrder/',
            data: {},
            dataType: 'html',
            success: function (htmlData) {
                var window = $('#WindowInsertOrder').data('tWindow');
                window.content(htmlData).center();
                window.open();
            }
        })
    }

</script>  
    
    <%  Html.Telerik().Window()
            .Name("WindowInsertOrder")
            .Title("New Order")   
            .Width(500)
            .Draggable(true)
            .Modal(true)
            .Visible(false)
            .Render();    
    %>  

    <table>
        <tr>
            <td>
             <%
                
                 Html.Telerik().Grid<Order>()
                    .Name("Orders")
                    .DataKeys(keys => keys.Add(s => s.OrderID))
                    .ToolBar(p => p.Template("<button type='button' class='t-button' id='NewProductOrder' onclick='LoadProductOrder()'>New Order</button>"))
                    .Columns(columns =>
                    {
                        columns.Bound(model => model.supplier);
                        columns.Bound(model => model.OrderDate).Format("{0:yyyy/MM/dd}");
                        columns.Bound(model => model.ExpectedDeliveryDate).Format("{0:yyyy/MM/dd}");
                        columns.Bound(model => model.PinkSlipNumber);
                        columns.Bound(model => model.Amount).Format("{0:c}"); 
                        columns.Bound(model => model.OrderID)
                            .ClientTemplate("<a href='../Orders/ProductOrder?OrderId=<#=OrderID#>'><button type='button' class='t-button'>Update</button></a>")
                            .Width(90).Title("");                                                 
                                        
                            columns.Command(commands =>
                            {
                                commands.Delete().ButtonType(GridButtonType.Text).Text("Delete");
                            }).Title("").Width(90);
                                                
                    })
                    .DataBinding(dataBinding =>
                    {
                        dataBinding.Ajax()
                                   .Select("_ListProductOrders", "Orders")
                                   .Delete("_RemoveProductOrders", "Orders");
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
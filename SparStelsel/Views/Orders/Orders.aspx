<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Orders
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script>
    $('#btnRefresh').live("click", function () {

        //var Invoice = $('#sInvoice').val();
        var Pink = $('#sPink').val();

        //$.cookie('Invoice', $('#sInvoice').val(), { path: '/' })
        $.cookie('Pink', $('#sPink').val(), { path: '/' })

        var $gridrefresh = $('#Orders');
        var gridrfsh = $gridrefresh.data('tGrid');
        Grid_applyFilter(gridrfsh)
    });

    function Grid_applyFilter(grid) {

        // Get the search fields
        var Invoice = $.cookie('Invoice');
        var Pink = $.cookie('Pink');
        //var pgSize = grid.pageSize;

        //$('#sInvoice').val(Invoice);
        $('#sPink').val(Pink);

        // Get a copy of the telerik grid
        if (grid == null) return;
        var pgSize = $('#pageSize').val();
        if (!pgSize) { pgSize = "100"; }
        pathArray = window.location.pathname.split('/');
        //alert(pathArray[1]);

        grid.pageSize = parseInt(pgSize);
        grid.ajax.selectUrl = "/" + pathArray[1] + "/_ListOrders?Pink=" + Pink;
        grid.currentPage = 1;
        grid.updatePager();
        grid.ajaxRequest();

    }
</script>    


    <fieldset>
        <legend title="">Manage Orders</legend>

<table>
  
<tr>
    <td width="100px" title="">Pink Slip Number: </td><td><%: Html.TextBox("sPink", "", new { style = "width:120px;" }) %></td> 
    <td>
    <button id="btnRefresh" class="t-button" name="btnRefresh"><img src="../images/Shared/ButtonIcons/View.gif" /></button>
    </td> 
</tr>
    
    </table></fieldset>

    <table>
        <tr>
            <td>
                <h2>
                     Orders
                </h2>
            </td>
        </tr>
        <tr>
            <td>
             <%
                
                 Html.Telerik().Grid<Order>()
                    .Name("Orders")
                    .DataKeys(keys => keys.Add(s => s.OrderID))
                    .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Orders"))
                    .Columns(columns =>
                    {
                        columns.Bound(model => model.supplier);
                        columns.Bound(model => model.OrderDate).Format("{0:yyyy/MM/dd}");
                        columns.Bound(model => model.ExpectedDeliveryDate).Format("{0:yyyy/MM/dd}");
                        columns.Bound(model => model.PinkSlipNumber);
                        columns.Bound(model => model.Amount).Format("{0:c}");                                                        
                   
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
                                   .Select("_ListOrders", "Orders")
                                   .Insert("_InsertOrders", "Orders")
                                   .Update("_UpdateOrders", "Orders")
                                   .Delete("_RemoveOrders", "Orders");
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
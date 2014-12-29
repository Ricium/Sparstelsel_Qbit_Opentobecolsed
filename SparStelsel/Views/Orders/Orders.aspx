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
        var Suffix = $('#sSuffix').val();
        var Pink = $('#sPink').val();
        var Supplier = $('#sSupplier').val();
        var Comment = $('#sComment').val();

        var datepicker = $('#sFrom').data('tDatePicker');
        var fromdate = datepicker.value();

        var datepicker2 = $('#sTo').data('tDatePicker');
        var todate = datepicker2.value();

        $.cookie('Suffix', Suffix, { path: '/' });
        $.cookie('Pink', Pink, { path: '/' });
        $.cookie('Supplier', Supplier, { path: '/' });
        $.cookie('Comment', Comment, { path: '/' });
        $.cookie('From', fromdate, { path: '/' });
        $.cookie('To', todate, { path: '/' });

        var $gridrefresh = $('#Orders');
        var gridrfsh = $gridrefresh.data('tGrid');
        Grid_applyFilter(gridrfsh);
    });

    $('#btnExport').live("click", function () {
        var Suffix = $('#sSuffix').val();
        var Pink = $('#sPink').val();
        var Supplier = $('#sSupplier').val();
        var Comment = $('#sComment').val();

        var datepicker = $('#sFrom').data('tDatePicker');
        var fromdate = datepicker.value();

        var datepicker2 = $('#sTo').data('tDatePicker');
        var todate = datepicker2.value();

        $.cookie('Suffix', Suffix, { path: '/' });
        $.cookie('Pink', Pink, { path: '/' });
        $.cookie('Supplier', Supplier, { path: '/' });
        $.cookie('Comment', Comment, { path: '/' });
        $.cookie('From', fromdate, { path: '/' });
        $.cookie('To', todate, { path: '/' });

        var $gridrefresh = $('#Orders');
        var gridrfsh = $gridrefresh.data('tGrid');
        Grid_Export(gridrfsh);
    });

    function Grid_applyFilter(grid) {
        // Get the search fields
        var Suffix = $.cookie('Suffix');
        var Pink = $.cookie('Pink');
        var Supplier = $.cookie('Supplier');
        var From = $.cookie('From');
        var To = $.cookie('To');
        var Comment = $.cookie('Comment');

        $('#sSuffix').val(Suffix);
        $('#sPink').val(Pink);
        $('#sSupplier').val(Supplier);
        $('#sComment').val(Comment);

        // Get a copy of the telerik grid
        if (grid == null) return;
        var pgSize = $('#pageSize').val();
        if (!pgSize) { pgSize = "100"; }
        pathArray = window.location.pathname.split('/');
        //alert(pathArray[1]);

        grid.pageSize = parseInt(pgSize);
        grid.ajax.selectUrl = "/" + pathArray[1] + "/_ListOrders?Suffix=" + Suffix + "&Pink="
                + Pink + "&Supplier=" + Supplier + "&From=" + From + "&To=" + To + "&Comment=" + Comment;
        grid.currentPage = 1;
        grid.updatePager();
        grid.ajaxRequest();

    }

    function Grid_Export(grid) {
        // Get the search fields
        var Suffix = $.cookie('Suffix');
        var Pink = $.cookie('Pink');
        var Supplier = $.cookie('Supplier');
        var From = $.cookie('From');
        var To = $.cookie('To');
        var Comment = $.cookie('Comment');

        $('#sSuffix').val(Suffix);
        $('#sPink').val(Pink);
        $('#sSupplier').val(Supplier);
        $('#sComment').val(Comment);

        // Get a copy of the telerik grid
        if (grid == null) return;
        var pgSize = $('#pageSize').val();
        if (!pgSize) { pgSize = "100"; }
        pathArray = window.location.pathname.split('/');

        $.ajax({
            type: 'POST',
            url: '/Orders/_OrderGridExport/',
            data: { Suffix: Suffix, Pink: Pink, Supplier: Supplier, From: From, To: To, Comment: Comment },
            dataType: 'html',
            success: function (response, status, xhr) {
                grid.pageSize = parseInt(pgSize);
                grid.ajax.selectUrl = "/" + pathArray[1] + "/_ListOrders?Suffix=" + Suffix + "&Pink="
                        + Pink + "&Supplier=" + Supplier + "&From=" + From + "&To=" + To + "&Comment=" + Comment;
                grid.currentPage = 1;
                grid.updatePager();
                grid.ajaxRequest();

                // check for a filename
                var filename = "";
                var disposition = xhr.getResponseHeader('Content-Disposition');
                if (disposition && disposition.indexOf('attachment') !== -1) {
                    var filenameRegex = /filename[^;=\n]*=((['"]).*?\2|[^;\n]*)/;
                    var matches = filenameRegex.exec(disposition);
                    if (matches != null && matches[1]) filename = matches[1].replace(/['"]/g, '');
                }

                var type = xhr.getResponseHeader('Content-Type');
                var blob = new Blob([response], { type: type });

                if (typeof window.navigator.msSaveBlob !== 'undefined') {
                    // IE workaround for "HTML7007: One or more blob URLs were revoked by closing the blob for which they were created. These URLs will no longer resolve as the data backing the URL has been freed."
                    window.navigator.msSaveBlob(blob, filename);
                } else {
                    var URL = window.URL || window.webkitURL;
                    var downloadUrl = URL.createObjectURL(blob);

                    if (filename) {
                        // use HTML5 a[download] attribute to specify filename
                        var a = document.createElement("a");
                        // safari doesn't support this yet
                        if (typeof a.download === 'undefined') {
                            window.location = downloadUrl;
                        } else {
                            a.href = downloadUrl;
                            a.download = filename;
                            document.body.appendChild(a);
                            a.click();
                        }
                    } else {
                        window.location = downloadUrl;
                    }

                    setTimeout(function () { URL.revokeObjectURL(downloadUrl); }, 100); // cleanup
                }
            }
        });
    }
</script>    


    <fieldset>
        <legend title="">Manage Orders</legend>

<table>  
    <tr>
        <td width="100px" title="">Pink Slip Number: </td><td><%: Html.TextBox("sPink", "", new { style = "width:120px;" }) %></td> 
         <td width="30px" title="">Supplier: </td><td title=""><%: Html.DropDownList("sSupplier", ViewData["SupllierWithAll"]  as IEnumerable<SelectListItem>)%></td>  
    </tr> 
    <tr>
        <td width="100px" title="">Comment: </td><td><%: Html.DropDownList("sComment", ViewData["CommentsWithAll"]  as IEnumerable<SelectListItem>)%></td>
        <td width="100px" title="">Suffix: </td><td><%: Html.TextBox("sSuffix", "", new { style = "width:120px;" }) %></td>
    </tr>
    <tr>
           <td width="30px" title="">From: </td><td title=""><%: Html.Telerik().DatePicker().Name("sFrom")%></td> 
           <td width="30px" title="">To: </td><td title=""><%: Html.Telerik().DatePicker().Name("sTo")%></td> 
            <td>
                <button id="btnRefresh" class="t-button" name="btnRefresh">Filter</button>
            </td> 
           <td>
                <button id="btnExport" class="t-button" name="btnExport">Export</button>
            </td> 
        </tr>      
    </table>

    </fieldset>

    <table>
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
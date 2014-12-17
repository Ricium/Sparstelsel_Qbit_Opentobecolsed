<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   GRVLists
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script>
    $('#btnRefresh').live("click", function () {

        var Invoice = $('#sInvoice').val();
        var Pink = $('#sPink').val();
        var Supplier = $('#sSupplier').val();

        var datepicker = $('#sFrom').data('tDatePicker');
        var fromdate = datepicker.value();

        var datepicker2 = $('#sTo').data('tDatePicker');
        var todate = datepicker2.value();
        
        $.cookie('Invoice', Invoice, { path: '/' });
        $.cookie('Pink', Pink, { path: '/' });
        $.cookie('Supplier', Supplier, { path: '/' });
        $.cookie('From', fromdate, { path: '/' });
        $.cookie('To', todate, { path: '/' });

        var $gridrefresh = $('#GRVLists');
        var gridrfsh = $gridrefresh.data('tGrid');
        Grid_applyFilter(gridrfsh)
    });

    $('#btnExport').live("click", function () {

        var Invoice = $('#sInvoice').val();
        var Pink = $('#sPink').val();
        var Supplier = $('#sSupplier').val();

        var datepicker = $('#sFrom').data('tDatePicker');
        var fromdate = datepicker.value();

        var datepicker2 = $('#sTo').data('tDatePicker');
        var todate = datepicker2.value();

        $.cookie('Invoice', Invoice, { path: '/' });
        $.cookie('Pink', Pink, { path: '/' });
        $.cookie('Supplier', Supplier, { path: '/' });
        $.cookie('From', fromdate, { path: '/' });
        $.cookie('To', todate, { path: '/' });

        var $gridrefresh = $('#GRVLists');
        var gridrfsh = $gridrefresh.data('tGrid');
        Grid_Export(gridrfsh)
    });

    function Grid_applyFilter(grid) {

        // Get the search fields
        var Invoice = $.cookie('Invoice');
        var Pink = $.cookie('Pink');
        var Supplier = $.cookie('Supplier');
        var From = $.cookie('From');
        var To = $.cookie('To');
        //var pgSize = grid.pageSize;

        $('#sInvoice').val(Invoice);
        $('#sPink').val(Pink);
        $('#sSupplier').val(Supplier);

        // Get a copy of the telerik grid
        if (grid == null) return;
        var pgSize = $('#pageSize').val();
        if (!pgSize) { pgSize = "100"; }
        pathArray = window.location.pathname.split('/');
        //alert(pathArray[1]);

        grid.pageSize = parseInt(pgSize);
        grid.ajax.selectUrl = "/" + pathArray[1] + "/_ListGRVLists?Invoice=" + Invoice + "&Pink=" + Pink + "&Supplier=" + Supplier + "&From=" + From + "&To=" + To;
        grid.currentPage = 1;
        grid.updatePager();
        grid.ajaxRequest();

    }

    function Grid_Export(grid) {

        // Get the search fields
        var Invoice = $.cookie('Invoice');
        var Pink = $.cookie('Pink');
        var Supplier = $.cookie('Supplier');
        var From = $.cookie('From');
        var To = $.cookie('To');
        //var pgSize = grid.pageSize;

        $('#sInvoice').val(Invoice);
        $('#sPink').val(Pink);
        $('#sSupplier').val(Supplier);

        // Get a copy of the telerik grid
        if (grid == null) return;
        var pgSize = $('#pageSize').val();
        if (!pgSize) { pgSize = "100"; }
        pathArray = window.location.pathname.split('/');
        //alert(pathArray[1]);

        $.ajax({
            type: 'POST',
            url: '/GRV/_GRVListGridExport/',
            data: { Invoice: Invoice, Pink: Pink, Supplier: Supplier, From: From, To: To},
            dataType: 'html',
            success: function (response, status, xhr) {
                grid.pageSize = parseInt(pgSize);
                grid.ajax.selectUrl = "/" + pathArray[1] + "/_ListGRVLists?Invoice=" + Invoice + "&Pink=" + Pink + "&Supplier=" + Supplier + "&From=" + From + "&To=" + To;
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
   <legend title="">Manage GRVs</legend>
   <table>
       <tr>
            <td width="100px" title="">Invoice Number:</td><td><%: Html.TextBox("sInvoice", "", new { style = "width:120px;" })%></td>
            <td width="100px" title="">Pink Slip Number: </td><td><%: Html.TextBox("sPink", "", new { style = "width:120px;" }) %></td>
            <td width="30px" title="">Supplier: </td><td title=""><%: Html.DropDownList("sSupplier", ViewData["SupplierID"]  as IEnumerable<SelectListItem>)%></td>  
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
                
                 Html.Telerik().Grid<GRVList>()
                    .Name("GRVLists")
                    .DataKeys(keys => keys.Add(s => s.GRVListID))
                    .ToolBar(commands => 
                            {
                                commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add GRVList");
                                
                            })
                    .Columns(columns =>
                    {                 
                        columns.Bound(model => model.InvoiceNumber);
                        columns.Bound(model => model.StateDate).Format("{0:yyyy/MM/dd}");
                        columns.Bound(model => model.Number);
                        columns.Bound(model => model.PayDate).Format("{0:yyyy/MM/dd}");
                        columns.Bound(model => model.PinkSlipNumber).Width(120);
                        columns.Bound(model => model.GRVDate).Format("{0:yyyy/MM/dd}");
                        columns.Bound(model => model.InvoiceDate).Format("{0:yyyy/MM/dd}");
                        columns.Bound(model => model.ExcludingVat).Format("{0:c}");
                        columns.Bound(model => model.IncludingVat).Format("{0:c}");
                        columns.Bound(model => model.SupplierDetails);
                        columns.Bound(model => model.ExpectedPayDate).Format("{0:yyyy/MM/dd}");
                                          
                   
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
                                   .Select("_ListGRVLists", "GRV")
                                   .Insert("_InsertGRVLists", "GRV")
                                   .Update("_UpdateGRVLists", "GRV")
                                   .Delete("_RemoveGRVLists", "GRV");
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


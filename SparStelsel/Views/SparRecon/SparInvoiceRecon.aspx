<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Spar Invoice Recon
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        function onAutoCompleteDataBinding(e) {
            var supplierdd = $('#SupplierId').data('tDropDownList');
            var supplier = supplierdd.value();

            var datepicker = $('#StateDate').data('tDatePicker');
            var date = datepicker.inputValue;

            e.data = $.extend({}, e.data, { InvoiceDate: date, SupplierId: supplier });
        }

        function onAutoComplete(e)
        {
            var autoComplete = $('#InvoiceNumber').data('tAutoComplete');
            var invoicenumber = autoComplete.value();

            var supplierdd = $('#SupplierId').data('tDropDownList');
            var supplier = supplierdd.value();

            var datepicker = $('#StateDate').data('tDatePicker');
            var date = datepicker.inputValue;
            $.post('/SparRecon/_GetInvoiceAmount/', { InvoiceDate: date, SupplierId: supplier, InvoiceNumber: invoicenumber }, function (data) {
                var numberTextBox = $("#Amount").data("tTextBox");
                var newValue = data
                numberTextBox.value(newValue);
            });
        }
    </script>
    <table>
        <tr>
            <td>
                <h2>
                     Recons
                </h2>
            </td>
        </tr>
        <tr>
            <td>
             <%
                
                 Html.Telerik().Grid<SparInvoiceRecon>()
                    .Name("Recons")
                    .DataKeys(keys => keys.Add(s => s.SparReconId))
                    .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Payment"))
                    .Columns(columns =>
                    {
                        columns.Bound(model => model.StateDate).Format("{0:yyyy-MM-dd}");
                        //columns.Bound(model => model.SupplierId);
                        columns.Bound(model => model.InvoiceNumber);
                        columns.Bound(model => model.Amount);
                        columns.Bound(model => model.ModifiedDate).Format("{0:yyyy-MM-dd}");
                        columns.Bound(model => model.ModifiedBy);
                        columns.Bound(model => model.Status).Width(300);

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
                                   .Select("_GetRecons", "SparRecon")
                                   .Insert("_Insert", "SparRecon")
                                   .Update("_Update", "SparRecon")
                                   .Delete("_Remove", "SparRecon");
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


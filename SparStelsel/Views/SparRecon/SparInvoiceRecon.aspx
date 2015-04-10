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

            var datepicker = $('#GRVDate').data('tDatePicker');
            var date = datepicker.inputValue;


            e.data = $.extend({}, e.data, { InvoiceDate: date, SupplierId: supplier });
        }

        function onAutoComplete(e)
        {
            var autoComplete = $('#InvoiceNumber').data('tAutoComplete');
            var invoicenumber = autoComplete.value();

            var supplierdd = $('#SupplierId').data('tDropDownList');
            var supplier = supplierdd.value();

            var datepicker = $('#GRVDate').data('tDatePicker');
            var date = datepicker.inputValue;
            $.post('/SparRecon/_GetInvoiceAmount/', { InvoiceDate: date, SupplierId: supplier, InvoiceNumber: invoicenumber }, function (data) {
                $('#Amount').attr('value', data);
                $('#PaidAmount').attr('value', data);             

            });

        }

        function SelectRadio(e)
        {
            var suffix = '';
            if(e == 1)
            {
                suffix = ' - GRV';
                $('#CLM').prop('checked', false);
            }
            else
            {
                suffix = ' - CLM';
                $('#GRV').prop('checked', false);
            }

            var autoComplete = $('#InvoiceNumber').data('tAutoComplete');
            var invoicenumber = autoComplete.value();
            invoicenumber = invoicenumber.concat(suffix);

            autoComplete.value(invoicenumber);
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
                    .ToolBar(commands => {
                        commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Payment");
                        commands.Custom().ImageHtmlAttributes(new { style = "position:Relitive" }).ButtonType(GridButtonType.ImageAndText).Text("Add multiple Payments").Action("MultiPayment","SparRecon");
                    })
                    .Columns(columns =>
                    {
                        columns.Bound(model => model.GRVDate).Format("{0:yyyy-MM-dd}");
                        //columns.Bound(model => model.SupplierId);
                        columns.Bound(model => model.InvoiceNumber);
                        columns.Bound(m => m.PaidAmount).Format("{0:c}").HtmlAttributes(new { style = "text-align:right" }); 
                        columns.Bound(model => model.Amount).Format("{0:c}").HtmlAttributes(new { style = "text-align:right" }); 
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


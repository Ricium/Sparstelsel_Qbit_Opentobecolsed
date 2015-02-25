<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   ProofOfPayments
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        function OpenInvoices()
        {
            var supplierdd = $('#SupplierID').data('tDropDownList');
            var supplier = supplierdd.value();

            $.post('/Payment/_CheckSupplierType/', { SupplierId: supplier }, function (data) {
                if (data == "DI")
                {
                    $('#Invoiceload').show();
                }
                else
                {
                    $('#InvoiceNumber').attr('value', '');
                    $('#Invoiceload').hide();
                }
            });
        }

        function CheckSupplier(e)
        {
            var supplierdd = $('#SupplierID').data('tDropDownList');
            var supplier = supplierdd.value();

            e.data = $.extend({}, e.data, { SupplierId: supplier });
        }
    </script>
    <table>
        <tr>
            <td>
                <h2>
                     Payments
                </h2>
            </td>
        </tr>
        <tr>
            <td>
             <%
                
                 Html.Telerik().Grid<ProofOfPayment>()
                    .Name("ProofOfPayments")
                    .DataKeys(keys => keys.Add(s => s.ProofOfPaymentID))
                    .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add Payment"))
                    .Columns(columns =>
                    {

                        columns.Bound(model => model.ActualDate).Format("{0:yyyy/MM/dd}");
                        columns.Bound(model => model.ModifiedDate).Format("{0:yyyy/MM/dd}");
                        columns.Bound(model => model.PaymentDescription);
                        columns.Bound(model => model.Amount).Format("{0:c}");
                        columns.Bound(model => model.cashtype);
                                               
                   
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
                                   .Select("_ListProofOfPayments", "Payment")
                                   .Insert("_Insert", "Payment")
                                   .Update("_UpdateProofOfPayments", "Payment")
                                   .Delete("_RemoveProofOfPayments", "Payment");
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


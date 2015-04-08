<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SparInvoiceRecon>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Multiple Recon
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        function buttonInsertFunds() {
            var form = $('#FundForm').serialize();

            $.ajax({
                type: 'POST',
                url: '/SparRecon/_InsertPaymentFromMulti/',
                data: form,
                dataType: 'html',
                success: function (htmlData) {
                    $('#InsertedContent').prepend(htmlData + "<br/>");
                    //$('#FundForm').trigger('reset');                    
                    $("#InvoiceNumber").attr('value', '');
                    $("#InvoiceNumber").focus();
                    $("#Amount").attr('value', '');
                    $("#PaidAmount").attr('value', '');

                    var autoComplete = $('#InvoiceNumber').data('tAutoComplete');
                    autoComplete.reload();



                }
            });
        }

        function InsertFunds(e)
        {
            var charCode = (typeof e.which === "number") ? e.which : e.keyCode;

            if (charCode == '17') {
                var form = $('#FundForm').serialize();

                $.ajax({
                    type: 'POST',
                    url: '/Money/_InsertPaymentFromMulti/',
                    data: form,
                    dataType: 'html',
                    success: function (htmlData) {
                        $('#InsertedContent').prepend(htmlData + "<br/>");
                        //$('#FundForm').trigger('reset');                    
                        $("#InvoiceNumber").attr('value', '');
                        $("#InvoiceNumber").focus();
                        $("#Amount").attr('value', '');
                        $("#PaidAmount").attr('value', '');

                        var autoComplete = $('#InvoiceNumber').data('tAutoComplete');
                        autoComplete.reload();

                        var count = $("#Count").attr('value');
                        count++;
                        $("#Count").attr('value', count);

                   
                    }
                });
            }
        }

                function onAutoCompleteDataBinding(e) {
                    var supplierdd = $('#SupplierId').data('tDropDownList');
                    var supplier = supplierdd.value();

                    var datepicker = $('#GRVDate').data('tDatePicker');
                    var date = datepicker.inputValue;


                    e.data = $.extend({}, e.data, { InvoiceDate: date, SupplierId: supplier });
                }

                function onAutoComplete(e) {
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
            
        
    </script>
    <table>
        <tr>
            <td>
                <h2>
                     Multiple Payments
                </h2>
            </td>
        </tr>
        <tr>
            <td>
                <form id="FundForm">
                    <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.SparReconId) %>
                        </td>
                        <td>
                            <%: Html.HiddenFor(m => m.GRVTypeId) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.GRVDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.GRVDate).Value(DateTime.Today).TodayButton()  %>
                            <%: Html.ValidationMessageFor(m => m.GRVDate) %>
                        </td>
                    </tr>
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.SupplierId)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.SupplierId).BindTo((IEnumerable<SelectListItem>) ViewData["Suppliers"])
                                .HtmlAttributes(new { style = "width: 300px" }) %>
                            <%: Html.ValidationMessageFor(model => model.SupplierId) %>
                        </td>
                    </tr>
                     <tr>
                        <td>
                           <%: Html.LabelFor(m => m.InvoiceNumber) %>
                        </td>
                        <td>
                            
                            <%: Html.Telerik().AutoCompleteFor(m => m.InvoiceNumber) 
                                .DataBinding(d => d.Ajax().Select("_GetInvoices", "SparRecon"))
                                .AutoFill(true).Filterable(f => f.FilterMode(AutoCompleteFilterMode.Contains))
                                .Enable(true).HtmlAttributes(new { style = "width: 300px" })
                                .ClientEvents(e => e.OnDataBinding("onAutoCompleteDataBinding").OnClose("onAutoComplete").OnLoad("onAutoCompleteDataBinding"))
                                
                                %>
                            <%: Html.ValidationMessageFor(m => m.InvoiceNumber) %>
                        </td>
                    </tr>

                   <tr>
                     <td>
                           <%: Html.LabelFor(m => m.Amount)%>
                        </td>
                        <td>
                          R <%: Html.TextBoxFor(m => m.Amount)%>
                            <%: Html.ValidationMessageFor(model => model.Amount) %>
                        </td>
                    </tr>   
                                       <tr>
                     <td>
                           <%: Html.LabelFor(m => m.PaidAmount)%>
                        </td>
                        <td>
                          R <%: Html.TextBoxFor(m => m.PaidAmount)%>
                            <%: Html.ValidationMessageFor(model => model.PaidAmount) %>
                        </td>
                    </tr> 
                 </table>    

                    
                </form>
                <button type='button' class='t-button' id='InsertFund' onclick='buttonInsertFunds()'>Insert</button>  <%: Html.ActionLink("Back","SparInvoiceRecon","SparRecon")%>
            </td>
        </tr>
        <tr>
            <td>
                <div id="InsertedContent"></div>
            </td>
            <td>
             
            </td>

        </tr>
    </table>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ElectronicFund>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Coin Movement
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        function buttonInsertFunds() {
            var form = $('#FundForm').serialize();

            $.ajax({
                type: 'POST',
                url: '/Money/_InsertElectronicFromMulti/',
                data: form,
                dataType: 'html',
                success: function (htmlData) {
                    $('#InsertedContent').prepend("R " + htmlData + "<br/>");
                    //$('#FundForm').trigger('reset');                    
                    $("#Total").attr('value', '');
                    $("#Total").focus();

                    var count = $("#Count").attr('value');
                    count++;
                    $("#Count").attr('value', count);

                    var total = parseFloat($("#BigTotal").attr('value'));
                    total += parseFloat(htmlData);
                    $("#BigTotal").attr('value', total);
                }
            });
        }

        function InsertFunds(e)
        {
            var charCode = (typeof e.which === "number") ? e.which : e.keyCode;

            if (charCode == '13') {
                var form = $('#FundForm').serialize();

                $.ajax({
                    type: 'POST',
                    url: '/Money/_InsertElectronicFromMulti/',
                    data: form,
                    dataType: 'html',
                    success: function (htmlData) {
                        $('#InsertedContent').prepend("R " + htmlData + "<br/>");
                        //$('#FundForm').trigger('reset');                    
                        $("#Total").attr('value', '');
                        $("#Total").focus();

                        var count = $("#Count").attr('value');
                        count++;
                        $("#Count").attr('value', count);

                        var total = parseFloat($("#BigTotal").attr('value'));
                        total += parseFloat(htmlData);
                        $("#BigTotal").attr('value', total);
                    }
                });
            }
        }
    </script>
    <table>
        <tr>
            <td>
                <h2>
                     Electronic Funds
                </h2>
            </td>
        </tr>
        <tr>
            <td>
                <form id="FundForm">
                    <table>
                   <tr>
                     <td>
                         <%: Html.HiddenFor(m => m.ElectronicFundID) %>
                           <%: Html.LabelFor(m => m.MovementTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.MovementTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["Movements"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.MovementTypeID) %>
                        </td>
                    </tr>

                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.ActualDate)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DatePickerFor(m => m.ActualDate).Value(DateTime.Today).TodayButton() %>
                            <%: Html.ValidationMessageFor(model => model.MovementTypeID) %>
                        </td>
                    </tr>
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.EmployeeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.EmployeeID).BindTo((IEnumerable<SelectListItem>) ViewData["Employees"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.EmployeeID) %>
                        </td>
                    </tr>
                        <tr>
                     <td>
                           <%: Html.LabelFor(m => m.ElectronicTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.ElectronicTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["ElectronicType"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.ElectronicTypeID) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Total) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Total, new { onkeyup="InsertFunds(event)" })%>
                            <%: Html.ValidationMessageFor(m => m.Total) %>
                        </td>
                    </tr> 
                </table>

                    
                </form>
                <button type='button' class='t-button' id='InsertFund' onclick='buttonInsertFunds()'>Insert</button>
            </td>
        </tr>
        <tr>
            <td>
                <div id="InsertedContent"></div>
            </td>
            <td>
                <%: Html.TextBox("Count", 0)%>
            </td>
            <td>
                <%: Html.TextBox("BigTotal", 0)%>
            </td>
        </tr>
    </table>
</asp:Content>


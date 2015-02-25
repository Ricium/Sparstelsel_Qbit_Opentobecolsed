<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CashierDayEnd>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Cashier Day-end
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        Number.prototype.formatMoney = function (places, symbol, thousand, decimal) {
            places = !isNaN(places = Math.abs(places)) ? places : 2;
            symbol = symbol !== undefined ? symbol : "$ ";
            thousand = thousand || ",";
            decimal = decimal || ".";
            var number = this,
                negative = number < 0 ? "-" : "",
                i = parseInt(number = Math.abs(+number || 0).toFixed(places), 10) + "",
                j = (j = i.length) > 3 ? j % 3 : 0;
            return symbol + negative + (j ? i.substr(0, j) + thousand : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + thousand) + (places ? decimal + Math.abs(number - i).toFixed(places).slice(2) : "");
        };

        function buttonInsertFunds() {
            var form = $('#FundForm').serialize();

            $.ajax({
                type: 'POST',
                url: '/Money/_InsertElectronicFromMulti/',
                data: form,
                dataType: 'html',
                success: function (htmlData) {
                    var count = $("#Count").attr('value');

                    var col = $("#col").attr('value');
                    var colselect = count % 15;
                    count++;
                    if (colselect == 0) {
                        col++;
                        $("#col").attr('value', col);
                    }

                    $('#InsertedContent #col' + col).append(parseFloat(htmlData).formatMoney(2, "R ", " ", ".") + "<br/>");
                    //$('#FundForm').trigger('reset');

                    $("#ElectronicFund_Total").attr('value', '');
                    $("#ElectronicFund_Total").focus();

                    $("#Count").attr('value', count);

                    var total = parseFloat($("#BigTotal").attr('value'));
                    total += parseFloat(htmlData);
                    $("#BigTotal").attr('value', total);

                    $('#CountValue').empty();
                    $('#CountValue').append("Count: " + count);

                    $('#BigTotalValue').empty();
                    var t = total.formatMoney(2, "R ", " ", ".");
                    $('#BigTotalValue').append("Total: " + t);

                    DisableCashierSelect();

                    $('#DoneSelect').show();
                    //EnableItem(3);

                    //SelectItem(3);
                }
            });
        }

        function InsertFunds(e) {
            var charCode = (typeof e.which === "number") ? e.which : e.keyCode;

            if (charCode == '13') {
                var form = $('#FundForm').serialize();

                $.ajax({
                    type: 'POST',
                    url: '/Money/_InsertElectronicFromMulti/',
                    data: form,
                    dataType: 'html',
                    success: function (htmlData) {
                        var count = $("#Count").attr('value');

                        var col = $("#col").attr('value');
                        var colselect = count % 15;
                        count++;
                        if (colselect == 0) {
                            col++;
                            $("#col").attr('value', col);
                        }

                        $('#InsertedContent #col' + col).append(parseFloat(htmlData).formatMoney(2, "R ", " ", ".") + "<br/>");
                        //$('#FundForm').trigger('reset');                    

                        $("#ElectronicFund_Total").attr('value', '');
                        $("#ElectronicFund_Total").focus();



                        $("#Count").attr('value', count);

                        var total = parseFloat($("#BigTotal").attr('value'));
                        total += parseFloat(htmlData);
                        $("#BigTotal").attr('value', total);

                        $('#CountValue').empty();
                        $('#CountValue').append("Count: " + count);

                        $('#BigTotalValue').empty();
                        var t = total.formatMoney(2, "R ", " ", ".");
                        $('#BigTotalValue').append("Total: " + t);
                        $('#DoneSelect').show();

                        DisableCashierSelect();

                        //EnableItem(3);
                        //SelectItem(3);
                    }
                });
            }
        }

        function InsertSigma(e) {

            var form = $('#SigmaForm').serialize();
            $.post('/Money/_SigmaCashier/', form, function (data) {
                $('#SigmaForm').trigger('reset');
                var total = parseFloat(data);
                $('#SigmaSelector').hide();
                $('#SigmaCompleted').show();
                $('#SigmaContainer').append("Sigma Total: " + total.formatMoney(2, "R ", " ", "."));
                DisableCashierSelect();
            });

            EnableItem(2);
            SelectItem(2);

            return false;
        }

        function InsertMultipeCashMovements(e) {
            var form = $('#MultipleCashMovementsForm').serialize();
            $.post('/Money/_InsertMultipleCashCashier/', form, function (data) {
                $('#MultipleCashMovementsForm').trigger('reset');
                var total = parseFloat(data);
                $('#CashContainer').append("Cash Total: " + total.formatMoney(2, "R ", " ", "."));
                $('#CashSelector').hide();
                $('#CashCompleted').show();
                DisableCashierSelect();
            });

            EnableItem(1);
            SelectItem(1);


            return false;
        }

        function ChangeDate() {
            var datepicker = $('#ActualDate').data('tDatePicker');

            var d = datepicker.value();
            var curr_date = d.getDate();
            var curr_month = d.getMonth() + 1; //Months are zero based
            var curr_year = d.getFullYear();
            var new_val = curr_year + "-" + curr_month + "-" + curr_date;

            $('#CashMovements_ActualDate').val(new_val);
            $('#ElectronicFund_ActualDate').val(new_val);
            $('#SigmaSale_ActualDate').val(new_val);
            $('#ReportActualDate').val(new_val);
        }

        function ChangeEmployee() {
            var employeepicker = $('#EmployeeID').data('tDropDownList');

            $('#CashMovements_EmployeeID').val(employeepicker.value());
            $('#ElectronicFund_EmployeeID').val(employeepicker.value());
            $('#SigmaSale_EmployeeID').val(employeepicker.value());
            $('#ReportEmployeeID').val(employeepicker.value());
        }

        function ShowCash() {
            $('#CashSelector').show();
            $('#CashCompleted').hide();
            $('#CashContainer').empty();
        }

        function ShowSigma() {
            $('#SigamSelector').show();
            $('#SigmaCompleted').hide();
            $('#SigmaContainer').empty();
        }

        function SelectItem(item) {
            var tabStrip = $("#CashierTab").data("tTabStrip");
            tabStrip.select($(".t-item", tabStrip.element)[item]);
        }

        function EnableItem(item) {
            var tabStrip = $("#CashierTab").data("tTabStrip");
            tabStrip.enable($(".t-item", tabStrip.element)[item]);
        }

        function DisableItem(item) {
            var tabStrip = $("#CashierTab").data("tTabStrip");
            tabStrip.disable($(".t-item", tabStrip.element)[item]);
        }

        function GotoReport() {
            EnableItem(3);
            SelectItem(3);
            DisableItem(0);
            DisableItem(1);
            DisableItem(2);

            var form = $('#ReportForm').serialize();
            $.post('/Money/_CashierDayEndReportShow/', form, function (data) {
                $('#Report').html(data);
            });
        }

        function DisableCashierSelect(){
            var datepicker = $('#ActualDate').data('tDatePicker');
            var employeepicker = $('#EmployeeID').data('tDropDownList');

            datepicker.disable();
            employeepicker.disable();
        }
    </script>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>Cashier
                        </td>
                        <td>
                            <%: Html.Telerik().DropDownListFor(m => m.EmployeeID).BindTo((IEnumerable<SelectListItem>)ViewData["Employees"])
                                .ClientEvents(e => e.OnChange("ChangeEmployee").OnLoad("ChangeEmployee")) %>
                        </td>
                    </tr>
                    <tr>
                        <td>Date
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m=>m.ActualDate).Value(DateTime.Today).TodayButton()
                            .ClientEvents(e => e.OnChange("ChangeDate").OnLoad("ChangeDate")) %>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>


    <% Html.Telerik().TabStrip()
            .Name("CashierTab")
            .Items(tab =>
            {
                tab.Add().Text("Cash").Content(() =>
                    {%>
    <div id="CashCompleted" style="display: none; font-size: large">
        Your cash was sucessfully inserted. See your report for details.<br />
        To capture cash again, click here
        <button onclick="ShowCash()" class="t-button">Capture Cash</button>
    </div>
    <div id="CashSelector">
        <form id="MultipleCashMovementsForm" method="post">
            <table>
                <tr>
                    <td>
                        <%: Html.HiddenFor(m => m.CashMovements.ActualDate) %>
                        <%: Html.HiddenFor(m => m.CashMovements.EmployeeID) %>
                        <%: Html.HiddenFor(m => m.CashMovements.MovementTypeID) %>
                    </td>
                </tr>
                <% for (int i = 0; i < Model.CashMovements.Movements.Count; i++)
                   {
                %>
                <tr>
                    <td>
                        <%: Html.DisplayFor(c => c.CashMovements.Movements[i].moneyunit) %>
                        <%: Html.HiddenFor(c => c.CashMovements.Movements[i].MoneyUnitID) %>
                    </td>
                    <td>
                        <%: Html.Telerik().IntegerTextBoxFor(c => c.CashMovements.Movements[i].Count).MinValue(0)%>
                    </td>
                </tr>
                <% } %>
            </table>
        </form>
        <button id="SubmitMultipleCashMovements" onclick="InsertMultipeCashMovements()" class="t-button">Save</button>
    </div>
    <br />
    <div id="CashContainer" style="font-size: large"></div>                      
                    <%});

                tab.Add().Text("Sigma Sales").Content(() =>
                      { %> 
    <div id="SigmaCompleted" style="display: none; font-size: large">
        Your Sigma Sale was sucessfully inserted. See your report for details.<br />
        To capture Sigma again, click here
        <button onclick="ShowSigma()" class="t-button">Capture Sigma</button>
    </div>
    <div id="SigmaSelector">
        <form id="SigmaForm" method="post">
            <table>
                <tr>
                    <td>
                        <%: Html.HiddenFor(m => m.SigmaSale.ActualDate) %>
                        <%: Html.HiddenFor(m => m.SigmaSale.EmployeeID) %>
                        <%: Html.HiddenFor(m => m.SigmaSale.MovementTypeID) %>
                        <%: Html.HiddenFor(m => m.SigmaSale.ReconciliationTypeID) %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.SigmaSale.Amount) %>
                    </td>
                    <td>
                        <%: Html.Telerik().CurrencyTextBoxFor(m => m.SigmaSale.Amount) %>
                        <%: Html.ValidationMessageFor(m => m.SigmaSale.Amount) %>
                    </td>
                </tr>
            </table>
        </form>
        <button id="SubmitSigma" onclick="InsertSigma()" class="t-button">Save</button>
    </div>
    <div id="SigmaContainer" style="font-size: large"></div> 
                    <% }).Enabled(false);

                      tab.Add().Text("Electronic Funds").Content(() =>
                          { %>
    <table>
        <tr>
            <td>
                <form id="FundForm">
                    <table>
                        <tr>
                            <td>
                                <%: Html.HiddenFor(m => m.ElectronicFund.ElectronicFundID)%>
                                <%: Html.HiddenFor(m => m.ElectronicFund.ActualDate) %>
                                <%: Html.HiddenFor(m => m.ElectronicFund.EmployeeID) %>                                
                                <%: Html.HiddenFor(m => m.ElectronicFund.MovementTypeID) %>
                                <input type="hidden" value="0" id="col" />
                                <input type="hidden" value="0" id="Count" />
                                <input type="hidden" value="0" id="BigTotal" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <%: Html.LabelFor(m => m.ElectronicFund.ElectronicTypeID)%>
                            </td>
                            <td>
                                <%: Html.Telerik().DropDownListFor(m => m.ElectronicFund.ElectronicTypeID).BindTo((IEnumerable<SelectListItem>)ViewData["ElectronicType"]).HtmlAttributes(new { style = "width: 250px" })%>
                                <%: Html.ValidationMessageFor(model => model.ElectronicFund.ElectronicTypeID)%>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <%: Html.LabelFor(m => m.ElectronicFund.Total)%>
                            </td>
                            <td>
                                <%: Html.TextBoxFor(m => m.ElectronicFund.Total, new { onkeyup = "InsertFunds(event)" })%>
                                <%: Html.ValidationMessageFor(m => m.ElectronicFund.Total)%>
                            </td>
                        </tr>
                    </table>
                </form>
                <button type='button' class='t-button' id='InsertFund' onclick='buttonInsertFunds()'>Insert</button>
            </td>
            <td>
                <div id="InsertedContent">
                    <table>
                        <tr>
                            <td id="col1"></td>
                            <td id="col2"></td>
                            <td id="col3"></td>
                            <td id="col4"></td>
                            <td id="col5"></td>
                            <td id="col6"></td>
                            <td id="col7"></td>
                            <td id="col8"></td>
                            <td id="col9"></td>
                            <td id="col10"></td>
                            <td id="col11"></td>
                            <td id="col12"></td>
                            <td id="col13"></td>
                            <td id="col14"></td>
                            <td id="col15"></td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div id="CountValue" style="font-size: large"></div>
                <div id="BigTotalValue" style="font-size: large"></div>
            </td>
            <td>
                <div id="DoneSelect" style="display: none">
                    <button id="DoneButton" onclick="GotoReport()" class="t-button">Go To Report</button>
                </div>
            </td>
        </tr>
    </table>
                    <%
                    }).Enabled(false);

                tab.Add().Text("Report").Content(() =>
                    {
                        %> 
                            <form id="ReportForm">
                                <%: Html.HiddenFor(m => m.ReportActualDate) %>
                                <%: Html.HiddenFor(m => m.ReportEmployeeID) %>
                            </form>
                            <div id="Report"></div> <%
                    }).Enabled(false);
            })
            .SelectedIndex(0).Effects(e => e.Expand())
            .Render();
    %>




    
</asp:Content>


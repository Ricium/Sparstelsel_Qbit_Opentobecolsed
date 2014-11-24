<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CashEntry>" %>
<%@ Import Namespace ="SparStelsel" %>
<%@ Import Namespace="SparStelsel.Models" %>
<%@ Import Namespace="SparStelsel.Controllers" %>
<!DOCTYPE html>
<html>
    <head>
        <title></title>
        <script type="text/javascript">
            function SaveCashForm() {
                var form = $('#CashForm').serialize();
                $.post('/CashUp/InsertCashMovement/', form, function (data) {
                    $('#CashForm').trigger('reset');
                });
            }
        </script>
    </head>
        <body>
       <form id="CashForm" name="CashForm" method="post">
                <%: Html.HiddenFor(m => m.UserID) %>
                <%:Html.HiddenFor(m => m.CurrentDate) %>
           <%:Html.HiddenFor(m => m.CashTypeID) %>
            <table>
                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.R200) %>
                    </td>
                    <td>
                       <%: Html.TextBoxFor(m => m.R200)%>
                    </td>
                </tr>
                                <tr>
                    <td>
                         <%: Html.LabelFor(m => m.R100) %>
                    </td>
                    <td>
                        <%: Html.TextBoxFor(m => m.R100)%>
                    </td>
                </tr>
                                <tr>
                    <td>
                          <%: Html.LabelFor(m => m.R50) %>
                    </td>
                    <td>
                         <%: Html.TextBoxFor(m => m.R50)%>
                    </td>
                </tr>
                                <tr>
                    <td>
                       <%: Html.LabelFor(m => m.R20) %>
                    </td>
                    <td>
                         <%: Html.TextBoxFor(m => m.R20)%>
                    </td>
                </tr>
                                <tr>
                    <td>
                    <%: Html.LabelFor(m => m.R10) %>
                    </td>
                    <td>
                         <%: Html.TextBoxFor(m => m.R10)%>
                    </td>
                </tr>
                                <tr>
                    <td>
                      <%: Html.LabelFor(m => m.R5) %>
                    </td>
                    <td>
                       <%: Html.TextBoxFor(m => m.R5)%>
                    </td>
                </tr>
                                <tr>
                    <td>
                       <%: Html.LabelFor(m => m.R2) %>
                    </td>
                    <td>
                        <%: Html.TextBoxFor(m => m.R2)%>
                    </td>
                </tr>
                                <tr>
                    <td>
                      <%: Html.LabelFor(m => m.R1) %>
                    </td>
                    <td>
                        <%: Html.TextBoxFor(m => m.R1)%>
                    </td>
                </tr>
                                <tr>
                    <td>
                         <%: Html.LabelFor(m => m.R050) %>
                    </td>
                    <td>
                        <%: Html.TextBoxFor(m => m.R050)%>
                    </td>
                </tr>
                                <tr>
                    <td>
                       <%: Html.LabelFor(m => m.R020) %>
                    </td>
                    <td>
                       <%: Html.TextBoxFor(m => m.R020)%>
                    </td>
                </tr>
                                <tr>
                    <td>
                        <%: Html.LabelFor(m => m.R010) %>
                    </td>
                    <td>
                         <%: Html.TextBoxFor(m => m.R010)%>
                    </td>
                </tr>
            </table>
           <button class="t-button" onclick="SaveCashForm()">&nbsp Save</button>
           </form>
        </body>
    
</html>

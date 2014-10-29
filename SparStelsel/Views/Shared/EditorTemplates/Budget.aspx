<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Budget>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Budget </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.BudgetID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.BudgetDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.BudgetDate) %>
                            <%: Html.ValidationMessageFor(m => m.BudgetDate) %>
                        </td>
                    </tr>
                    <tr>
                                            <tr>
                        <td>
                            <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.Amount) %>
                        </td>
                        <td>
                            <%: Html.Telerik().CurrencyTextBoxFor(m => m.Amount) %>
                            <%: Html.ValidationMessageFor(m => m.Amount) %>
                        </td>
                    </tr>
                    <tr>

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

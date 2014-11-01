<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<PickUpKwikpay>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Pick Up </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.PickUpID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.ActualDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.ActualDate) %>
                            <%: Html.ValidationMessageFor(m => m.ActualDate) %>
                        </td>
                    </tr>
                                        <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Amount) %>
                        </td>
                        <td>
                            <%: Html.Telerik().CurrencyTextBoxFor(m => m.Amount) %>
                            <%: Html.ValidationMessageFor(m => m.Amount) %>
                        </td>
                    </tr>
                                     

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

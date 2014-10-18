<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MoneyUnit>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>KwikPayType </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.MoneyUnitID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.MoneyUnits) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.MoneyUnits) %>
                            <%: Html.ValidationMessageFor(m => m.MoneyUnits) %>
                        </td>
                    </tr>
                    <tr>

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

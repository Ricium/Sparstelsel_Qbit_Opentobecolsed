<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<InstantMoneyType>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>InstantMoneyType </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.InstantMoneyTypeID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.InstantMoneyTypes) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.InstantMoneyTypes) %>
                            <%: Html.ValidationMessageFor(m => m.InstantMoneyTypes) %>
                        </td>
                    </tr>
                    <tr>

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<GRVType>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>GRVType </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.GRVTypeID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.GRVTypes) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.GRVTypes) %>
                            <%: Html.ValidationMessageFor(m => m.GRVTypes) %>
                        </td>
                    </tr>
                    <tr>

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

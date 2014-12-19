<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<PickUpFNB>" %>
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
               <%: Html.TextBox("r100") %>
            </td>
            <td>
               <%: Html.TextBox("r200") %>
            </td>
        </tr>
    </table>

    
</body>
</html>

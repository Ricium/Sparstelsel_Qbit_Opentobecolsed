<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CashType>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>CashType </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.CashTypeID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.CashTypes) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.CashTypes) %>
                            <%: Html.ValidationMessageFor(m => m.CashTypes) %>
                        </td>
                    </tr>
                    <tr>
                  
                                     

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

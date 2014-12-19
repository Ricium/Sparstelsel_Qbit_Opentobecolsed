<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CashMovementKwikPay>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>KwikPay </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

  
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.CashMovementID) %>
                      
                        </td>
                        <td></td>
                    </tr>
                                        <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Amount) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Amount) %>
                            <%: Html.ValidationMessageFor(m => m.Amount) %>
                        </td>
                    </tr>
                   
    </table>

    
</body>
</html>

<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<KwikPay>" %>
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
                            <%: Html.HiddenFor(m => m.KwikPayID) %>
                            <%: Html.HiddenFor(m => m.KwikPayTypeID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.ActualDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DateTimePickerFor(m => m.ActualDate) %>
                            <%: Html.ValidationMessageFor(m => m.ActualDate) %>
                        </td>
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

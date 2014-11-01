<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<KwikPay>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Expected </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.KwikPayID) %>
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
                                      <tr>
                     <td>
                           <%: Html.LabelFor(m => m.KwikPayTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.KwikPayTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["KwikPayType"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.KwikPayTypeID) %>
                        </td>
                    </tr>          

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

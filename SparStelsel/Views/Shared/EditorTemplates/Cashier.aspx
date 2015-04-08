<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Cashier>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Cashier</title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.CashierID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.Name) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Name) %>
                            <%: Html.ValidationMessageFor(m => m.Name) %>
                        </td>
                    </tr>
                           <tr>
                        <td>
                            <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.Surname) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Surname) %>
                            <%: Html.ValidationMessageFor(m => m.Surname) %>
                        </td>
                    </tr>
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.CompanyID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.CompanyID).BindTo((IEnumerable<SelectListItem>) ViewData["Company"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.CompanyID) %>
                        </td>
                    </tr>               
                    <tr>
                        <td>
                            <b Class=asteriks>*</b> Username of Cashier
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.ModifiedBy) %>
                            <%: Html.ValidationMessageFor(m => m.ModifiedBy) %>
                        </td>
                    </tr>
                </table>
    

    
</body>
</html>

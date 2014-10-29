<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<ElectronicFund>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>ElectronicFunds </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.ElectronicTypeID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.ElectronicFunds) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.ElectronicFunds) %>
                            <%: Html.ValidationMessageFor(m => m.ElectronicFunds) %>
                        </td>
                    </tr>
                                        <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Total) %>
                        </td>
                        <td>
                            <%: Html.Telerik().CurrencyTextBoxFor(m => m.Total) %>
                            <%: Html.ValidationMessageFor(m => m.Total) %>
                        </td>
                    </tr>
  
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.ElectronicTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.ElectronicTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["ElectronicType"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.ElectronicTypeID) %>
                        </td>
                    </tr> 
                    <tr>
                               
                  
                                     

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<InstantMoney>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Instant Money</title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.InstantMoneyID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.EmployeeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.EmployeeID).BindTo((IEnumerable<SelectListItem>) ViewData["Employees"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.EmployeeID) %>
                        </td>
                    </tr> 
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.ActualDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.ActualDate).Value(DateTime.Today).TodayButton()  %>
                            <%: Html.ValidationMessageFor(m => m.ActualDate) %>
                        </td>
                    </tr> 
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.InstantMoneyTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.InstantMoneyTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["InstantMoneyType"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.InstantMoneyTypeID) %>
                        </td>
                    </tr>                   
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Amount) %>
                        </td>
                        <td>
                            <%: Html.Telerik().CurrencyTextBoxFor(m => m.Amount).CurrencySymbol("R") %>
                            <%: Html.ValidationMessageFor(m => m.Amount) %>
                        </td>
                    </tr>                               
                  
                                     

                </table>    
</body>
</html>

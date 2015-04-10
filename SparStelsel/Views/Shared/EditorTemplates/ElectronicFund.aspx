<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<ElectronicFund>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Electronic Fund</title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

                <table>
                   <tr>
                     <td>
                         <%: Html.HiddenFor(m => m.ElectronicFundID) %>
                           <%: Html.LabelFor(m => m.MovementTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.MovementTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["Movements"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.MovementTypeID) %>
                        </td>
                    </tr>

                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.ActualDate)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DatePickerFor(m => m.ActualDate).Value(DateTime.Today).TodayButton() %>
                            <%: Html.ValidationMessageFor(model => model.MovementTypeID) %>
                        </td>
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
                           <%: Html.LabelFor(m => m.Total) %>
                        </td>
                        <td>
                          R  <%: Html.TextBoxFor(m => m.Total)  %>
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


    
</body>
</html>

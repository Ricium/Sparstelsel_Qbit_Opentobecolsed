﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Order>" %>
<%@ Import Namespace ="SparStelsel" %>
<%@ Import Namespace="SparStelsel.Models" %>
<%@ Import Namespace="SparStelsel.Controllers" %>

<!DOCTYPE html>
<html>
    <head id="Head1" runat="server">
    <title></title>    
    </head>
        <body>            
  <% using (Html.BeginForm("_InsertProductOrder", "Orders", FormMethod.Post))
            { %>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.OrderID) %>
                        </td>
                        <td>
                            <%: Html.HiddenFor(m => m.Amount) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.PinkSlipNumber) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.PinkSlipNumber) %>
                            <%: Html.ValidationMessageFor(m => m.PinkSlipNumber) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.OrderDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.OrderDate).Value(DateTime.Today).TodayButton()  %>
                            <%: Html.ValidationMessageFor(m => m.OrderDate) %>
                        </td>
                    </tr>
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.SupplierID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.SupplierID).BindTo((IEnumerable<SelectListItem>) ViewData["Supllier"]).HtmlAttributes(new { style = "width: 350px" })%>
                            <%: Html.ValidationMessageFor(model => model.SupplierID) %>
                        </td>
                    </tr> 
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.ExpectedDeliveryDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.ExpectedDeliveryDate).TodayButton() %>
                            <%: Html.ValidationMessageFor(m => m.ExpectedDeliveryDate) %>
                        </td>
                    </tr> 
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Suffix) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Suffix) %>
                            <%: Html.ValidationMessageFor(m => m.Suffix) %>
                        </td>
                    </tr>
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.CommentID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.CommentID).BindTo((IEnumerable<SelectListItem>) ViewData["Comments"]).HtmlAttributes(new { style = "width: 350px" })%>
                            <%: Html.ValidationMessageFor(model => model.CommentID) %>
                        </td>
                    </tr>                                                                                        
                </table>      
            <button id="SubmitOrder" type="submit" class="t_button">Create</button>
            <% } %>
        </body>
</html>

﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CoinMovement>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Coin Movement </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.CoinMovementID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.ActualDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.ActualDate).Value(DateTime.Now).TodayButton() %>
                            <%: Html.ValidationMessageFor(m => m.ActualDate) %>
                        </td>
                    </tr>
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.MovementTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.MovementTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["CoinMovementType"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.MovementTypeID) %>
                        </td>
                    </tr> 
                    <tr>
                     <td>
                           <%: Html.LabelFor(m => m.MoneyUnitID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.MoneyUnitID).BindTo((IEnumerable<SelectListItem>) ViewData["MoneyUnit"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.MoneyUnitID) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Amount) %>
                        </td>
                        <td>
                           R <%: Html.TextBoxFor(m => m.Amount)  %>
                            <%: Html.ValidationMessageFor(m => m.Amount) %>
                        </td>
                    </tr>                                    

                </table>


    
</body>
</html>

﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<DayEndCashupQuery>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Report
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Day end Cashup</h3>
   <% using (Html.BeginForm("GetDayEndCashupReport", "Verslae", FormMethod.Post))
       { %>
        <table>
            <tr>
                <td>
                    Day End Cashup For:
                </td>
                <td>
                    <%: Html.Telerik().DatePickerFor(m => m.Date) %>
                </td>
            </tr>
            <tr>
                <td>
                    Opening Balance for day:
                </td>
                <td>
                    <%: Html.TextBoxFor(m => m.OpeningBalance)  %>
                </td>
            </tr>
            <tr>
                <td>
                    Petty Cash for day:
                </td>
                <td>
                    <%:  Html.Telerik().CurrencyTextBoxFor(m => m.PettyCash)  %>
                </td>
            </tr>
            <tr>
                <td>
                    Sigma Cards Expected for day:
                </td>
                <td>
                    <%:  Html.Telerik().CurrencyTextBoxFor(m => m.SigmaCardsExpected)  %>
                </td>
            </tr>

        </table>
       <button type="submit" class="t-button">Get Report</button>      
    <% } %>

</asp:Content>
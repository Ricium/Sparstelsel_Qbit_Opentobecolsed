﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<DateTimeFromToQuery>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Report
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Spar Invoice Reconciliation</h3>
   <% using (Html.BeginForm("GetSparReconReport", "Verslae", FormMethod.Post))
       { %>
        <table>
            <tr>
                <td>
                    Select Date:
                </td>
                <td>
                    <%: Html.Telerik().DatePickerFor(m => m.From) %>
                </td>
            </tr>
            <tr>
                <td>
                    Select Supplier Type:
                </td>
                <td>
                    <%: Html.Telerik().DropDownListFor(m => m.IntergerSelect).BindTo((IEnumerable<SelectListItem>)ViewData["SupplierTypes"]) %>
                </td>
            </tr>
        </table>
       <button type="submit" class="t-button">Get Report</button>      
    <% } %>

</asp:Content>
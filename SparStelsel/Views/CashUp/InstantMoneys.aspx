<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace ="SparStelsel" %>
<%@ Import Namespace="SparStelsel.Models" %>
<%@ Import Namespace="SparStelsel.Controllers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Instant Money
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<% Html.Telerik().TabStrip()
       .Name("TabStrip")
       .Items(tabstrip =>
           {
               tabstrip.Add()
                    .HtmlAttributes(new { id = "CashTab" })
                    .Text("Cash")
                    .Content(() =>
                    {
                        Html.RenderPartial("_CashInstantMoney");
                    });
               tabstrip.Add()
                   .HtmlAttributes(new { id = "ElectronicFundTab" })
                   .Text("ElectronicFunds")
                   .Content(() =>
                   {
                       Html.RenderPartial("_ElectronicFundInstantMoney");
                   });

               tabstrip.Add()
                  .HtmlAttributes(new { id = "PickUpTab" })
                  .Text("PickUps")
                  .Content(() =>
                  {
                      Html.RenderPartial("_PickUpInstantMoney");
                  });
               tabstrip.Add()
                   .HtmlAttributes(new { id = "ExpectedTab" })
                   .Text("Expected")
                   .Content(() =>
                   {
                       Html.RenderPartial("_InstantMoney");
                   });
           })
           .SelectedIndex(0)
           .Render();
           %> 
    
</asp:Content>



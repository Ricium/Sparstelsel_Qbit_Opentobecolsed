<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace ="SparStelsel" %>
<%@ Import Namespace="SparStelsel.Models" %>
<%@ Import Namespace="SparStelsel.Controllers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Cash Up
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
                        Html.RenderPartial("_Cash");
                    });
               tabstrip.Add()
                   .HtmlAttributes(new { id = "CardsTab" })
                   .Text("Cards")
                   .Content(() =>
                   {
                       Html.RenderPartial("_Cards");
                   });
               tabstrip.Add()
                    .HtmlAttributes(new { id = "ChequesTab" })
                    .Text("Cheques")
                    .Content(() =>
                    {
                        Html.RenderPartial("_Cheques");
                    });

               tabstrip.Add()
                  .HtmlAttributes(new { id = "PickUpsTab" })
                  .Text("Pick Ups")
                  .Content(() =>
                  { 
                      Html.RenderPartial("_PickUps");
                  });
               tabstrip.Add()
                   .HtmlAttributes(new { id = "ExpectedTab" })
                   .Text("Expected")
                   .Content(() =>
                   {
                       Html.RenderPartial("_FNB");
                   });
               tabstrip.Add()
                .HtmlAttributes(new { id = "InstantMoneyTab" })
                .Text("Expected")
                .Content(() =>
                {
                    Html.RenderPartial("_FNB");
                });
           })
           .SelectedIndex(0)
           .Render();
           %> 
    
</asp:Content>



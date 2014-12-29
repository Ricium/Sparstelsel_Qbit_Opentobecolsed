<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace ="SparStelsel" %>
<%@ Import Namespace="SparStelsel.Models" %>
<%@ Import Namespace="SparStelsel.Controllers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Cash Up
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>
        Cash Up
    </h2>

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
                   .HtmlAttributes(new { id = "ElectronicTab" })
                   .Text("Electronic Funds")
                   .Content(() =>
                   {
                       Html.RenderPartial("_Electronic");
                   });

              
               tabstrip.Add()
                  .HtmlAttributes(new { id = "PickUpsTab" })
                  .Text("Pick Ups")
                  .Content(() =>
                  { 
                      Html.RenderPartial("_PickUps");
                  });
               
              tabstrip.Add()
                   .HtmlAttributes(new { id = "CashReconTab" })
                   .Text("Cash Reconciliation")
                   .Content(() =>
                   {
                       Html.RenderPartial("_CashRecon");
                   });
               
               tabstrip.Add()
                .HtmlAttributes(new { id = "InstantMoneyTab" })
                .Text("Instant Money")
                .Content(() =>
                {
                    Html.RenderPartial("_InstantMoney");
                });
               
               tabstrip.Add()
                  .HtmlAttributes(new { id = "FNBTab" })
                  .Text("FNB")
                  .Content(() =>
                  {
                      Html.RenderPartial("_FNB");
                  });
               
               tabstrip.Add()
                  .HtmlAttributes(new { id = "KwikPayTab" })
                  .Text("Kwik Pay")
                  .Content(() =>
                  {
                      Html.RenderPartial("_KwikPay");
                  });
           })
           .SelectedIndex(0)
           .Render();
           %> 
    
</asp:Content>



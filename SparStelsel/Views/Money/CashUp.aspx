<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace ="SparStelsel" %>
<%@ Import Namespace="SparStelsel.Models" %>
<%@ Import Namespace="SparStelsel.Controllers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Cash Up
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        function LoadMultipleCashMovements() {
            $.ajax({
                type: 'POST',
                url: '/Money/_MultipleCashMovements/',
                data: { },
                dataType: 'html',
                success: function (htmlData) {
                    var window = $('#WindowInsertMultipleCash').data('tWindow');
                    window.content(htmlData).center();
                    window.open();
                }
            })
        };

        function InsertMultipeCashMovements(e) {            
            var form = $('#MultipleCashMovementsForm').serialize();
            $.post('/Money/_InsertMultipleCash/', form, function (data) {
                $('#MultipleCashMovementsForm').trigger('reset');
                RefreshGrid();
            });

            var window = $('#WindowInsertMultipleCash').data('tWindow');
            window.close();           

            return false;
        }

        function RefreshGrid() {
            var $gridrefresh = $('#CashMovements');
            var gridrfsh = $gridrefresh.data('tGrid');
            gridrfsh.ajaxRequest();
        }
    </script>

    <%  Html.Telerik().Window()
            .Name("WindowInsertMultipleCash")
            .Title("Day-end Cash")   
            .Width(350)
            .Draggable(true)
            .Modal(true)
            .Visible(false)
            .Render();
    
    %>

    <h2>
        Cash Up
    </h2>

<% Html.Telerik().TabStrip()
       .Name("TabStrip")
       .Items(tabstrip =>
           {
               tabstrip.Add()
                    .HtmlAttributes(new { id = "CashTab" })
                    .Text("Cashier Day-end Cash")
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



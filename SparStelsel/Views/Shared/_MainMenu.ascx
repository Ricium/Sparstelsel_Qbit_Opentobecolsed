<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<%  Html.Telerik()
        .Menu()
        .Name("Menu")

        .Effects(fx =>
        {
            fx.Slide();
        })
        .Items(items =>
        {
            items.Add()
                 .Text("Home")
                 .Url("~/Home/Index");
            items.Add()
                 .Text("Maintenance")
                 .Url("~/Home/Index")
                 .Items(item =>
                     {
                         item.Add().Text("CashTypes").Url("~/Maintenance/CashTypes");
                         item.Add().Text("CommentType").Url("~/Maintenance/CommentTypes");
                         item.Add().Text("GRVType").Url("~/Maintenance/GRVTypes");
                         item.Add().Text("InstantMoneyType").Url("~/Maintenance/InstantMoneyTypes");
                         item.Add().Text("KwikPayType").Url("~/Maintenance/KwikPayTypes");
                         item.Add().Text("MoneyUnit").Url("~/Maintenance/MoneyUnits");
                         item.Add().Text("MovementType").Url("~/Maintenance/MovementTypes");
                         item.Add().Text("UserType").Url("~/Maintenance/UserTypes");
                     });
        })
             .Render();
            %>

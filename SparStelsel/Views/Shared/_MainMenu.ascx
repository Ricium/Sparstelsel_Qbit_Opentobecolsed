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
                         item.Add().Text("ElectronicType").Url("~/Maintenance/ElectronicTypes");
                         item.Add().Text("FNBType").Url("~/Maintenance/FNBTypes");
                         item.Add().Text("Budget").Url("~/Maintenance/Budgets");
                     });

            items.Add()
                .Text("Supplier")
                .Url("~/Home/Index")
                .Items(Sitem =>
                    {
                        Sitem.Add().Text("Supplier").Url("~/Supplier/Suppliers");
                        Sitem.Add().Text("SupplierType").Url("~/Supplier/SupplierTypes");
                    });
            items.Add()
                .Text("Product")
                .Url("~/Home/Index")
                .Items(Pitems =>
                    {
                        Pitems.Add().Text("Products").Url("~/Products/Products");
                    });
            items.Add()
                .Text("Payments")
                .Url("~/Home/Index")
                .Items(Payitems =>
                {
                    Payitems.Add().Text("Proof Of Payment").Url("~/Payment/ProofOfPayments");
                });
            items.Add()
            .Text("GRV")
            .Url("~/Home/Index")
            .Items(GRVitems =>
            {
                GRVitems.Add().Text("GRV").Url("~/GRV/GRVLists");
            });
            items.Add()
         .Text("Users")
         .Url("~/Home/Index")
         .Items(Uitems =>
         {
             Uitems.Add().Text("Users").Url("~/Users/Users");
         });
            items.Add()
            .Text("Transits")
            .Url("~/Home/Index")
            .Items(Tritems =>
            {
                Tritems.Add().Text("Transits").Url("~/Transits/Transits");
            });
            items.Add()
      .Text("CashBox")
      .Url("~/Home/Index")
      .Items(Tritems =>
      {
          Tritems.Add().Text("CashBoxs").Url("~/Cash/CashBoxs");
      });
           
            items.Add()
                .Text("CashUp")
                .Url("~/Home/Index")
                .Items(Tritems =>
                {
                    Tritems.Add().Text("KwikPay").Url("~/CashUp/KwikPays");
                    Tritems.Add().Text("InstantMoney").Url("~/CashUp/InstantMoneys");
                    Tritems.Add().Text("FNB").Url("~/CashUp/FNBs");
                });
                
        })
             .Render();
            %>

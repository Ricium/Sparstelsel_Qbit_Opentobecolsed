<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<% string[] roles = {""};
   
    if (HttpContext.Current.Session["Username"] != null)
   {
      roles = Roles.GetRolesForUser(HttpContext.Current.Session["Username"].ToString()); 
   }
%>
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
                 .Url("~/Home/Home");

            if (roles.Contains("admin"))
            {
                items.Add()
                    .Text("Accounts")
                    .Url("#")
                    .Items(c =>
                    {
                        c.Add().Text("Register New User").Url("~/Account/Register");

                        if (roles.Contains("admin"))
                        {
                            c.Add().Text("Add Role").Url("~/Account/RoleManagement");
                        }
                    });
            }
            
            items.Add()
                 .Text("Maintenance")
                 .Url("~/Home/Home")
                 .Items(item =>
                     {
                         item.Add().Text("Comment").Url("~/Maintenance/Comment");
                         item.Add().Text("GRVType").Url("~/Maintenance/GRVTypes");
                         item.Add().Text("InstantMoneyType").Url("~/Maintenance/InstantMoneyTypes");
                         item.Add().Text("KwikPayType").Url("~/Maintenance/KwikPayTypes");
                         item.Add().Text("MoneyUnit").Url("~/Maintenance/MoneyUnits");
                         item.Add().Text("MovementType").Url("~/Maintenance/MovementTypes");
                         item.Add().Text("UserType").Url("~/Maintenance/UserTypes");
                         item.Add().Text("Budget").Url("~/Maintenance/Budgets");
                         item.Add().Text("Status").Url("~/Maintenance/Status");
                     });

            items.Add()
                .Text("Supplier")
                .Url("~/Home/Home")
                .Items(Sitem =>
                    {
                        Sitem.Add().Text("Supplier").Url("~/Supplier/Suppliers");
                        Sitem.Add().Text("SupplierType").Url("~/Supplier/SupplierTypes");
                    });

            items.Add()
                .Text("Payments")
                .Url("~/Home/Home")
                .Items(Payitems =>
                {
                    Payitems.Add().Text("Proof Of Payment").Url("~/Payment/ProofOfPayments");
                });
            
            items.Add()
            .Text("GRV")
            .Url("~/Home/Home")
            .Items(GRVitems =>
            {
                GRVitems.Add().Text("GRV").Url("~/GRV/GRVLists");
                GRVitems.Add().Text("GRV Import").Url("~/GRV/ImportGRVList");
            });
            
            items.Add()
                .Text("Order")
                .Url("~/Home/Home")
                .Items(Tritems =>
                {
                    Tritems.Add().Text("Orders").Url("~/Orders/Orders");
                    //Tritems.Add().Text("Order vs GRV - Report").Url("~/Orders/OrdervsGRVReport");
                });

            items.Add()
                .Text("Reports")
                .Url("#")
                .Items(item =>
                {
                    item.Add().Text("Order Reports").Url("#").Items(i =>
                        {
                            i.Add().Text("Order vs GRV").Url("~/Verslae/OrdervsGRVReport");
                            i.Add().Text("Orders For Expected Delivery Date").Url("~/Verslae/OrdersExpectedDateReport");
                        });
                    item.Add().Text("Pinkslip Reports").Url("#").Items(i =>
                        {
                            i.Add().Text("Orders by Pinkslip").Url("~/Verslae/PinkSlipOrderReport");
                            i.Add().Text("GRV Totals by Pinkslip").Url("~/Verslae/PinkSlipGRVReport");
                        });
                    
                    
                });

            items.Add()
                 .Text("Log off")
                 .Url("~/Account/Logoff");

            items.Add()
              .Text("Cashier")
              .Url("#")
              .Items(Tritems =>
              {
                  Tritems.Add().Text("Cashier").Url("~/Cashier/Cashier");
              });

            /*
            items.Add()
             .Text("Users")
             .Url("~/Home/Home")
             .Items(Uitems =>
             {
                 Uitems.Add().Text("Users").Url("~/Users/Users");
             });
            
            items.Add()
                .Text("Transits")
                .Url("~/Home/Home")
                .Items(Tritems =>
                {
                    Tritems.Add().Text("Transits").Url("~/Transits/Transits");
                });
            
            items.Add()
              .Text("CashBox")
              .Url("~/Home/Home")
              .Items(Tritems =>
              {
                  Tritems.Add().Text("CashBoxs").Url("~/Cash/CashBoxs");
              });
           
            
            
           
            
           items.Add()
                    .Text("Cashier CashUp")
                    .Url("~/Cashier/CashierCashUp")
                    .Items(Tritems =>
                    {
                        Tritems.Add().Text("CashierCashUp").Url("~/Cashier/CashierCashUp");
                    });
            
            items.Add()
                .Text("CashUp")
                .Url("~/Home/Home")
                .Items(Tritems =>
                {
                    Tritems.Add().Text("KwikPay").Url("~/CashUp/KwikPays");
                    Tritems.Add().Text("InstantMoney").Url("~/CashUp/InstantMoneys");
                    Tritems.Add().Text("FNB").Url("~/CashUp/FNBs");
                });
            */
                
            })      
            .Render();
 %>

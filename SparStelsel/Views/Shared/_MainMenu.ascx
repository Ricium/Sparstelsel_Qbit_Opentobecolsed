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
                 .Url("#")
                 .Items(item =>
                     {
                         item.Add().Text("Payment Types").Url("~/Maintenance/CashTypes");
                         item.Add().Text("Comments").Url("~/Maintenance/Comment");
                         item.Add().Text("Products").Url("~/Products/Products");
                         item.Add().Text("Cashiers").Url("~/Cashier/Cashier");
                     });

            items.Add()
                .Text("Supplier")
                .Url("#")
                .Items(Sitem =>
                    {
                        Sitem.Add().Text("Supplier").Url("~/Supplier/Suppliers");
                    });

            items.Add()
                .Text("Payments")
                .Url("#")
                .Items(Payitems =>
                {
                    Payitems.Add().Text("Add Payment").Url("~/Payment/ProofOfPayments");
                });
            
            items.Add()
            .Text("GRV")
            .Url("#")
            .Items(GRVitems =>
            {
                GRVitems.Add().Text("GRV List").Url("~/GRV/GRVLists");
                GRVitems.Add().Text("Import GRV List").Url("~/GRV/ImportGRVList");
            });
            
            items.Add()
                .Text("Orders")
                .Url("#")
                .Items(Tritems =>
                {
                    Tritems.Add().Text("Orders").Url("~/Orders/Orders");
                    Tritems.Add().Text("Product Orders").Url("~/Orders/ProductOrders");
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
                    
                    item.Add().Text("Payment Reports").Url("#").Items(i =>
                        {
                            i.Add().Text("Payment Report").Url("~/Verslae/PaymentReport");
                        });
                    
                    item.Add().Text("Cash-up Reports").Url("#").Items(i =>
                    {
                        i.Add().Text("Cash Office Day End Report").Url("~/Verslae/CashOfficeReport");
                        i.Add().Text("Cashier Report").Url("~/Verslae/CashierReport");
                        i.Add().Text("Day End Cash Up Report").Url("~/Verslae/DayendcashupReport");
                    });

                    item.Add().Text("Reconciliation Reports").Url("#").Items(i =>
                    {
                        i.Add().Text("Spar Invoice Recon Report").Url("~/Verslae/SparReconReport");
                    });                       
                });

            items.Add()
                .Text("Cashier")
                .Url("#")
                .Items(item =>
                {
                    item.Add().Text("Sigma Cashup").Url("~/Money/CashierDayEnd");
                    item.Add().Text("Money Services").Url("#").Items(i =>
                    {
                        i.Add().Text("Kwikpay").Url("~/Money/CashierKwikpay");
                        i.Add().Text("InstantMoney").Url("~/Money/CashierInstantMoney");
                        i.Add().Text("FNB").Url("~/Money/CashierFNB"); 
                    });
                });

            items.Add()
                .Text("Cash Office")
                .Url("#")
                .Items(item =>
                {
                    
                    item.Add().Text("Day End Cash Office").Url("~/Money/Cashup");

                    item.Add().Text("Live Cashier Status").Url("~/Money/CashierStatus");
                    
                    item.Add().Text("Cash Movements").Url("#").Items(i =>
                    {
                        i.Add().Text("Coin Movement").Url("~/Money/CoinMovement"); 
                        i.Add().Text("Transits").Url("~/Money/Transits");
                        i.Add().Text("Cashbox").Url("~/Money/Cashbox");
                        i.Add().Text("Cash Office").Url("~/Money/CashOffice");                                               
                    });                    
                });

            items.Add()
                .Text("Spar Recon")
                .Url("#")
                .Items(item =>
                {
                    item.Add().Text("Invoice Recon").Url("~/SparRecon/SparInvoiceRecon");
                });

            items.Add()
                 .Text("Log off: " + HttpContext.Current.Session["Username"].ToString())
                 .Url("~/Account/Logoff"); 
                 

        }).Render();
 %>

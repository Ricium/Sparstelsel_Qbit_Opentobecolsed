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

            if (roles.Contains("r_admin"))
            {
                items.Add()
                    .Text("Accounts")
                    .Url("#")
                    .Items(c =>
                    {
                        c.Add().Text("Register New User").Url("~/Account/Register");

                        /*if (roles.Contains("r_admin"))
                        {
                            c.Add().Text("Add Role").Url("~/Account/RoleManagement");
                        }*/
                    });
            }

            if (roles.Contains("p_maintenance") || roles.Contains("r_admin"))
            {
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
            }

            if (roles.Contains("p_supplier") || roles.Contains("r_admin"))
            {
                items.Add()
                    .Text("Supplier")
                    .Url("#")
                    .Items(Sitem =>
                        {
                            Sitem.Add().Text("Supplier").Url("~/Supplier/Suppliers");
                        });
            }

            if (roles.Contains("p_payments") || roles.Contains("r_admin"))
            {
                items.Add()
                    .Text("Payments")
                    .Url("#")
                    .Items(Payitems =>
                    {
                        Payitems.Add().Text("Add Payment").Url("~/Payment/ProofOfPayments");
                    });
            }

            if ((roles.Contains("p_GRV")) || ((roles.Contains("p_GRVimport"))) || roles.Contains("r_admin"))
            {
                items.Add()
                .Text("GRV")
                .Url("#")
                .Items(GRVitems =>
                {
                    if (roles.Contains("p_GRV") || roles.Contains("r_admin"))
                    {
                        GRVitems.Add().Text("GRV List").Url("~/GRV/GRVLists");
                    }

                    if (roles.Contains("p_GRVimport") || roles.Contains("r_admin"))
                    {
                        GRVitems.Add().Text("Import GRV List").Url("~/GRV/ImportGRVList");
                    }
                });
            }

            if ((roles.Contains("p_orders")) || ((roles.Contains("p_productorder"))) || roles.Contains("r_admin"))
            {
                items.Add()
                    .Text("Orders")
                    .Url("#")
                    .Items(Tritems =>
                    {
                        if (roles.Contains("p_orders") || roles.Contains("r_admin"))
                        {
                            Tritems.Add().Text("Orders").Url("~/Orders/Orders");
                        }

                        if (roles.Contains("p_productorders") || roles.Contains("r_admin"))
                        {
                            Tritems.Add().Text("Product Orders").Url("~/Orders/ProductOrders");
                        }
                    });
            }

            if (roles.Contains("p_reports") || roles.Contains("r_admin"))
            {
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
            }

            if (roles.Contains("p_cashier") || roles.Contains("r_admin"))
            {
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
            }

            if (roles.Contains("p_cashoffice") || roles.Contains("r_admin"))
            {
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
            }
            if (roles.Contains("p_recons") || roles.Contains("r_admin"))
            {
                items.Add()
                    .Text("Spar Recon")
                    .Url("#")
                    .Items(item =>
                    {
                        item.Add().Text("Invoice Recon").Url("~/SparRecon/SparInvoiceRecon");
                    });
            }

            items.Add()
                 .Text("Log off: " + HttpContext.Current.Session["Username"].ToString())
                 .Url("~/Account/Logoff"); 
                 

        }).Render();
 %>

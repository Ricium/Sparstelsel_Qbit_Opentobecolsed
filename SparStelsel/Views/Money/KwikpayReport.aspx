<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CashierKwikpayReport>" %>

<%@ Import Namespace="SparStelsel" %>
<%@ Import Namespace="SparStelsel.Models" %>
<%@ Import Namespace="SparStelsel.Controllers" %>
<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <fieldset>
        <legend><b>Cashier</b></legend>
        <%: Html.DisplayFor(m => m.Cashier.Name) %> <%: Html.DisplayFor(m => m.Cashier.Surname) %>
    </fieldset>
    <br />
    <fieldset>
        <legend><b>Movements</b></legend>
        <table>
            <tr>
                <td style="vertical-align: top">
                    <fieldset>
                        <legend><b>Cash</b></legend>
                        <table>
                            <tr>
                                <td style="text-align: left; width: 75px">CASH</td>
                                <td style="text-align: center; width: 50px">QTY</td>
                                <td colspan="2" style="text-align: center;">AMOUNT</td>
                            </tr>

                            <% foreach (CashMovement cash in Model.CashMovements)
                               {
                            %><tr>
                                <td style="text-align: left; width: 75px">
                                    <%: Html.DisplayFor(c => cash.moneyunit) %>
                                </td>
                                <td style="text-align: center; width: 50px">
                                    <%: Html.DisplayFor(c => cash.Count) %>
                                </td>
                                <td>R
                                </td>
                                <td style="text-align: right; width: 75px">
                                    <%: Html.DisplayFor(c => cash.Amount) %>
                                </td>
                            </tr>
                            <%
                                   } %>
                            <tr>
                                <td colspan="2"></td>
                                <td>R</td>
                                <td style="text-align: right; border-bottom: double; border-top: solid">
                                    <%: Html.DisplayFor(m => m.CashTotal)%>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </td>
                <td style="vertical-align: top">
                    <fieldset>
                        <legend><b>Cards</b></legend>
                        <table>
                            <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td style="vertical-align: top">
                                                <table>
                                                    <% int count = 0;
                                                       foreach (ElectronicFund el in Model.ElectronicFunds)
                                                       {
                                                           if (el.ElectronicTypeID == 2)
                                                           {
                                                               count++;

                                                               if (count % 13 == 0)
                                                               {
                                                    %>
                                                    <tr>
                                                        <td>R</td>
                                                        <td style="text-align: right; width: 75px">
                                                            <%: Html.DisplayFor(c => el.Total) %>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td style="vertical-align: top">
                                                <table>
                                                    <%
                                                       }
                                                       else
                                                       {
                                                    %><tr>
                                                        <td>R</td>
                                                        <td style="text-align: right; width: 75px">
                                                            <%: Html.DisplayFor(c => el.Total) %>
                                                        </td>
                                                    </tr>
                                                    <%
                                                       }
                                                   }

                                               } %>

                                                    <% for (int i = 0; i < 13 - (count % 13); i++)
                                                       {
                                                    %>
                                                    <tr>
                                                        <td></td>
                                                        <td style="text-align: center; width: 75px">-</td>
                                                    </tr>
                                                    <%
                                                   }  %>
                                                    <tr>
                                                        <td>R</td>
                                                        <td style="text-align: right; width: 75px; border-bottom: double; border-top: solid"><%: Html.DisplayFor(m => m.CardsTotal) %></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>

                    </fieldset>
                </td>
            </tr>
            <tr>
                <td style="vertical-align: top">
                    <fieldset>
                        <legend><b>Cheques</b></legend>
                        <table>
                            <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td style="vertical-align: top">
                                                <table>
                                                    <% int ccount = 0;
                                                       foreach (ElectronicFund el in Model.ElectronicFunds)
                                                       {
                                                           if (el.ElectronicTypeID == 3)
                                                           {
                                                               ccount++;

                                                               if (ccount % 5 == 0)
                                                               {
                                                    %>
                                                    <tr>
                                                        <td>R</td>
                                                        <td style="text-align: right; width: 75px">
                                                            <%: Html.DisplayFor(c => el.Total) %>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td style="vertical-align: top">
                                                <table>
                                                    <%
                                                           }
                                                           else
                                                           {
                                                    %><tr>
                                                        <td>R</td>
                                                        <td style="text-align: right; width: 75px">
                                                            <%: Html.DisplayFor(c => el.Total) %>
                                                        </td>
                                                    </tr>
                                                    <%
                                                           }
                                                       }

                                                   } %>

                                                    <% for (int i = 0; i < 5 - (ccount % 5); i++)
                                                       {
                                                    %>
                                                    <tr>
                                                        <td></td>
                                                        <td style="text-align: center; width: 75px">-</td>
                                                    </tr>
                                                    <%
                                                       }  %>
                                                    <tr>
                                                        <td>R</td>
                                                        <td style="text-align: right; width: 75px; border-bottom: double; border-top: solid"><%: Html.DisplayFor(m => m.ChequeTotal) %></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </td>
                <td style="vertical-align: top">
                    <fieldset>
                        <legend><b>Pickups</b></legend>
                        <table>
                            <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td style="vertical-align: top">
                                                <table>
                                                    <% int pcount = 0;
                                                       foreach (PickUp p in Model.Pickups)
                                                       {

                                                           pcount++;

                                                           if (pcount % 5 == 0)
                                                           {
                                                    %>
                                                    <tr>
                                                        <td>R</td>
                                                        <td style="text-align: right; width: 75px">
                                                            <%: Html.DisplayFor(c => p.Amount) %>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td style="vertical-align: top">
                                                <table>
                                                    <%
                                                           }
                                                           else
                                                           {
                                                    %><tr>
                                                        <td>R</td>
                                                        <td style="text-align: right; width: 75px">
                                                            <%: Html.DisplayFor(c => p.Amount) %>
                                                        </td>
                                                    </tr>
                                                    <%
                                                           }


                                                   } %>

                                                    <% for (int i = 0; i < 5 - (pcount % 5); i++)
                                                       {
                                                    %>
                                                    <tr>
                                                        <td></td>
                                                        <td style="text-align: center; width: 75px">-</td>
                                                    </tr>
                                                    <%
                                                       }  %>
                                                    <tr>
                                                        <td>R</td>
                                                        <td style="text-align: right; width: 75px; border-bottom: double; border-top: solid"><%: Html.DisplayFor(m => m.PickupTotal) %></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </td>
            </tr>
            
        </table>
    </fieldset>
    <br />
    <fieldset>
        <legend><b>Reconciliation</b></legend>
        <table>
            <tr>
                <td style="vertical-align: top; width: 33%">
                    <fieldset>
                        <legend><b>Expected</b></legend>
                        <table>
                            <tr>
                                <td>Electricity
                                </td>
                                <td style="padding-left: 10px">R
                                </td>
                                <td style="text-align: right; width: 75px; border-bottom: double; border-top: solid">
                                    <%: Html.DisplayFor(m => m.ElectricityTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td>Airtime
                                </td>
                                <td style="padding-left: 10px">R
                                </td>
                                <td style="text-align: right; width: 75px; border-bottom: double; border-top: solid">
                                    <%: Html.DisplayFor(m => m.AirTimeTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td>Account Payments
                                </td>
                                <td style="padding-left: 10px">R
                                </td>
                                <td style="text-align: right; width: 75px; border-bottom: double; border-top: solid">
                                    <%: Html.DisplayFor(m => m.AccountPaymentTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td style="padding-left: 10px">R
                                </td>
                                <td style="text-align: right; width: 75px; border-bottom: double; border-top: solid">
                                    <%: Html.DisplayFor(m => m.ExpectedTotal) %>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </td>
                <td style="vertical-align: top; width: 500px">
                    <fieldset>
                        <legend><b>Declared</b></legend>
                        <table>
                            <tr>
                                <td>Cash
                                </td>
                                <td style="padding-left: 10px">R
                                </td>
                                <td style="text-align: right;">
                                    <%: Html.DisplayFor(m => m.CashTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td>Cards
                                </td>
                                <td style="padding-left: 10px">R
                                </td>
                                <td style="text-align: right;">
                                    <%: Html.DisplayFor(m => m.CardsTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td>Cheques
                                </td>
                                <td style="padding-left: 10px">R
                                </td>
                                <td style="text-align: right;">
                                    <%: Html.DisplayFor(m => m.ChequeTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td>Pickups
                                </td>
                                <td style="padding-left: 10px">R
                                </td>
                                <td style="text-align: right;">
                                    <%: Html.DisplayFor(m => m.PickupTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td style="padding-left: 10px">R</td>
                                <td style="text-align: right; width: 75px; border-bottom: double; border-top: solid">
                                    <%: Html.DisplayFor(m => m.DeclaredTotal) %>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </td>
            </tr>
        </table>
    </fieldset>
    <br />
    <fieldset>
        <legend><b>Day End</b></legend>
        <table>
            <tr>
                <td>FNB Balance
                </td>
                <% if (Model.Final == 0)
                   { %>
                <td>Matched</td>
                <% }
                   else if (Model.Final < 0)
                   { %>
                <td style="color: red">Under</td>
                <% }
                   else
                   {%>
                <td style="color: green">Over</td>
                <%}
                %>
                <td>R
                </td>
                <td style="text-align: right; width: 75px; border-bottom: double; border-top: solid">
                    <%: Html.DisplayFor(m => m.Final) %>
                </td>
            </tr>
        </table>
    </fieldset>
    <br />
    <fieldset>
        <legend><b>Sign-Off</b></legend>
        <table>
            <tr>
                <td style="width: 100px">Signed By: 
                </td>
                <td style="border-bottom: solid; width: 250px"></td>
                <td style="width: 80px; padding-left: 10px">Signature: 
                </td>
                <td style="border-bottom: solid; width: 250px"></td>
            </tr>
        </table>
        <br />
        <table>
            <tr>
                <td style="width: 100px">Date: 
                </td>
                <td style="border-bottom: solid; width: 250px"></td>
                <td style="width: 80px; padding-left: 10px">Time: 
                </td>
                <td style="border-bottom: solid; width: 250px"></td>
            </tr>
        </table>
    </fieldset>
</body>
</html>


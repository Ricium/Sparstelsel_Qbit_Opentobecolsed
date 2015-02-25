<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CashierReport>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Report
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% using (Html.BeginForm("GetCashierReportPDF","Verslae",FormMethod.Post))
       {%>
    <%: Html.HiddenFor(m => m.CashierId)%>
    <%: Html.HiddenFor(m => m.ReportDate)%>
    <button type="submit" class="t-button">Print</button>
    <%} %>
    <br />
    <br />
    <br />

  <b> <fieldset>
       <legend>Cashier: <%: Model.Cashier.Name %> <%: Model.Cashier.Surname %></legend>
       <table>
           <tr>
               <td style="vertical-align:top">
                   <fieldset>
                       <legend></legend>
                       <table>
                           <tr>
                               <td>
                                   Total Cash
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                   <%: Model.CashTotal %>
                               </td>
                           </tr>
                           <tr>
                                <td>
                                    Total Cards
                                </td>
                                <td>
                                    R
                                </td>
                                <td class="td-right">
                                   <%: Model.CardsTotal %>
                                </td>
                           </tr>
                           <tr>
                               <td>
                                   Total Cheques
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                  <%: Model.ChequeTotal %>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                   Total Sassa
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                   <%: Model.SassaTotal %>
                               </td>
                           </tr>
                       </table>
                   </fieldset>
               </td>
               <td style="vertical-align:top">
                   <fieldset>
                       <legend></legend>
                       <table>
                           <tr>
                               <td>
                                   Total Pickups
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                   <%: Model.PickupTotal %>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                   Total Floats
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                   <%: Model.FloatTotal %>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                   Total Extra Floats
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                    <%: Model.ExtraFloatTotal %>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                   Total Sigma
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                    <%: Model.SigmaTotal %>
                               </td>
                           </tr>
                       </table>
                   </fieldset>
               </td>
               <td style="vertical-align:top">
                   <fieldset>
                       <legend></legend>
                       <table>
                           <tr>
                               <td>
                                   Total Instant Money Floats
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                   <%: Model.IMFloatTotal %>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                   Total Instant Money Received
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                  <%: Model.IMRecTotal %>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                   Total Instant Money Paid
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                  <%: Model.IMPaidTotal %>
                               </td>
                           </tr>
                       </table>
                   </fieldset>
               </td>
               <td style="vertical-align:top">
                   <fieldset>
                       <legend></legend>
                       <table>
                           <tr>
                               <td>
                                   Total FNB Referenced
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                   <%: Model.FNBRefTotal %>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                   Total FNB Returns
                               </td>               
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                   <%: Model.FNBRetTotal %>
                               </td>
                           </tr>
                       </table>
                   </fieldset>
               </td>
               <td style="vertical-align:top">
                   <fieldset>
                       <legend></legend>
                       <table>
                           <tr>
                               <td>
                                   Total Electricity
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                   <%: Model.ElecTotal %>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                   Total Airtime
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                   <%: Model.AirTotal %>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                   Total Account Payments
                               </td>
                               <td>
                                   R
                               </td>
                               <td class="td-right">
                                   <%: Model.AccTotal %>
                               </td>
                           </tr>
                       </table>
                   </fieldset>
               </td>
           </tr>       
       </table>
   </fieldset>
    </b>
    
       <fieldset><legend>Cash</legend>
       <table><tr>     <td style="vertical-align:top"></tr></table>
        <table>     
            <tr> <td> 
 
                         <fieldset><legend>Casier</legend>
                        <table>
                                   <tr>
                
                                        <% MoneyUnitRepository mu = new MoneyUnitRepository(); %>
                                        <% foreach(CashMovement item in Model.CashMovements)
                                           {  %>
                        
                                        <% if( item.MovementTypeID == 1){ %>
                                                <tr> 
                                                    <td>
                                                        <%: mu.GetMoneyUnit(item.MoneyUnitID).MoneyUnits %>
                                                    </td>
                                                    <td>
                                                        R 
                                                    </td>
                                                    <td class="td-right">
                                                        <%: item.Amount  %>
                                                    </td>
                                                </tr> <%}} %>
                                        </table></fieldset>
       </td><td> 
         
                                <fieldset> <legend>FNB</legend>

                                     <table>
                                        <% foreach(CashMovement item in Model.CashMovements)
                                           { %>
                        
                                        <% if( item.MovementTypeID == 2){ %>
                       
                        
                                                <tr>
                                    
                                                    <td>
                                                        <%: mu.GetMoneyUnit(item.MoneyUnitID).MoneyUnits %>
                                                    </td>
                                                    <td>
                                                        R 
                                                    </td>
                                                    <td class="td-right">
                                                        <%: item.Amount  %>
                                                    </td>
                                                </tr>     <%}} %>
                                        </table></fieldset>
           </td><td>

                                   <fieldset><legend>Kwik Pay</legend>
                 
                                     <table>
                                        <% foreach(CashMovement item in Model.CashMovements)
                                           { %>
                        
                                        <% if( item.MovementTypeID == 3){ %>
                       
                        
                                                <tr>
                                    
                                                    <td>
                                                        <%: mu.GetMoneyUnit(item.MoneyUnitID).MoneyUnits %>
                                                    </td>
                                                    <td>
                                                        R 
                                                    </td>
                                                    <td class="td-right">
                                                        <%: item.Amount  %>
                                                    </td>
                                                </tr>     <%}} %>
                                        </table></fieldset>
               </td><td>
                                            <fieldset><legend>Instant Money</legend>
                 
                                     <table>
                                        <% foreach(CashMovement item in Model.CashMovements)
                                           { %>
                        
                                        <% if( item.MovementTypeID == 4){ %>
                       
                        
                                                <tr>
                                    
                                                    <td>
                                                        <%: mu.GetMoneyUnit(item.MoneyUnitID).MoneyUnits %>
                                                    </td>
                                                    <td>
                                                        R 
                                                    </td>
                                                    <td class="td-right">
                                                        <%: item.Amount  %>
                                                    </td>
                                                </tr>     <%}} %>
                                        </table></fieldset>
                   </td></tr>
                   </table>
                       <table>
                        <tr>
                            <td>
                                <b>Total</b>
                            </td>
                            <td>
                               <b>R</b>
                            </td>
                            <td class="td-right">
                               <b> <%: Model.CashTotal %></b>
                            </td>
                        </tr>


                    </table>
                </fieldset>
            </td>
            <td style="vertical-align:top">
                <fieldset>
                    <legend>Electronic Transactions</legend>
                    <table>
                        <tr>
                            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>Sassa</legend>
                                    <table>
                                        <% foreach(ElectronicFund item in Model.ElectronicFunds)
                                           { 
                                               if(item.ElectronicTypeID == 1) {%>
                                        <tr>
                                            <td>
                                               
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Total %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                               <b> Total</b>
                                            </td>
                                            <td>
                                                 <b>R </b>
                                            </td>
                                            <td class="td-right">
                                                <b> <%: Model.SassaTotal %> </b>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
                            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>Cards</legend>
                                    <table>
                                        <% foreach(ElectronicFund item in Model.ElectronicFunds)
                                           { 
                                               if(item.ElectronicTypeID == 2) {%>
                                        <tr>
                                            <td>
                                               
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Total %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                                <b> Total </b>
                                            </td>
                                            <td>
                                                 <b>R </b>
                                            </td>
                                            <td>
                                                <%: Model.CardsTotal %>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
                            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>Cheques</legend>
                                    <table>
                                        <% foreach(ElectronicFund item in Model.ElectronicFunds)
                                           { 
                                               if(item.ElectronicTypeID == 3) {%>
                                        <tr>
                                            <td>
                                                
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Total %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                                 <b>Total </b>
                                            </td>
                                            <td>
                                                <b> R </b>
                                            </td>
                                            <td class="td-right">
                                               <b>  <%: Model.ChequeTotal %> </b>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
    </table>

    <fieldset><legend>PickUps</legend><table>
        <tr>
            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>Pickups</legend>
                                    <table>
                                        <% foreach(PickUp item in Model.Pickups)
                                           { %>            
                                        <tr>
                                            <td>
                                                
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Amount %>
                                            </td>
                                        </tr>
                                            <% } %>
                                        <tr>
                                            <td>
                                                 <b>Total </b>
                                            </td>
                                            <td>
                                                <b> R </b>
                                            </td>
                                            <td class="td-right">
                                                 <b><%: Model.PickupTotal %> </b>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>Floats</legend>
                                    <table>
                                        <% foreach(CashReconciliation item in Model.Recons)
                                           { 
                                               if(item.ReconciliationTypeID == 1) {%>
                                        <tr>
                                            <td>
                                                
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Amount %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                                 <b>Total </b>
                                            </td>
                                            <td>
                                                 <b>R </b>
                                            </td>
                                            <td class="td-right">
                                                 <b><%: Model.FloatTotal %> </b>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>Extra Floats</legend>
                                    <table>
                                        <% foreach(CashReconciliation item in Model.Recons)
                                           { 
                                               if(item.ReconciliationTypeID == 2) {%>
                                        <tr>
                                            <td>
                                               
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Amount %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                                 <b>Total </b>
                                            </td>
                                            <td>
                                                <b> R </b>
                                            </td>
                                            <td class="td-right">
                                                <b> <%: Model.ExtraFloatTotal %> </b>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>Sigma</legend>
                                    <table>
                                        <% foreach(CashReconciliation item in Model.Recons)
                                           { 
                                               if(item.ReconciliationTypeID == 3) {%>
                                        <tr>
                                            <td>
                                                
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Amount %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                                 <b>Total </b>
                                            </td>
                                            <td>
                                                <b> R </b>
                                            </td>
                                            <td class="td-right">
                                                <b> <%: Model.SigmaTotal %> </b>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
        </tr>
    </table></fieldset>

    <fieldset><legend>Instant Money</legend><table>
        <tr>
            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>Instant Money Floats</legend>
                                    <table>
                                        <% foreach(InstantMoney item in Model.InstantMoney)
                                           { 
                                               if(item.InstantMoneyTypeID == 1) {%>
                                        <tr>
                                            <td>
                                                
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Amount %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                                <b> Total </b>
                                            </td>
                                            <td>
                                                 <b>R </b>
                                            </td>
                                            <td class="td-right">
                                                <b> <%: Model.IMFloatTotal %> </b>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>Instant Money Received</legend>
                                    <table>
                                        <% foreach(InstantMoney item in Model.InstantMoney)
                                           { 
                                               if(item.InstantMoneyTypeID == 2) {%>
                                        <tr>
                                            <td>
                                                
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Amount %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                                 <b>Total </b>
                                            </td>
                                            <td>
                                                <b> R </b>
                                            </td>
                                            <td class="td-right">
                                                <b> <%: Model.IMRecTotal %> </b>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>Instant Money Paid</legend>
                                    <table>
                                        <% foreach(InstantMoney item in Model.InstantMoney)
                                           { 
                                               if(item.InstantMoneyTypeID == 3) {%>
                                        <tr>
                                            <td>
                                               
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Amount %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                                <b> Total </b>
                                            </td>
                                            <td>
                                                <b>R </b>
                                            </td>
                                            <td class="td-right">
                                                <b> <%: Model.IMPaidTotal %> </b>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
        </tr>
    </table></fieldset>
    
    <fieldset><legend>FNB</legend><table>
        <tr>
            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>FNB References</legend>
                                    <table>
                                        <% foreach(FNB item in Model.FNB)
                                           { 
                                               if(item.FNBTypeID == 1) {%>
                                        <tr>
                                            <td>
                                                
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Amount %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                                <b> Total </b>
                                            </td>
                                            <td>
                                                 <b>R  </b>
                                            </td>
                                            <td class="td-right">
                                                <b> <%: Model.FNBRefTotal %> </b>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>FNB Returns</legend>
                                    <table>
                                        <% foreach(FNB item in Model.FNB)
                                           { 
                                               if(item.FNBTypeID == 2) {%>
                                        <tr>
                                            <td>
                                                
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Amount %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                                <b> Total </b>
                                            </td>
                                            <td>
                                                 <b>R </b>
                                            </td>
                                            <td class="td-right">
                                                <b> <%: Model.FNBRetTotal %> </b>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
        </tr>
    </table></fieldset>

   <fieldset><legend>KwikPay</legend><table>
        <tr>
            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>Kwik Pay Electricity</legend>
                                    <table>
                                        <% foreach(KwikPay item in Model.KwikPays)
                                           { 
                                               if(item.KwikPayTypeID == 1) {%>
                                        <tr>
                                            <td>
                                                
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Amount %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                                <b> Total  </b>
                                            </td>
                                            <td>
                                                <b> R </b>
                                            </td>
                                            <td class="td-right">
                                                <%: Model.ElecTotal %>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>Kwik Pay Airtime</legend>
                                    <table>
                                        <% foreach(KwikPay item in Model.KwikPays)
                                           { 
                                               if(item.KwikPayTypeID == 2) {%>
                                        <tr>
                                            <td>
                                                
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Amount %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                                 <b>Total </b>
                                            </td>
                                            <td>
                                                <b> R </b>
                                            </td>
                                            <td class="td-right">
                                                <b> <%: Model.AirTotal %> </b>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
            <td style="vertical-align:top">
                                <fieldset>
                                    <legend>Kwik Pay Account Payments</legend>
                                    <table>
                                        <% foreach(KwikPay item in Model.KwikPays)
                                           { 
                                               if(item.KwikPayTypeID == 3) {%>
                                        <tr>
                                            <td>
                                               
                                            </td>
                                            <td>
                                                R
                                            </td>
                                            <td class="td-right">
                                                <%: item.Amount %>
                                            </td>
                                        </tr>
                                        <%      }
                                            } %>
                                        <tr>
                                            <td>
                                                 <b>Total </b>
                                            </td>
                                            <td>
                                                <b> R </b>
                                            </td>
                                            <td class="td-right">
                                                <b> <%: Model.AccTotal %> </b>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </td>
        </tr>
    </table></fieldset> 
    
    

    

    


</asp:Content>
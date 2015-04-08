<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<CashierDayEnd>"%>
<%@ Import Namespace ="SparStelsel" %>
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
        <table>
                <tr>
                    <td><p><%: Html.DisplayFor(m => m.Report.Cashier.Name) %> <%: Html.DisplayFor(m => m.Report.Cashier.Surname) %></p></td>
                    <td style="width:60%">
                    </td>
                    <td>
                        <b>Pickups</b>
                    </td>
                    <td>R</td>
                    <td style="text-align:right;">
                        <%: Html.DisplayFor(m => m.Report.PickupTotal) %>
                    </td>                    
                </tr>
            </table>      
</fieldset>  
        <br />      
    <fieldset>
        <legend><b>Movements</b></legend>
            <table>
                <tr>
                    <td style="vertical-align:top">
                        <fieldset>
                            <legend><b>Cash</b></legend>
                            <table>
                                <tr>
                                    <td style="text-align:left; width:75px">CASH</td>
                                    <td style="text-align:center; width:50px">QTY</td>
                                    <td colspan="2" style="text-align:center;">AMOUNT</td>
                                </tr>
                    
                                <% foreach (CashMovement cash in Model.Report.CashMovements)
                                   {
                                       %><tr>
                                           <td style="text-align:left; width:75px">
                                               <%: Html.DisplayFor(c => cash.moneyunit) %>
                                           </td>
                                           <td style="text-align:center; width:50px">
                                               <%: Html.DisplayFor(c => cash.Count) %>
                                           </td>
                                           <td>
                                               R
                                           </td>
                                           <td style="text-align:right; width:75px">
                                               <%: Html.DisplayFor(c => cash.Amount) %>
                                           </td>
                                         </tr> <%
                                   } %>
                                <tr>
                                    <td colspan="2"></td>
                                    <td>R</td>
                                    <td style="text-align:right; border-bottom:double; border-top:solid">
                                        <%: Html.DisplayFor(m => m.Report.CashTotal)%>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                    </td>
                    <td style="vertical-align:top">
                        <fieldset>
                            <legend><b>Cards</b></legend>
                            <table>
                                <tr>
                                    <td>
                                        <table>
                                            <tr>
                                                <td style="vertical-align:top"> 
                                                    <table>
                                                                  <% int count = 0;
                                               foreach (ElectronicFund el in Model.Report.ElectronicFunds)
                                               {
                                                   if(el.ElectronicTypeID == 2)
                                                   {  
                                                       count++;
                                                   
                                                       if(count % 13 == 0)
                                                       {
                                                           %> <tr>
                                                               <td>R</td>
                                                               <td style="text-align:right; width:75px">
                                                                  <%: Html.DisplayFor(c => el.Total) %>
                                                               </td>
                                                             </tr></table>
                                                        </td>
                                                        <td style="vertical-align:top"><table> <%
                                                       }
                                                       else
                                                       {
                                                       %><tr>
                                                           <td>R</td>
                                                           <td style="text-align:right; width:75px">
                                                              <%: Html.DisplayFor(c => el.Total) %>
                                                           </td>
                                                         </tr> <%
                                                       }
                                                   }
                                                   
                                               } %>

                                                <% for (int i = 0; i < 13 - (count%13); i++)
                                                   {
                                                  %> <tr><td></td><td style="text-align:center; width:75px">-</td></tr> <%
                                                   }  %>                                          
                                                            <tr>
                                                                <td>R</td>
                                                                <td style="text-align:right; width:75px; border-bottom:double; border-top:solid"><%: Html.DisplayFor(m => m.Report.CardsTotal) %></td>
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
                    <td style="vertical-align:top">
                        <fieldset>
                            <legend><b>Cheques</b></legend>
                            <table>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td style="vertical-align:top"> 
                                                        <table>
                                                  <% int ccount = 0;
                                                   foreach (ElectronicFund el in Model.Report.ElectronicFunds)
                                                   {
                                                       if(el.ElectronicTypeID == 3)
                                                       {  
                                                           ccount++;
                                                   
                                                           if(ccount % 5 == 0)
                                                           {
                                                               %> <tr>
                                                               <td>R</td>
                                                               <td style="text-align:right; width:75px">
                                                                  <%: Html.DisplayFor(c => el.Total) %>
                                                               </td>
                                                             </tr></table>
                                                            </td>
                                                            <td style="vertical-align:top"><table> <%
                                                           }
                                                           else
                                                           {
                                                           %><tr>
                                                               <td>R</td>
                                                               <td style="text-align:right; width:75px">
                                                                  <%: Html.DisplayFor(c => el.Total) %>
                                                               </td>
                                                             </tr> <%
                                                           }
                                                       }
                                                   
                                                   } %>

                                                    <% for (int i = 0; i < 5 - (ccount%5); i++)
                                                       {
                                                      %> <tr><td></td><td style="text-align:center; width:75px">-</td></tr> <%
                                                       }  %>                                          
                                                                <tr>
                                                                    <td>R</td>
                                                                    <td style="text-align:right; width:75px; border-bottom:double; border-top:solid"><%: Html.DisplayFor(m => m.Report.ChequeTotal) %></td>
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
                    <td style="vertical-align:top">
                        <fieldset>
                            <legend><b>Sassa</b></legend>
                            <table>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td style="vertical-align:top"> 
                                                        <table>
                                                                      <% int scount = 0;
                                                   foreach (ElectronicFund el in Model.Report.ElectronicFunds)
                                                   {
                                                       if(el.ElectronicTypeID == 1)
                                                       {  
                                                           scount++;
                                                   
                                                           if(scount % 10 == 0)
                                                           {
                                                               %> 
                                                            <tr>
                                                               <td>R</td>
                                                               <td style="text-align:right; width:75px">
                                                                  <%: Html.DisplayFor(c => el.Total) %>
                                                               </td>
                                                             </tr>
                                                        </table>
                                                            </td>
                                                            <td style="vertical-align:top"><table> <%
                                                           }
                                                           else
                                                           {
                                                           %><tr>
                                                               <td>R</td>
                                                               <td style="text-align:right; width:75px">
                                                                  <%: Html.DisplayFor(c => el.Total) %>
                                                               </td>
                                                             </tr> <%
                                                           }
                                                       }
                                                   
                                                   } %>

                                                    <% for (int i = 0; i < 10 - (scount%10); i++)
                                                       {
                                                      %> <tr><td></td><td style="text-align:center; width:75px">-</td></tr> <%
                                                       }  %>                                          
                                                                <tr>
                                                                    <td>R</td>
                                                                    <td style="text-align:right; width:75px; border-bottom:double; border-top:solid"><%: Html.DisplayFor(m => m.Report.SassaTotal) %></td>
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
                <td style="vertical-align:top; width:33%">
                    <fieldset>
                        <legend><b>Sales</b></legend>
                        <table>
                            <tr>
                                <td>
                                    Sigma Expected
                                </td>
                                <td style="padding-left:10px">
                                    R
                                </td>
                                <td style="text-align:right; padding-left:5px">
                                    <%: Html.DisplayFor(m => m.Report.SigmaTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    EFT Expected
                                </td>
                                <td style="padding-left:10px">
                                    R
                                </td>
                                <td style="text-align:right; padding-left:5px"> 
                                    <%: Html.DisplayFor(m => m.Report.EFTReconTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Cash Expected
                                </td>
                                <td style="padding-left:10px">
                                    R
                                </td>
                                <td style="text-align:right; padding-left:5px"> 
                                    <%: Html.DisplayFor(m => m.Report.CashReconTotal) %>
                                </td>
                            </tr>
                            
                        </table>
                    </fieldset>
                </td>
                <td style="vertical-align:top; width:33%">
                    <fieldset>
                        <legend><b>Expected</b></legend>
                        <table>
                            <tr>
                                <td>
                                    Start up float
                                </td>
                                <td style="padding-left:10px">
                                    R
                                </td>
                                <td style="text-align:right;">
                                    <%: Html.DisplayFor(m => m.Report.FloatTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Extra up float
                                </td>
                                <td style="padding-left:10px">
                                    R
                                </td>
                                <td style="text-align:right;">
                                    <%: Html.DisplayFor(m => m.Report.ExtraFloatTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Sigma Sales
                                </td>
                                <td style="padding-left:10px">
                                    R
                                </td>
                                <td style="text-align:right;">
                                    <%: Html.DisplayFor(m => m.Report.SigmaTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Sassa Payouts
                                </td>
                                <td style="padding-left:10px">
                                    R
                                </td>
                                <td style="text-align:right;">
                                    <%: Html.DisplayFor(m => m.Report.SassaTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td style="padding-left:10px">R</td>
                                <td style="text-align:right; width:75px; border-bottom:double; border-top:solid">
                                    <%: Html.DisplayFor(m => m.Report.Expected) %>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </td>
                <td style="vertical-align:top; width:500px">
                    <fieldset>
                        <legend><b>Declared</b></legend>
                        <table>
                            <tr>
                                <td>
                                    Pickups
                                </td>
                                <td style="padding-left:10px">
                                    R
                                </td>
                                <td style="text-align:right;">
                                    <%: Html.DisplayFor(m => m.Report.PickupTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Day end cash
                                </td>
                                <td style="padding-left:10px">
                                    R
                                </td>
                                <td style="text-align:right;"> 
                                    <%: Html.DisplayFor(m => m.Report.CashTotal) %>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td style="padding-left:10px">R</td>
                                <td style="text-align:right; width:75px; border-bottom:double; border-top:solid">
                                    <%: Html.DisplayFor(m => m.Report.Declared) %>
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
                            <td>
                                EFT Balance
                            </td>
                            <% if (Model.Report.EFTFinal == 0)
                               { %> <td>Matched</td> <% }
                               else if (Model.Report.EFTFinal < 0)
                                { %> <td style="color:red">Under</td> <% }
                                else
                                {%> <td style="color:green">Over</td> <%}
                            %>
                            <td>
                                R
                            </td>
                            <td style="text-align:right; width:75px; border-bottom:double;">
                                <%: Html.DisplayFor(m => m.Report.EFTFinal) %>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Cash Balance
                            </td>
                            <% if (Model.Report.CashFinal == 0)
                               { %> <td>Matched</td> <% }
                               else if (Model.Report.CashFinal < 0)
                                { %> <td style="color:red">Under</td> <% }
                                else
                                {%> <td style="color:green">Over</td> <%}
                            %>
                            <td>
                                R
                            </td>
                            <td style="text-align:right; width:75px; border-bottom:double;">
                                <%: Html.DisplayFor(m => m.Report.CashFinal) %>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Day end Balance
                            </td>
                            <% if (Model.Report.Final == 0)
                               { %> <td>Matched</td> <% }
                               else if (Model.Report.Final < 0)
                                { %> <td style="color:red">Under</td> <% }
                                else
                                {%> <td style="color:green">Over</td> <%}
                            %>
                            <td>
                                R
                            </td>
                            <td style="text-align:right; width:75px; border-bottom:double;">
                                <%: Html.DisplayFor(m => m.Report.Final) %>
                            </td>
                        </tr>
                    </table>
        </fieldset>
        
        <br />
        <fieldset>
            <legend><b>Sign-Off</b></legend>
            <table>
                <tr>
                    <td style="width:100px">
                        Signed By: 
                    </td>
                    <td style="border-bottom:solid; width:250px">
        
                    </td>
                    <td style="width:80px; padding-left:10px">
                        Signature: 
                    </td>                    
                    <td style="border-bottom:solid; width:250px">
        
                    </td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td style="width:100px">
                        Date: 
                    </td>
                    <td style="border-bottom:solid; width:250px">
        
                    </td>
                    <td style="width:80px; padding-left:10px">
                        Time: 
                    </td>                    
                    <td style="border-bottom:solid; width:250px">
        
                    </td>
                </tr>
            </table>
        </fieldset>
    </body>    
</html>


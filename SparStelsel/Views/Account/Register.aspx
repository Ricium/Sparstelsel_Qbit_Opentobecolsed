﻿<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SparStelsel.Models.RegisterModel>" %>

<asp:Content ID="registerTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Register
</asp:Content>

<asp:Content ID="registerContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Create a New Account</h2>
    <p>
        Use the form below to create a new account. 
    </p>
    <p>
        Passwords are required to be a minimum of <%: Membership.MinRequiredPasswordLength %> characters in length.
    </p>

    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

    <% using (Html.BeginForm()) { %>
        <%: Html.ValidationSummary(true, "Account creation was unsuccessful. Please correct the errors and try again.") %>
        <div>
            <fieldset>
                <legend>Account Information</legend>
                
                <table>
                    <tr style="vertical-align:top">
                        <td>
                            <div class="editor-label">
                                <%: Html.LabelFor(m => m.UserName) %>
                            </div>
                            <div class="editor-field">
                                <%: Html.TextBoxFor(m => m.UserName) %>
                                <%: Html.ValidationMessageFor(m => m.UserName) %>
                            </div>
                
                            <div class="editor-label">
                                <%: Html.LabelFor(m => m.Email) %>
                            </div>
                            <div class="editor-field">
                                <%: Html.TextBoxFor(m => m.Email) %>
                                <%: Html.ValidationMessageFor(m => m.Email) %>
                            </div>
                
                            <div class="editor-label">
                                <%: Html.LabelFor(m => m.Password) %>
                            </div>
                            <div class="editor-field">
                                <%: Html.PasswordFor(m => m.Password) %>
                                <%: Html.ValidationMessageFor(m => m.Password) %>
                            </div>
                
                            <div class="editor-label">
                                <%: Html.LabelFor(m => m.ConfirmPassword) %>
                            </div>
                            <div class="editor-field">
                                <%: Html.PasswordFor(m => m.ConfirmPassword) %>
                                <%: Html.ValidationMessageFor(m => m.ConfirmPassword) %>
                            </div>

                            <div class="editor-label">
                                <%: Html.LabelFor(m => m.SecurityQuestion) %>
                            </div>
                            <div class="editor-field">
                                <%: Html.TextBoxFor(m => m.SecurityQuestion) %>
                                <%: Html.ValidationMessageFor(m => m.SecurityQuestion) %>
                            </div>

                            <div class="editor-label">
                                <%: Html.LabelFor(m => m.SecurityAnswer) %>
                            </div>
                            <div class="editor-field">
                                <%: Html.TextBoxFor(m => m.SecurityAnswer) %>
                                <%: Html.ValidationMessageFor(m => m.SecurityAnswer) %>
                            </div>
                        </td>
                        <td>
                            <fieldset>
                                <legend>Companies</legend>
                                <div class="editor-field">
                                    <% List<string> citems = (List<string>)ViewData["companyNames"];
                                    if(citems != null)
                                    { 
                                       foreach(string item in citems)
                                       {                       
                                           %> <input type="checkbox" name="roles" value ="<%: item %>" /> <%: item %> <%
                                        } 
                                   }%>
                                </div>
                            </fieldset>
                            <br />
                            <fieldset>
                                <legend>Roles</legend>
                                <div class="editor-field">
                                    <% List<string> ritems = (List<string>)ViewData["roleNames"];
                    
                                   foreach(string item in ritems)
                                   {                       
                                       %> <input type="checkbox" name="roles" value ="<%: item %>" /> <%: item %> <%
                                   } %>
                                </div>
                            </fieldset>
                            <br />
                            <fieldset>
                                <legend>Permissions</legend>
                                <div class="editor-field">
                                    <% List<string> pitems = (List<string>)ViewData["permissionNames"];
                                       int count = 0;%>
                                    <table>
                                        <tr>
                                            <% foreach (string item in pitems)
                                   {
                                       count++;
                                       if(count%4 == 0)
                                       {
                                           %></tr><tr><%
                                       }   
                                       else
                                       {
                                          %> <td><input type="checkbox" name="roles" value ="<%: item %>" /> <%: item %> </td> <%
                                       }      
                                        
                                   } %>
                                        </tr>
                                    </table>

                                       
                                </div>
                            </fieldset>
                        </td>
                    </tr>
                </table>
                

                
                
                <p>
                    <input type="submit" value="Register" />
                </p>
            </fieldset>
        </div>
    <% } %>
</asp:Content>

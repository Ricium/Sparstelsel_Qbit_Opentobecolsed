<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SparStelsel.Models.RoleModel>" %>

<asp:Content ID="registerTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Role Management
</asp:Content>

<asp:Content ID="registerContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Add Role</h2>
    <p>
        Please Role Name
    </p>

    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

    <% using (Html.BeginForm()) { %>
        <%: Html.ValidationSummary(true, "Role creation was unsuccessful. Role MAY already exist.") %>
        <div>
            <fieldset>
                <legend>Role Information</legend>
                
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.RoleName) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.RoleName) %>
                    <%: Html.ValidationMessageFor(m => m.RoleName) %>
                </div>
                
                
                <p>
                    <input type="submit" value="Add Role" />
                </p>
            </fieldset>
        </div>
    <% } %>
 </asp:Content>

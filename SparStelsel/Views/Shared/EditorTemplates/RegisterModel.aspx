<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<RegisterModel>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Register User</title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>       
        <tr>
            <td>
                <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.UserName) %>
            </td>
            <td>
                <%: Html.TextBoxFor(m => m.UserName) %>
                <%: Html.ValidationMessageFor(m => m.UserName) %>
            </td>
        </tr>

        <tr>
            <td>
                <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.Email) %>
            </td>
            <td>
                <%: Html.TextBoxFor(m => m.Email) %>
                <%: Html.ValidationMessageFor(m => m.Email) %>
            </td>
        </tr>
        
        <tr>
            <td>
                <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.Password) %>
            </td>
            <td>
                <%: Html.PasswordFor(m => m.Password) %>
                <%: Html.ValidationMessageFor(m => m.Password) %>
            </td>
        </tr>

        <tr>
            <td>
                <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.ConfirmPassword) %>
            </td>
            <td>
                <%: Html.PasswordFor(m => m.ConfirmPassword) %>
                <%: Html.ValidationMessageFor(m => m.ConfirmPassword) %>
            </td>
        </tr>
        <tr>           
            <td>
                <%: Html.LabelFor(m => m.roles) %>
            </td>
            <td>
                <% List<SelectListItem> items = (List<SelectListItem>) ViewData["roleNames"];
                    
                    foreach(SelectListItem item in items)
                   {
                       
                       %> <input type="checkbox" name="roles" value ="<%: item.Value %>" <%: item.Selected ? " checked=\"checked\" " : "" %> /> <%
                   } %>
              
                                 
                <%: Html.ValidationMessageFor(m => m.roles) %>
            </td>
        </tr>
        </table>
    

</body>
</html>

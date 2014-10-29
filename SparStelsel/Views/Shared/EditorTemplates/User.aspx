<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<User>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>User </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.UserTypeID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.UserName) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.UserName) %>
                            <%: Html.ValidationMessageFor(m => m.UserName) %>
                        </td>
                    </tr>
                                        <tr>
                        <td>
                           <%: Html.LabelFor(m => m.UserSurname) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.UserSurname) %>
                            <%: Html.ValidationMessageFor(m => m.UserSurname) %>
                        </td>
                    </tr>
                                                            <tr>
                        <td>
                           <%: Html.LabelFor(m => m.UserEmail) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.UserEmail) %>
                            <%: Html.ValidationMessageFor(m => m.UserEmail) %>
                        </td>
                    </tr>

                                                         <tr>
                        <td>
                           <%: Html.LabelFor(m => m.UserCell) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.UserCell) %>
                            <%: Html.ValidationMessageFor(m => m.UserCell) %>
                        </td>
                    </tr>
                    <tr>
                                            <tr>
                     <td>
                           <%: Html.LabelFor(m => m.UserTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.UserTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["UserType"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.UserTypeID) %>
                        </td>
                    </tr> 
                    <tr>
                  
                                     

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

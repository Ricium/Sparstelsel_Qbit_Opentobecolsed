<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Comment>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Comment </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.CommentID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Comments) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Comments) %>
                            <%: Html.ValidationMessageFor(m => m.Comments) %>
                        </td>
                    </tr>
                      
                                            <tr>
                     <td>
                           <%: Html.LabelFor(m => m.CommentTypeID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.CommentTypeID).BindTo((IEnumerable<SelectListItem>) ViewData["CommentType"]).HtmlAttributes(new { style = "width: 250px" })%>
                            <%: Html.ValidationMessageFor(model => model.CommentTypeID) %>
                        </td>
                    </tr> 
                    <tr>
                  
                                     

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

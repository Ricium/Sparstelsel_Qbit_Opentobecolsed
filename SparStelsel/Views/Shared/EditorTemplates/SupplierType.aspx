<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<SupplierType>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>SupplierType </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.SupplierTypeID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.SupplierTypes) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.SupplierTypes) %>
                            <%: Html.ValidationMessageFor(m => m.SupplierTypes) %>
                        </td>
                    </tr>
                    <tr>
                  
                                     

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

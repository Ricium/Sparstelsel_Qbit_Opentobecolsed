﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<ElectronicType>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>ElectronicTypes </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.ElectronicTypeID) %>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.ElectronicTypes) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.ElectronicTypes) %>
                            <%: Html.ValidationMessageFor(m => m.ElectronicTypes) %>
                        </td>
                    </tr>
                    <tr>
                               <tr>
                        <td>
                            <b Class=asteriks>*</b> <%: Html.LabelFor(m => m.ElectronicTypeDescription) %>
                        </td>
                        <td>
                            <%: Html.TextAreaFor(m => m.ElectronicTypeDescription) %>
                            <%: Html.ValidationMessageFor(m => m.ElectronicTypeDescription) %>
                        </td>
                    </tr>
                    <tr>

                </table>
            </td>
        </tr>
    </table>

    
</body>
</html>

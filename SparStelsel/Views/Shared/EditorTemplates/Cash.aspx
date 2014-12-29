<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Cash>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Cash </title>
</head>
<body>
    <%: Html.ValidationSummary(false) %>

 
                <table>
                    <tr>
                        <td>
                           Cashier
                        </td>
                        <td>
                             <%: Html.Telerik().DropDownList().Name("Employee").BindTo((IEnumerable<SelectListItem>)ViewData["Employees"]) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           Date
                        </td>
                        <td>
                             <%: Html.Telerik().DatePicker().Name("cashDate").Value(DateTime.Today).TodayButton() %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           Movemnet
                        </td>
                        <td>
                             <%: Html.Telerik().DropDownList().Name("Movement").BindTo((IEnumerable<SelectListItem>)ViewData["Movements"]) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           R 0.05
                        </td>
                        <td>
                            <%: Html.TextBox("r005") %>
                        </td>
                    </tr>
                                        <tr>
                        <td>
                           R 0.10
                        </td>
                        <td>
                            <%: Html.TextBox("r010") %>
                        </td>
                    </tr>
                                                            <tr>
                        <td>
                           R 0.20
                        </td>
                        <td>
                            <%: Html.TextBox("r020") %>
                        </td>
                    </tr>
                                        <tr>
                        <td>
                           R 0.50
                        </td>
                        <td>
                            <%: Html.TextBox("r050") %>
                        </td>
                    </tr>
                                        <tr>
                        <td>
                           R 1.00
                        </td>
                        <td>
                            <%: Html.TextBox("r1") %>
                        </td>
                    </tr>
                                                            <tr>
                        <td>
                           R 2.00
                        </td>
                        <td>
                            <%: Html.TextBox("r2") %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           R 5.00
                        </td>
                        <td>
                            <%: Html.TextBox("r5") %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           R 10.00
                        </td>
                        <td>
                            <%: Html.TextBox("r10") %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           R 20.00
                        </td>
                        <td>
                            <%: Html.TextBox("r20") %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           R 50.00
                        </td>
                        <td>
                            <%: Html.TextBox("r50") %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           R 100.00
                        </td>
                        <td>
                            <%: Html.TextBox("r100") %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           R 200.00
                        </td>
                        <td>
                            <%: Html.TextBox("r200") %>
                        </td>
                    </tr>

                </table>

</body>
</html>

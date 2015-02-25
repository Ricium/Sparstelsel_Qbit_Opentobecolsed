<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Order>" %>
<%@ Import Namespace ="SparStelsel" %>
<%@ Import Namespace="SparStelsel.Models" %>
<%@ Import Namespace="SparStelsel.Controllers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Product Order
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <script>
         function GetProduct(e) {
             var productdd = $('#ProductID').data('tDropDownList');
             var product = productdd.value();

             $.post('/Orders/_GetProductPrice/', { ProductId: product }, function (data) {
                 var numberTextBox = $("#Price").data("tTextBox");
                 var newValue = data;
                 numberTextBox.value(newValue);
             });
         }
    </script>

    <fieldset>
        <legend>Order Details</legend>
        <% using (Html.BeginForm("_ProcessProductOrder", "Orders", FormMethod.Post))
            { %>
               <table>
                    <tr>
                        <td>
                            <%: Html.HiddenFor(m => m.OrderID) %>
                        </td>
                        <td>
                            <%: Html.HiddenFor(m => m.Amount) %>
                            <%: Html.HiddenFor(m => m.SupplierID) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.PinkSlipNumber) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.PinkSlipNumber) %>
                            <%: Html.ValidationMessageFor(m => m.PinkSlipNumber) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.OrderDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.OrderDate).Value(DateTime.Today).TodayButton()  %>
                            <%: Html.ValidationMessageFor(m => m.OrderDate) %>
                        </td>
                        <td>
                           <%: Html.LabelFor(m => m.ExpectedDeliveryDate) %>
                        </td>
                        <td>
                            <%: Html.Telerik().DatePickerFor(m => m.ExpectedDeliveryDate).TodayButton() %>
                            <%: Html.ValidationMessageFor(m => m.ExpectedDeliveryDate) %>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           <%: Html.LabelFor(m => m.Suffix) %>
                        </td>
                        <td>
                            <%: Html.TextBoxFor(m => m.Suffix) %>
                            <%: Html.ValidationMessageFor(m => m.Suffix) %>
                        </td>
                        <td>
                           <%: Html.LabelFor(m => m.CommentID)%>
                        </td>
                        <td>
                           <%: Html.Telerik().DropDownListFor(m => m.CommentID).BindTo((IEnumerable<SelectListItem>) ViewData["Comments"]).HtmlAttributes(new { style = "width: 350px" })%>
                            <%: Html.ValidationMessageFor(model => model.CommentID) %>
                        </td>
                        <td>
                            <button id="SubmitOrder" type="submit" class="t-button">Process</button>
                        </td>
                    </tr>                                                                                    
                </table>  
            <% } %>
    </fieldset>
    <%        Html.Telerik().Grid<OrderProduct>()
                    .Name("Products")
                    .DataKeys(keys => keys.Add(s => s.OrderProductID))
                    .ToolBar(t => t.Insert().ButtonType(GridButtonType.ImageAndText).Text("Add Product"))
                    .Columns(columns =>
                    {
                        columns.Bound(model => model.ProductID);
                        columns.Bound(model => model.Quantity);
                        columns.Bound(model => model.Price).Format("{0:c}");
                        columns.Bound(model => model.ModifiedDate).Format("{0:yyyy-MM-dd}");
                        columns.Bound(model => model.ModifiedBy);

                        columns.Command(commands =>
                        {
                            commands.Edit().ButtonType(GridButtonType.ImageAndText).Text("Update");
                        }).Title("").Width(90);


                        columns.Command(commands =>
                        {
                            commands.Delete().ButtonType(GridButtonType.ImageAndText).Text("Delete");
                        }).Title("").Width(90);                          
                    })
                    .DataBinding(dataBinding =>
                    {
                        dataBinding.Ajax()
                                   .Select("_ListProduct", "Orders", new { OrderId = Model.OrderID })
                                   .Insert("_InsertProduct", "Orders")
                                   .Update("_UpdateProduct","Orders")
                                   .Delete("_RemoveProduct","Orders");
                    })

                    .Pageable(paging => paging.PageSize(50))
                    .Sortable()
                    .Scrollable(scrolling => scrolling.Height(250))
                    .Editable(editing => editing.Mode(GridEditMode.PopUp))
                    .Render();             
                 %>
</asp:Content>



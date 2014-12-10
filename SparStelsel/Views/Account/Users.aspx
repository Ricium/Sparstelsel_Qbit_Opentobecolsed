<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Register Users
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Register User</h2>

    <table>
        <tr>
            <td>
     <% Html.Telerik().Grid<RegisterModel>()
        .Name("Users")
        .DataKeys(keys => keys.Add(s => s.UserName))
        .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(Telerik.Web.Mvc.UI.GridButtonType.ImageAndText))
        .Columns(columns =>
        {
            columns.Bound(m => m.UserName);
            columns.Bound(m => m.Email);
            columns.Command(commands =>
            {
                commands.Delete().ButtonType(Telerik.Web.Mvc.UI.GridButtonType.ImageAndText).Text("Remove User");
            });
        })
        .DataBinding(dataBinding => 
        {
            dataBinding.Ajax()
                        .Select("_ListUser", "Account")
                       .Insert("_InsertUser", "Account")
                       .Delete("_DeleteUser", "Account"); 
        })
       
        .Pageable(paging => paging.PageSize(50))
        .Sortable()
        .Scrollable(scrolling => scrolling.Height(250))
        .Filterable()
        .Editable(editing => editing.Mode(Telerik.Web.Mvc.UI.GridEditMode.PopUp).InsertRowPosition(Telerik.Web.Mvc.UI.GridInsertRowPosition.Top))
        .Render(); %>
            </td>
        </tr>
    </table>
</asp:Content>

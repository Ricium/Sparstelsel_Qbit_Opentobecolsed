<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   CashType
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <table>
        <tr>
            <td>
                <h2>
                     CashType
                </h2>
            </td>
        </tr>
        <tr>
            <td>
             <%
                 if (ViewBag.UPList.Contains(1))
                 {
                     Html.Telerik().Grid<CashType>()
                    .Name("CashTypes")
                    .DataKeys(keys => keys.Add(s => s.))
                    .ToolBar(commands => commands.Insert().ImageHtmlAttributes(new { style = "margin-left:0" }).ButtonType(GridButtonType.ImageAndText).Text("Add VehicleMaintenanceType"))
                    .Columns(columns =>
                    {

                        columns.Bound(model => model.TypeID);
                        columns.Bound(model => model.TypeName);
                        columns.Bound(model => model.ModifiedDate);
                        columns.Bound(model => model.ModifiedBy);
                   
                        if (ViewBag.UPList.Contains(1))
                        {
                            columns.Command(commands =>
                            {
                                commands.Edit().ButtonType(GridButtonType.ImageAndText).Text("Update");
                            }).Title("").Width(90);
                        }
                        if (ViewBag.UPList.Contains(1))
                        {
                            columns.Command(commands =>
                            {
                                commands.Delete().ButtonType(GridButtonType.ImageAndText).Text("Delete");
                            }).Title("").Width(90);
                        }
                    })
                    .DataBinding(dataBinding =>
                    {
                        dataBinding.Ajax()
                                   .Select("_ListVehicleMaintenanceType", "FleetManagement")
                                   .Insert("_InsertVehicleMaintenanceType", "FleetManagement")
                                   .Update("_UpdateVehicleMaintenanceType", "FleetManagement")
                                   .Delete("_RemoveVehicleMaintenanceType", "FleetManagement");
                    })

                    .Pageable(paging => paging.PageSize(50))
                    .Sortable()
                    .Scrollable(scrolling => scrolling.Height(250))
                    .Editable(editing => editing.Mode(GridEditMode.PopUp))
                    .Render();
                 }
                 else
                 {
                     Html.Telerik().Grid<VehicleMaintenanceType>()
                        .Name("VehicleMaintenanceType")
                        .DataKeys(keys => keys.Add(s => s.TypeID))
                        .Columns(columns =>
                        {

                            columns.Bound(model => model.TypeID);
                            columns.Bound(model => model.TypeName);
                            columns.Bound(model => model.ModifiedDate);
                            columns.Bound(model => model.ModifiedBy);
                    
                            
                            if (ViewBag.UPList.Contains(1))
                            {
                                columns.Command(commands =>
                                {
                                    commands.Edit().ButtonType(GridButtonType.ImageAndText).Text("Update");
                                }).Title("");
                            }
                            if (ViewBag.UPList.Contains(1))
                            {
                                columns.Command(commands =>
                                {
                                    commands.Delete().ButtonType(GridButtonType.ImageAndText).Text("Delete");
                                }).Title("");
                            }
                        })
                        .DataBinding(dataBinding =>
                        {
                            dataBinding.Ajax()
                                       .Select("_ListVehicleMaintenanceType", "FleetManagement")
                                       .Insert("_InsertVehicleMaintenanceType", "FleetManagement")
                                       .Update("_UpdateVehicleMaintenanceType", "FleetManagement")
                                       .Delete("_RemoveVehicleMaintenanceType", "FleetManagement");
                        })

                        .Pageable(paging => paging.PageSize(50))
                        .Sortable()
                        .Scrollable(scrolling => scrolling.Height(250))
                        .Editable(editing => editing.Mode(GridEditMode.PopUp))
                        .Render();
                 }%>
            </td>
        </tr>
    </table>
</asp:Content>


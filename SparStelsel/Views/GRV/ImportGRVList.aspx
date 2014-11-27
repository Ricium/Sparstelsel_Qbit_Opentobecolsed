<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="SparStelsel"%>
<%@ Import Namespace="SparStelsel.Models"%>
<%@ Import Namespace="SparStelsel.Controllers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   GRV List Import
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<!--<script>
    $(document).ready(function () {
         $('#fileform').submit(function () {

            var blah = new FormData($('#fileform')[0]);
            blah.append("file", $("#files")[0].files[0]);

            $.ajax({
                async: true,
                type: 'POST',
                url: '/GRV/ImportFromExcel/',
                data: blah,
                success: function (data) {
                    document.location.href = "/GRV/GRVLists/";
                },
                cache: false,
                contentType: false,
                processData: false
            });
            return false;
        });
    });

</script>-->

     <% using (Html.BeginForm("ImportFromExcel", "GRV", FormMethod.Post, new { enctype = "multipart/form-data" }))
       { %>
         <table>
             <tr>
                 <td>Excel file</td>
                 <td><input class="t-button" type="file"  id="files" name="grv" /></td>
                 <td><input class="t-button" type="submit" id="Submit" name="Submit" value="Submit"/></td>
             </tr>
         </table>
     <% } %>
</asp:Content>


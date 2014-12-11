<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<SparStelsel.Models.LogOnModel>" %>


   

    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

    <% using (Html.BeginForm()) { %>
        <%: Html.ValidationSummary(true, "Login was unsuccessful. Please correct the errors and try again.") %>
        <div style="width:400px;height:400px;background-color:rgb(257,47,57);border-color:black;border:solid;border-radius:50;padding:20px;margin:auto auto;box-shadow: 10px 10px 5px #888888; ">
            <h2 style="color:white"><u>Log On</u></h2>
             <img src="../../Images/logo.jpg"style="width:400px;height:50px;" />
    <p style="color:white">
        Please enter your user name and password. 
    </p>
            <fieldset>
                <legend style="color:white">Account Information</legend>
                
                <div class="editor-label"style="color:white; padding:5px;" >
                    <%: Html.LabelFor(m => m.UserName) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.UserName) %>
                    <%: Html.ValidationMessageFor(m => m.UserName) %>
                </div>
                
                <div class="editor-label"style="color:white; padding:5px;">
                    <%: Html.LabelFor(m => m.Password) %>
                </div>
                <div class="editor-field">
                    <%: Html.PasswordFor(m => m.Password) %>
                    <%: Html.ValidationMessageFor(m => m.Password) %>
                </div>
                
                <div class="editor-label"style="color:white;padding:5px;">
                    <%: Html.CheckBoxFor(m => m.RememberMe) %>
                    <%: Html.LabelFor(m => m.RememberMe) %>
                </div>
                
                <p>
                    <input type="submit" value="Log On" />
                </p>
            </fieldset>
        </div>
    <% } %>

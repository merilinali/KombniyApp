#pragma checksum "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36c0f3a5ce158d086682c1d5a4e77f869eb18951"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ChangePassword), @"mvc.1.0.view", @"/Views/Manage/ChangePassword.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\_ViewImports.cshtml"
using KombniyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\_ViewImports.cshtml"
using KombniyApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36c0f3a5ce158d086682c1d5a4e77f869eb18951", @"/Views/Manage/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde0cb099000a1d3912655c1fefd364ef5f3e561", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KombniyApp.Models.ChangePasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml"
  
    ViewBag.Title = "Cambiar contraseña";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 6 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml"
 using (Html.BeginForm("ChangePassword", "Manage", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Formulario para cambiar contraseña</h4>\r\n    <hr />\r\n");
#nullable restore
#line 13 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 15 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml"
   Write(Html.LabelFor(m => m.OldPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml"
       Write(Html.PasswordFor(m => m.OldPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml"
   Write(Html.LabelFor(m => m.NewPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml"
       Write(Html.PasswordFor(m => m.NewPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 27 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml"
   Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml"
       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Cambiar contraseña\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 39 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\ChangePassword.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KombniyApp.Models.ChangePasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
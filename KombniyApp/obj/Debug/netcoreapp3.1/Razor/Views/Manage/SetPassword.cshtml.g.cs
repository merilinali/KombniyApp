#pragma checksum "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\SetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9d38958b938c53c99207b35f74277a132e95da6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_SetPassword), @"mvc.1.0.view", @"/Views/Manage/SetPassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9d38958b938c53c99207b35f74277a132e95da6", @"/Views/Manage/SetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde0cb099000a1d3912655c1fefd364ef5f3e561", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_SetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KombniyApp.Models.SetPasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\SetPassword.cshtml"
  
    ViewBag.Title = "Crear contraseña";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\SetPassword.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n<p class=\"text-info\">\r\n    No dispone de un nombre de usuario o contraseña local para este sitio. Agregue una cuenta\r\n    local para iniciar sesión sin que sea necesario ningún inicio de sesión externo.\r\n</p>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\SetPassword.cshtml"
 using (Html.BeginForm("SetPassword", "Manage", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\SetPassword.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Crear inicio de sesión local</h4>\r\n    <hr />\r\n");
#nullable restore
#line 19 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\SetPassword.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\SetPassword.cshtml"
   Write(Html.LabelFor(m => m.NewPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\SetPassword.cshtml"
       Write(Html.PasswordFor(m => m.NewPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 27 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\SetPassword.cshtml"
   Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\SetPassword.cshtml"
       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Establecer contraseña\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\SetPassword.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 39 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\SetPassword.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KombniyApp.Models.SetPasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
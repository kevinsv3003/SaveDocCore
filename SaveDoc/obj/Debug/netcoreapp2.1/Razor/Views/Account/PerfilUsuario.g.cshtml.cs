#pragma checksum "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\PerfilUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e7d04dd2bf31383523e90d8c0d0f88d65b3aceb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_PerfilUsuario), @"mvc.1.0.view", @"/Views/Account/PerfilUsuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/PerfilUsuario.cshtml", typeof(AspNetCore.Views_Account_PerfilUsuario))]
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
#line 1 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\_ViewImports.cshtml"
using SaveDoc;

#line default
#line hidden
#line 2 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\_ViewImports.cshtml"
using SaveDoc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7d04dd2bf31383523e90d8c0d0f88d65b3aceb", @"/Views/Account/PerfilUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c6a99c3436ca721091b9a9109f0f11d9537f9b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_PerfilUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\PerfilUsuario.cshtml"
  
    ViewBag.Title = "Cuenta";
    ViewBag.SubTitle = "Perfil de Usuario";
    ViewBag.url = @Url.Action("PerfilUsuario", "Account");
    Layout = "~/Views/Shared/_LayoutDoc.cshtml";

#line default
#line hidden
            BeginContext(195, 141, true);
            WriteLiteral("\r\n\r\n<div id=\"viewDatosPersonales\" class=\"animated fadeIn\"></div>\r\n<div id=\"ModalChangePass\"></div>\r\n<div id=\"ModalEditUsuario\"></div>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(336, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b02378834128465b85d82e10fb133a0f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(404, 137, true);
            WriteLiteral("\r\n<script>\r\n\r\n    $(function () {\r\n        ShowDatosPersonales();\r\n    });\r\n\r\n\r\n    function ShowModalChangePass() {\r\n        var url = \'");
            EndContext();
            BeginContext(542, 39, false);
#line 25 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\PerfilUsuario.cshtml"
              Write(Url.Action("_CambiarContra", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(581, 510, true);
            WriteLiteral(@"';
        $.ajax({
            type: ""POST"",
            url: url,
            contentType: ""application/json; charset=utf-8"",
            dataType: ""html"",
            success: function (response) {
                $('#ModalChangePass').html(response);
                $('#modal-changePass').modal(""show"");
            },
            error: function (response) {
                console.log(response);
            }
        });
    }

    function ShowDatosPersonales() {
        var url = '");
            EndContext();
            BeginContext(1092, 41, false);
#line 42 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\PerfilUsuario.cshtml"
              Write(Url.Action("_DatosPersonales", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 516, true);
            WriteLiteral(@"';
        $.ajax({
            type: ""POST"",
            url: url,
            contentType: ""application/json; charset=utf-8"",
            dataType: ""html"",
            async: false,
            success: function (response) {
                $('#viewDatosPersonales').html(response);
            },
            error: function (response) { console.log(response);}
        });
    }

    function ShowModalEdit(origen, id) {
        var parametros = { Origen: origen, IdUser: id }
        var url = '");
            EndContext();
            BeginContext(1650, 41, false);
#line 58 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\PerfilUsuario.cshtml"
              Write(Url.Action("_FormEditUsuario", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 510, true);
            WriteLiteral(@"';
        $.ajax({
            type: ""POST"",
            url: url,
            data: JSON.stringify(parametros),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""html"",
            success: function (response) {
                $('#ModalEditUsuario').html(response);
                $('#modal-editUser').modal(""show"");
            },
            error: function (response) {
                console.log(response);
            }
        });
    }
</script>

");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

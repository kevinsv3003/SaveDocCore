#pragma checksum "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\AccesoDenegado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e592bd8aa636f135c3d44122e72d3252aefe814"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AccesoDenegado), @"mvc.1.0.view", @"/Views/Account/AccesoDenegado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/AccesoDenegado.cshtml", typeof(AspNetCore.Views_Account_AccesoDenegado))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e592bd8aa636f135c3d44122e72d3252aefe814", @"/Views/Account/AccesoDenegado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c6a99c3436ca721091b9a9109f0f11d9537f9b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AccesoDenegado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/css/AccesoDenegado/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\AccesoDenegado.cshtml"
  
    ViewData["Title"] = "AccesoDenegado";
    Layout = null;
    var estaLogueado = User.Identity.IsAuthenticated;

#line default
#line hidden
            BeginContext(127, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc80564557084fb496510521b5632de2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(195, 706, true);
            WriteLiteral(@"
<style>
    a:hover {
        background: #fff !important;
        color: #008648 !important;
        -webkit-box-shadow: 0px 4px 15px -5px #07832c !important;
        box-shadow: 0px 4px 15px -5px #07832c !important;
        transition: 0.5s ease !important;
        -webkit-transition: 0.5s ease !important;
        -o-transition: 0.5s ease !important;
    }
</style>



<div id=""notfound"">
    <div class=""notfound"">
        <div class=""notfound-404"">
            <h1>Oops!</h1>
        </div>
        <br /><br />
        <h2>403 - Acceso Denegado!</h2>
        <p>Usted no posee el permiso para acceder a este formulario, favor coumicarse con el administrador del sistema.</p>
");
            EndContext();
#line 30 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\AccesoDenegado.cshtml"
         if (estaLogueado)
        {

#line default
#line hidden
            BeginContext(940, 28, true);
            WriteLiteral("            <a class=\"boton\"");
            EndContext();
            BeginWriteAttribute("href", " href=", 968, "", 1001, 1);
#line 32 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\AccesoDenegado.cshtml"
WriteAttributeValue("", 974, Url.Action("Index","Home"), 974, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1001, 25, true);
            WriteLiteral(">Regresar al Inicio</a>\r\n");
            EndContext();
#line 33 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\AccesoDenegado.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1062, 28, true);
            WriteLiteral("            <a class=\"boton\"");
            EndContext();
            BeginWriteAttribute("href", " href=", 1090, "", 1126, 1);
#line 36 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\AccesoDenegado.cshtml"
WriteAttributeValue("", 1096, Url.Action("Index","Account"), 1096, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1126, 22, true);
            WriteLiteral(">Ingresar Sesión</a>\r\n");
            EndContext();
#line 37 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\AccesoDenegado.cshtml"
        }

#line default
#line hidden
            BeginContext(1159, 26, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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

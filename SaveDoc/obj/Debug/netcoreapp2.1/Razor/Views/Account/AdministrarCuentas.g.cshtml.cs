#pragma checksum "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\AdministrarCuentas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0e3ee642d9de7e38150bcc5a0379b34280e6f0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AdministrarCuentas), @"mvc.1.0.view", @"/Views/Account/AdministrarCuentas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/AdministrarCuentas.cshtml", typeof(AspNetCore.Views_Account_AdministrarCuentas))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e3ee642d9de7e38150bcc5a0379b34280e6f0c", @"/Views/Account/AdministrarCuentas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c6a99c3436ca721091b9a9109f0f11d9537f9b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AdministrarCuentas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dominio.EntidadesDto.UsuarioDto>
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
#line 1 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\AdministrarCuentas.cshtml"
  
    ViewBag.Title = "Cuentas";
    ViewBag.SubTitle = "Administrar Cuentas";
    ViewBag.url = @Url.Action("AdministrarCuentas", "Account");
    Layout = "~/Views/Shared/_LayoutDoc.cshtml";

#line default
#line hidden
            BeginContext(241, 358, true);
            WriteLiteral(@"
<div class=""col-md-3"" style=""padding-left:0px"">
    <button type=""button"" id=""btnNuevoDoc"" class=""btn float-left bg-olive"" onclick=""ShowModalEdit(2,'')"">
        <i class=""fa fa-plus""></i>
        Agregar Usuarios
    </button>
</div>
<br /><br />

<div id=""ModalEditUsuario""></div>
<div id=""viewListaUsuarios"" class=""animated fadeIn""></div>


");
            EndContext();
            BeginContext(599, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77881d1995d8473f8c773b89755b26ae", async() => {
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
            BeginContext(667, 130, true);
            WriteLiteral("\r\n<script>\r\n    function ShowModalEdit(origen, id) {\r\n        var parametros = { Origen: origen, IdUser: id }\r\n        var url = \'");
            EndContext();
            BeginContext(798, 41, false);
#line 25 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\AdministrarCuentas.cshtml"
              Write(Url.Action("_FormEditUsuario", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(839, 548, true);
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
     function ShowUsuarios() {
        var url = '");
            EndContext();
            BeginContext(1388, 39, false);
#line 42 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\AdministrarCuentas.cshtml"
              Write(Url.Action("_TablaUsuarios", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 466, true);
            WriteLiteral(@"';
        $.ajax({
            type: ""POST"",
            url: url,
            contentType: ""application/json; charset=utf-8"",
            dataType: ""html"",
            success: function (response) {
                $('#viewListaUsuarios').html(response);
            },
            error: function (response) {
                console.log(response);
            }
        });
    }

    $(function () {
        ShowUsuarios();
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dominio.EntidadesDto.UsuarioDto> Html { get; private set; }
    }
}
#pragma warning restore 1591

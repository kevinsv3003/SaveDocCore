#pragma checksum "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Area\_ListaAreaCuadro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf6799e3e2643e53bc95b24b8d691880cf02eed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Area__ListaAreaCuadro), @"mvc.1.0.view", @"/Views/Area/_ListaAreaCuadro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Area/_ListaAreaCuadro.cshtml", typeof(AspNetCore.Views_Area__ListaAreaCuadro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf6799e3e2643e53bc95b24b8d691880cf02eed", @"/Views/Area/_ListaAreaCuadro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c6a99c3436ca721091b9a9109f0f11d9537f9b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Area__ListaAreaCuadro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dominio.EntidadesDto.AreaDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/css/AreaEstilos.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e6bda230e6a448cb935e20b4c6b139e", async() => {
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
            BeginContext(102, 632, true);
            WriteLiteral(@"

<div class=""box box-success "">
    <div class=""box-header with-border"">
        <i class=""fa fa-shopping-bag""></i>
        <h3 class=""box-title"">Listado de áreas</h3>
        <div class=""box-tools pull-right"">
            <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"" data-toggle=""tooltip"" title="""" data-original-title=""Collapse"">
                <i class=""fa fa-minus""></i>
            </button>
        </div>
    </div>
    <div class=""box-body"">
        <div id=""divGrupos"" style=""height: 510px; overflow-y: auto"">
            <div class=""row"" style=""margin-right: 0px"">                
");
            EndContext();
#line 17 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Area\_ListaAreaCuadro.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(799, 278, true);
            WriteLiteral(@"                    <div class=""col-md-3"">

                        <div class=""box box-default shadow animated fadeIn"" style=""box-shadow: 0 2px 5px 0 rgba(0,0,0,0.16), 0 2px 10px 0 rgba(0,0,0,0.12);"">
                            <div class=""box-header with-border fondocard""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1077, "\"", 1187, 4);
            WriteAttributeValue("", 1085, "background-image:", 1085, 17, true);
            WriteAttributeValue(" ", 1102, "url(", 1103, 5, true);
#line 22 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Area\_ListaAreaCuadro.cshtml"
WriteAttributeValue("", 1107, string.Format("data:image/png;base64,{0}", Convert.ToBase64String(item.Fondo)), 1107, 79, false);

#line default
#line hidden
            WriteAttributeValue("", 1186, ")", 1186, 1, true);
            EndWriteAttribute();
            BeginContext(1188, 53, true);
            WriteLiteral(">\r\n                                <h3 class=\"texto\">");
            EndContext();
            BeginContext(1242, 11, false);
#line 23 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Area\_ListaAreaCuadro.cshtml"
                                             Write(item.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(1253, 191, true);
            WriteLiteral("</h3>\r\n                            </div>\r\n                            <div class=\"box-body descripciones\">\r\n                                <div class=\"panel-text text-muted\">Area Nº: <span>");
            EndContext();
            BeginContext(1445, 11, false);
#line 26 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Area\_ListaAreaCuadro.cshtml"
                                                                             Write(item.AreaId);

#line default
#line hidden
            EndContext();
            BeginContext(1456, 111, true);
            WriteLiteral("</span></div>\r\n                                <div class=\"panel-text text-muted text-cute\">Descripción: <span>");
            EndContext();
            BeginContext(1568, 16, false);
#line 27 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Area\_ListaAreaCuadro.cshtml"
                                                                                           Write(item.Descripcion);

#line default
#line hidden
            EndContext();
            BeginContext(1584, 184, true);
            WriteLiteral("</span></div>\r\n                            </div>\r\n                            <div class=\"box-footer text-center\">\r\n                                <button class=\"btn bg-olive fadeIn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1768, "\"", 1809, 3);
            WriteAttributeValue("", 1778, "showModalFormArea(", 1778, 18, true);
#line 30 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Area\_ListaAreaCuadro.cshtml"
WriteAttributeValue("", 1796, item.AreaId, 1796, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1808, ")", 1808, 1, true);
            EndWriteAttribute();
            BeginContext(1810, 265, true);
            WriteLiteral(@">
                                    <i class=""fa fa-edit""></i>
                                    Modificar Área
                                </button>
                                <button class=""btn btn-default fadeIn pull-right"" title=""Eliminar área""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2075, "\"", 2130, 3);
            WriteAttributeValue("", 2085, "ConfirmarEliminado(EliminarArea,", 2085, 32, true);
#line 34 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Area\_ListaAreaCuadro.cshtml"
WriteAttributeValue("", 2117, item.AreaId, 2117, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2129, ")", 2129, 1, true);
            EndWriteAttribute();
            BeginContext(2131, 232, true);
            WriteLiteral(">\r\n                                    <i class=\"fa fa-trash-o\" style=\"font-size:19px\"></i>\r\n                                </button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 40 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Area\_ListaAreaCuadro.cshtml"
                }

#line default
#line hidden
            BeginContext(2382, 130, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<script>\r\n\r\n    \r\n    function EliminarArea(AreaId) {\r\n        var url = \'");
            EndContext();
            BeginContext(2513, 35, false);
#line 49 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Area\_ListaAreaCuadro.cshtml"
              Write(Url.Action("_EliminarArea", "Area"));

#line default
#line hidden
            EndContext();
            BeginContext(2548, 584, true);
            WriteLiteral(@"';        
        $.ajax({
            type: ""POST"",
            url: url,
            data: JSON.stringify(AreaId),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""html"",
            success: function (response) {
                showCuadroArea();
                SuccessGuardarJq(response, vacio);
                //SuccessGuardar(response);
            },
            error: function (response) {
                console.log(response);
                FailGuardarJq(response);
            }
        });
    }   
    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dominio.EntidadesDto.AreaDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fc4bae5ab2c4e1cce781e1f6ae2a96245e647c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account__TablaUsuarios), @"mvc.1.0.view", @"/Views/Account/_TablaUsuarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/_TablaUsuarios.cshtml", typeof(AspNetCore.Views_Account__TablaUsuarios))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fc4bae5ab2c4e1cce781e1f6ae2a96245e647c0", @"/Views/Account/_TablaUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c6a99c3436ca721091b9a9109f0f11d9537f9b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Account__TablaUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dominio.EntidadesDto.UsuarioDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(50, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28c8ade2b08e4093af5f94abb773e0d6", async() => {
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
            BeginContext(135, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(137, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9b1455c542c43bc83e574c40548ec18", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(228, 1778, true);
            WriteLiteral(@"

<div class=""row"">
    <div class="" col-md-12"" >
        <div class=""box box-success shadow"">
            <div class=""box-header with-border"">
                <i class=""fa fa-id-card-o""></i>
                <h3 class=""box-title"">Listado de Usuarios  </h3>

                <div class=""box-tools pull-right"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"" data-toggle=""tooltip"" title="""" data-original-title=""Collapse"">
                        <i class=""fa fa-minus""></i>
                    </button>
                </div>
            </div>

            <div id=""contentUser"" class=""box-body box-profile"" style=""padding: 10px 20px 10px 20px"">

                <table id=""tablaUsuario"" class=""table table-hover dataTable"" style=""border: 1px solid #dddddd;"" role=""grid"">
                    <thead>
                        <tr class=""bg-olive"">
                            <th class=""text-center"">
                                Nombres
                    ");
            WriteLiteral(@"        </th>
                            <th class=""text-center"">
                                Apellidos
                            </th>
                            <th class=""text-center"">
                                Usuario
                            </th>
                            <th class=""text-center"">
                                Correo
                            </th>
                            <th class=""text-center"">
                                Rol
                            </th>
                            <th class=""text-center"">
                                Acciones
                            </th>
                        </tr>
                    </thead>
                    <tbody >
");
            EndContext();
#line 47 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2087, 129, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-justify\">\r\n                                    ");
            EndContext();
            BeginContext(2217, 12, false);
#line 51 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml"
                               Write(item.Nombres);

#line default
#line hidden
            EndContext();
            BeginContext(2229, 136, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-justify\">\r\n                                    ");
            EndContext();
            BeginContext(2366, 14, false);
#line 54 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml"
                               Write(item.Apellidos);

#line default
#line hidden
            EndContext();
            BeginContext(2380, 136, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-justify\">\r\n                                    ");
            EndContext();
            BeginContext(2517, 13, false);
#line 57 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml"
                               Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2530, 136, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-justify\">\r\n                                    ");
            EndContext();
            BeginContext(2667, 10, false);
#line 60 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml"
                               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2677, 136, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-justify\">\r\n                                    ");
            EndContext();
            BeginContext(2814, 8, false);
#line 63 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml"
                               Write(item.Rol);

#line default
#line hidden
            EndContext();
            BeginContext(2822, 216, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"width: 15em;\" class=\"text-right\">\r\n                                    <a class=\"btn btn-flat bg-olive shadow grow btn-sp btnaccion\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3038, "\"", 3075, 3);
            WriteAttributeValue("", 3048, "ShowModalEdit(3,\'", 3048, 17, true);
#line 66 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml"
WriteAttributeValue("", 3065, item.Id, 3065, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3073, "\')", 3073, 2, true);
            EndWriteAttribute();
            BeginContext(3076, 292, true);
            WriteLiteral(@" data-toggle=""tooltip"" data-html=""true"" data-placement=""left"" title=""Ver Detalles"">
                                        <i class=""fa fa-edit""></i>
                                    </a>
                                    <a class=""btn btn-flat bg-olive shadow grow btn-sp btnaccion""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3368, "\"", 3426, 5);
            WriteAttributeValue("", 3378, "_RestaurarContra(\'", 3378, 18, true);
#line 69 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml"
WriteAttributeValue("", 3396, item.Email, 3396, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3407, "\',\'", 3407, 3, true);
#line 69 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml"
WriteAttributeValue("", 3410, item.UserName, 3410, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 3424, "\')", 3424, 2, true);
            EndWriteAttribute();
            BeginContext(3427, 306, true);
            WriteLiteral(@" data-toggle=""tooltip"" data-html=""true"" data-placement=""left"" title=""Restaurar Contraseña"">
                                        <i class=""fa  fa-refresh""></i>
                                    </a>
                                    <a class=""btn btn-flat btn-danger shadow grow btn-sp btnaccion""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3733, "\"", 3764, 3);
            WriteAttributeValue("", 3743, "_Eliminar(\'", 3743, 11, true);
#line 72 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml"
WriteAttributeValue("", 3754, item.Id, 3754, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3762, "\')", 3762, 2, true);
            EndWriteAttribute();
            BeginContext(3765, 267, true);
            WriteLiteral(@" data-toggle=""tooltip"" data-html=""true"" data-placement=""left"" title=""Eliminar"">
                                        <i class=""fa fa-remove""></i>
                                    </a>
                                </td>
                            </tr>
");
            EndContext();
#line 77 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml"
                        }

#line default
#line hidden
            BeginContext(4059, 581, true);
            WriteLiteral(@"
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

<script>
    $(function () {
        EstiloTabla('#tablaUsuario');        
    });

    function _Eliminar(id) {
        ConfirmarEliminado(EliminarUsuario, id);
    }

    function _RestaurarContra(email, username) {
        ConfirmarRestauracion(RecordarContra, email, username);
    }

    function RecordarContra(email, username) {
        IniciarLoad('#contentUser');
        var model = { Email: email, userName: username }
        var url = '");
            EndContext();
            BeginContext(4641, 43, false);
#line 102 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml"
              Write(Url.Action("RecordarContraseña", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(4684, 779, true);
            WriteLiteral(@"';        
        $.ajax({
            type: ""POST"",
            url: url,
            data: JSON.stringify(model),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""html"",
            success: function (response) {
                console.log(response);
                SuccessMensaje(""Se ha restaurado la contraseña con éxito, se recomiendo cambiarla al iniciar sesión."");
                CerrarLoad('#contentUser');
            },
            error: function (response) {
                console.log(response);
                CerrarLoad('#contentUser');
                FailGuardarJq(response);
            }
        });
    }

    function EliminarUsuario(Id) {
        IniciarLoad('#contentUser');
        var url = '");
            EndContext();
            BeginContext(5464, 40, false);
#line 124 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_TablaUsuarios.cshtml"
              Write(Url.Action("EliminarUsuario", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(5504, 619, true);
            WriteLiteral(@"';        
        $.ajax({
            type: ""POST"",
            url: url,
            data: JSON.stringify(Id),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""html"",
            success: function (response) {
                ShowUsuarios();
                SuccessGuardarJq(response, vacio);
                CerrarLoad('#contentUser');
            },
            error: function (response) {
                console.log(response);
                CerrarLoad('#contentUser');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dominio.EntidadesDto.UsuarioDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

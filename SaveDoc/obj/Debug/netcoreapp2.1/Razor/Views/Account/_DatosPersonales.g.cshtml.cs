#pragma checksum "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f282fad7cb592aaf5f4fe23cc99c90bf86cf130f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account__DatosPersonales), @"mvc.1.0.view", @"/Views/Account/_DatosPersonales.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/_DatosPersonales.cshtml", typeof(AspNetCore.Views_Account__DatosPersonales))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f282fad7cb592aaf5f4fe23cc99c90bf86cf130f", @"/Views/Account/_DatosPersonales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c6a99c3436ca721091b9a9109f0f11d9537f9b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Account__DatosPersonales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entidades.Entidades.UsuarioApp>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-user-img img-responsive pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:65%; height:230px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/img/avatar5.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User profile picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/img/avatar2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
   
    var sexo = (Model.Sexo == "M") ? "Masculino" : "Femenino";

#line default
#line hidden
            BeginContext(113, 1157, true);
            WriteLiteral(@"
<div class=""row"">
    <div class="" col-md-12"">
        <div class=""box box-success shadow"">
            <div class=""box-header with-border"">
                <i class=""fa fa-id-card-o""></i>
                <h3 class=""box-title"">Datos Personales</h3>

                <div class=""box-tools pull-right"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"" data-toggle=""tooltip"" title="""" data-original-title=""Collapse"">
                        <i class=""fa fa-minus""></i>
                    </button>
                </div>
            </div>

            <!-- /.box-header -->
            <div class=""box-body box-profile"" style=""padding: 10px 20px 10px 20px"">
                <div id=""divInfoEst"" style=""height: 420px;"">
                    <div class=""row"">
                        <div class=""col-md-5"">
                            <div class=""row"">
                                <div class=""form-group"">
                                    <h5 class=""col-md-2");
            WriteLiteral(" text-bold\">Nombres: </h5>\r\n                                    <div class=\"col-md-10\">\r\n                                        <h5>");
            EndContext();
            BeginContext(1271, 13, false);
#line 30 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
                                       Write(Model.Nombres);

#line default
#line hidden
            EndContext();
            BeginContext(1284, 470, true);
            WriteLiteral(@"</h5>
                                    </div>
                                </div>
                            </div>      <br />
                            <br />
                            <div class=""row"">
                                <div class=""form-group"">
                                    <h5 class=""col-md-2 text-bold"">Apellidos: </h5>
                                    <div class=""col-md-10"">
                                        <h5>");
            EndContext();
            BeginContext(1755, 15, false);
#line 39 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
                                       Write(Model.Apellidos);

#line default
#line hidden
            EndContext();
            BeginContext(1770, 508, true);
            WriteLiteral(@"</h5>
                                    </div>
                                </div>
                            </div>


                            <br />
                            <br />
                            <div class=""row"">
                                <div class=""form-group"">
                                    <h5 class=""col-md-2 text-bold"">Fecha de Nacimiento: </h5>
                                    <div class=""col-md-10"">
                                        <h5>");
            EndContext();
            BeginContext(2279, 23, false);
#line 51 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
                                       Write(ViewBag.FechaNacimiento);

#line default
#line hidden
            EndContext();
            BeginContext(2302, 489, true);
            WriteLiteral(@"</h5>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <br />
                            <div class=""row"">
                                <div class=""form-group"">
                                    <h5 class=""col-md-2 text-bold"">Edad: </h5>
                                    <div class=""col-md-10"">
                                        <h5>");
            EndContext();
            BeginContext(2792, 12, false);
#line 61 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
                                       Write(ViewBag.Edad);

#line default
#line hidden
            EndContext();
            BeginContext(2804, 489, true);
            WriteLiteral(@"</h5>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <br />
                            <div class=""row"">
                                <div class=""form-group"">
                                    <h5 class=""col-md-2 text-bold"">Sexo: </h5>
                                    <div class=""col-md-10"">
                                        <h5>");
            EndContext();
            BeginContext(3294, 4, false);
#line 71 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
                                       Write(sexo);

#line default
#line hidden
            EndContext();
            BeginContext(3298, 494, true);
            WriteLiteral(@"</h5>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <br />
                            <div class=""row"">
                                <div class=""form-group"">
                                    <h5 class=""col-md-2 text-bold"">Dirección: </h5>
                                    <div class=""col-md-10"">
                                        <h5>");
            EndContext();
            BeginContext(3793, 15, false);
#line 81 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
                                       Write(Model.Direccion);

#line default
#line hidden
            EndContext();
            BeginContext(3808, 495, true);
            WriteLiteral(@"</h5>
                                    </div>
                                </div>
                            </div>

                            <br />
                            <br />
                            <div class=""row"">
                                <div class=""form-group"">
                                    <h5 class=""col-md-2 text-bold"">Télefono: </h5>
                                    <div class=""col-md-10"">
                                        <h5>");
            EndContext();
            BeginContext(4304, 17, false);
#line 92 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
                                       Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4321, 491, true);
            WriteLiteral(@"</h5>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <br />
                            <div class=""row"">
                                <div class=""form-group"">
                                    <h5 class=""col-md-2 text-bold"">Correo: </h5>
                                    <div class=""col-md-10"">
                                        <h5>");
            EndContext();
            BeginContext(4813, 11, false);
#line 102 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
                                       Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(4824, 2264, true);
            WriteLiteral(@"</h5>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <br />
                            <div class=""row"">
                                <div class=""form-group"">
                                    <h5 class=""col-md-2 text-bold"">Contraseña: </h5>
                                    <div class=""col-md-10"">
                                        <h5>[<a href=""#"" style=""color:#01714a"" onclick=""ShowModalChangePass()"">Cambiar Contraseña</a>]</h5>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <br />

                        </div>

                        <div class=""col-md-3"">
                            <fieldset style=""display: block;
                                            margin-left: 2px;
                               ");
            WriteLiteral(@"             margin-right: 2px;
                                            padding-top: 0.35em;
                                            padding-bottom: 0.625em;
                                            padding-left: 0.75em;
                                            padding-right: 0.75em;
                                            border: 2px groove;"">
                                <legend style=""width:auto;
                                            padding:0px 12px;
                                            margin:0px;"">
                                    Datos de Usuario
                                </legend>

                                <div class=""col-md-12"">
                                    <div class=""row"">
                                        <div class=""form-group"">
                                            <div class=""col-md-6 pull-left"" style=""padding-right:0px"">
                                                <h5 class=""text-bold"">Nombre de Usuario: <");
            WriteLiteral("/h5>\r\n                                            </div>\r\n\r\n                                            <div class=\"col-md-6  pull-left\" style=\"padding-left:0px\">\r\n                                                <h5>");
            EndContext();
            BeginContext(7089, 14, false);
#line 144 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
                                               Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(7103, 667, true);
            WriteLiteral(@"</h5>
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""form-group"">
                                            <div class=""col-md-6 pull-left"" style=""padding-right:0px"">
                                                <h5 class=""text-bold"">Rol: </h5>
                                            </div>
                                            <div class=""col-md-6 pull-left"" style=""padding-left:0px"">
                                                <h5>");
            EndContext();
            BeginContext(7771, 11, false);
#line 155 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
                                               Write(ViewBag.Rol);

#line default
#line hidden
            EndContext();
            BeginContext(7782, 486, true);
            WriteLiteral(@"</h5>
                                            </div>
                                        </div>
                                    </div>
                                </div>





                            </fieldset>
                        </div>
                        <br />
                        <div class=""col-md-4"">
                            <div class=""col-md-12"">
                                <div class=""row "" style=""margin-bottom:10px"">
");
            EndContext();
#line 171 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
                                     if (Model.Sexo == "M")
                                    {

#line default
#line hidden
            BeginContext(8366, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2cdca913989d4ca1967ba8c82a3e0ce8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
#line 172 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
                                                                                                                                                                                     }
                                    else
                                    {

#line default
#line hidden
            BeginContext(8592, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ccb5754e2fbd403c8f221d94555ce969", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
#line 174 "C:\Users\ksilva\Desktop\Proyectos\GitHub\SaveDocCore\SaveDoc\Views\Account\_DatosPersonales.cshtml"
                                                                                                                                                                                     }

#line default
#line hidden
            BeginContext(8739, 578, true);
            WriteLiteral(@"
                                </div>

                                <div class=""row"" style=""margin-top:10px"">
                                    <button class=""btn btn-block btn-social bg-olive pull-right"" style="" width:65%;"" type=""button"" onclick=""ShowModalEdit(1,'')"" ><i class=""fa fa-pencil-square-o""></i>&nbsp;<b>Editar Información</b></button>
                                </div>
                            </div>


                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entidades.Entidades.UsuarioApp> Html { get; private set; }
    }
}
#pragma warning restore 1591

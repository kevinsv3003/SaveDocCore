#pragma checksum "C:\Users\ksilva\Desktop\Proyectos\Proyectos_Core\savedoccore\SaveDoc\Views\Reportes\CorreoContra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5f193b5c30cff7075c5cf88ca5384edba0fbcda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reportes_CorreoContra), @"mvc.1.0.view", @"/Views/Reportes/CorreoContra.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reportes/CorreoContra.cshtml", typeof(AspNetCore.Views_Reportes_CorreoContra))]
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
#line 1 "C:\Users\ksilva\Desktop\Proyectos\Proyectos_Core\savedoccore\SaveDoc\Views\_ViewImports.cshtml"
using SaveDoc;

#line default
#line hidden
#line 2 "C:\Users\ksilva\Desktop\Proyectos\Proyectos_Core\savedoccore\SaveDoc\Views\_ViewImports.cshtml"
using SaveDoc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f193b5c30cff7075c5cf88ca5384edba0fbcda", @"/Views/Reportes/CorreoContra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c6a99c3436ca721091b9a9109f0f11d9537f9b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Reportes_CorreoContra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 44, true);
            WriteLiteral("\r\n<h1>Sistema DocSave!</h1>\r\n<p>Hola Sr(a)  ");
            EndContext();
            BeginContext(45, 20, false);
#line 3 "C:\Users\ksilva\Desktop\Proyectos\Proyectos_Core\savedoccore\SaveDoc\Views\Reportes\CorreoContra.cshtml"
          Write(Model.NombreCompleto);

#line default
#line hidden
            EndContext();
            BeginContext(65, 79, true);
            WriteLiteral(", se le da aviso de su cambio de contraseña.</p>\r\n<p><strong>Usuario:</strong> ");
            EndContext();
            BeginContext(145, 19, false);
#line 4 "C:\Users\ksilva\Desktop\Proyectos\Proyectos_Core\savedoccore\SaveDoc\Views\Reportes\CorreoContra.cshtml"
                        Write(Model.NombreUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(164, 38, true);
            WriteLiteral("</p>\r\n<p><strong>Contraseña:</strong> ");
            EndContext();
            BeginContext(203, 16, false);
#line 5 "C:\Users\ksilva\Desktop\Proyectos\Proyectos_Core\savedoccore\SaveDoc\Views\Reportes\CorreoContra.cshtml"
                           Write(Model.Contraseña);

#line default
#line hidden
            EndContext();
            BeginContext(219, 135, true);
            WriteLiteral("</p>\r\n<p>Nota!! Se recomienda cambiar su contraseña al iniciar sesión en el apartado de <strong>Configuracion de Perfil</strong>.</p>\r\n");
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

#pragma checksum "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\_DetallesNT.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00a8610626e419c555202057859df3fd3991c1d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__DetallesNT), @"mvc.1.0.view", @"/Views/Home/_DetallesNT.cshtml")]
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
#line 1 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\_ViewImports.cshtml"
using RetoTecnico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\_ViewImports.cshtml"
using RetoTecnico.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\_DetallesNT.cshtml"
using EntidadesCompartidas.Entidades;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00a8610626e419c555202057859df3fd3991c1d1", @"/Views/Home/_DetallesNT.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b548c9c998d09b279d304c2701d1ef11d0646d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__DetallesNT : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NoTripulada>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\_DetallesNT.cshtml"
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\_DetallesNT.cshtml"
  
    ViewData["Title"] = "Home Page";



#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table-dark"" summary=""Naves Lanzadas"" border=""1"">
            <thead>
                <tr>
                    <th scope=""col"">Velocidad</th>
                    <th scope=""col"">Sistema de propulsion</th>
                    <th scope=""col"">Peso</th>
                    <th scope=""col"">Empuje</th>
                    <th scope=""col"">Se encuentra en actividad</th>
                    <th scope=""col"">Codigo de motor</th>
                    <th scope=""col"">En que planeta se encuentra</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
#nullable restore
#line 22 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\_DetallesNT.cshtml"
                   Write(Model.Velocidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM/H</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\_DetallesNT.cshtml"
                   Write(Model.SistemaDePropulsion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\_DetallesNT.cshtml"
                   Write(Model.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\_DetallesNT.cshtml"
                   Write(Model.Empuje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\_DetallesNT.cshtml"
                   Write(Model.Actividad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\_DetallesNT.cshtml"
                   Write(Model.TipoMotor.CodFabrica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\_DetallesNT.cshtml"
                   Write(Model.LugarDeEstudio.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NoTripulada> Html { get; private set; }
    }
}
#pragma warning restore 1591

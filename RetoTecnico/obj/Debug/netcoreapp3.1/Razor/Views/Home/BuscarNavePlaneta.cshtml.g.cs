#pragma checksum "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddbe1791e733db795abdd9a2ed4b06c8adefe096"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BuscarNavePlaneta), @"mvc.1.0.view", @"/Views/Home/BuscarNavePlaneta.cshtml")]
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
#line 1 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"
using EntidadesCompartidas.Entidades;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddbe1791e733db795abdd9a2ed4b06c8adefe096", @"/Views/Home/BuscarNavePlaneta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b548c9c998d09b279d304c2701d1ef11d0646d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BuscarNavePlaneta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Nave>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"
  
    ViewData["Title"] = "Home Page";

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"
     using (Html.BeginForm("BuscarNavePlaneta", "Home", FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <div class=\"btn-group\">");
#nullable restore
#line 11 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"
                              Write(Html.DropDownList("Nombre", ViewBag.ListPlaneta as SelectList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <br />\r\n            <button type=\"submit\">Buscar</button>\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"
     
    if (Model != null)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table-dark"" summary=""Naves Lanzadas"" border=""1"">
                <thead>
                    <tr>
                        <th scope=""col"">Velocidad</th>
                        <th scope=""col"">Sistema de propulsion</th>
                        <th scope=""col"">Peso</th>
                        <th scope=""col"">Empuje</th>
                        <th scope=""col"">Se encuentra en actividad</th>
                        <th scope=""col"">Codigo de motor</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
#nullable restore
#line 33 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"
                       Write(item.Velocidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM/H</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"
                       Write(item.SistemaDePropulsion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"
                       Write(item.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"
                       Write(item.FechaDespegue);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"
                       Write(item.Firma.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"
                       Write(Html.ActionLink("Ver", "DetallesNT", "Home", new { numero = item.Numero }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 42 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\BuscarNavePlaneta.cshtml"

        }
    }


#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Nave>> Html { get; private set; }
    }
}
#pragma warning restore 1591

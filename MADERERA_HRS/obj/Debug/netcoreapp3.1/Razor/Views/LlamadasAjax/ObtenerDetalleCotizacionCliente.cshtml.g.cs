#pragma checksum "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1dab9f92f66b5f6d0fb7468d7980de6d9ef8a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LlamadasAjax_ObtenerDetalleCotizacionCliente), @"mvc.1.0.view", @"/Views/LlamadasAjax/ObtenerDetalleCotizacionCliente.cshtml")]
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
#line 1 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\_ViewImports.cshtml"
using MADERERA_HRS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\_ViewImports.cshtml"
using MADERERA_HRS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1dab9f92f66b5f6d0fb7468d7980de6d9ef8a8", @"/Views/LlamadasAjax/ObtenerDetalleCotizacionCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0567fe31a7291547ba761674eb427d99aa8dfebf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LlamadasAjax_ObtenerDetalleCotizacionCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
  Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td><img style=\"width:40px;height:55px\"");
            BeginWriteAttribute("src", " src=\"", 97, "\"", 115, 1);
#nullable restore
#line 5 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
WriteAttributeValue("", 103, item.Imagen, 103, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\n    <td>");
#nullable restore
#line 6 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
   Write(item.Producto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 7 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
   Write(item.Medidas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n        ");
#nullable restore
#line 9 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
   Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 10 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
         if (item.Cotizacion.Id_Estado == 1 || item.Cotizacion.Id_Estado == 3 || item.Cotizacion.Id_Estado == 6)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"actualizarcantidaddetallecotizacion btn btn-warning\" data-idcotizacion=\"");
#nullable restore
#line 12 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
                                                                                         Write(item.Id_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-iddetallecotizacion=\"");
#nullable restore
#line 12 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
                                                                                                                                        Write(item.Id_Detalle_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"glyphicon glyphicon-refresh\"></span></a>\n");
#nullable restore
#line 13 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\n");
#nullable restore
#line 15 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
     if (item.Cotizacion.Id_Estado == 3)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 17 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
       Write(item.Estado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 18 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
       Write(item.Estado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 19 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 22 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
       Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 23 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
       Write(item.Sub_Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 24 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td>");
#nullable restore
#line 25 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
   Write(item.Estado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n");
#nullable restore
#line 27 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
         if (item.Cotizacion.Id_Estado == 1 || item.Cotizacion.Id_Estado == 3 || item.Cotizacion.Id_Estado == 6)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"eliminaritemdetallecotizacion btn btn-danger\" data-idcotizacion=\"");
#nullable restore
#line 29 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
                                                                                  Write(item.Id_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-iddetallecotizacion=\"");
#nullable restore
#line 29 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
                                                                                                                                 Write(item.Id_Detalle_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"glyphicon glyphicon-trash\"></span>");
            WriteLiteral("</a>\n");
#nullable restore
#line 30 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <label>...</label>");
#nullable restore
#line 32 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>\n");
#nullable restore
#line 36 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionCliente.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

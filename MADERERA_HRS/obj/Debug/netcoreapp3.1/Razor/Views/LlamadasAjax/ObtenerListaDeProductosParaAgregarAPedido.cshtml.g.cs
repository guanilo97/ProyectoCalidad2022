#pragma checksum "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerListaDeProductosParaAgregarAPedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a2d5498ff84355db2e786d03a7804b3262cd069"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LlamadasAjax_ObtenerListaDeProductosParaAgregarAPedido), @"mvc.1.0.view", @"/Views/LlamadasAjax/ObtenerListaDeProductosParaAgregarAPedido.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a2d5498ff84355db2e786d03a7804b3262cd069", @"/Views/LlamadasAjax/ObtenerListaDeProductosParaAgregarAPedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0567fe31a7291547ba761674eb427d99aa8dfebf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LlamadasAjax_ObtenerListaDeProductosParaAgregarAPedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerListaDeProductosParaAgregarAPedido.cshtml"
  Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerListaDeProductosParaAgregarAPedido.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td><img style=\"width:40px;height:55px\"");
            BeginWriteAttribute("src", " src=\"", 105, "\"", 123, 1);
#nullable restore
#line 5 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerListaDeProductosParaAgregarAPedido.cshtml"
WriteAttributeValue("", 111, item.Imagen, 111, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> ");
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 6 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerListaDeProductosParaAgregarAPedido.cshtml"
       Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 7 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerListaDeProductosParaAgregarAPedido.cshtml"
       Write(item.Categoria.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 8 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerListaDeProductosParaAgregarAPedido.cshtml"
       Write(item.Medidas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 9 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerListaDeProductosParaAgregarAPedido.cshtml"
       Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 10 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerListaDeProductosParaAgregarAPedido.cshtml"
       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>\n            <button class=\"agregarproductoapedido btn btn-warning\" data-idproducto=\"");
#nullable restore
#line 12 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerListaDeProductosParaAgregarAPedido.cshtml"
                                                                               Write(item.Id_Producto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"glyphicon glyphicon-plus\"></span> Agregar</button>\n        </td>\n    </tr>\n");
#nullable restore
#line 15 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerListaDeProductosParaAgregarAPedido.cshtml"
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
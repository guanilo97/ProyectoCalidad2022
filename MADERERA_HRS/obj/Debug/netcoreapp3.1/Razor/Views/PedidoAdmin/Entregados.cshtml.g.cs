#pragma checksum "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\Entregados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c10889ca1144dd2396ca46f725fdf5a02428573"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PedidoAdmin_Entregados), @"mvc.1.0.view", @"/Views/PedidoAdmin/Entregados.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c10889ca1144dd2396ca46f725fdf5a02428573", @"/Views/PedidoAdmin/Entregados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0567fe31a7291547ba761674eb427d99aa8dfebf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PedidoAdmin_Entregados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/PedidoAdmin/Entregados"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/scriptsmaderera/Notificaciones.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\Entregados.cshtml"
   Layout = "Layout_Admin"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<footer>\n    <h1>Pedidos entregados</h1>\n    <br />\n    <br />\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c10889ca1144dd2396ca46f725fdf5a024285735166", async() => {
                WriteLiteral(@"
        <div class=""col-md-12"">
            <div class=""col-md-3"">
                <input type=""text"" class=""form-control"" name=""query"" placeholder=""Ingrese DNI"" />
            </div>
            <div class=""col-md-2"">
                <button class=""btn btn-primary"">Buscar</button>
            </div>
            <div class=""col-sm-2""></div>
");
                WriteLiteral("        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <br />
    <div class=""container"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>DNI</th>
                    <th>Nombre</th>
                    <th>Teléfono-comunicación</th>
                    <th>Fecha</th>
                    <th>Fecha-E-Solicitada</th>
                    <th>Dirección entrega</th>
                    <th>Total</th>
                    <th>Opciones</th>
                </tr>
            </thead>
            <tbody id=""tbodynuevospedidos"">
");
#nullable restore
#line 38 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\Entregados.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 41 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\Entregados.cshtml"
                       Write(item.Usuario.DNI);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 42 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\Entregados.cshtml"
                       Write(item.Usuario.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 43 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\Entregados.cshtml"
                       Write(item.Telefono_Comunicacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 44 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\Entregados.cshtml"
                       Write(item.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 45 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\Entregados.cshtml"
                       Write(item.Fecha_Entrega_Solicitada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 46 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\Entregados.cshtml"
                       Write(item.Direccion_Entrega);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 47 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\Entregados.cshtml"
                       Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <a class=\"verdetallepedido btn btn-success\" data-idpedido=\"");
#nullable restore
#line 49 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\Entregados.cshtml"
                                                                                  Write(item.Id_Pedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\".bd-example-modal-xl1\"><span class=\"glyphicon glyphicon-eye-open\"></span> Ver productos</a>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 52 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\Entregados.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>

    <!--Modal para mostrar el detalle de mi pedido que estoy seleccionando------------------->
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>


    <!-- Extra large modal -->


    <div class=""modal fade bd-example-modal-xl1"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myExtraLargeModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-xl"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Detalle de pedido</h5>
                    <button type=""button"" class=");
            WriteLiteral(@"""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th>Imagen</th>
                                <th>Producto</th>
                                <th>Medidas</th>
                                <th>Cantidad</th>
                                <th>Precio Unit.</th>
                                <th>SubTotal</th>
                            </tr>
                        </thead>
                        <tbody id=""detallpedido"">
                        </tbody>
                    </table>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
");
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n\n</footer>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c10889ca1144dd2396ca46f725fdf5a0242857313021", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c10889ca1144dd2396ca46f725fdf5a0242857314059", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- CSS only -->
<script>
    var idpedido = 0;

    $(""body"").on(""click"", "".verdetallepedido"", function (e) {
        var $this = $(this)
        e.preventDefault();
        idpedido = $this.data(""idpedido"");

        var request = $.ajax({
            url: '/LlamadasAjax/ObtenerDetallePedidoEntregadoAdmin?idpedido=' + idpedido
        });
        request.done(function (resp) {
            $(""#detallpedido"").html(resp);
        });
    });
</script>
");
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
#pragma checksum "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce22a1fd86e91a0a2e071ea54d7ea903430e7bd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PedidoAdmin_EnConstruccion), @"mvc.1.0.view", @"/Views/PedidoAdmin/EnConstruccion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce22a1fd86e91a0a2e071ea54d7ea903430e7bd7", @"/Views/PedidoAdmin/EnConstruccion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0567fe31a7291547ba761674eb427d99aa8dfebf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PedidoAdmin_EnConstruccion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/PedidoAdmin/EnConstruccion"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
   Layout = "Layout_Admin"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<footer>\n    <h1>Pedidos en construcción</h1>\n    <br />\n    <br />\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce22a1fd86e91a0a2e071ea54d7ea903430e7bd75199", async() => {
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
                    <th>Avance</th>
                    <th>Opciones</th>
                </tr>
            </thead>
            <tbody id=""tbodynuevospedidos"">
");
#nullable restore
#line 39 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 42 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                       Write(item.Usuario.DNI);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 43 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                       Write(item.Usuario.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 44 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                       Write(item.Telefono_Comunicacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 45 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                       Write(item.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 46 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                       Write(item.Fecha_Entrega_Solicitada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 47 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                       Write(item.Direccion_Entrega);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 48 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                       Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n");
#nullable restore
#line 50 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                              string a = "";
                                a = Convert.ToString(item.Avance + "%");
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"progress\">\n                                <div class=\"progress-bar bg-primary\" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 2087, "\"", 2104, 2);
            WriteAttributeValue("", 2095, "width:", 2095, 6, true);
#nullable restore
#line 54 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
WriteAttributeValue(" ", 2101, a, 2102, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2105, "\"", 2133, 1);
#nullable restore
#line 54 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
WriteAttributeValue("", 2121, item.Avance, 2121, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\">");
#nullable restore
#line 54 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                                                                                                                                                                        Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                            </div>\n                            <br />\n                            <a class=\"actualizarporcentajeconstrucion btn btn-warning\" data-idpedido=\"");
#nullable restore
#line 57 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                                                                                                 Write(item.Id_Pedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"glyphicon glyphicon-refresh\"></span></a>\n                        </td>\n                        <td>\n                            <a class=\"finalizarconstruccionpedido btn btn-warning\" data-idpedido=\"");
#nullable restore
#line 60 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                                                                                             Write(item.Id_Pedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"glyphicon glyphicon-play\"></span>Finalizar construcción</a>\n                            <a class=\"verdetallepedido btn btn-success\" data-idpedido=\"");
#nullable restore
#line 61 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                                                                                  Write(item.Id_Pedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\".bd-example-modal-xl1\"><span class=\"glyphicon glyphicon-eye-open\"></span> Ver productos</a>\n                            <a class=\"eliminarpedido btn btn-danger\" data-idpedido=\"");
#nullable restore
#line 62 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
                                                                               Write(item.Id_Pedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"glyphicon glyphicon-trash\"></span>Eliminar</a>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 65 "C:\Users\HP\Downloads\Inversiones-H-R-master\MADERERA_HRS\Views\PedidoAdmin\EnConstruccion.cshtml"
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
                                <th>Estado</th>
                                <th>Eliminar</th>
                            </tr>
                        </thead>
                        <tbody id=""detallpedido"">
                        </tbody>
                    </table>
                </div>
                <div class=""modal-footer"">
                    <button id=""btnagregarproducto"" cl");
            WriteLiteral("ass=\"btn btn-primary\" data-toggle=\"modal\" data-target=\".bd-example-modal-xl\">Agregar producto</button>\n                    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cerrar</button>\n");
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>


    <!--En este modal obtengo todos los productos mediante ajax y puedo agregar a mi pedido-->
    <div class=""modal fade bd-example-modal-xl"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myExtraLargeModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-xl"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Detalle de pedido</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th>Imagen</th>
                                <th>Producto</th>
                                <");
            WriteLiteral(@"th>Categoria</th>
                                <th>Medidas</th>
                                <th>Precio Unit.</th>
                                <th>Descripción</th>
                                <th> Opciones </th>
                            </tr>
                        </thead>
                        <tbody id=""tbodylistaproductos"">
                        </tbody>
                    </table>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
");
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n\n</footer>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce22a1fd86e91a0a2e071ea54d7ea903430e7bd718496", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce22a1fd86e91a0a2e071ea54d7ea903430e7bd719534", async() => {
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
    $(""body"").on(""click"", "".eliminarpedido"", function (e) {
        e.preventDefault();
        var $this = $(this);
        idpedido = $this.data(""idpedido"");

        Swal.fire({
            title: 'Estas seguro?',
            text: ""No podrás revertir esto!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'Cancelar',
            confirmButtonText: 'Si, eliminar pedido!'
        }).then((result) => {
            if (result.value) {
                location.href = ""/PedidoAdmin/Eliminar?idpedido="" + idpedido + ""&&Vista=EnConstruccion"";
            }
        })
    });

    $(""body"").on(""click"", "".finalizarconstruccionpedido"", function (e) {
        e.preventDefault();
        var $this = $(this);
        var idpedido = $this.data(""idpedido"");

        const swalWithBootstrapButtons = Swal.mixin({
            customClass: {
        ");
            WriteLiteral(@"        confirmButton: 'btn btn-success',
                cancelButton: 'btn btn-danger'
            },
            buttonsStyling: false
        })

        swalWithBootstrapButtons.fire({
            title: 'Estas seguro?',
            text: ""No podras revertir esto!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonText: 'Si, finalizar construcción!',
            cancelButtonText: 'No, cancelar!',
            reverseButtons: true
        }).then((result) => {
            if (result.isConfirmed) {
                location.href = ""/PedidoAdmin/FinalizarConstruccion?idpedido="" + idpedido;
            }
        })
    });

    $(""body"").on(""click"", "".verdetallepedido"", function (e) {
        var $this = $(this)
        e.preventDefault();
        idpedido = $this.data(""idpedido"");

        var request = $.ajax({
            url: '/LlamadasAjax/ObtenerDetallePedidoAdmin?idpedido=' + idpedido
        });
        request.done(function (resp) {
            $(""#detallpedido");
            WriteLiteral(@""").html(resp);
        });

    });

    $(""body"").on(""click"", "".actualizarcantidaddetallepedido"", function (e) {
        var $this = $(this)
        e.preventDefault();
        var iddetallepedido = $this.data(""iddetallepedido"");
        idpedido = $this.data(""idpedido"");

        Swal.fire({
            text: 'Actualizar cantidad de producto',
            input: 'number'
        }).then(function (result) {
            if (result.value) {
                const amount = result.value
                if (amount > 0) {
                    var request1 = $.ajax({
                        url: '/LlamadasAjax/ActualizarCantidadDeDetallePedido?iddetallepedido=' + iddetallepedido + ""&&cantidad="" + amount
                    });
                    request1.done(function (resp) {
                        if (resp == true) {
                            var request = $.ajax({
                                url: '/LlamadasAjax/ObtenerDetallePedidoAdmin?idpedido=' + idpedido
                            });
                ");
            WriteLiteral(@"            request.done(function (resp) {
                                $(""#detallpedido"").html(resp);

                                var request3 = $.ajax({
                                    url: '/LlamadasAjax/ObtenerPedidosEnConstruccionAdmin'
                                });
                                request3.done(function (resp) {
                                    $(""#tbodynuevospedidos"").html(resp);
                                });
                                const Toast = Swal.mixin({
                                    toast: true,
                                    position: 'top-end',
                                    showConfirmButton: false,
                                    timer: 3000,
                                    timerProgressBar: true,
                                    didOpen: (toast) => {
                                        toast.addEventListener('mouseenter', Swal.stopTimer)
                                        toast.addEventListener('mouseleave");
            WriteLiteral(@"', Swal.resumeTimer)
                                    }
                                })

                                Toast.fire({
                                    icon: 'success',
                                    title: 'Se actualizo con exito'
                                })
                            });
                        }
                        else {
                            Swal.fire({
                                icon: 'error',
                                title: 'Oops...',
                                text: 'Algo salio mal!',
                                //footer: '<a href="""">Why do I have this issue?</a>'
                            })
                        }
                    });
                } else {
                    Swal.fire({
                        icon: 'error',
                        title: 'Oops...',
                        text: 'La cantidad debe ser mayor a cero!'
                        //footer: '<a href="""">Why do I have this issue?</a");
            WriteLiteral(@">'
                    })
                }
            } else {
                Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                    text: 'Asegurese de ingresar una cantidad!'
                    //footer: '<a href="""">Why do I have this issue?</a>'
                })
            }
        })
    });

    $(""body"").on(""click"", "".eliminaritemdetallepedido"", function (e) {
        var $this = $(this)
        e.preventDefault();
        var iddetallepedido = $this.data(""iddetallepedido"");
        idpedido = $this.data(""idpedido"");

        Swal.fire({
            title: 'Estas seguro?',
            text: ""No podrás revertir esto!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'Cancelar',
            confirmButtonText: 'Si, eliminar producto!'
        }).then((result) => {
            if (result.isConfirmed) {
                const");
            WriteLiteral(@" Toast = Swal.mixin({
                    toast: true,
                    position: 'top-end',
                    showConfirmButton: false,
                    timer: 3000,
                    timerProgressBar: true,
                    didOpen: (toast) => {
                        toast.addEventListener('mouseenter', Swal.stopTimer)
                        toast.addEventListener('mouseleave', Swal.resumeTimer)
                    }
                })

                Toast.fire({
                    icon: 'success',
                    title: 'Se elimino con exito'
                })

                var request1 = $.ajax({
                    url: '/LlamadasAjax/EliminarItemDetallePedido?iddetallepedido=' + iddetallepedido
                });
                request1.done(function (resp) {
                    if (resp == true) {
                        var request = $.ajax({
                            url: '/LlamadasAjax/ObtenerDetallePedidoAdmin?idpedido=' + idpedido
                        });
        ");
            WriteLiteral(@"                request.done(function (resp) {
                            $(""#detallpedido"").html(resp);

                            var request3 = $.ajax({
                                url: '/LlamadasAjax/ObtenerPedidosEnConstruccionAdmin'
                            });
                            request3.done(function (resp) {
                                $(""#tbodynuevospedidos"").html(resp);
                            });
                            const Toast = Swal.mixin({
                                toast: true,
                                position: 'top-end',
                                showConfirmButton: false,
                                timer: 3000,
                                timerProgressBar: true,
                                didOpen: (toast) => {
                                    toast.addEventListener('mouseenter', Swal.stopTimer)
                                    toast.addEventListener('mouseleave', Swal.resumeTimer)
                                }
     ");
            WriteLiteral(@"                       })

                            Toast.fire({
                                icon: 'success',
                                title: 'Se elimino con exito'
                            })
                        });
                    }
                    else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Oops...',
                            text: 'Algo salio mal!',
                            //footer: '<a href="""">Why do I have this issue?</a>'
                        })
                    }
                });

            }
        })
    });

    $(""#btnagregarproducto"").click(function (e) {
        e.preventDefault();
        var request = $.ajax({
            url: '/LlamadasAjax/ObtenerListaDeProductosParaAgregarAPedido'
        });
        request.done(function (resp) {
            $(""#tbodylistaproductos"").html(resp);
        });

    });

    $(""body"").on(""click"", "".agregarproductoapedido"", function (e) {");
            WriteLiteral(@"
        var $this = $(this)
        e.preventDefault();
        var idproducto = $this.data(""idproducto"");

        var request = $.ajax({
            url: '/LlamadasAjax/AgregarProductoAPedido?idpedido=' + idpedido + '&&idproducto=' + idproducto
        });
        request.done(function (resp) {
            if (resp == true) {
                var request1 = $.ajax({
                    url: '/LlamadasAjax/ObtenerDetallePedidoAdmin?idpedido=' + idpedido
                });
                request1.done(function (resp) {
                    $(""#detallpedido"").html(resp);
                });
                var request3 = $.ajax({
                    url: '/LlamadasAjax/ObtenerPedidosEnConstruccionAdmin'
                });
                request3.done(function (resp) {
                    $(""#tbodynuevospedidos"").html(resp);
                });

                const Toast = Swal.mixin({
                    toast: true,
                    position: 'top-end',
                    showConfirmButton: false,
  ");
            WriteLiteral(@"                  timer: 3000,
                    timerProgressBar: true,
                    didOpen: (toast) => {
                        toast.addEventListener('mouseenter', Swal.stopTimer)
                        toast.addEventListener('mouseleave', Swal.resumeTimer)
                    }
                })

                Toast.fire({
                    icon: 'success',
                    title: 'Se agregó con exito'
                })
            }
        });
    });

    $(""body"").on(""click"", "".actualizarporcentajeconstrucion"", function (e) {
        var $this = $(this)
        e.preventDefault();
        idpedido = $this.data(""idpedido"");

        Swal.fire({
            text: 'Actualizar porcentaje - solo de 0% - 100%',
            input: 'number'
        }).then(function (result) {
            if (result.value) {
                const amount = result.value
                if (amount >= 0 && amount <= 100) {
                    location.href = ""/PedidoAdmin/CambiarPorcentajeConstruccion?idpedido");
            WriteLiteral(@"="" + idpedido + ""&&porcentaje="" + amount;
                } else {
                    Swal.fire({
                        icon: 'error',
                        title: 'Oops...',
                        text: 'La cantidad debe ser entre 0% - 100%!'
                        //footer: '<a href="""">Why do I have this issue?</a>'
                    })
                }
            } else {
                Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                    text: 'Asegurese de ingresar una cantidad!'
                    //footer: '<a href="""">Why do I have this issue?</a>'
                })
            }
        })
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

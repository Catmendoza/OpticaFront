#pragma checksum "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5f77b27d8452879d4a3011abaeefb7409616946"
// <auto-generated/>
#pragma warning disable 1591
namespace Optica.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\_Imports.razor"
using Optica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\_Imports.razor"
using Optica.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inicio/{correo}")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<img src=\"/img/logo.png\" asp-append-version=\"true\" width=\"300px\">\r\n\r\nBienvenido ");
            __builder.AddContent(1, 
#nullable restore
#line 7 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
            correo

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, " a la optica Cat, encontraras marcos para tu gafas a tu gusto y un buen precio en tus lentes.\r\n\r\n");
#nullable restore
#line 9 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
 if (_usuarios != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "    <div class=\" row px-4\" style=\"background-color: #F9C953; height: 30px;\"></div>\r\n    ");
            __builder.OpenComponent<Blazorise.Carousel>(4);
            __builder.AddAttribute(5, "SelectedSlide", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
                                    selectedSlide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "SelectedSlideChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedSlide = __value, selectedSlide))));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<Blazorise.CarouselSlide>(9);
                __builder2.AddAttribute(10, "Name", "1");
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\r\n            <img src=\"/img/gafa4.jpg\" Display=\"Display.Block\" Style=\"width: 100%; height: 500px;\">\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Blazorise.CarouselSlide>(14);
                __builder2.AddAttribute(15, "Name", "2");
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(17, "\r\n            <img src=\"/img/gafa5.jpg\" Display=\"Display.Block\" Style=\"width: 100%;height: 500px;\">\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<Blazorise.CarouselSlide>(19);
                __builder2.AddAttribute(20, "Name", "3");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(22, "\r\n            <img src=\"/img/gafa6.jpg\" Display=\"Display.Block\" Style=\"width: 100%;height: 500px;\">\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.AddMarkupContent(25, "    <div class=\" row px-4\" style=\"background-color: #F9C953; height: 30px;\"></div>\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "style", "width: 300px; display: flex;");
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 26 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
         foreach (var item in _gafas)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "style", "margin: 20px;");
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenComponent<Blazorise.Card>(33);
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n                    <img src=\"/img/gafa1.jpg\" asp-append-version=\"true\" width=\"300px\">\r\n\r\n                    ");
                __builder2.OpenComponent<Blazorise.CardBody>(36);
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(38, "\r\n                        ");
                    __builder3.OpenComponent<Blazorise.CardTitle>(39);
                    __builder3.AddAttribute(40, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 33 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
                                         5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(42, 
#nullable restore
#line 33 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
                                             item["filtro"]

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n                        ");
                    __builder3.OpenComponent<Blazorise.CardText>(44);
                    __builder3.AddAttribute(45, "size", "3");
                    __builder3.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(47, "\r\n                            ");
                        __builder4.OpenElement(48, "p");
                        __builder4.AddContent(49, " Material: ");
                        __builder4.AddContent(50, 
#nullable restore
#line 35 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
                                           item["material"]

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(51, "\r\n                            ");
                        __builder4.OpenElement(52, "p");
                        __builder4.AddContent(53, " Marco: ");
                        __builder4.AddContent(54, 
#nullable restore
#line 36 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
                                        item["marco"]

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(55, "\r\n                            ");
                        __builder4.OpenElement(56, "p");
                        __builder4.AddContent(57, "Precio: ");
                        __builder4.AddContent(58, 
#nullable restore
#line 37 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
                                        item["precio"]

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(59, "\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\r\n                        ");
                    __builder3.OpenComponent<Blazorise.Button>(61);
                    __builder3.AddAttribute(62, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 39 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
                                       Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
                                                                  () => comprar(item["id"].ToString())

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(65, "Comprar");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\r\n                        ");
                    __builder3.OpenComponent<Blazorise.Button>(67);
                    __builder3.AddAttribute(68, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 40 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
                                       Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
                                                                  () => comprarCredito(item["id"].ToString())

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(71, "Comprar");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 44 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 46 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
            
    private Newtonsoft.Json.Linq.JArray _usuarios;
    private Newtonsoft.Json.Linq.JArray _gafas;

    protected override async Task OnInitializedAsync() { await getUsuario(); await getGafas(); }

    private async Task getUsuario() => _usuarios = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(await
        Http.GetStringAsync("http://localhost:5000/api/usuarios/"));

    private async Task getGafas() => _gafas = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(await
        Http.GetStringAsync("http://localhost:5000/api/gafas/"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor"
      
    [Parameter]
    public string correo { get; set; }
    private string selectedSlide = "2";

    protected override void OnParametersSet()
    {
        this.correo = correo;
    }

    public async void comprar(string id)
    {
        var res = await Http.GetStringAsync("http://localhost:5000/api/compra/" + id + "/" + correo + "/PSE");

        await js.InvokeAsync<string>("console.log", res);
    }

    public async void comprarCredito(string id)
    {
        var res = await Http.GetStringAsync("http://localhost:5000/api/compra/" + id + "/" + correo + "/TC");

        await js.InvokeAsync<string>("console.log", res);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

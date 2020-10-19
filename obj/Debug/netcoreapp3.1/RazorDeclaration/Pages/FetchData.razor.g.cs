#pragma checksum "C:\Users\catic\Documents\Proyectos\Programación.net\parcial2\Optica\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5f77b27d8452879d4a3011abaeefb7409616946"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Demo4.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using Demo4.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using Demo4.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\Pages\FetchData.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\Pages\FetchData.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\Pages\FetchData.razor"
using Demo4.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\Pages\FetchData.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
        catch (AccessTokenNotAvailableException exception)
        {        
            Toaster.Add($"Detaljer: {exception.Message}", MatToastType.Warning, "Systemfeil oppstod.");
            // exception.Redirect();
        }
        Toaster.Add("Et slags værvarsel er hentet.", MatToastType.Info, "Til din informasjon");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

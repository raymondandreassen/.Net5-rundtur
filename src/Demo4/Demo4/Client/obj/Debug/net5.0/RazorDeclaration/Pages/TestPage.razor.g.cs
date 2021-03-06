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
#line 14 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\_Imports.razor"
using Demo4.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\Pages\TestPage.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/testpage")]
    public partial class TestPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\Pages\TestPage.razor"
       
    bool loadingTheKey = false;
    string theKey = "";

    bool loadingCountries = false;
    RequestContries reqdata = new RequestContries();
    List<ResponseCountries> countrylist = null;

    protected async Task GetTheKey(MouseEventArgs e)
    {
        loadingTheKey = true;
        theKey = await Http.GetStringAsync("api/Test/GetTheKey");
        loadingTheKey = false;
        Toaster.Add(theKey, MatToastType.Info, "Nøkkelen er hentet");


    }    
    
    protected async Task GetCountries(MouseEventArgs e)
    {   // Demo, den laaaang veien
        loadingCountries = true;
        countrylist = null;

        using (var request = new HttpRequestMessage(HttpMethod.Post, "api/Test/GetCountries"))
        {
            var json = JsonConvert.SerializeObject(reqdata);
            using (var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json"))
            {
                request.Content = stringContent;

                using (var response = await Http.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    response.EnsureSuccessStatusCode();
                    var jsonString = await response.Content.ReadAsStringAsync();
                    countrylist = JsonConvert.DeserializeObject<List<ResponseCountries>>(jsonString);
                }
            }
        }
        loadingCountries = false;
        
        Toaster.Add($"Antall land hentet: {countrylist.Count()}", MatToastType.Info, "Hentet noe data til deg");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

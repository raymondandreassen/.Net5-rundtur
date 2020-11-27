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
#line 3 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\Pages\Newuser.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/newuser")]
    public partial class Newuser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\Pages\Newuser.razor"
       
    AppUser appUser = new AppUser();
    bool loading = false;
    private EditContext editContext;
    
    protected override void OnInitialized()
    {
        editContext = new EditContext(appUser);
    }

    protected async Task RegisterNewUser(MouseEventArgs e)
    { 
        var isValid = editContext.Validate();
        if(!isValid) 
        {
            Toaster.Add("Vennligst rett opp feil i skjema.", MatToastType.Info, "Kan ikke sende inn");
            return;  
        }

        using (var request = new HttpRequestMessage(HttpMethod.Post, "api/User/NewUser"))
        {
            var json = JsonConvert.SerializeObject(appUser);
            using (var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json"))
            {
                request.Content = stringContent;

                using (var response = await Http.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    response.EnsureSuccessStatusCode();
                    var jsonString = await response.Content.ReadAsStringAsync();
                    int? usernumber = JsonConvert.DeserializeObject<int?>(jsonString);

                    if(!usernumber.HasValue)
                    {
                        Toaster.Add("Serverside feil.", MatToastType.Warning, "Et eller annet gikk galt");
                    }
                    else
                    {
                        Navigation.NavigateTo($"/edituser/{usernumber.Value}", false);
                    }
                }
            }
        }
    }     

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

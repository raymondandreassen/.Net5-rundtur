#pragma checksum "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\Pages\Authentication.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd62cc02026485888ddc4370c3712440a1e12d89"
// <auto-generated/>
#pragma warning disable 1591
namespace Demo3.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\_Imports.razor"
using Demo3.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\_Imports.razor"
using Demo3.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\Pages\Authentication.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authentication/{action}")]
    public partial class Authentication : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteAuthenticatorView>(0);
            __builder.AddAttribute(1, "Action", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\Pages\Authentication.razor"
                                  Action

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "LogInFailed", (Microsoft.AspNetCore.Components.RenderFragment<System.String>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "alert alert-danger");
                __builder2.AddAttribute(5, "role", "alert");
                __builder2.AddContent(6, 
#nullable restore
#line 8 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\Pages\Authentication.razor"
                                                      strLogInFailed

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(7, "LogOut", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "alert alert-info");
                __builder2.AddAttribute(10, "role", "alert");
                __builder2.AddContent(11, 
#nullable restore
#line 11 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\Pages\Authentication.razor"
                                                    strLogOut

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(12, "LogOutSucceeded", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "alert alert-success");
                __builder2.AddAttribute(15, "role", "alert");
                __builder2.AddContent(16, 
#nullable restore
#line 14 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\Pages\Authentication.razor"
                                                       strLogOutSucceeded

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(17, "LoggingIn", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "alert alert-info");
                __builder2.AddAttribute(20, "role", "alert");
                __builder2.AddContent(21, 
#nullable restore
#line 17 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\Pages\Authentication.razor"
                                                    strLoggingIn

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(22, "CompletingLoggingIn", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "alert alert-success");
                __builder2.AddAttribute(25, "role", "alert");
                __builder2.AddContent(26, 
#nullable restore
#line 20 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\Pages\Authentication.razor"
                                                       strCompletingLoggingIn

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\repos\.Net5-rundtur\src\Demo3\Demo3\Client\Pages\Authentication.razor"
       
    [Parameter] public string Action { get; set; }

    string strLogInFailed           = "Din pålogging var IKKE vellykket.";
    string strLogOut                = "Forsøker å lukke din sesjon mot UiT.";
    string strLogOutSucceeded       = "Din pålogget sesjon mot UiT har blitt avsluttet.";
    string strLoggingIn             = "Sender deg til UiT sin Office365 pålogging.";
    string strCompletingLoggingIn   = "Påloggingen til UiT var vellykket.";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

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
#line 2 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\Pages\Quiz.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/quiz/{quizid:int}")]
    public partial class Quiz : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\repos\.Net5-rundtur\src\Demo4\Demo4\Client\Pages\Quiz.razor"
       
    [Parameter]
    public int quizid { get; set; } = 1;

    protected Questionare questionare = null;

    protected async Task GetNextQuiz(MouseEventArgs e)
    {
        await LoadQuiz();
    }

    protected async Task LoadQuiz()
    {
        try
        {        
            //var response = await Http.GetFromJsonAsync<Questionare>($"/api/Question/GetQuestion?quizId={quizid}");

/*
            var resp = await Http.GetAsync($"/api/Question/GetQuestion?quizId={quizid}");
            resp.EnsureSuccessStatusCode();
            var jsonString = await resp.Content.ReadAsStringAsync();
            Console.WriteLine(jsonString);
*/

            //Questionare c = JsonConvert.DeserializeObject<Questionare>(jsonString);
            }
            catch(Exception exc)
            {
                
            }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

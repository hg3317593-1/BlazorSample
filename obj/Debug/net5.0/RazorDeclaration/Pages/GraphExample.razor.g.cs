// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorSample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Users\Administrator\source\repos\BlazorSample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\Administrator\source\repos\BlazorSample\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Users\Administrator\source\repos\BlazorSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Users\Administrator\source\repos\BlazorSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Users\Administrator\source\repos\BlazorSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Users\Administrator\source\repos\BlazorSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Users\Administrator\source\repos\BlazorSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Users\Administrator\source\repos\BlazorSample\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Users\Administrator\source\repos\BlazorSample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Users\Administrator\source\repos\BlazorSample\_Imports.razor"
using BlazorSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Users\Administrator\source\repos\BlazorSample\_Imports.razor"
using BlazorSample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\Administrator\source\repos\BlazorSample\Pages\GraphExample.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Users\Administrator\source\repos\BlazorSample\Pages\GraphExample.razor"
using Microsoft.Graph;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GraphExample")]
    public partial class GraphExample : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "E:\Users\Administrator\source\repos\BlazorSample\Pages\GraphExample.razor"
       
    private User user;

    protected async override Task OnInitializedAsync()
    {
        var request = GraphClient.Me.Request();
        user = await request.GetAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GraphServiceClient GraphClient { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Shared\AuthLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d46cb5353de88a6ca1858b7caa26866fd57edb8"
// <auto-generated/>
#pragma warning disable 1591
namespace ItvTicketsService.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using ItvTicketsService.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class AuthLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-primary");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "id", "layoutAuthentication");
            __builder.AddMarkupContent(4, @"<div id=""layoutAuthentication_header""><header class=""py-2 bg-light mt-auto""><div class=""container-fluid""><div class=""row""><div class=""logoDiv""><a class=""navbar-brand"" href=""/""><img src=""images/itv-logo.png"" alt=""logo"" style=""width: 196px;height: 40px;""></a></div>
                        <div class=""serviceCenterdiv""><div class=""input-group""><div class=""navbar-brand"">
                                    Service Center
                                </div></div></div></div></div></header></div>

        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "layoutAuthentication_content");
            __builder.OpenElement(7, "main");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row justify-content-center");
            __builder.AddContent(12, 
#nullable restore
#line 30 "G:\progetti\blazor\ItvTicketsService\ItvTicketsService\Client\Shared\AuthLayout.razor"
                         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        \n        ");
            __builder.AddMarkupContent(14, "<div id=\"layoutAuthentication_footer\"><footer class=\"py-4 bg-light mt-auto\"><div class=\"container-fluid\"><div class=\"d-flex align-items-center justify-content-between small\"><div class=\"text-muted\">Sync: online/offline</div></div></div></footer></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

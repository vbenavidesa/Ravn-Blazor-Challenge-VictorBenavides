#pragma checksum "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1f56f62224c80a8cb799a2b6e8d1ab527b1aeb5"
// <auto-generated/>
#pragma warning disable 1591
namespace RavnChallenge.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\_Imports.razor"
using RavnChallenge.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\_Imports.razor"
using RavnChallenge.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor"
using RavnChallenge.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor"
using RavnChallenge.Shared.Dtos;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata/{id}")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor"
 if (data == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "margin-left: 10%; margin-right: 10%");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr style=\"padding-top: 32px\"><th style=\"color: #121212; font-size: 16px; width: 85%\">General Information</th>\r\n                    <th></th></tr></thead>\r\n            ");
            __builder.OpenElement(6, "tbody");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "<td style=\"color: #828282; font-size: 16px\">Eye Color</td>\r\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddAttribute(10, "style", "color: #333333; font-size: 16px");
            __builder.AddContent(11, 
#nullable restore
#line 23 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor"
                                                                 data.Eye_color

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "<td style=\"color: #828282; font-size: 16px\">Hair Color</td>\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddAttribute(16, "style", "color: #333333; font-size: 16px");
            __builder.AddContent(17, 
#nullable restore
#line 27 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor"
                                                                 data.Hair_color

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "<td style=\"color: #828282; font-size: 16px\">Skin Color</td>\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddAttribute(22, "style", "color: #333333; font-size: 16px");
            __builder.AddContent(23, 
#nullable restore
#line 31 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor"
                                                                 data.Skin_color

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "<td style=\"color: #828282; font-size: 16px\">Birth Year</td>\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "style", "color: #333333; font-size: 16px");
            __builder.AddContent(29, 
#nullable restore
#line 35 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor"
                                                                 data.Birth_year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        <br>\r\n        <br>\r\n        ");
            __builder.OpenElement(31, "table");
            __builder.AddAttribute(32, "class", "table");
            __builder.AddMarkupContent(33, "<thead><tr style=\"padding-top: 32px\"><th style=\"color: #121212; font-size: 16px\"><strong>Vehicles</strong></th></tr></thead>\r\n            ");
            __builder.OpenElement(34, "tbody");
#nullable restore
#line 48 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor"
                 foreach (string item in data.Vehicles)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "tr");
            __builder.OpenElement(36, "td");
            __builder.AddAttribute(37, "style", "color: #828282; font-size: 16px");
            __builder.AddContent(38, 
#nullable restore
#line 51 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor"
                                                                     item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "D:\Software\RAVN\RavnChallenge\RavnChallenge\Client\Pages\FetchData.razor"
       
    private PersonDto data;

    [Parameter]
    public string Id { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        data = await Http.GetFromJsonAsync<PersonDto>("people/" + Id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\NavMenu.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "516d76437360a2866329807edeb98e6ba7814f453ac5cd276d5029e2f59b6c78"
// <auto-generated/>
#pragma warning disable 1591
namespace MudBlazorTemplates1.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\_Imports.razor"
using MudBlazorTemplates1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\_Imports.razor"
using MudBlazorTemplates1.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(2);
                __builder2.AddAttribute(3, "Href", (object)(""));
                __builder2.AddAttribute(4, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 2 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\NavMenu.razor"
                               NavLinkMatch.All

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(5, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 2 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\NavMenu.razor"
                                                        Icons.Material.Filled.Home

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(7, "Home");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n    ");
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(9);
                __builder2.AddAttribute(10, "Href", (object)("counter"));
                __builder2.AddAttribute(11, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 3 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\NavMenu.razor"
                                      NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(12, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 3 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\NavMenu.razor"
                                                                  Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(13, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(14, "Counter");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n    ");
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(16);
                __builder2.AddAttribute(17, "Href", (object)("fetchdata"));
                __builder2.AddAttribute(18, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 4 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\NavMenu.razor"
                                        NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(19, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 4 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\NavMenu.razor"
                                                                    Icons.Material.Filled.List

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(20, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(21, "Fetch data");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
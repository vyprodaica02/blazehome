#pragma checksum "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "48d83f667d09ee4615eb81846c86b677a3ac0a6ab24c1e8a3b0dc73f1892561b"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<global::MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<global::MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n\n    ");
            __builder.OpenComponent<global::MudBlazor.MudAppBar>(6);
            __builder.AddAttribute(7, "Elevation", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 7 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
                          0

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudIconButton>(9);
                __builder2.AddAttribute(10, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 8 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 8 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(12, "Edge", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Edge>(
#nullable restore
#line 8 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(13, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
                                                                                                             (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                ))));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudSpacer>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudIconButton>(17);
                __builder2.AddAttribute(18, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 10 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
                              Icons.Custom.Brands.MudBlazor

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(19, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 10 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
                                                                    Color.Inherit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(20, "Link", (object)("https://mudblazor.com/"));
                __builder2.AddAttribute(21, "Target", (object)("_blank"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudIconButton>(23);
                __builder2.AddAttribute(24, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 11 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
                              Icons.Custom.Brands.GitHub

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(25, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 11 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(26, "Link", (object)("https://github.com/MudBlazor/MudBlazor/"));
                __builder2.AddAttribute(27, "Target", (object)("_blank"));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n  \n");
            __builder.OpenComponent<global::MudBlazor.MudLayout>(29);
            __builder.AddAttribute(30, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudDrawer>(31);
                __builder2.AddAttribute(32, "Elevation", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 15 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
                                                   1

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(33, "Style", (object)("top: 64px"));
                __builder2.AddAttribute(34, "Open", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 15 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
                           _drawerOpen

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(35, "OpenChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen)))));
                __builder2.AddAttribute(36, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudDrawerHeader>(37);
                    __builder3.AddAttribute(38, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudText>(39);
                        __builder4.AddAttribute(40, "Typo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 17 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(41, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(42, "MudBlazorTemplates1");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n        ");
                    __builder3.OpenComponent<global::MudBlazorTemplates1.Shared.NavMenu>(44);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\n    ");
                __builder2.OpenComponent<global::MudBlazor.MudMainContent>(46);
                __builder2.AddAttribute(47, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudContainer>(48);
                    __builder3.AddAttribute(49, "MaxWidth", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.MaxWidth>(
#nullable restore
#line 22 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
                                MaxWidth.Large

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(50, "Class", (object)("my-16 pt-16"));
                    __builder3.AddAttribute(51, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (23,14)-(23,18) 26 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
__builder4.AddContent(52, Body);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Duc\Desktop\MudBlazorTemplates1\MudBlazorTemplates1\Shared\MainLayout.razor"
       
    bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

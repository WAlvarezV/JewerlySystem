#pragma checksum "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ee2d0a716ffda69a01a423c1489397107f4fddb"
// <auto-generated/>
#pragma warning disable 1591
namespace Pomona.Pwa.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Pomona.Pwa.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Pomona.Pwa.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 2 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "PreferExactMatches", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\App.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(6);
                    __builder3.AddAttribute(7, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 4 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
#nullable restore
#line 6 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\App.razor"
                     if (!context.User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<Pomona.Pwa.Client.Shared.RedirectToLogin>(10);
                        __builder4.CloseComponent();
#nullable restore
#line 9 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\App.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(11, "<p>You are not authorized to access this resource.</p>");
#nullable restore
#line 13 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\App.razor"
                    }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(12, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(13);
                    __builder3.AddAttribute(14, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 18 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(16, "<p>Sorry, there\'s nothing at this address.</p>");
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
    }
}
#pragma warning restore 1591

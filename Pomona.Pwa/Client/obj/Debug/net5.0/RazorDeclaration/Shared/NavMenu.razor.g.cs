// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Pomona.Pwa.Client.Shared
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
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Pomona.Pwa.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Pomona.Pwa.Client.Pages.Contract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Pomona.Pwa.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Pomona.Pwa.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Pomona.Protos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Pomona.Protos.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Pomona.Protos.Contract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Pomona.Protos.Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using Pomona.Pwa.Client.Custom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "F:\Proyectos\Joyeria\repo\Pomona\Pomona.Pwa\Client\Shared\NavMenu.razor"
       
    private bool exSubInventory;
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

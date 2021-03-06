// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ShopLapTop.Server.Pages.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using ShopLapTop.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using ShopLapTop.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using ShopLapTop.Server.Pages.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using ShopLapTop.Shared.Request;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using ShopLapTop.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using ShopLapTop.Shared.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/NhaCungCap")]
    public partial class NhaCC_Component : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\NhaCC_Component.razor"
       
    NhaCCRequest Request = new NhaCCRequest();
    List<NhaCungCap> listNhaCCs = new List<NhaCungCap>();

    async Task addNCCAsync()
    {
        var result = await productService.AddNhaCC(Request);
        if (result.IsSuccess)
        {
            ShowNotification(new NotificationMessage() { Severity = NotificationSeverity.Success, Summary = "Them Thanh Cong", Duration = 4000 });
            Request = new NhaCCRequest();
            await OnInitializedAsync();
        }
        else
        {
            ShowNotification(new NotificationMessage() { Severity = NotificationSeverity.Error, Summary = "Them Khong Thanh Cong", Duration = 4000 });
        }
    }
    async Task GetNhaCCsAsync()
    {
        var result = await productService.GetNhaCC();
        if (result.IsSuccess)
        {
            listNhaCCs = result.NhaCungCaps;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        await GetNhaCCsAsync();
    }

    //Show Thong Bao
    void ShowNotification(NotificationMessage message)
    {
        notificationService.Notify(message);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService notificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductService productService { get; set; }
    }
}
#pragma warning restore 1591

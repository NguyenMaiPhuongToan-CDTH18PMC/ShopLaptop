#pragma checksum "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31435ab0fa78841a867bf1e23a66fa551786aca0"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/KhuyenMai")]
    public partial class KhuyenMai_Component : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Them Nha Cung Cap</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddAttribute(3, "style", "justify-content:center;margin-bottom:5px");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-6");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                         Request

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                 async () => await addKhuyenMaiAsync()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(13);
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(18);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n                ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "radzen-row");
                    __builder3.AddMarkupContent(22, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "class", "radzen-lable");
                    __builder3.AddAttribute(25, "Text", "Ten Khuyen Mai");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(27);
                    __builder3.AddAttribute(28, "Placeholder", "Ten Nha Cung Cap");
                    __builder3.AddAttribute(29, "class", "radzen-textbox");
                    __builder3.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                Request.TenKM

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Request.TenKM = __value, Request.TenKM))));
                    __builder3.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Request.TenKM));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n                ");
                    __builder3.OpenElement(35, "div");
                    __builder3.AddAttribute(36, "class", "radzen-row");
                    __builder3.AddMarkupContent(37, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(38);
                    __builder3.AddAttribute(39, "class", "radzen-lable");
                    __builder3.AddAttribute(40, "Text", "Loai Khuyen Mai");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n                    ");
                    __Blazor.ShopLapTop.Server.Pages.Product.KhuyenMai_Component.TypeInference.CreateRadzenNumeric_0(__builder3, 42, 43, "Dia Chi", 44, "radzen-textbox", 45, 
#nullable restore
#line 19 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                Request.LoaiKM

#line default
#line hidden
#nullable disable
                    , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Request.LoaiKM = __value, Request.LoaiKM)), 47, () => Request.LoaiKM);
                    __builder3.AddMarkupContent(48, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\r\n                ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "radzen-row");
                    __builder3.AddMarkupContent(52, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(53);
                    __builder3.AddAttribute(54, "class", "radzen-lable");
                    __builder3.AddAttribute(55, "Text", "Mo Ta");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextArea>(57);
                    __builder3.AddAttribute(58, "class", "radzen-textarea");
                    __builder3.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                 Request.MoTa

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Request.MoTa = __value, Request.MoTa))));
                    __builder3.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Request.MoTa));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\r\n                ");
                    __builder3.OpenElement(64, "div");
                    __builder3.AddAttribute(65, "class", "radzen-row");
                    __builder3.AddMarkupContent(66, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(67);
                    __builder3.AddAttribute(68, "class", "radzen-lable");
                    __builder3.AddAttribute(69, "Text", "Ngay Bat Dau");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\r\n                    ");
                    __Blazor.ShopLapTop.Server.Pages.Product.KhuyenMai_Component.TypeInference.CreateRadzenDatePicker_1(__builder3, 71, 72, "d", 73, 
#nullable restore
#line 27 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                   Request.NgayBD

#line default
#line hidden
#nullable disable
                    , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Request.NgayBD = __value, Request.NgayBD)), 75, () => Request.NgayBD);
                    __builder3.AddMarkupContent(76, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\r\n                ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "class", "radzen-row");
                    __builder3.AddMarkupContent(80, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(81);
                    __builder3.AddAttribute(82, "class", "radzen-lable");
                    __builder3.AddAttribute(83, "Text", "Ngay Ket Thuc");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\r\n                    ");
                    __Blazor.ShopLapTop.Server.Pages.Product.KhuyenMai_Component.TypeInference.CreateRadzenDatePicker_2(__builder3, 85, 86, "d", 87, 
#nullable restore
#line 31 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                   Request.NgayKT

#line default
#line hidden
#nullable disable
                    , 88, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Request.NgayKT = __value, Request.NgayKT)), 89, () => Request.NgayKT);
                    __builder3.AddMarkupContent(90, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\r\n                ");
                    __builder3.OpenElement(92, "div");
                    __builder3.AddAttribute(93, "class", "row justify-content-center");
                    __builder3.AddMarkupContent(94, "\r\n                    ");
                    __builder3.OpenElement(95, "div");
                    __builder3.AddAttribute(96, "class", "col-md-12 d-flex align-items-end justify-content-center");
                    __builder3.AddAttribute(97, "style", "margin-top: 16px;");
                    __builder3.AddMarkupContent(98, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(99);
                    __builder3.AddAttribute(100, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 35 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                  Radzen.ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(101, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 35 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                                                         Radzen.ButtonStyle.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(102, "class", "radzen-button");
                    __builder3.AddAttribute(103, "Icon", "save");
                    __builder3.AddAttribute(104, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(106);
                    __builder3.AddAttribute(107, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 36 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                  Radzen.ButtonType.Button

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(108, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 36 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                                                         Radzen.ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(109, "class", "radzen-button");
                    __builder3.AddAttribute(110, "Icon", "delete");
                    __builder3.AddAttribute(111, "Text", "Delete");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(112, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(114, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(116, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<KhuyenMai>>(119);
            __builder.AddAttribute(120, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 44 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                               4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(123, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<KhuyenMai>>(
#nullable restore
#line 44 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                                                             listKhuyenMais

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(125, "ColumnWidth", "200px");
            __builder.AddAttribute(126, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
                                                                                                                                                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(127, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(128, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<KhuyenMai>>(129);
                __builder2.AddAttribute(130, "Property", "TenKM");
                __builder2.AddAttribute(131, "Title", "Ten Khuyen Mai");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(132, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<KhuyenMai>>(133);
                __builder2.AddAttribute(134, "Property", "LoaiKM");
                __builder2.AddAttribute(135, "Title", "Phan Tram Khuyen Mai");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(136, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<KhuyenMai>>(137);
                __builder2.AddAttribute(138, "Property", "NgayBD");
                __builder2.AddAttribute(139, "Title", "Ngay Bat Dau");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(140, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<KhuyenMai>>(141);
                __builder2.AddAttribute(142, "Property", "NgayKT");
                __builder2.AddAttribute(143, "Title", "Ngay Ket Thuc");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(144, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\KhuyenMai_Component.razor"
       
    KhuyenMaiRequest Request = new KhuyenMaiRequest();
    List<KhuyenMai> listKhuyenMais = new List<KhuyenMai>();

    async Task addKhuyenMaiAsync()
    {
        var result = await productService.AddKhuyenMai(Request);
        if (result.IsSuccess)
        {
            ShowNotification(new NotificationMessage() { Severity = NotificationSeverity.Success, Summary = "Them Thanh Cong", Duration = 4000 });
            Request = new KhuyenMaiRequest();
            await OnInitializedAsync();
        }
        else
        {
            ShowNotification(new NotificationMessage() { Severity = NotificationSeverity.Error, Summary = "Them Khong Thanh Cong", Duration = 4000 });
        }
    }
    async Task GetKhuyenMaisAsync()
    {
        var result = await productService.GetKhuyenMais();
        if (result.IsSuccess)
        {
            listKhuyenMais = result.KhuyenMais;
        }
    }


    protected override async Task OnInitializedAsync()
    {
        await GetKhuyenMaisAsync();
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
namespace __Blazor.ShopLapTop.Server.Pages.Product.KhuyenMai_Component
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

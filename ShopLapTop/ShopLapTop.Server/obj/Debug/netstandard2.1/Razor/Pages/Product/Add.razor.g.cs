#pragma checksum "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65515d86d1b157f6d8a5e4f3e2fbac0878d32cce"
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
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\_Imports.razor"
using ShopLapTop.Server.Pages.Auth;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/Add")]
    public partial class Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add New Product</h3>\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-6");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "radzen-row");
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(13);
                __builder2.AddAttribute(14, "class", "radzen-lable");
                __builder2.AddAttribute(15, "Text", "Ten San Pham");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(17);
                __builder2.AddAttribute(18, "Placeholder", "Ten San Pham");
                __builder2.AddAttribute(19, "class", "radzen-textbox");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "radzen-row");
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(25);
                __builder2.AddAttribute(26, "class", "radzen-lable");
                __builder2.AddAttribute(27, "Text", "Loai San Pham");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(29);
                __builder2.AddAttribute(30, "Placeholder", "Loai San Pham");
                __builder2.AddAttribute(31, "class", "radzen-textbox");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "radzen-row");
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(37);
                __builder2.AddAttribute(38, "class", "radzen-lable");
                __builder2.AddAttribute(39, "Text", "Chi Tiet San Pham");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextArea>(41);
                __builder2.AddAttribute(42, "class", "radzen-textarea");
                __builder2.AddAttribute(43, "Style", "height:110px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "radzen-row");
                __builder2.AddMarkupContent(48, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(49);
                __builder2.AddAttribute(50, "class", "radzen-lable");
                __builder2.AddAttribute(51, "Text", "Mo Ta San Pham");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextArea>(53);
                __builder2.AddAttribute(54, "class", "radzen-textarea");
                __builder2.AddAttribute(55, "Style", "height:110px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-6");
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "radzen-row");
                __builder2.AddMarkupContent(64, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(65);
                __builder2.AddAttribute(66, "class", "radzen-lable");
                __builder2.AddAttribute(67, "Text", "Nha Cung Cap");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(69);
                __builder2.AddAttribute(70, "Placeholder", "Nha Cung Cap");
                __builder2.AddAttribute(71, "class", "radzen-textbox");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "radzen-row");
                __builder2.AddMarkupContent(76, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(77);
                __builder2.AddAttribute(78, "class", "radzen-lable");
                __builder2.AddAttribute(79, "Text", "Khuyen Mai");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(81);
                __builder2.AddAttribute(82, "Placeholder", "Khuyen Mai");
                __builder2.AddAttribute(83, "class", "radzen-textbox");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n\r\n            ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "radzen-row");
                __builder2.AddMarkupContent(88, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(89);
                __builder2.AddAttribute(90, "class", "radzen-lable");
                __builder2.AddAttribute(91, "Text", "Thuong Hieu");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(93);
                __builder2.AddAttribute(94, "Placeholder", "Thuong Hieu");
                __builder2.AddAttribute(95, "class", "radzen-textbox");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n\r\n            ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "radzen-row");
                __builder2.AddMarkupContent(100, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(101);
                __builder2.AddAttribute(102, "class", "radzen-lable");
                __builder2.AddAttribute(103, "Text", "Don Gia");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(105);
                __builder2.AddAttribute(106, "class", "radzen-textbox");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n            ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "radzen-row");
                __builder2.AddMarkupContent(111, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(112);
                __builder2.AddAttribute(113, "class", "radzen-lable");
                __builder2.AddAttribute(114, "Text", "So Luong");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n                ");
                __Blazor.ShopLapTop.Server.Pages.Product.Add.TypeInference.CreateRadzenNumeric_0(__builder2, 116, 117, 
#nullable restore
#line 44 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                            Amount

#line default
#line hidden
#nullable disable
                , 118, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Amount = __value, Amount)), 119, () => Amount);
                __builder2.AddMarkupContent(120, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n            ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "radzen-row");
                __builder2.AddMarkupContent(124, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(125);
                __builder2.AddAttribute(126, "class", "radzen-lable");
                __builder2.AddAttribute(127, "Text", "Ngay Tao");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n                ");
                __Blazor.ShopLapTop.Server.Pages.Product.Add.TypeInference.CreateRadzenDatePicker_1(__builder2, 129, 130, "d", 131, 
#nullable restore
#line 48 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                                Date

#line default
#line hidden
#nullable disable
                , 132, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Date = __value, Date)), 133, () => Date);
                __builder2.AddMarkupContent(134, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n            ");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "radzen-row");
                __builder2.AddMarkupContent(138, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(139);
                __builder2.AddAttribute(140, "class", "radzen-lable");
                __builder2.AddAttribute(141, "Text", "Ngay Sua");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(142, "\r\n                ");
                __Blazor.ShopLapTop.Server.Pages.Product.Add.TypeInference.CreateRadzenDatePicker_2(__builder2, 143, 144, "d", 145, 
#nullable restore
#line 52 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                                Date

#line default
#line hidden
#nullable disable
                , 146, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Date = __value, Date)), 147, () => Date);
                __builder2.AddMarkupContent(148, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n            ");
                __builder2.OpenElement(150, "div");
                __builder2.AddAttribute(151, "class", "radzen-row");
                __builder2.AddMarkupContent(152, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenUpload>(153);
                __builder2.AddAttribute(154, "Auto", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                    false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(155, "Multiple", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(156, "Url", "upload/multiple");
                __builder2.AddAttribute(157, "Style", "margin-bottom: 20px;");
                __builder2.AddAttribute(158, "ChooseText", "Hinh Anh");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(159, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n    ");
                __builder2.OpenElement(163, "div");
                __builder2.AddAttribute(164, "class", "row justify-content-center");
                __builder2.AddMarkupContent(165, "\r\n        ");
                __builder2.OpenElement(166, "div");
                __builder2.AddAttribute(167, "class", "col-md-12 d-flex align-items-end justify-content-center");
                __builder2.AddAttribute(168, "style", "margin-top: 16px;");
                __builder2.AddMarkupContent(169, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(170);
                __builder2.AddAttribute(171, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 61 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                      Radzen.ButtonType.Button

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(172, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 61 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                                                             Radzen.ButtonStyle.Success

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(173, "class", "radzen-button");
                __builder2.AddAttribute(174, "Icon", "save");
                __builder2.AddAttribute(175, "Text", "Save");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(176, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(177);
                __builder2.AddAttribute(178, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 62 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                      Radzen.ButtonType.Button

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(179, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 62 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                                                             Radzen.ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(180, "class", "radzen-button");
                __builder2.AddAttribute(181, "Icon", "delete");
                __builder2.AddAttribute(182, "Text", "Delete");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(183, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(184, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(185, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(186, "\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<Employee>>(187);
            __builder.AddAttribute(188, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 67 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(189, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 67 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(190, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 67 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                                               4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(191, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 67 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(192, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Employee>>(
#nullable restore
#line 67 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                                                                             employees

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(193, "ColumnWidth", "200px");
            __builder.AddAttribute(194, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 67 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
                                                                                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(195, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(196, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Employee>>(197);
                __builder2.AddAttribute(198, "Property", "TenSP");
                __builder2.AddAttribute(199, "Title", "Ten San Pham");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(200, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Employee>>(201);
                __builder2.AddAttribute(202, "Property", "LoaiSP");
                __builder2.AddAttribute(203, "Title", "Loai San Pham");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(204, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Employee>>(205);
                __builder2.AddAttribute(206, "Property", "DonGia");
                __builder2.AddAttribute(207, "Title", "Don Gia");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(208, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Employee>>(209);
                __builder2.AddAttribute(210, "Property", "DonGia");
                __builder2.AddAttribute(211, "Title", "Thuong Hieu");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(212, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "E:\Github\ShopLaptop\ShopLapTop\ShopLapTop.Server\Pages\Product\Add.razor"
       
    int Amount;
    DateTime Date = new DateTime();
    IEnumerable<Employee> employees;
    protected override void OnInitialized()
    {
        Date = DateTime.Now;
        base.OnInitialized();
    }
    public class Employee
    {
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public int DonGia { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ShopLapTop.Server.Pages.Product.Add
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
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

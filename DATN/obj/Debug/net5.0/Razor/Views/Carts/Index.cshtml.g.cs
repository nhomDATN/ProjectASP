#pragma checksum "D:\Study\DATN\Project\DATN\DATN\Views\Carts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91253f10c4be700dc2db9a4077ce49b9142d4325"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carts_Index), @"mvc.1.0.view", @"/Views/Carts/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Study\DATN\Project\DATN\DATN\Views\_ViewImports.cshtml"
using DATN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\DATN\Project\DATN\DATN\Views\_ViewImports.cshtml"
using DATN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91253f10c4be700dc2db9a4077ce49b9142d4325", @"/Views/Carts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9537ef48c69d90f04cb6e7793df4de3640a38013", @"/Views/_ViewImports.cshtml")]
    public class Views_Carts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""hero-wrap hero-bread"" style=""background-image: url('images/banner-1.jpg');"">
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <h1 class=""mb-0 bread"">Giỏ Hàng Của Tôi</h1>
            </div>
        </div>
    </div>
</div>

<section class=""ftco-section ftco-cart"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 ftco-animate"">
                <div class=""cart-list"">
                    <table class=""table"">
                        <thead class=""thead-primary"">
                            <tr class=""text-center"">
                                <th>&nbsp;</th>
                                <th>&nbsp;</th>
                                <th>Tên sản phẩm</th>
                                <th>Gía</th>
                                <th>Số lượng</th>
                                <th>Tổng<");
            WriteLiteral(@"/th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr class=""text-center"">
                                <td class=""product-remove""><a href=""#""><span class=""ion-ios-close""></span></a></td>

                                <td class=""image-prod""><div class=""img"" style=""background-image:url(images/hamburger.jpg);""></div></td>

                                <td class=""product-name"">
                                    <h3>Hamburger</h3>
                                    <p>Món ăn nhanh Hamburger là một loại thức ăn bao gồm bánh mì kẹp thịt xay (thường là thịt bò) ở giữa.</p>
                                </td>

                                <td class=""price"">$4.90</td>

                                <td class=""quantity"">
                                    <div class=""input-group mb-3"">
                                        <input type=""text"" name=""quantity"" class=""quantity form-control input-number""");
            WriteLiteral(@" value=""1"" min=""1"" max=""100"">
                                    </div>
                                </td>

                                <td class=""total"">$14.00</td>
                            </tr><!-- END TR-->

                            <tr class=""text-center"">
                                <td class=""product-remove""><a href=""#""><span class=""ion-ios-close""></span></a></td>

                                <td class=""image-prod""><div class=""img"" style=""background-image:url(images/6.jpg);""></div></td>

                                <td class=""product-name"">
                                    <h3>Gà Rán</h3>
                                    <p>Món ăn nhanh Gà Rán là một món ăn xuất xứ từ miền Nam Hoa Kỳ; nguyên liệu chính là những miếng thịt gà đã được lăn bột rồi chiên trên chảo, chiên ngập dầu, chiên áp suất hoặc chiên chân không.</p>
                                </td>

                                <td class=""price"">$15.00</td>

                                <td");
            WriteLiteral(@" class=""quantity"">
                                    <div class=""input-group mb-3"">
                                        <input type=""text"" name=""quantity"" class=""quantity form-control input-number"" value=""1"" min=""1"" max=""100"">
                                    </div>
                                </td>

                                <td class=""total"">$15.70</td>
                            </tr><!-- END TR-->
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""row justify-content-end"">
            <div class=""col-lg-4 mt-5 cart-wrap ftco-animate"">
                <div class=""cart-total mb-3"">
                    <h3>Mã Giảm Giá</h3>
                    <p>Nhập vào đây mã giảm giá nếu có</p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91253f10c4be700dc2db9a4077ce49b9142d43257932", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label");
                BeginWriteAttribute("for", " for=\"", 4025, "\"", 4031, 0);
                EndWriteAttribute();
                WriteLiteral(">Mã giảm giá</label>\r\n                            <input type=\"text\" class=\"form-control text-left px-3\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4136, "\"", 4150, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <p><a href=""checkout.html"" class=""btn btn-primary py-3 px-4"">Áp dụng phiếu giảm giá</a></p>
            </div>
            <div class=""col-lg-4 mt-5 cart-wrap ftco-animate"">
                <div class=""cart-total mb-3"">
                    <h3>Ước tính phí vận chuyển và thuế</h3>
                    <p>Nhập điểm đến của bạn để nhận ước tính vận chuyển</p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91253f10c4be700dc2db9a4077ce49b9142d432510333", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label for=\"country\">Quận/Huyện</label>\r\n                            <input type=\"text\" class=\"form-control text-left px-3\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4872, "\"", 4886, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <p><a href=""checkout.html"" class=""btn btn-primary py-3 px-4"">Ước tính</a></p>
            </div>
            <div class=""col-lg-4 mt-5 cart-wrap ftco-animate"">
                <div class=""cart-total mb-3"">
                    <h3>Tổng tiền giỏ hàng</h3>
                    <p class=""d-flex"">
                        <span>Tổng phụ</span>
                        <span>$29.00</span>
                    </p>
                    <p class=""d-flex"">
                        <span>Vận chuyển</span>
                        <span>$0.00</span>
                    </p>
                    <p class=""d-flex"">
                        <span>Hạ giá</span>
                        <span>$0.00</span>
                    </p>
                    <hr>
                    <p class=""d-flex total-price"">
                        <span>Tổng tiền</span>
                        <span>$29.00</span>
                    </p>
                </div>
                <p><a href=""ch");
            WriteLiteral("eckout.html\" class=\"btn btn-primary py-3 px-4\">Tiến hành kiểm tra</a></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

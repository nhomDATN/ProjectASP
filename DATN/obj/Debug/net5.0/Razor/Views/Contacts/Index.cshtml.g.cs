#pragma checksum "D:\Le_Vinh_Tan\Project ASP\ProjectASP\DATN\Views\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f046a57a85c048bfedcb0d3fb9257a3230e48890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Index), @"mvc.1.0.view", @"/Views/Contacts/Index.cshtml")]
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
#line 1 "D:\Le_Vinh_Tan\Project ASP\ProjectASP\DATN\Views\_ViewImports.cshtml"
using DATN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Le_Vinh_Tan\Project ASP\ProjectASP\DATN\Views\_ViewImports.cshtml"
using DATN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f046a57a85c048bfedcb0d3fb9257a3230e48890", @"/Views/Contacts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9537ef48c69d90f04cb6e7793df4de3640a38013", @"/Views/_ViewImports.cshtml")]
    public class Views_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-white p-5 contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""hero-wrap hero-bread"" style=""background-image: url('images/banhmi.jpg');"">
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">

                <h1 class=""mb-0 bread"">Liên Hệ Chúng Tôi</h1>
            </div>
        </div>
    </div>
</div>

<section class=""ftco-section contact-section bg-light"">
    <div class=""container"">
        <div class=""row d-flex mb-5 contact-info"">
            <div class=""w-100""></div>
            <div class=""col-md-3 d-flex"">
                <div class=""info bg-white p-4"">
                    <p><span>Địa Chỉ:</span> 65 Huỳnh Thúc Kháng, Bến Nghé, Quận 1, TP.HCM</p>
                </div>
            </div>
            <div class=""col-md-3 d-flex"">
                <div class=""info bg-white p-4"">
                    <p><span>SĐT:</span> <a href=""tel://6667514982"">+ 666 751 4982</a></p>
                </div>
            ");
            WriteLiteral(@"</div>
            <div class=""col-md-3 d-flex"">
                <div class=""info bg-white p-4"">
                    <p><span>Email:</span> <a href=""mailto:ckc_fastfood@caothang.edu.vn"">ckc_fastfood@caothang.edu.vn</a></p>
                </div>
            </div>
            <div class=""col-md-3 d-flex"">
                <div class=""info bg-white p-4"">
                    <p><span>Website</span> <a href=""#"">ckcfastfoods.com</a></p>
                </div>
            </div>
        </div>
        <div class=""row block-9"">
            <div class=""col-md-6 order-md-last d-flex"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f046a57a85c048bfedcb0d3fb9257a3230e488905605", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Tên đầy đủ"">
                    </div>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Email"">
                    </div>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Chủ đề"">
                    </div>
                    <div class=""form-group"">
                        <textarea");
                BeginWriteAttribute("name", " name=\"", 2255, "\"", 2262, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2263, "\"", 2268, 0);
                EndWriteAttribute();
                WriteLiteral(@" cols=""30"" rows=""7"" class=""form-control"" placeholder=""Nội dung""></textarea>
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" value=""Gửi"" class=""btn btn-primary py-3 px-5"">
                    </div>
                ");
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
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"col-md-6 d-flex\">\r\n                <div id=\"map\" class=\"bg-white\"></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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

#pragma checksum "D:\Soner Hoca\20 Eylül\AlGulumVerGulum\AlGulumVerGulum.Web.MVC.UI\Views\Shared\Components\FeatureNotices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c1b351dce778f286e0ae4b60fb5966dead472c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FeatureNotices), @"mvc.1.0.view", @"/Views/Shared/Components/FeatureNotices.cshtml")]
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
#line 2 "D:\Soner Hoca\20 Eylül\AlGulumVerGulum\AlGulumVerGulum.Web.MVC.UI\Views\_ViewImports.cshtml"
using AlGulumVerGulum.DTO.UserDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c1b351dce778f286e0ae4b60fb5966dead472c1", @"/Views/Shared/Components/FeatureNotices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bdcfb58e1089a10bbc31ea30cd2aa1d77e737c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FeatureNotices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/telefon.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""hot-jobs-area hot-jobs-area-two pb-100"" id=""feature-notices"">
    <div class=""container"">
        <div class=""section-title green-title"">
            <span>Sıcak Takaslar</span>
            <h2>Önerilen İlanlar</h2>
        </div>
        <ul class=""shorting-menu"">
            <li class=""filter"" data-filter=""all"">
                Sana yakın ilanlar
            </li>
            <li class=""filter"" data-filter="".part-time"">
                En çok teklif alanlar
            </li>
            <li class=""filter"" data-filter="".part-time"">
                En yeni ilanlar
            </li>
            <li class=""filter"" data-filter=""all"">
                Öne çıkan ilanlar
            </li>
        </ul>
        <div class=""shorting"">
            <div class=""row"">
");
#nullable restore
#line 23 "D:\Soner Hoca\20 Eylül\AlGulumVerGulum\AlGulumVerGulum.Web.MVC.UI\Views\Shared\Components\FeatureNotices.cshtml"
                 for (int i = 0; i < 10; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-12 col-md-6 mix part-time"">
                        <div class=""hot-jobs-list"">
                            <div class=""row align-items-center"">
                                <div class=""col-lg-2"">
                                    <a href=""job-details.html""");
            BeginWriteAttribute("class", " class=\"", 1147, "\"", 1155, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c1b351dce778f286e0ae4b60fb5966dead472c15687", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </a>
                                </div>
                                <div class=""col-lg-4"">
                                    <div class=""hot-jobs-content"">
                                        <h3><a href=""job-details.html"">Elektronik</a></h3>
                                        <span class=""sub-title"">Nokia 7610 Cep Telefonu</span>
                                        <ul>
                                            <li><span>İlan Sahibi:</span> H... T... (8.8 TP)</li>
                                            <li><span>Teklifler: </span>3</li>
                                        </ul>
                                    </div>
                                </div>
                                <div class=""col-lg-3"">
                                    <ul class=""deadline"">
                                        <li>
                                            <i class=""bx bx-location-plus""></i>
                                            Çan");
            WriteLiteral(@"kaya/Ankara
                                        </li>
                                        <li>
                                            <i class=""bx bx-calendar""></i>
                                            İlan Tarihi: 3 Eylül 2021
                                        </li>
                                    </ul>
                                </div>
                                <div class=""col-lg-3"">
                                    <div class=""hot-jobs-btn"">
                                        <a href=""/ilan-detayi"" class=""default-btn btn-two"">Detayları gör</a>
                                    </div>
                                </div>
                            </div>
                            <span class=""featured"">TP - 8.8/10</span>
                        </div>
                    </div>
");
#nullable restore
#line 64 "D:\Soner Hoca\20 Eylül\AlGulumVerGulum\AlGulumVerGulum.Web.MVC.UI\Views\Shared\Components\FeatureNotices.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 text-center mt-2\">\n                    <a href=\"#\" class=\"default-btn btn-two\">Daha fazla gör</a>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>");
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

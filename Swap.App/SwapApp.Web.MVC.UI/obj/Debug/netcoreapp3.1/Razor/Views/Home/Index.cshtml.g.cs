#pragma checksum "D:\Soner Hoca\20 Eylül\AlGulumVerGulum\AlGulumVerGulum.Web.MVC.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "093adf3e794e802d79fe74a85e857097f64f497d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"093adf3e794e802d79fe74a85e857097f64f497d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bdcfb58e1089a10bbc31ea30cd2aa1d77e737c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Soner Hoca\20 Eylül\AlGulumVerGulum\AlGulumVerGulum.Web.MVC.UI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Soner Hoca\20 Eylül\AlGulumVerGulum\AlGulumVerGulum.Web.MVC.UI\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("HomeBanner"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""working-area working-area-two pt-100 pb-70"">
    <div class=""container"">
        <div class=""section-title green-title"">
            <span>Takasım Geldi</span>
            <h2>Nasıl Çalışır?</h2>
        </div>
        <div class=""row"">
            <div class=""col-lg-3 col-sm-6"">
                <div class=""single-working"">
                    <i class=""flaticon-tick""></i>
                    <h3>Bir İlan Yayınla</h3>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate sint tempore.</p>
                </div>
            </div>
            <div class=""col-lg-3 col-sm-6"">
                <div class=""single-working"">
                    <i class=""flaticon-find-my-friend""></i>
                    <h3>Aradığın İlanı Bul</h3>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate sint tempore.</p>
                </div>
            </div>

            <div class=""col-lg-3 col-sm-6"">
                <");
            WriteLiteral(@"div class=""single-working"">
                    <i class=""flaticon-salary""></i>
                    <h3>Takas Teklifi Gönder</h3>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate sint tempore.</p>
                </div>
            </div>
            <div class=""col-lg-3 col-sm-6"">
                <div class=""single-working"">
                    <i class=""flaticon-submit""></i>
                    <h3>Takası Tamamla</h3>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate sint tempore.</p>
                </div>
            </div>
        </div>
    </div>
</section>

");
#nullable restore
#line 49 "D:\Soner Hoca\20 Eylül\AlGulumVerGulum\AlGulumVerGulum.Web.MVC.UI\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("HomeCategories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 51 "D:\Soner Hoca\20 Eylül\AlGulumVerGulum\AlGulumVerGulum.Web.MVC.UI\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("FeatureNotices"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"copy-right-area copy-right-area-two\">\r\n    <div class=\"container\">\r\n        <p>\r\n            © ");
#nullable restore
#line 57 "D:\Soner Hoca\20 Eylül\AlGulumVerGulum\AlGulumVerGulum.Web.MVC.UI\Views\Home\Index.cshtml"
         Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TakasEt Is Proudly Created By
            <a href=""../../../envytheme.com/index.html"" target=""_blank"">Yazılım 129</a>
        </p>
    </div>
</div>


<div class=""go-top go-top-two"">
    <i class=""bx bx-chevrons-up""></i>
    <i class=""bx bx-chevrons-up""></i>
</div>");
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

#pragma checksum "F:\Project\visual studio\Company\CompanyWebSite\Views\Shared\_Head.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ce423781dee985f2a323ebbf70fcb26c01c1a09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Head), @"mvc.1.0.view", @"/Views/Shared/_Head.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Head.cshtml", typeof(AspNetCore.Views_Shared__Head))]
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
#line 1 "F:\Project\visual studio\Company\CompanyWebSite\Views\_ViewImports.cshtml"
using CompanyWebSite;

#line default
#line hidden
#line 2 "F:\Project\visual studio\Company\CompanyWebSite\Views\_ViewImports.cshtml"
using CompanyWebSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ce423781dee985f2a323ebbf70fcb26c01c1a09", @"/Views/Shared/_Head.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1839c5f6b7f417587e69343b145b75d08b3d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Head : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Project\visual studio\Company\CompanyWebSite\Views\Shared\_Head.cshtml"
  
    ViewData["Title"] = "Head";
    Layout = null;

#line default
#line hidden
            BeginContext(75, 85, true);
            WriteLiteral("\r\n<!-- 公共头部导航 start -->\r\n<section class=\"public-header\">\r\n    <a class=\"hd-logo-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 160, "\"", 194, 1);
#line 9 "F:\Project\visual studio\Company\CompanyWebSite\Views\Shared\_Head.cshtml"
WriteAttributeValue("", 167, Url.Action("Index","Home"), 167, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(195, 262, true);
            WriteLiteral(@">
        <img class=""hd-logo-img"" src=""/images/public/logo.png"" alt="""" id=""logo"">
    </a>
    <div class=""hd-r"">
        <div class=""hd-nav"">
            <ul class=""nav-list"">
                <li class=""nav-item"">
                    <a class=""nav-link""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 457, "\"", 491, 1);
#line 16 "F:\Project\visual studio\Company\CompanyWebSite\Views\Shared\_Head.cshtml"
WriteAttributeValue("", 464, Url.Action("Index","Home"), 464, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(492, 264, true);
            WriteLiteral(@">首页</a>
                </li>
                <li class=""nav-item"">
                    <div class=""nav-link"" href=""javascript:;"">网站建设</div>
                    <ul class=""subitems"">
                        <li class=""subitem"">
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 756, "\"", 800, 1);
#line 22 "F:\Project\visual studio\Company\CompanyWebSite\Views\Shared\_Head.cshtml"
WriteAttributeValue("", 763, Url.Action("Classic","WebSiteBuild"), 763, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(801, 140, true);
            WriteLiteral(" class=\"subitem-link\">经典型网站</a>\r\n                        </li>\r\n                        <li class=\"subitem\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 941, "\"", 987, 1);
#line 25 "F:\Project\visual studio\Company\CompanyWebSite\Views\Shared\_Head.cshtml"
WriteAttributeValue("", 948, Url.Action("Marketing","WebSiteBuild"), 948, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(988, 140, true);
            WriteLiteral(" class=\"subitem-link\">营销型网站</a>\r\n                        </li>\r\n                        <li class=\"subitem\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1128, "\"", 1177, 1);
#line 28 "F:\Project\visual studio\Company\CompanyWebSite\Views\Shared\_Head.cshtml"
WriteAttributeValue("", 1135, Url.Action("ResponseType","WebSiteBuild"), 1135, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1178, 140, true);
            WriteLiteral(" class=\"subitem-link\">响应式网站</a>\r\n                        </li>\r\n                        <li class=\"subitem\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1318, "\"", 1361, 1);
#line 31 "F:\Project\visual studio\Company\CompanyWebSite\Views\Shared\_Head.cshtml"
WriteAttributeValue("", 1325, Url.Action("DirSir","WebSiteBuild"), 1325, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1362, 140, true);
            WriteLiteral(" class=\"subitem-link\">电商型网站</a>\r\n                        </li>\r\n                        <li class=\"subitem\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1502, "\"", 1544, 1);
#line 34 "F:\Project\visual studio\Company\CompanyWebSite\Views\Shared\_Head.cshtml"
WriteAttributeValue("", 1509, Url.Action("Dress","WebSiteBuild"), 1509, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1545, 192, true);
            WriteLiteral(" class=\"subitem-link\">外贸型网站</a>\r\n                        </li>\r\n                    </ul>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1737, "\"", 1772, 1);
#line 39 "F:\Project\visual studio\Company\CompanyWebSite\Views\Shared\_Head.cshtml"
WriteAttributeValue("", 1744, Url.Action("Index","Offer"), 1744, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1773, 112, true);
            WriteLiteral(">建站报价</a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1885, "\"", 1919, 1);
#line 42 "F:\Project\visual studio\Company\CompanyWebSite\Views\Shared\_Head.cshtml"
WriteAttributeValue("", 1892, Url.Action("Index","Case"), 1892, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1920, 112, true);
            WriteLiteral(">客户案例</a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2032, "\"", 2069, 1);
#line 45 "F:\Project\visual studio\Company\CompanyWebSite\Views\Shared\_Head.cshtml"
WriteAttributeValue("", 2039, Url.Action("Index","NetWork"), 2039, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2070, 112, true);
            WriteLiteral(">全国网点</a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2182, "\"", 2217, 1);
#line 48 "F:\Project\visual studio\Company\CompanyWebSite\Views\Shared\_Head.cshtml"
WriteAttributeValue("", 2189, Url.Action("Index","About"), 2189, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2218, 374, true);
            WriteLiteral(@">关于我们</a>
                </li>
            </ul>
        </div>

        <div class=""hd-tel"">
            <div class=""tel-title"">售前咨询</div>
            <div class=""tel-num"">
                <p class=""tel-num-t"">400-660-8066</p>
                <p class=""tel-num-b"">400-660-5555转1</p>
            </div>
        </div>
    </div>
</section>
<!-- 公共头部导航 end -->");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591

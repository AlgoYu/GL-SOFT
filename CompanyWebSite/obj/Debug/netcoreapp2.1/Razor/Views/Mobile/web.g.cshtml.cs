#pragma checksum "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c5fc6fda45c4a8c1a07537006607b66b727087e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mobile_web), @"mvc.1.0.view", @"/Views/Mobile/web.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mobile/web.cshtml", typeof(AspNetCore.Views_Mobile_web))]
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
#line 1 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\_ViewImports.cshtml"
using CompanyWebSite;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\_ViewImports.cshtml"
using CompanyWebSite.Models;

#line default
#line hidden
#line 1 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
using Newtonsoft.Json.Serialization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c5fc6fda45c4a8c1a07537006607b66b727087e", @"/Views/Mobile/web.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1839c5f6b7f417587e69343b145b75d08b3d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Mobile_web : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
  
    Layout = null;
    var serializerSettings = new JsonSerializerSettings
    {
        // 设置为驼峰命名
        ContractResolver = new CamelCasePropertyNamesContractResolver()
    };
    var dataStr = JsonConvert.SerializeObject(Model, Formatting.None, serializerSettings);

#line default
#line hidden
            BeginContext(361, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(398, 428, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f880d9114d5649bbbbe84b49b88c6b00", async() => {
                BeginContext(404, 415, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>经典型网站 - 格莱软件</title>
    <link rel=""stylesheet"" href=""/css/common.css"">
    <link rel=""stylesheet"" href=""/css/mobile.css"">
    <link href=""/layui/css/layui.css"" rel=""stylesheet"" />
    <link href=""/css/cooper.css"" rel=""stylesheet"" />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(826, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(830, 12257, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "697347211173400bb539f455998425e9", async() => {
                BeginContext(836, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(839, 23, false);
#line 28 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
Write(Html.Partial("_Cooper"));

#line default
#line hidden
                EndContext();
                BeginContext(862, 93, true);
                WriteLiteral("\r\n<!-- 公共头部导航 start -->\r\n    <section class=\"public-header\">\r\n        <a class=\"hd-logo-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 955, "\"", 989, 1);
#line 31 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
WriteAttributeValue("", 962, Url.Action("Index","Home"), 962, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(990, 284, true);
                WriteLiteral(@">
            <img class=""hd-logo-img"" src=""/images/public/logo.png"" alt="""">
        </a>
        <div class=""hd-r"">
            <div class=""hd-nav"">
                <ul class=""nav-list"">
                    <li class=""nav-item cur"">
                        <a class=""nav-link""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1274, "\"", 1308, 1);
#line 38 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
WriteAttributeValue("", 1281, Url.Action("Index","Home"), 1281, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1309, 288, true);
                WriteLiteral(@">首页</a>
                    </li>
                    <li class=""nav-item"">
                        <div class=""nav-link"" href=""javascript:;"">网站建设</div>
                        <ul class=""subitems"">
                            <li class=""subitem"">
                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1597, "\"", 1641, 1);
#line 44 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
WriteAttributeValue("", 1604, Url.Action("Classic","WebSiteBuild"), 1604, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1642, 152, true);
                WriteLiteral(" class=\"subitem-link\">经典型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1794, "\"", 1840, 1);
#line 47 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
WriteAttributeValue("", 1801, Url.Action("Marketing","WebSiteBuild"), 1801, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1841, 152, true);
                WriteLiteral(" class=\"subitem-link\">营销型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1993, "\"", 2042, 1);
#line 50 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
WriteAttributeValue("", 2000, Url.Action("ResponseType","WebSiteBuild"), 2000, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2043, 152, true);
                WriteLiteral(" class=\"subitem-link\">响应式网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2195, "\"", 2238, 1);
#line 53 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
WriteAttributeValue("", 2202, Url.Action("DirSir","WebSiteBuild"), 2202, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2239, 152, true);
                WriteLiteral(" class=\"subitem-link\">电商型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2391, "\"", 2433, 1);
#line 56 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
WriteAttributeValue("", 2398, Url.Action("Dress","WebSiteBuild"), 2398, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2434, 212, true);
                WriteLiteral(" class=\"subitem-link\">外贸型网站</a>\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2646, "\"", 2681, 1);
#line 61 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
WriteAttributeValue("", 2653, Url.Action("Index","Offer"), 2653, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2682, 124, true);
                WriteLiteral(">建站报价</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2806, "\"", 2840, 1);
#line 64 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
WriteAttributeValue("", 2813, Url.Action("Index","Case"), 2813, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2841, 124, true);
                WriteLiteral(">客户案例</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2965, "\"", 3002, 1);
#line 67 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
WriteAttributeValue("", 2972, Url.Action("Index","NetWork"), 2972, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3003, 124, true);
                WriteLiteral(">全国网点</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3127, "\"", 3162, 1);
#line 70 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
WriteAttributeValue("", 3134, Url.Action("Index","About"), 3134, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3163, 8179, true);
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
    <!-- 公共头部导航 end -->
    <!-- 主体内容 start -->
    <section class=""mobile-web"">
        <!-- banner广告 start -->
        <section class=""p-banner"">
            <div class=""banner-con"">
                <h3 class=""banner-tit"">手机网站 - 把您的网站，装在客户的兜兜里</h3>
                <p class=""banner-desc"">方便操作，便捷管理，极致触屏体验、让客户随时随地联系你</p>
                <div class=""banner-btn"">
                    <a href="""" target=""_blank"">在线咨询</a>
                </div>
            </div>
        </section>
        <!-- banner广告 end -->
        <section class=""items"">
            <ul class=""block-1 public-center list"">
           ");
                WriteLiteral(@"     <li class=""item"">
                    <img src=""/images/mobile/web/shouji-show-1-1.png"" alt=""img"">
                    <p>搜索优化，抢占移动端排名</p>
                </li>
                <li class=""item"">
                    <img src=""/images/mobile/web/shouji-show-1-2.png"" alt=""img"">
                    <p>搜索优化，抢占移动端排名</p>
                </li>
                <li class=""item"">
                    <img src=""/images/mobile/web/shouji-show-1-3.png"" alt=""img"">
                    <p>搜索优化，抢占移动端排名</p>
                </li>
                <li class=""item"">
                    <img src=""/images/mobile/web/shouji-show-1-4.png"" alt=""img"">
                    <p>搜索优化，抢占移动端排名</p>
                </li>
                <li class=""item"">
                    <img src=""/images/mobile/web/shouji-show-1-5.png"" alt=""img"">
                    <p>搜索优化，抢占移动端排名</p>
                </li>
            </ul>
        </section>
        <section class=""items"">
            <h3 class=""items-title"">提供专属手机客户端与客户零距离接触</h3>");
                WriteLiteral(@"
            <ul class=""block-2 public-center list"">
                <li class=""item"">
                    <img class=""item-img"" src=""/images/mobile/web/shouji-show-2-1.png"" alt=""img"">
                    <div class=""item-tit"">搜索优化，抢占移动端排名</div>
                    <p class=""item-p"">Zmobile可以在用户手机桌面生成企业图标</p>
                    <p class=""item-p"">一点就能进入到企业客户端</p>
                </li>
                <li class=""item"">
                    <img class=""item-img"" src=""/images/mobile/web/shouji-show-2-2.png"" alt=""img"">
                    <div class=""item-tit"">定制化欢迎页 强化企业品牌</div>
                    <p class=""item-p"">Zmobile为您提供量身定制的展示欢迎页</p>
                    <p class=""item-p"">大图展示提升品牌形象</p>
                </li>
                <li class=""item"">
                    <img class=""item-img"" src=""/images/mobile/web/shouji-show-2-3.png"" alt=""img"">
                    <div class=""item-tit"">地图定位 引导客户入店</div>
                    <p class=""item-p"">地图模块可调用GPS功能进行线路规划</p>
                    <p class=""it");
                WriteLiteral(@"em-p"">快速找到您的企业位置</p>
                </li>
            </ul>
        </section>
        <section class=""items"">
            <ul class=""block-3 public-center list"">
                <li class=""item"">
                    <div class=""img-box"">
                        <img src=""/images/mobile/web/shouji-show-3-1.png"">
                        <img src=""/images/mobile/web/shouji-show-3-1-hover.png"">
                    </div>
                    <p>二维码后台下载</p>
                </li>
                <li class=""item"">
                    <div class=""img-box"">
                        <img src=""/images/mobile/web/shouji-show-3-2.png"">
                        <img src=""/images/mobile/web/shouji-show-3-2-hover.png"">
                    </div>
                    <p>短信后台发布</p>
                </li>
                <li class=""item"">
                    <div class=""img-box"">
                        <img src=""/images/mobile/web/shouji-show-3-3.png"">
                        <img src=""/images/mobile/web/sh");
                WriteLiteral(@"ouji-show-3-3-hover.png"">
                    </div>
                    <p>一键留言</p>
                </li>
                <li class=""item"">
                    <div class=""img-box"">
                        <img src=""/images/mobile/web/shouji-show-3-4.png"">
                        <img src=""/images/mobile/web/shouji-show-3-4-hover.png"">
                    </div>
                    <p>一键询价</p>
                </li>
                <li class=""item"">
                    <div class=""img-box"">
                        <img src=""/images/mobile/web/shouji-show-3-5.png"">
                        <img src=""/images/mobile/web/shouji-show-3-5-hover.png"">
                    </div>
                    <p>一键分享</p>
                </li>
                <li class=""item"">
                    <div class=""img-box"">
                        <img src=""/images/mobile/web/shouji-show-3-6.png"">
                        <img src=""/images/mobile/web/shouji-show-3-6-hover.png"">
                    </div>
         ");
                WriteLiteral(@"           <p>一键地图</p>
                </li>
                <li class=""item"">
                    <div class=""img-box"">
                        <img src=""/images/mobile/web/shouji-show-3-7.png"">
                        <img src=""/images/mobile/web/shouji-show-3-7-hover.png"">
                    </div>
                    <p>一键拨打</p>
                </li>
            </ul>
        </section>
        <section class=""items bgimg"">
            <h3 class=""items-title"">成功案例</h3>
            <ul class=""block-4 public-center list"">
                <li class=""item"">
                    <a href="""">
                        <img src=""/images/mobile/web/case-1.jpg"" alt=""img"">
                    </a>
                </li>
                <li class=""item"">
                    <a href="""">
                        <img src=""/images/mobile/web/case-2.jpg"" alt=""img"">
                    </a>
                </li>
                <li class=""item"">
                    <a href="""">
                       ");
                WriteLiteral(@" <img src=""/images/mobile/web/case-3.jpg"" alt=""img"">
                    </a>
                </li>
                <li class=""item"">
                    <a href="""">
                        <img src=""/images/mobile/web/case-4.jpg"" alt=""img"">
                    </a>
                </li>
            </ul>
        </section>
        <section class=""items"">
            <ul class=""block-5 public-center list"">
                <li class=""item"">
                    <img class=""item-img"" src=""http://s.300.cn/v2.0/home/images/special/shouji/shouji-show-4-1.png"" alt=""img"">
                    <div class=""item-tit"">安全</div>
                    <p class=""item-p"">病毒杀除率高于99%</p>
                </li>
                <li class=""item"">
                    <img class=""item-img"" src=""http://s.300.cn/v2.0/home/images/special/shouji/shouji-show-4-1.png"" alt=""img"">
                    <div class=""item-tit"">稳定</div>
                    <p class=""item-p"">网站可用性高于99.9%%</p>
                </li>
               ");
                WriteLiteral(@" <li class=""item"">
                    <img class=""item-img"" src=""http://s.300.cn/v2.0/home/images/special/shouji/shouji-show-4-1.png"" alt=""img"">
                    <div class=""item-tit"">极速</div>
                    <p class=""item-p"">5倍赔付中断服务的时间</p>
                </li>
                <li class=""item"">
                    <img class=""item-img"" src=""http://s.300.cn/v2.0/home/images/special/shouji/shouji-show-4-1.png"" alt=""img"">
                    <div class=""item-tit"">周到</div>
                    <p class=""item-p"">覆盖70多个城市，近80家服务网络</p>
                </li>
                <li class=""item"">
                    <img class=""item-img"" src=""http://s.300.cn/v2.0/home/images/special/shouji/shouji-show-4-1.png"" alt=""img"">
                    <div class=""item-tit"">贴心</div>
                    <p class=""item-p"">全国7x24小时客服热线</p>
                </li>
            </ul>
        </section>
    </section>
    <!-- 主体内容 end -->
    <!-- 公共 - 更多服务 start -->
    <!-- 公共 - 更多服务 end -->
    ");
                EndContext();
                BeginContext(11343, 21, false);
#line 256 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
Write(Html.Partial("_Help"));

#line default
#line hidden
                EndContext();
                BeginContext(11364, 31, true);
                WriteLiteral("\r\n    <!-- 公共底部 start -->\r\n    ");
                EndContext();
                BeginContext(11396, 23, false);
#line 258 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
Write(Html.Partial("_Bottom"));

#line default
#line hidden
                EndContext();
                BeginContext(11419, 361, true);
                WriteLiteral(@"
    <!-- 公共底部 end -->

<script src=""/assets/jquery1.11.2.js""></script>
<script src=""https://cdn.bootcss.com/jquery-cookie/1.4.1/jquery.cookie.js""></script>
    <script src=""/js/public.js""></script>
<script src=""https://cdn.bootcss.com/vue/2.5.18-beta.0/vue.min.js""></script>
<script src=""/layui/layui.js""></script>
<script>
    var data = JSON.parse('");
                EndContext();
                BeginContext(11781, 17, false);
#line 267 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
                      Write(Html.Raw(dataStr));

#line default
#line hidden
                EndContext();
                BeginContext(11798, 900, true);
                WriteLiteral(@"');
    layui.use(['form','jquery','layer'], function () {
        var form = layui.form;
        var $ = layui.$;
        var layer = layui.layer;

        $(""#cooper"").on(""click"", function(data) {
            $(""#app"").css(""display"", ""block"");
            $(""#app"").css(""animation"", ""cooperation-animation 1.2s"");
        });

        var app = new Vue({
            el: '#app',
            data: {
                titles: data
            },
            mounted: function() {
                form.render();
            }
        });

        form.on(""submit(commit)"", function (data) {
            var details = $("":checked"");
            var detail = """";
            for (var i = 0; i < details.length; i++) {
                detail += details[i].value + "" | "";
            }
            data.field.detail = detail;
            console.log(data);
            $.post('");
                EndContext();
                BeginContext(12699, 32, false);
#line 296 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Views\Mobile\web.cshtml"
               Write(Url.Action("AddCooper","Cooper"));

#line default
#line hidden
                EndContext();
                BeginContext(12731, 349, true);
                WriteLiteral(@"', data.field, function(data,status) {
                if (data.data == 1) {
                    layer.msg(""提交成功！请等待我们联系您！"");
                    $('#app').css('display', 'none');
                } else {
                    layer.msg(""提交失败！"");
                }
            });

            return false;
        });
    });
</script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13087, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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

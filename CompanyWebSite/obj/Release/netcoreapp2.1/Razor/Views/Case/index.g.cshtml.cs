#pragma checksum "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb50b6b3923e0928c9ad612579d54b72328250ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Case_index), @"mvc.1.0.view", @"/Views/Case/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Case/index.cshtml", typeof(AspNetCore.Views_Case_index))]
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
#line 1 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 2 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
using Newtonsoft.Json.Serialization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb50b6b3923e0928c9ad612579d54b72328250ce", @"/Views/Case/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e1839c5f6b7f417587e69343b145b75d08b3d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Case_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
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
#line 4 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
  
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
            BeginContext(398, 357, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ec728e0616c477993c85f5c56e26264", async() => {
                BeginContext(404, 344, true);
                WriteLiteral(@"
    <meta name=""keywords"" content=""xiaoyu"" />
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>客户案例 - 格莱软件</title>
    <link rel=""stylesheet"" href=""css/common.css"">
    <link rel=""stylesheet"" href=""css/case.css"">
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
            BeginContext(755, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(759, 12065, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959073e85bc94346a90778c93d6521f2", async() => {
                BeginContext(765, 97, true);
                WriteLiteral("\r\n    <!-- 公共头部导航 start -->\r\n    <section class=\"public-header\">\r\n        <a class=\"hd-logo-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 862, "\"", 896, 1);
#line 29 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 869, Url.Action("Index","Home"), 869, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(897, 290, true);
                WriteLiteral(@">
            <img class=""hd-logo-img"" src=""/images/public/logo.png"" alt="""" id=""logo"">
        </a>
        <div class=""hd-r"">
            <div class=""hd-nav"">
                <ul class=""nav-list"">
                    <li class=""nav-item"">
                        <a class=""nav-link""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1187, "\"", 1221, 1);
#line 36 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 1194, Url.Action("Index","Home"), 1194, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1222, 288, true);
                WriteLiteral(@">首页</a>
                    </li>
                    <li class=""nav-item"">
                        <div class=""nav-link"" href=""javascript:;"">网站建设</div>
                        <ul class=""subitems"">
                            <li class=""subitem"">
                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1510, "\"", 1554, 1);
#line 42 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 1517, Url.Action("Classic","WebSiteBuild"), 1517, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1555, 152, true);
                WriteLiteral(" class=\"subitem-link\">经典型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1707, "\"", 1753, 1);
#line 45 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 1714, Url.Action("Marketing","WebSiteBuild"), 1714, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1754, 152, true);
                WriteLiteral(" class=\"subitem-link\">营销型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1906, "\"", 1955, 1);
#line 48 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 1913, Url.Action("ResponseType","WebSiteBuild"), 1913, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1956, 152, true);
                WriteLiteral(" class=\"subitem-link\">响应式网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2108, "\"", 2151, 1);
#line 51 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 2115, Url.Action("DirSir","WebSiteBuild"), 2115, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2152, 152, true);
                WriteLiteral(" class=\"subitem-link\">电商型网站</a>\r\n                            </li>\r\n                            <li class=\"subitem\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2304, "\"", 2346, 1);
#line 54 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 2311, Url.Action("Dress","WebSiteBuild"), 2311, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2347, 212, true);
                WriteLiteral(" class=\"subitem-link\">外贸型网站</a>\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2559, "\"", 2594, 1);
#line 59 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 2566, Url.Action("Index","Offer"), 2566, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2595, 128, true);
                WriteLiteral(">建站报价</a>\r\n                    </li>\r\n                    <li class=\"nav-item cur\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2723, "\"", 2757, 1);
#line 62 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 2730, Url.Action("Index","Case"), 2730, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2758, 124, true);
                WriteLiteral(">客户案例</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2882, "\"", 2919, 1);
#line 65 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 2889, Url.Action("Index","NetWork"), 2889, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2920, 124, true);
                WriteLiteral(">全国网点</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3044, "\"", 3079, 1);
#line 68 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 3051, Url.Action("Index","About"), 3051, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3080, 3631, true);
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
    <div id=""app"">
        <section class=""case-main"">
            <!-- banner start -->
            <section class=""main-banner"">
                <div class=""img-box"">
                    <img src=""/images/case/case-banner.png"" alt="""">
                </div>
                <div class=""banner-contetn"">
                    <div class=""banner-wrap"">
                        <h2 class=""banner-tit"">精品案例</h2>
                        <p class=""banner-p"">行业，风格，功能，产品……您只管选，我们负责呈现！</p>
                    </div>
                </div>
            </section>
  ");
                WriteLiteral(@"          <!-- banner end -->
            <!--筛选项 start-->
            <section>
                <div class=""top-nav public-center"">
                    <div class=""nav-item"">
                        <div class=""item-label"">行业分类：</div>
                        <ul class=""list current type"">
                            <li class=""item"" v-on:click=""industryid = null,getData()"" v-bind:class=""{ cur: industryid==null }"">不限</li>
                            <li class=""item"" v-for=""item in industries"" v-on:click=""industryid = item.id,getData()"" v-bind:class=""{ cur: industryid==item.id }"">{{item.name}}</li>
                        </ul>
                        <div class=""slider-up"">展开</div>
                    </div>
                    <div class=""line""></div>
                    <div class=""nav-item"">
                        <div class=""item-label"">颜色：</div>
                        <ul class=""list bgcolor"">
                            <li class=""item"" v-bind:class=""{ cur: colorid==null }"" v-on:click=");
                WriteLiteral(@"""colorid = null,getData()""></li>
                            <li class=""item"" v-for=""item in colors"" v-bind:title=""item.name"" v-on:click=""colorid = item.id,getData()"" v-bind:class=""{ cur: item.id==colorid }""></li>
                        </ul>
                    </div>
                    <div class=""nav-item"">
                        <div class=""item-label"">产品分类：</div>
                        <ul class=""list"">
                            <li class=""item"" v-bind:class=""{ cur: productid==null }"" v-on:click=""productid = null,getData()"">不限</li>
                            <li class=""item"" v-for=""item in products"" v-on:click=""productid = item.id,getData()"" v-bind:class=""{ cur: item.id==productid }"">{{item.name}}</li>
                        </ul>
                    </div>
                    <div class=""nav-item"">
                        <div class=""item-label"">客户端：</div>
                        <ul class=""list"">
                            <li class=""item"" v-bind:class=""{ cur: clientid==null }"" v");
                WriteLiteral(@"-on:click=""clientid = null,getData()"">不限</li>
                            <li class=""item"" v-for=""item in clients"" v-on:click=""clientid = item.id,getData()"" v-bind:class=""{ cur: item.id==clientid }"">{{item.name}}</li>
                        </ul>
                    </div>
                </div>
            </section>
            <!--筛选项 end-->
            <!--案例列表 start-->
            <section>
                <ul class=""public-list public-center"">
                    <li class=""public-item"" v-for=""item in cases"">
                        <a");
                EndContext();
                BeginWriteAttribute(":href", " :href=\"", 6711, "\"", 6765, 3);
                WriteAttributeValue("", 6719, "\'", 6719, 1, true);
#line 139 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
WriteAttributeValue("", 6720, Url.Action("CaseDetail","Case"), 6720, 32, false);

#line default
#line hidden
                WriteAttributeValue("", 6752, "?id=\'+item.id", 6752, 13, true);
                EndWriteAttribute();
                BeginContext(6766, 1239, true);
                WriteLiteral(@" target=""_blank"">
                            <div class=""img-box"">
                                <img :src=""item.cover"" alt=""深圳市超跃食品有限公司"">
                            </div>
                            <div class=""item-desc"">
                                <p class=""item-tit"">{{item.name}}</p>
                                <p class=""item-type"">食品餐饮</p>
                            </div>
                        </a>
                    </li>
                </ul>
            </section>
            <!--案例列表 end-->
            <!--分页 start-->
            <section>
                <div class=""pagination public-center"">
                    <a class=""first"" href="""" v-on:click=""page=1"">首页</a>
                    <a class=""prev"" href="""" v-if=""paging>1 && page-1>0"">上一页</a>
                    <a class=""num"" href="""" v-for=""item in paging"" v-bind:class=""{ active: page==item }"">{{item}}</a>
                    <a class=""next"" href="""" v-if=""paging>1 && page+1<=paging"">下一页</a>
                    ");
                WriteLiteral("<a class=\"end\" href=\"\" v-on:click=\"page=paging\">尾页</a>\r\n                </div>\r\n            </section>\r\n            <!--分页 end-->\r\n        </section>\r\n    </div>\r\n    <!-- 主体内容 end -->\r\n    <!-- 公共底部 start -->\r\n    ");
                EndContext();
                BeginContext(8006, 23, false);
#line 167 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
Write(Html.Partial("_Bottom"));

#line default
#line hidden
                EndContext();
                BeginContext(8029, 414, true);
                WriteLiteral(@"
    <!-- 公共底部 end -->

    <script src=""assets/jquery1.11.2.js""></script>
    <script src=""https://cdn.bootcss.com/jquery-cookie/1.4.1/jquery.cookie.js""></script>
    <script src=""js/public.js""></script>
    <script src=""https://cdn.bootcss.com/vue/2.5.17/vue.min.js""></script>
    <script src=""https://cdn.bootcss.com/axios/0.18.0/axios.min.js""></script>
    <script>
         var dataDto = JSON.parse('");
                EndContext();
                BeginContext(8444, 17, false);
#line 176 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
                              Write(Html.Raw(dataStr));

#line default
#line hidden
                EndContext();
                BeginContext(8461, 2721, true);
                WriteLiteral(@"');
            //修改系统信息
            $(""#logo"").attr(""src"", dataDto.systemInfo.logoUrl); //修改Logo
            $(""#logo"").css(""width"", ""150px"");   //修改尺寸
            $(""#copyright"").text(dataDto.systemInfo.copyright); //修改版权
            $(""#record"").text(dataDto.systemInfo.record);   //修改备案
            $(""#weChatQR"").attr(""src"", dataDto.systemInfo.weChatQR);   //修改二维码
            $(""#weChatQR"").css(""width"", ""130px"");   //修改二维码尺寸
            document.title = dataDto.systemInfo.siteTitle; //修改标题
            document.getElementsByTagName(""meta"")[0].content = dataDto.systemInfo.keyWords;   //修改网站关键字

        //Vue
        var app = new Vue({
            el: '#app',
            data: {
                industries: null,
                colors: null,
                products: null,
                clients: null,
                cases: null,
                industryid: null,
                colorid: null,
                productid: null,
                clientid: null,
                case: nul");
                WriteLiteral(@"l,
                paging: 0,
                page: 1,
                limit: 10
            },
            mounted: function () {
                this.initStyle();
                this.initData();
            },
            methods: {
                initStyle: function () {
                    // 展开效果
                    (function () {
                        var bool = true;
                        $('.slider-up').click(function () {
                            $(this).toggleClass('current');
                            if (bool) {
                                bool = false;
                                var list = $('.list.type');
                                if (list.hasClass('current')) {
                                    list.animate({
                                        height: '87px',
                                    }, function () {
                                        bool = true;
                                    }).removeClass('current');

          ");
                WriteLiteral(@"                          $(this).html('收起');
                                } else {
                                    list.animate({
                                        height: ""29px"",
                                    }, function () {
                                        bool = true;
                                    }).addClass('current')
                                    $(this).html('展开');
                                }
                            }
                        })
                    })()
                },
                initData: function () {
                    var that = this;
                    axios.get('");
                EndContext();
                BeginContext(11183, 29, false);
#line 241 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
                          Write(Url.Action("InitData","Case"));

#line default
#line hidden
                EndContext();
                BeginContext(11212, 894, true);
                WriteLiteral(@"')
                        .then(function (response) {
                            that.industries = response.data.data.industries;
                            that.colors = response.data.data.colors;
                            that.products = response.data.data.products;
                            that.clients = response.data.data.clients;
                            that.paging = response.data.total == 0 ? 0 : response.data.total <= response.data.limit ? 1 : Math.ceil(response.data.total / response.data.limit);
                            that.getData();
                        })
                        .catch(function (error) {
                            console.log(error);
                        });

                },
                getData: function () {
                    var that = this;
                    that.page = 1;
                    $.post('");
                EndContext();
                BeginContext(12107, 32, false);
#line 258 "F:\Project\visual studio\Company\CompanyWebSite\Views\Case\index.cshtml"
                       Write(Url.Action("SelectCases","Case"));

#line default
#line hidden
                EndContext();
                BeginContext(12139, 678, true);
                WriteLiteral(@"',
                        {
                            page: that.page,
                            limit: that.limit,
                            industryid: that.industryid,
                            colorid: that.colorid,
                            productid: that.productid,
                            clientid: that.clientid
                        }, function (data, status) {
                            that.cases = data.data;
                            that.paging = data.total == 0 ? 0 : data.total <= data.limit ? 1 : Math.ceil(data.total / data.limit);
                        });
                }
            }
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
            BeginContext(12824, 11, true);
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

#pragma checksum "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e74b803f377b7267b0ce5a01ef8dc40823176069"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ManagementSystem_Views_Login_Index), @"mvc.1.0.view", @"/Areas/ManagementSystem/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ManagementSystem/Views/Login/Index.cshtml", typeof(AspNetCore.Areas_ManagementSystem_Views_Login_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e74b803f377b7267b0ce5a01ef8dc40823176069", @"/Areas/ManagementSystem/Views/Login/Index.cshtml")]
    public class Areas_ManagementSystem_Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Login\Index.cshtml"
  
    Layout = null;
    var titleName = "科信达人力资源后台管理系统";

#line default
#line hidden
            BeginContext(81, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(108, 8288, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc8d14a770c34942937bf541c33df91d", async() => {
                BeginContext(114, 443, true);
                WriteLiteral(@"

    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""robots"" content=""noarchive"">
    <meta name=""Baiduspider"" content=""noarchive"">
    <meta name=""googlebot"" content=""noarchive"">
    <Meta http-equiv=""Page-Enter"" Content=""blendTrans(Duration=0.5)"">
    <Meta http-equiv=""Page-Exit"" Content=""blendTrans(Duration=0.5)"">
    <title>");
                EndContext();
                BeginContext(558, 9, false);
#line 18 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Login\Index.cshtml"
      Write(titleName);

#line default
#line hidden
                EndContext();
                BeginContext(567, 7629, true);
                WriteLiteral(@" - 贵州格莱软件科技有限公司</title>
    <link href=""https://cdn.bootcss.com/animate.css/3.7.0/animate.min.css"" rel=""stylesheet"">
    <style>
        img, object, embed, video {
            max-width: 100%;
        }
        /* IE 6 不支持最大宽度，因此默认为 100% 宽度 */
        .ie6 img {
            width: 100%;
        }
        /*定义滚动条高宽及背景 高宽分别对应横竖滚动条的尺寸*/
        ::-webkit-scrollbar {
            width: 5px;
            height: 16px;
            background-color: #5f98de;
        }

        /*定义滚动条轨道 内阴影+圆角*/
        ::-webkit-scrollbar-track {
            -webkit-box-shadow: inset 0 0 6px rgba(0,0,0,0.3);
            border-radius: 10px;
            background-color: #528dd6;
        }

        /*定义滑块 内阴影+圆角*/
        ::-webkit-scrollbar-thumb {
            border-radius: 10px;
            -webkit-box-shadow: inset 0 0 6px rgba(0,0,0,.3);
            background-color: #4582ce;
        }

        ul {
            list-style: none;
            margin: 0px;
            padding: 0px;
        }

 ");
                WriteLiteral(@"       a:link {
            text-decoration: none;
        }

        * {
            margin: 0px;
            padding: 0px;
            list-style: none;
            text-decoration: none;
        }

        html, body {
            font-size: 14px;
            text-decoration: none;
            background: #5f98de url(/images/login-bg.png) 50% 50% no-repeat;
            width: 100%;
            height: 100%;
        }

        input {
            outline: none;
            background: #fff;
        }

            input:-webkit-autofill, textarea:-webkit-autofill, select:-webkit-autofill {
                background-color: #fff;
                background-image: none;
                color: rgb(0, 0, 0);
            }

            input::before {
                background-color: #fff;
            }

        .ui-bgcolor-1 {
            background: #333a43;
        }

        .ui-bgcolor-2 {
            background: #5f98de;
        }

        .ui-bgcolor-3 {
        ");
                WriteLiteral(@"    background: #f2f3f5;
        }

        .ui-bgcolor-4 {
            background: #FFFFFF;
        }

        .ui-bgcolor-5 {
            color: #757575;
        }

        input {
            margin: 0px;
            padding: 0px;
            border: none;
            height: 35px;
            width: 91%;
            padding: 0 8px;
            marquee-style: scroll;
        }

        .ui-pannel {
            text-align: center;
            width: 100%;
            height: 100%;
            overflow: hidden;
            clear: both;
        }

        .ui-wrap {
            width: 400px;
            height: 260px;
            overflow: hidden;
            clear: both;
            background: #FFFFFF;
            opacity: .9;
            border-radius: 3px;
            -webkit-border-radius: 3px;
            -moz-border-radius: 3px;
            position: absolute;
            left: 50%;
            top: 50%;
            margin: -130px -200px;
        }

        ");
                WriteLiteral(@".ui-top {
            height: auto;
            width: auto;
            overflow: hidden;
            margin: 5px 15px;
            clear: both;
        }

            .ui-top > .left {
                width: 40px;
                height: auto;
                float: left;
            }

            .ui-top > .right {
                width: auto;
                height: auto;
                margin-left: 40px;
            }

                .ui-top > .right img {
                    width: 60px;
                    height: 60px;
                    overflow: hidden;
                    margin-top: 10px;
                }

        .ui-input {
            width: auto;
            height: auto;
            margin: 5px 20px;
            clear: both;
            overflow: hidden;
        }

            .ui-input > .left {
                width: 90px;
                float: left;
                overflow: hidden;
            }

                .ui-input > .left li {
      ");
                WriteLiteral(@"              height: 35px;
                    line-height: 35px;
                    color: #757575;
                    overflow: hidden;
                    text-align: right;
                }

            .ui-input > .right {
                width: auto;
                height: auto;
                overflow: hidden;
                margin-left: 100px;
            }

        .wrap {
            border: 1px #E6E6E6 solid;
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            -ms-border-radius: 5px;
            border-radius: 5px;
            width: auto;
            height: auto;
            overflow: hidden;
        }

        .ui-input > .right ul {
            margin: 0px;
            padding: 0px;
            width: auto;
        }

        .ui-input > .right li {
            height: 35px;
            line-height: 35px;
            color: #757575;
            overflow: hidden;
            border-bottom: 1px solid #E6E6E6;
       ");
                WriteLiteral(@" }

            .ui-input > .right li:last-child {
                border-bottom: none;
            }

        .ui-btn-item {
            width: auto;
            height: auto;
            text-align: center;
            margin: 20px 10px 10px 10px;
            clear: both;
            overflow: hidden;
        }

            .ui-btn-item a {
                display: inline-block;
                margin: 0 8px;
                -webkit-border-radius: 5px;
                -moz-border-radius: 5px;
                -ms-border-radius: 5px;
                border-radius: 5px;
                height: 29px;
                line-height: 29px;
                width: 90px;
                text-align: center;
            }

            .ui-btn-item .send_btn {
                background: #518ed8;
                color: #FFF;
            }

                .ui-btn-item .send_btn:hover {
                    background: #2d8cf0;
                    color: #FFF;
                }

       ");
                WriteLiteral(@"     .ui-btn-item .caned_btn {
                background: #d8d8d8;
                color: #000;
            }

        .ui-code {
            width: auto;
            clear: left;
            overflow: hidden;
        }

            .ui-code .c-left {
                width: 40%;
                height: 35px;
                float: left;
                overflow: hidden;
            }

            .ui-code .c-right {
                width: auto;
                height: 35px;
                margin: 0 0 0 50%;
                overflow: hidden;
            }

        .ui-copy {
            width: 100%;
            height: 30px;
            line-height: 30px;
            text-align: center;
            color: #d5e1f0;
            bottom: 0;
            left: 0;
            position: absolute;
            font-size: 12px;
        }

            .ui-copy a {
                color: #d5e1f0;
            }

                .ui-copy a:hover {
                    color: #FFF;
");
                WriteLiteral(@"                }
        /*字体元素居中*/
        .flex-center {
            -moz-justify-content: center;
            -webkit-justify-content: center;
            justify-content: center;
            -moz-align-items: center;
            -webkit-align-items: center;
            -ms-align-items: center;
            align-items: center;
            display: -moz-flex;
            display: -webkit-flex;
            display: flex;
        }

        ");
                EndContext();
                BeginContext(8197, 192, true);
                WriteLiteral("@media only screen and (min-width: 100px) and (max-width:768px) {\r\n            .ui-wrap {\r\n                width: auto;\r\n                height: auto;\r\n            }\r\n        }\r\n    </style>\r\n");
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
            BeginContext(8396, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(8400, 5772, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfec1e45be8547dfbd88221f723a294d", async() => {
                BeginContext(8406, 113, true);
                WriteLiteral("\r\n\t<script>\r\n        if (window.parent.window !== window) {\r\n            window.parent.document.location.href = \'");
                EndContext();
                BeginContext(8520, 19, false);
#line 330 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Login\Index.cshtml"
                                               Write(Url.Action("Check"));

#line default
#line hidden
                EndContext();
                BeginContext(8539, 1460, true);
                WriteLiteral(@"';
            document.body.innerHTML = """";
        }
	</script>
	
    <div class=""ui-pannel"">
        <div class=""ui-wrap animated flipInY"">
            <div class=""ui-top"">
                <div class=""left"">
                    <img src=""/images/login-left.gif"" />
                </div>
                <div class=""right"">
                    <img src=""/images/logo.png"" />
                </div>
            </div>
            <div class=""ui-input"">
                <div class=""left"">
                    <ul>
                        <li>登录账号</li>
                        <li>登录密码</li>
                        <li>验 证 码</li>
                    </ul>
                </div>
                <div class=""right"">
                    <div class=""wrap"">
                        <ul>
                            <li><input type=""text"" id=""txtUserName"" placeholder=""输入账号！"" maxlength=""20"" /></li>
                            <li><input type=""password"" id=""txtPassword"" placeholder=""输入密码！"" maxlength=""");
                WriteLiteral(@"25"" /></li>
                            <li class=""ui-code""><div class=""c-left""><input type=""text"" id=""txtValidateCode"" placeholder=""输入验证码！"" maxlength=""6"" /></div><div class=""c-right""><img src=""/ManagementSystem/ValidateCode"" class=""validate-code"" style=""cursor:pointer;"" onclick=""this.src = '/ManagementSystem/ValidateCode?' + Math.random()"" ref=""imgValidateCOde"" /></div></li>
                        </ul>
                        ");
                EndContext();
                BeginContext(10000, 23, false);
#line 360 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Login\Index.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(10023, 838, true);
                WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""ui-btn-item"">
                <a href=""javascript:void(0);"" class=""send_btn"">登  录</a>
                <a href=""javascript:void(0);"" class=""caned_btn"">取  消</a>
            </div>
        </div>

        <!--[if lte IE 8]>
            <div style=""position: absolute; top: 50%; left: 0; right: 0; width: 100%; height: 40px; margin-top: -180px;"">
                <span style=""color: red; background: white; padding: 20px;"">
                    您的浏览器版本过低，推荐使用<a href=""https://browser.360.cn/se/"" target=""_blank"">360浏览器</a>，提升体验效果。
                    <a href=""https://browser.360.cn/se/"" target=""_blank"">点此下载360浏览器</a>
                </span>
            </div>
        <![endif]-->

        <div class=""ui-copy"">Copyright &copy; ");
                EndContext();
                BeginContext(10862, 17, false);
#line 379 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Login\Index.cshtml"
                                         Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(10879, 1, true);
                WriteLiteral("-");
                EndContext();
                BeginContext(10881, 30, false);
#line 379 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Login\Index.cshtml"
                                                            Write(DateTime.Now.AddYears(10).Year);

#line default
#line hidden
                EndContext();
                BeginContext(10911, 31, true);
                WriteLiteral(" All Right Reserved Powered by ");
                EndContext();
                BeginContext(10943, 9, false);
#line 379 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Login\Index.cshtml"
                                                                                                                          Write(titleName);

#line default
#line hidden
                EndContext();
                BeginContext(10952, 1637, true);
                WriteLiteral(@" 技术支持：<a href=""http://www.gelaisoft.com/"" title=""贵州格莱软件科技有限公司"" target=""_blank"">贵州格莱软件科技有限公司</a></div>
    </div>

    <script src=""/layui/layui.all.js""></script>
    <script src=""https://cdn.bootcss.com/js-sha1/0.6.0/sha1.min.js""></script>


    <script type=""text/javascript"">

    layui.use('layer',function() {
        $ = layui.jquery;
        layer = layui.layer;

        layuiReady();
    });


    function layuiReady() {

        var app = {
            login: function () {
                var userName = $.trim($(""#txtUserName"").val());
                var password = $.trim($(""#txtPassword"").val());
                var validateCode = $.trim($(""#txtValidateCode"").val());
                if (!userName) {
                    app.tip(""请输入登录账号！"", ""txtUserName"");
                }
                else if (!password) {
                    app.tip(""请输入登录密码！"", ""txtPassword"");
                }
                else if (validateCode == """") {
                    app.tip(""请输入验证码！"", ""txt");
                WriteLiteral(@"ValidateCode"");
                } else {
                    var index = layer.load(0, {
                        shade: [0.3, '#000']
                    });

                    var token = $(""input[name='__RequestVerificationToken']"").val();
                    var model = {
                        loginName: userName,
                            password: sha1(password),
                            validateCode: validateCode.toLowerCase(),
                            __requestVerificationToken: token
                    };
                    
                    $.post(""/ManagementSystem/");
                EndContext();
                BeginContext(12590, 27, false);
#line 424 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Login\Index.cshtml"
                                         Write(Url.Action("Check","Login"));

#line default
#line hidden
                EndContext();
                BeginContext(12617, 334, true);
                WriteLiteral(@""", model, function (data) {
                        layer.close(index);
                        if (data.status == 1) {
                            layer.msg('登录成功，正在跳转到首页', { time: 300000, icon: 6 });
                            setTimeout(function () {
                                window.location.href = ""/ManagementSystem/");
                EndContext();
                BeginContext(12952, 30, false);
#line 429 "F:\Project\visual studio\Company\CompanyWebSite\Areas\ManagementSystem\Views\Login\Index.cshtml"
                                                                     Write(Url.Action("Index", "Manager"));

#line default
#line hidden
                EndContext();
                BeginContext(12982, 1183, true);
                WriteLiteral(@""";
                            }, 3000);
                        }
                        else {
                            $("".validate-code"").attr(""src"", '/ManagementSystem/ValidateCode?' + Math.random());
                            layer.msg(data.msg, { time: 3000, icon: 5 });
                        }
                    }, ""json"");
                }
            },
            tip: function (msg, obj) {
                layer.tips(msg, '#' + obj, {
                    tips: [1, '#3595CC'],
                    time: 3000
                });
                $(""#"" + obj).focus();
            }
        };

        $(function () {
            $(""#txtUserName"").focus();
            $("".send_btn"").on(""click"", function () {
                app.login();
            });
            $(document).on(""keydown"", function (e) {
                if (e.keyCode === 13) {
                    app.login();
                }
            });
            $("".caned_btn"").on(""click"", function () {
   ");
                WriteLiteral("             $(\":input\").each(function (i) {\r\n                    $(this).val(\"\");\r\n                });\r\n            });\r\n        });\r\n    }\r\n    </script>\r\n\r\n");
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
            BeginContext(14172, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

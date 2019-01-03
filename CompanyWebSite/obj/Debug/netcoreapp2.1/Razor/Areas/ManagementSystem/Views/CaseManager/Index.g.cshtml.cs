#pragma checksum "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Areas\ManagementSystem\Views\CaseManager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62af30d19a4d990922aca21cc66c21b6b06f52a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ManagementSystem_Views_CaseManager_Index), @"mvc.1.0.view", @"/Areas/ManagementSystem/Views/CaseManager/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ManagementSystem/Views/CaseManager/Index.cshtml", typeof(AspNetCore.Areas_ManagementSystem_Views_CaseManager_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62af30d19a4d990922aca21cc66c21b6b06f52a7", @"/Areas/ManagementSystem/Views/CaseManager/Index.cshtml")]
    public class Areas_ManagementSystem_Views_CaseManager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
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
            BeginContext(15, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(44, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee45596581454e75a94fab6946bfa9f7", async() => {
                BeginContext(50, 96, true);
                WriteLiteral("\r\n    <title>CaseManagement</title>\r\n    <link href=\"/layui/css/layui.css\" rel=\"stylesheet\" />\r\n");
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
            BeginContext(153, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(155, 7332, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "421e8de17b4645b989893545d6ee93e3", async() => {
                BeginContext(161, 1629, true);
                WriteLiteral(@"
    <div>
        <table id=""CaseTable"" lay-filter=""CaseTableContainer""></table>
        <script src=""/layui/layui.js""></script>
        <!--表工具条-->
        <script type=""text/html"" id=""ToolBar"">
            <div>
                <button class=""layui-btn"" lay-event=""AddCase"">增加</button>
                <button class=""layui-btn layui-btn-danger"" lay-event=""DeleteSelectCases"">批量删除</button>
                <div class=""layui-input-inline"" style=""margin-left: 200px"">
                    <input class=""layui-input"" placeholder=""查找案例名称"" id=""KeyWord"" />
                </div>
                <button class=""layui-btn layui-btn-normal"" lay-event=""SearchIndustries"">搜索</button>
            </div>
        </script>
        <!--列工具条-->
        <script type=""text/html"" id=""ColumnToolBar"">
            <div class=""layui-btn-container"">
                <button class=""layui-btn layui-btn-warm layui-btn-sm"" lay-event=""EditCase"">详情</button>
                <button class=""layui-btn layui-btn-danger layui-btn-sm""");
                WriteLiteral(@" lay-event=""DeleteCase"">删除</button>
            </div>
        </script>
        <script>
            layui.use(['jquery','table', 'layer'],
                function () {
                //初始化
                var table = layui.table;
                var layer = layui.layer;
                var $ = layui.$;
                //计算窗口高度
                var tableHeight = window.innerHeight*0.98;
                //渲染数据表格
                var CaseTable = table.render({
                    elem: '#CaseTable',
                    height: tableHeight,
                    url: '/ManagementSystem/");
                EndContext();
                BeginContext(1791, 42, false);
#line 45 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Areas\ManagementSystem\Views\CaseManager\Index.cshtml"
                                       Write(Url.Action("TableCaseData", "CaseManager"));

#line default
#line hidden
                EndContext();
                BeginContext(1833, 1574, true);
                WriteLiteral(@"' //数据接口
                    ,
                    page: true //开启分页
                    ,
                    toolbar: ""#ToolBar"",
                    cols: [
                        [//表头
                            { field: 'checkbox', type: ""checkbox"", width: 80, fixed: 'left' },
                            { field: 'id', title: 'ID', width: 80, sort: true, fixed: 'left' },
                            { field: 'name', title: '案例名称', width: 220 },
                            { field: 'cover', title: '案例封面', width: 180 },
                            { field: 'tool', title: '工具条', width: 135, toolbar: ""#ColumnToolBar"" }
                        ]
                    ]
                    ,
                    response: {
                        statusName: 'status' //规定数据状态的字段名称，默认：code
                        ,statusCode: 200 //规定成功的状态码，默认：0
                        ,msgName: 'message' //规定状态信息的字段名称，默认：msg
                        ,countName: 'total' //规定数据总数的字段名称，默认：count
                 ");
                WriteLiteral(@"       ,dataName: 'data' //规定数据列表的字段名称，默认：data
                    }
                });

                //表工具条监听
                table.on('toolbar(CaseTableContainer)', function(obj) {
                    console.log(obj);
                    switch (obj.event) {
                        //增加行业
                        case ""AddCase"":
                            layer.open({
                                type: 2,
                                area: ['600px','600px'],
                                content: ['/ManagementSystem/");
                EndContext();
                BeginContext(3408, 35, false);
#line 78 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Areas\ManagementSystem\Views\CaseManager\Index.cshtml"
                                                        Write(Url.Action("AddCase","CaseManager"));

#line default
#line hidden
                EndContext();
                BeginContext(3443, 749, true);
                WriteLiteral(@"']
                            });
                            break;
                        //批量删除
                        case ""DeleteSelectCases"":
                            var select = table.checkStatus('CaseTable');
                            if (select.data.length == 0) {
                                layer.msg(""您还未选中！"");
                                return;
                            }
                            layer.confirm('真的要删除吗？', {
                                btn: ['确定', '取消'] //可以无限个按钮
                            }, function (index, layero) {
                                layer.close(index);
                                //按钮【按钮一】的回调
                                $.post('/ManagementSystem/");
                EndContext();
                BeginContext(4193, 39, false);
#line 93 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Areas\ManagementSystem\Views\CaseManager\Index.cshtml"
                                                     Write(Url.Action("DeleteCases","CaseManager"));

#line default
#line hidden
                EndContext();
                BeginContext(4232, 1751, true);
                WriteLiteral(@"',
                                    {
                                        cases: select.data
                                    },
                                    function (data, status) {
                                        if (data.total > 0) {
                                            layer.msg(""删除成功！"");
                                            table.reload(""CaseTable"");
                                        } else {
                                            layer.msg(""删除失败！"");
                                        }
                                    });
                            }, function (index) {
                                layer.close(index);
                                //按钮【按钮二】的回调

                            });
                            break;
                         //关键字搜索
                        case ""SearchIndustries"":
                            var value = $(""#KeyWord"").val();

                            table.reload(""CaseTabl");
                WriteLiteral(@"e"",
                                {
                                    where: {
                                        keyword: value
                                    }
                                });
                            break;
                    }
                });

                //列工具条监听
                    table.on('tool(CaseTableContainer)', function (obj) {
                        switch (obj.event) {
                            //编辑行业
                        case ""EditCase"":
                            layer.open({
                                type: 2,
                                area: ['600px','600px'],
                                content: '/ManagementSystem/");
                EndContext();
                BeginContext(5984, 38, false);
#line 133 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Areas\ManagementSystem\Views\CaseManager\Index.cshtml"
                                                       Write(Url.Action("UpdateCase","CaseManager"));

#line default
#line hidden
                EndContext();
                BeginContext(6022, 497, true);
                WriteLiteral(@"?id=' + obj.data.id
                            });
                            break;
                        //删除行业
                        case ""DeleteCase"":
                            layer.confirm('真的要删除吗？', {
                                btn: ['确定', '取消'] //可以无限个按钮
                            }, function(index, layero){
                                //按钮【按钮一】的回调
                                layer.close(index);
                                $.post('/ManagementSystem/");
                EndContext();
                BeginContext(6520, 39, false);
#line 143 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Areas\ManagementSystem\Views\CaseManager\Index.cshtml"
                                                     Write(Url.Action("DeleteCases","CaseManager"));

#line default
#line hidden
                EndContext();
                BeginContext(6559, 921, true);
                WriteLiteral(@"',
                                    {
                                        cases: [obj.data]
                                    },
                                    function (data, status) {
                                        if (data.total > 0) {
                                            layer.msg(""删除成功！"");
                                            table.reload(""CaseTable"");
                                        } else {
                                            layer.msg(""删除失败！"");
                                        }
                                    });
                                }, function (index) {
                                    layer.close(index);
                                //按钮【按钮二】的回调
                            });

                        break;
                    }
                });
            });
        </script>
    </div>
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
            BeginContext(7487, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591

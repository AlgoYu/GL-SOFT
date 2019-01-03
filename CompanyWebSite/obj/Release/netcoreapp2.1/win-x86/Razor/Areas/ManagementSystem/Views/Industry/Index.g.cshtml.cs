#pragma checksum "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Areas\ManagementSystem\Views\Industry\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff0b8e9bf90469bfb55045267b8fb119cd71d775"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ManagementSystem_Views_Industry_Index), @"mvc.1.0.view", @"/Areas/ManagementSystem/Views/Industry/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ManagementSystem/Views/Industry/Index.cshtml", typeof(AspNetCore.Areas_ManagementSystem_Views_Industry_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0b8e9bf90469bfb55045267b8fb119cd71d775", @"/Areas/ManagementSystem/Views/Industry/Index.cshtml")]
    public class Areas_ManagementSystem_Views_Industry_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
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
            BeginContext(44, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3269900866334125bfe36db5478ba3a2", async() => {
                BeginContext(50, 100, true);
                WriteLiteral("\r\n    <title>IndustryManagement</title>\r\n    <link href=\"/layui/css/layui.css\" rel=\"stylesheet\" />\r\n");
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
            BeginContext(157, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(159, 8980, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ef39720c3844a318221120da717805e", async() => {
                BeginContext(165, 1662, true);
                WriteLiteral(@"
    <div>
        <table id=""IndustryTable"" lay-filter=""IndustryTableContainer""></table>
        <script src=""/layui/layui.js""></script>
        <!--表工具条-->
        <script type=""text/html"" id=""ToolBar"">
            <div>
                <button class=""layui-btn"" lay-event=""AddIndustry"">增加</button>
                <button class=""layui-btn layui-btn-danger"" lay-event=""DeleteSelectIndustries"">批量删除</button>
                <div class=""layui-input-inline"" style=""margin-left: 200px"">
                    <input class=""layui-input"" placeholder=""查找ID或名称"" id=""KeyWord""/>
                </div>
                <button class=""layui-btn layui-btn-normal"" lay-event=""SearchIndustries"">搜索</button>
            </div>
        </script>
        <!--列工具条-->
        <script type=""text/html"" id=""ColumnToolBar"">
            <div class=""layui-btn-container"">
                <button class=""layui-btn layui-btn-warm layui-btn-sm"" lay-event=""EditIndustry"">编辑</button>
                <button class=""layui-btn layui-btn");
                WriteLiteral(@"-danger layui-btn-sm"" lay-event=""DeleteIndustry"">删除</button>
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
                var industryTable = table.render({
                    elem: '#IndustryTable',
                    height: tableHeight,
                    url: '/ManagementSystem/");
                EndContext();
                BeginContext(1828, 42, false);
#line 45 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Areas\ManagementSystem\Views\Industry\Index.cshtml"
                                       Write(Url.Action("SelectIndustries", "Industry"));

#line default
#line hidden
                EndContext();
                BeginContext(1870, 1563, true);
                WriteLiteral(@"' //数据接口
                    ,
                    page: true //开启分页
                    ,
                    toolbar: ""#ToolBar"",
                    cols: [
                        [//表头
                            { field: 'checkbox', type:""checkbox"", width: 80, fixed: 'left' },
                            { field: 'id', title: 'ID', width: 80, sort: true, fixed: 'left' },
                            { field: 'name', title: '行业名称', width: 180 },
                            { field: 'tool', title: '工具条', width: 135, toolbar:""#ColumnToolBar"" }
                        ]
                    ]
                    ,
                    response: {
                        statusName: 'status' //规定数据状态的字段名称，默认：code
                        ,statusCode: 200 //规定成功的状态码，默认：0
                        ,msgName: 'message' //规定状态信息的字段名称，默认：msg
                        ,countName: 'total' //规定数据总数的字段名称，默认：count
                        ,dataName: 'data' //规定数据列表的字段名称，默认：data
                    }
       ");
                WriteLiteral(@"         });

                //表工具条监听
                table.on('toolbar(IndustryTableContainer)', function(obj) {
                    console.log(obj);
                    switch (obj.event) {
                        //增加行业
                        case ""AddIndustry"":
                            layer.prompt({
                                formType: 0,
                                title: '请输入新增行业名称'
                            },function(value, index, elem) {
                                $.post('/ManagementSystem/");
                EndContext();
                BeginContext(3434, 36, false);
#line 78 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Areas\ManagementSystem\Views\Industry\Index.cshtml"
                                                     Write(Url.Action("AddIndustry","Industry"));

#line default
#line hidden
                EndContext();
                BeginContext(3470, 1431, true);
                WriteLiteral(@"',
                                    {
                                        name: value
                                    },
                                    function (data, status) {
                                        if (data.total > 0) {
                                            layer.msg(""添加成功！请去最后一页查看！"");
                                            table.reload(""IndustryTable"");
                                            layer.close(index);
                                        } else {
                                            layer.msg(""添加失败！"");
                                        }
                                    });
                            });
                            break;
                        //批量删除
                        case ""DeleteSelectIndustries"":
                            var select = table.checkStatus('IndustryTable'); 
                            if (select.data.length == 0) {
                                layer.msg(""您还未选中！"");");
                WriteLiteral(@"
                                return;
                            }
                            layer.confirm('真的要删除吗？', {
                                btn: ['确定', '取消'] //可以无限个按钮
                            }, function (index, layero) {
                                layer.close(index);
                                //按钮【按钮一】的回调
                                $.post('/ManagementSystem/");
                EndContext();
                BeginContext(4902, 41, false);
#line 105 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Areas\ManagementSystem\Views\Industry\Index.cshtml"
                                                     Write(Url.Action("DeleteIndustries","Industry"));

#line default
#line hidden
                EndContext();
                BeginContext(4943, 1945, true);
                WriteLiteral(@"',
                                    {
                                        industries: select.data
                                    },
                                    function (data, status) {
                                        if (data.total > 0) {
                                            layer.msg(""删除成功！"");
                                            table.reload(""IndustryTable"");
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
           ");
                WriteLiteral(@"                 
                            table.reload(""IndustryTable"",
                                {
                                    where: {
                                        keyword: value
                                    }
                                });
                            break;
                    }
                });

                //列工具条监听
                    table.on('tool(IndustryTableContainer)', function (obj) {
                        switch (obj.event) {
                            //编辑行业
                        case ""EditIndustry"":
                            layer.prompt({
                                formType: 0,
                                title: '请输入修改名称',
                                value: obj.data.name
                            },function(value, index, elem) {
                                $.post('/ManagementSystem/");
                EndContext();
                BeginContext(6889, 39, false);
#line 147 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Areas\ManagementSystem\Views\Industry\Index.cshtml"
                                                     Write(Url.Action("UpdateIndustry","Industry"));

#line default
#line hidden
                EndContext();
                BeginContext(6928, 1204, true);
                WriteLiteral(@"',
                                    {
                                        id:obj.data.id,
                                        name: value
                                    },
                                    function (data, status) {
                                        if (data.total > 0) {
                                            layer.msg(""修改成功！"");
                                            table.reload(""IndustryTable"");
                                            layer.close(index);
                                        } else {
                                            layer.msg(""修改失败！"");
                                        }
                                    });
                            });
                            break;
                        //删除行业
                        case ""DeleteIndustry"":
                            layer.confirm('真的要删除吗？', {
                                btn: ['确定', '取消'] //可以无限个按钮
                            }, fun");
                WriteLiteral("ction(index, layero){\r\n                                //按钮【按钮一】的回调\r\n                                layer.close(index);\r\n                                $.post(\'/ManagementSystem/");
                EndContext();
                BeginContext(8133, 41, false);
#line 170 "C:\Users\Administrator\Desktop\Company\CompanyWebSite\Areas\ManagementSystem\Views\Industry\Index.cshtml"
                                                     Write(Url.Action("DeleteIndustries","Industry"));

#line default
#line hidden
                EndContext();
                BeginContext(8174, 958, true);
                WriteLiteral(@"',
                                    {
                                        industries: [obj.data]
                                    },
                                    function (data, status) {
                                        if (data.total > 0) {
                                            layer.msg(""删除成功！"");
                                            table.reload(""IndustryTable"");
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
            BeginContext(9139, 9, true);
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

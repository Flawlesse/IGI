#pragma checksum "D:\УЧЁБА\5сем\ИГИ\WEB_953506_лавренович_1\WEB_953506_лавренович\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baf651755a8e38a7939a0e253723fa94b2b7d84d"
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
#line 1 "D:\УЧЁБА\5сем\ИГИ\WEB_953506_лавренович_1\WEB_953506_лавренович\Views\_ViewImports.cshtml"
using WEB_953506_лавренович;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\УЧЁБА\5сем\ИГИ\WEB_953506_лавренович_1\WEB_953506_лавренович\Views\_ViewImports.cshtml"
using WEB_953506_лавренович.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baf651755a8e38a7939a0e253723fa94b2b7d84d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa52d4f2b7f0ce7bf97e835930464779cd9e796d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("htmlpage.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\УЧЁБА\5сем\ИГИ\WEB_953506_лавренович_1\WEB_953506_лавренович\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Главная страница";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"container\">\r\n    <!--Содержимое страницы-->\r\n    <h1>Лабораторная работа 3</h1>\r\n    <h3>Список</h3>\r\n    <hr>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baf651755a8e38a7939a0e253723fa94b2b7d84d4444", async() => {
                WriteLiteral("\r\n        <h2>");
#nullable restore
#line 15 "D:\УЧЁБА\5сем\ИГИ\WEB_953506_лавренович_1\WEB_953506_лавренович\Views\Home\Index.cshtml"
       Write(ViewData["Text"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n        <h3>Форма</h3>\r\n        <ol type=\"A\">\r\n");
#nullable restore
#line 18 "D:\УЧЁБА\5сем\ИГИ\WEB_953506_лавренович_1\WEB_953506_лавренович\Views\Home\Index.cshtml"
             for (int i = 1; i < 5; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>элемент ");
#nullable restore
#line 20 "D:\УЧЁБА\5сем\ИГИ\WEB_953506_лавренович_1\WEB_953506_лавренович\Views\Home\Index.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(" списка</li>\r\n");
#nullable restore
#line 21 "D:\УЧЁБА\5сем\ИГИ\WEB_953506_лавренович_1\WEB_953506_лавренович\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </ol>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baf651755a8e38a7939a0e253723fa94b2b7d84d5800", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 23 "D:\УЧЁБА\5сем\ИГИ\WEB_953506_лавренович_1\WEB_953506_лавренович\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewData["Lst"] as SelectList;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <div class=""form-group row"">
            <div class=""col-sm-2""></div>
            <div class=""col-sm-10"">
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox"" name=""checkboxItem"" id=""gridCheck1"" value=""check1"">
                    <label class=""form-check-label"" for=""gridCheck1"">
                        Чек-бокс 1
                    </label>
                </div>
            </div>
            <div class=""col-sm-2""></div>
            <div class=""col-sm-10"">
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox"" name=""checkboxItem"" id=""gridCheck2"" value=""check2"">
                    <label class=""form-check-label"" for=""gridCheck2"">
                        Чек-бокс 2
                    </label>
                </div>
            </div>
        </div>
        <fieldset class=""form-group"">
            <div class=""row"">
                <legend class=""col-form-label col-sm");
                WriteLiteral(@"-2 pt-0""></legend>
                <div class=""col-sm-10"">
                    <div class=""form-check form-check-inline"">
                        <input class=""form-check-input"" type=""radio"" name=""RadioOption"" id=""inlineRadio1"" value=""option1"">
                        <label class=""form-check-label"" for=""inlineRadio1"">Радио-1</label>
                    </div>
                    <div class=""form-check form-check-inline"">
                        <input class=""form-check-input"" type=""radio"" name=""RadioOption"" id=""inlineRadio2"" value=""option2"">
                        <label class=""form-check-label"" for=""inlineRadio2"">Радио-2</label>
                    </div>
                    <div class=""form-check form-check-inline"">
                        <input class=""form-check-input"" type=""radio"" name=""RadioOption"" id=""inlineRadio3"" value=""option3"">
                        <label class=""form-check-label"" for=""inlineRadio3"">Радио-3 </label>
                    </div>
                </div>
            </");
                WriteLiteral(@"div>
        </fieldset>
        <div class=""form-group row"">
            <label for=""inputLogin"" class=""col-sm-2 col-form-label"">Логин</label>
            <div class=""col-sm-10"">
                <input type=""text"" class=""form-control"" name=""login"" id=""inputLogin"" placeholder=""Ведите имя"" required>
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""inputPassword3"" class=""col-sm-2 col-form-label"">Пароль</label>
            <div class=""col-sm-10"">
                <input type=""password"" class=""form-control"" name=""password"" id=""inputPassword3"" placeholder=""Введите пароль"" required>
            </div>
        </div>
        <div class=""form-group row"">
            <div class=""col-sm-10"">
                <button type=""submit"" class=""btn btn-primary"">Отправить</button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</main>");
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

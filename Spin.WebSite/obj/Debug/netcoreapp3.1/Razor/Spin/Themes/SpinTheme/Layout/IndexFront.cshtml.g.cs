#pragma checksum "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78cb855d381e40a8ec560a13cf4b088156f88b61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Themes_SpinTheme_Layout_IndexFront), @"mvc.1.0.view", @"/Spin/Themes/SpinTheme/Layout/IndexFront.cshtml")]
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
#line 3 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Base.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Helper.Extend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Modules.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Base.Helper.Extend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Base.Helper.Company;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cb855d381e40a8ec560a13cf4b088156f88b61", @"/Spin/Themes/SpinTheme/Layout/IndexFront.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Themes_SpinTheme_Layout_IndexFront : Spin.Base.Extend.Page.SpinWebViewPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/clientapp/runtime-es5.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/clientapp/polyfills-es5.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/clientapp/styles-es5.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/clientapp/vendor-es5.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/clientapp/main-es5.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
  
    Spin.Modules.API.LanguageBL BL = new Spin.Modules.API.LanguageBL();

    //1. probar todo desde cdn
    //2. utilitarios para imagenes y otros archivos
    //3. unificar css y quitar bloqueos

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cb855d381e40a8ec560a13cf4b088156f88b616501", async() => {
                WriteLiteral(@"
    <title>CMS Framework</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <link href=""https://fonts.googleapis.com/css?family=Roboto&display=swap"" rel=""stylesheet"">
    <link");
                BeginWriteAttribute("href", " href=\'", 502, "\'", 571, 1);
#nullable restore
#line 16 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
WriteAttributeValue("", 509, SpinViewPage.ValidateURL("/lib/font-awesome/css/all.min.css"), 509, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n    <link");
                BeginWriteAttribute("href", " href=\'", 617, "\'", 694, 1);
#nullable restore
#line 17 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
WriteAttributeValue("", 624, SpinViewPage.ValidateURL("/lib/bootstrap/dist/css/bootstrap.min.css"), 624, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" async />\r\n    <link");
                BeginWriteAttribute("href", " href=\'", 732, "\'", 817, 1);
#nullable restore
#line 18 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
WriteAttributeValue("", 739, SpinViewPage.ValidateURL("/Spin/Themes/SpinTheme/Resource/css/SpinTheme.css"), 739, 78, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" async />\r\n    <link");
                BeginWriteAttribute("href", " href=\'", 855, "\'", 946, 1);
#nullable restore
#line 19 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
WriteAttributeValue("", 862, SpinViewPage.ValidateURL("/Spin/Themes/SpinTheme/Resource/css/SpinTheme-media.css"), 862, 84, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" async />\r\n\r\n    ");
#nullable restore
#line 21 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
Write(SpinViewPage.Styles.Render());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cb855d381e40a8ec560a13cf4b088156f88b6110013", async() => {
                WriteLiteral(@"
    <div id=""wrapper"" class=""wrapper"">
        <header>
            <div class=""row no-gutters justify-content-end"">
                <div class=""col-4 col-md-2"">
                    <a href=""https://dev.cmsspin.com"" target=""_blank"">
                        <img class=""img-logo"" src=""/spin-sys/dist/img/logo-spin-color.png"" />
                    </a>
                </div>
                <div class=""col-4"">
                    <div class=""language-top"">
                        <a href=""?ui-culture=en"">EN</a>
");
#nullable restore
#line 35 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
                         foreach (var ItemLang in BL.SelectAll())
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
                        Write("|");

#line default
#line hidden
#nullable disable
                WriteLiteral(" <a");
                BeginWriteAttribute("href", " href=\"", 1685, "\"", 1730, 2);
                WriteAttributeValue("", 1692, "?ui-culture=", 1692, 12, true);
#nullable restore
#line 37 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
WriteAttributeValue("", 1704, ItemLang.Code.ToLower(), 1704, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 37 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
                                                                                Write(ItemLang.Code.ToUpper());

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a>\r\n");
#nullable restore
#line 38 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </header>\r\n        <main>\r\n            ");
#nullable restore
#line 45 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <footer>\r\n                <div class=\"row no-gutters  justify-content-center\">\r\n                    <div class=\"col-12\">\r\n                        ");
#nullable restore
#line 49 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
                   Write(CompanyFactory.Information.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" VS ");
#nullable restore
#line 49 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
                                                       Write(CompanyFactory.Information.Version);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 49 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
                                                                                             Write(CompanyFactory.Information.TypeVersion);

#line default
#line hidden
#nullable disable
                WriteLiteral(") | © ");
#nullable restore
#line 49 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
                                                                                                                                           Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 49 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
                                                                                                                                                              Write(CompanyFactory.Information.Copyright);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </footer>\r\n        </main>\r\n\r\n    </div>\r\n\r\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cb855d381e40a8ec560a13cf4b088156f88b6115003", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cb855d381e40a8ec560a13cf4b088156f88b6116103", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cb855d381e40a8ec560a13cf4b088156f88b6117203", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cb855d381e40a8ec560a13cf4b088156f88b6118303", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cb855d381e40a8ec560a13cf4b088156f88b6119403", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 2705, "\'", 2772, 1);
#nullable restore
#line 64 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
WriteAttributeValue("", 2711, SpinViewPage.ValidateURL("/lib/jquery/dist/jquery.min.js"), 2711, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    ");
#nullable restore
#line 65 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\SpinTheme\Layout\IndexFront.cshtml"
Write(SpinViewPage.JavaScripts.Render());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
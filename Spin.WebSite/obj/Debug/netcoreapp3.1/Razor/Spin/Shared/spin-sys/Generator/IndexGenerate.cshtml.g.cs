#pragma checksum "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\IndexGenerate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2d2fadcef40177511e38bfc68b2904bc1d7e48a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Shared_spin_sys_Generator_IndexGenerate), @"mvc.1.0.view", @"/Spin/Shared/spin-sys/Generator/IndexGenerate.cshtml")]
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
#nullable restore
#line 1 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\IndexGenerate.cshtml"
using Spin.Modules.API;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2d2fadcef40177511e38bfc68b2904bc1d7e48a", @"/Spin/Shared/spin-sys/Generator/IndexGenerate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Shared_spin_sys_Generator_IndexGenerate : Spin.Base.Extend.Page.SpinWebViewPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\IndexGenerate.cshtml"
   
    this.SpinViewPage.AddTryStyle("/css/Generator/GeneratorExtend.css");
    this.SpinViewPage.AddTryStyle("/css/Generator/GeneratorExtend-media.css");
    this.SpinViewPage.AddTryJavaScript($"/Spin/Module/{SpinViewPage.ModuleName}/Resource/js/{SpinViewPage.ControllerName}/ExtendController.js", false, false, 0);  
    this.SpinViewPage.AddTryStyle($"/Spin/Module/{SpinViewPage.ModuleName}/Resource/css/{SpinViewPage.ControllerName}/ExternalStyle.css", false);
    
    //Language
    var Language = LanguageBL.AllowLanguage;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div ng-app=\"SpinApp\" class=\"content-controller\">\r\n\r\n    <!--Add by use Angular-->\r\n    <input type=\"hidden\" name=\"module\" id=\"module\"");
            BeginWriteAttribute("value", " value=\"", 701, "\"", 733, 1);
#nullable restore
#line 14 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\IndexGenerate.cshtml"
WriteAttributeValue("", 709, SpinViewPage.ModuleName, 709, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"controller\" id=\"controller\"");
            BeginWriteAttribute("value", " value=\"", 797, "\"", 833, 1);
#nullable restore
#line 15 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\IndexGenerate.cshtml"
WriteAttributeValue("", 805, SpinViewPage.ControllerName, 805, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"action\" id=\"action\"");
            BeginWriteAttribute("value", " value=\"", 889, "\"", 921, 1);
#nullable restore
#line 16 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\IndexGenerate.cshtml"
WriteAttributeValue("", 897, SpinViewPage.ActionName, 897, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"segment\" id=\"segment\"");
            BeginWriteAttribute("value", " value=\"", 979, "\"", 1012, 1);
#nullable restore
#line 17 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\IndexGenerate.cshtml"
WriteAttributeValue("", 987, SpinViewPage.SegmentName, 987, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"TotalCountRows\" id=\"TotalCountRows\"");
            BeginWriteAttribute("value", " value=\"", 1084, "\"", 1115, 1);
#nullable restore
#line 18 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\IndexGenerate.cshtml"
WriteAttributeValue("", 1092, ViewBag.TotalCountRows, 1092, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"isAdmin\" name=\"isAdmin\"");
            BeginWriteAttribute("value", " value=\"", 1173, "\"", 1271, 1);
#nullable restore
#line 19 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\IndexGenerate.cshtml"
WriteAttributeValue("", 1181, ViewBag.Security.User.IdGroup != 1 && ViewBag.Security.User.IdGroup != 5?"false":"true", 1181, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n    <!--Select Script Template-->\r\n\r\n    ");
#nullable restore
#line 23 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\IndexGenerate.cshtml"
Write(await Html.SpinRenderActionAsync("SelectGenerate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <!--Detail Script Template-->\r\n    ");
#nullable restore
#line 27 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\IndexGenerate.cshtml"
Write(await Html.SpinRenderActionAsync("DetailGenerate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n    <div id=\"viewContent\" class=\"content-view\" ng-view>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
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

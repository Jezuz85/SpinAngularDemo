#pragma checksum "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Introduction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e689f4b9dab92476f51b8b1718a3354850b6eba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Documentation_Site_Views_spin_sys_Home_Introduction), @"mvc.1.0.view", @"/Spin/Module/Documentation/Site/Views/spin-sys/Home/Introduction.cshtml")]
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
#line 1 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Introduction.cshtml"
using Spin.WebSite.Spin.Themes.SpinTheme.Language;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Introduction.cshtml"
using Spin.Base.Documentation.Language;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e689f4b9dab92476f51b8b1718a3354850b6eba7", @"/Spin/Module/Documentation/Site/Views/spin-sys/Home/Introduction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Documentation_Site_Views_spin_sys_Home_Introduction : Spin.Base.Extend.Page.SpinWebViewPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <img class=\"introduction-image\" src=\"/Spin/Module/Documentation/Resource/spin-sys/img/introImage.jpg\" />\r\n</div>\r\n<div class=\"introduction-content\">\r\n    <h1>\r\n        ");
#nullable restore
#line 9 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Introduction.cshtml"
   Write(DocumentationLanguage.WelcomeTechnicalDoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <div class=\"introduction-version\">\r\n        ");
#nullable restore
#line 12 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Introduction.cshtml"
   Write(CompanyFactory.Information.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 12 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Introduction.cshtml"
                                     Write(CompanyFactory.Information.Version);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 12 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Introduction.cshtml"
                                                                           Write(CompanyFactory.Information.TypeVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral(") © ");
#nullable restore
#line 12 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Introduction.cshtml"
                                                                                                                       Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"text-welcome\">\r\n        ");
#nullable restore
#line 15 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Introduction.cshtml"
   Write(SpinThemeLanguage.IntroText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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

#pragma checksum "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\GeneralInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3690b24928e6894dd3932ecd75f64f9cc02c9434"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Documentation_Site_Views_spin_sys_Home_GeneralInformation), @"mvc.1.0.view", @"/Spin/Module/Documentation/Site/Views/spin-sys/Home/GeneralInformation.cshtml")]
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
#line 2 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\GeneralInformation.cshtml"
using Spin.Base.Documentation.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\GeneralInformation.cshtml"
using Spin.Base.Documentation.Language;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3690b24928e6894dd3932ecd75f64f9cc02c9434", @"/Spin/Module/Documentation/Site/Views/spin-sys/Home/GeneralInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Documentation_Site_Views_spin_sys_Home_GeneralInformation : Spin.Base.Extend.Page.SpinWebViewPage<MemberDocument>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\GeneralInformation.cshtml"
  
    string TypeClass = Model.TypeMember.ToString();

    if (Model is ClassDocument)
        TypeClass = (((ClassDocument)Model).IsAbstract) ? "Abstract Class" : "Class";


    if (Model.IsStatic)
        TypeClass = "Static";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"namespace\">\r\n    ");
#nullable restore
#line 17 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\GeneralInformation.cshtml"
Write(DocumentationLanguage.Namespace);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 17 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\GeneralInformation.cshtml"
                                 Write(Model.Namespace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"namespace\">\r\n    ");
#nullable restore
#line 20 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\GeneralInformation.cshtml"
Write(DocumentationLanguage.Assemblies);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 20 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\GeneralInformation.cshtml"
                                  Write(Model.TypeClass.Assembly.ManifestModule);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<h1 class=\"title\">\r\n    ");
#nullable restore
#line 23 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\GeneralInformation.cshtml"
Write(Model.FullName.Replace(",", ", "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 23 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\GeneralInformation.cshtml"
                                    Write(TypeClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n</h1>\r\n<div class=\"content-page\">\r\n    ");
#nullable restore
#line 26 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\GeneralInformation.cshtml"
Write(Model.GetTranslate(a => a.Summary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"content-page\">\r\n    ");
#nullable restore
#line 30 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\GeneralInformation.cshtml"
Write(Model.GetTranslate(a => a.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemberDocument> Html { get; private set; }
    }
}
#pragma warning restore 1591

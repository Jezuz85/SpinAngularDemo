#pragma checksum "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Email\Views\spin-sys\Home\ChangeStateSMS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c7d94adf1bec896e667aff7bd93e3b3d9dc1d6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Security_Email_Views_spin_sys_Home_ChangeStateSMS), @"mvc.1.0.view", @"/Spin/Module/Security/Email/Views/spin-sys/Home/ChangeStateSMS.cshtml")]
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
#line 1 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Email\Views\spin-sys\Home\ChangeStateSMS.cshtml"
using Spin.Security.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7d94adf1bec896e667aff7bd93e3b3d9dc1d6f", @"/Spin/Module/Security/Email/Views/spin-sys/Home/ChangeStateSMS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Security_Email_Views_spin_sys_Home_ChangeStateSMS : Spin.Base.Extend.Page.SpinWebViewPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Email\Views\spin-sys\Home\ChangeStateSMS.cshtml"
  
    SpinViewPage.IsLayout = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("Million AND UP\r\n");
#nullable restore
#line 7 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Email\Views\spin-sys\Home\ChangeStateSMS.cshtml"
Write(Model.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" changed status to  ");
#nullable restore
#line 7 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Email\Views\spin-sys\Home\ChangeStateSMS.cshtml"
                                 Write(Model.IsConnect?"Available":"Unavailable");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591

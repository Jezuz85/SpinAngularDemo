#pragma checksum "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13b666bd47ef01cdd6eb16d229ed6617b810d66a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Dashboard_Admin_Views_spin_sys_Home_Index), @"mvc.1.0.view", @"/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml")]
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
#line 2 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
using Spin.Modules.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13b666bd47ef01cdd6eb16d229ed6617b810d66a", @"/Spin/Module/Dashboard/Admin/Views/spin-sys/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Dashboard_Admin_Views_spin_sys_Home_Index : Spin.Base.Extend.Page.SpinWebViewPage<IEnumerable<Module>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
  
    SpinViewPage.AddStyle("/Spin/Module/Dashboard/Resource/spin-sys/css/Dashboard-home.css");
    SpinViewPage.AddStyle("/Spin/Module/Dashboard/Resource/spin-sys/css/Dashboard-home-media.css");


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row align-items-center content-module module-dashboard\"");
            BeginWriteAttribute("style", " style=\'", 328, "\'", 420, 3);
            WriteAttributeValue("", 336, "background-image:url(", 336, 21, true);
#nullable restore
#line 8 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
WriteAttributeValue("", 357, SpinViewPage.RelativePath("backend/background-backend.jpg"), 357, 62, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 419, ")", 419, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"col-12 content-dashboard\">\r\n");
#nullable restore
#line 10 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
         foreach (var ModuleData in Model)
    {
        string Path = (String.IsNullOrEmpty(ModuleData.InitPath)) ? $"/Admin/{ModuleData.Name}/Home/IndexGenerate" : ModuleData.InitPath;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"item-module\">\r\n\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 711, "\"", 723, 1);
#nullable restore
#line 16 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
WriteAttributeValue("", 718, Path, 718, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"content-img-item-module\">\r\n                    <img class=\"img-item-module\"");
            BeginWriteAttribute("src", " src=\"", 830, "\"", 876, 3);
            WriteAttributeValue("", 836, "/Spin/Module/", 836, 13, true);
#nullable restore
#line 18 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
WriteAttributeValue("", 849, ModuleData.Name, 849, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 867, "/Icon.png", 867, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 877, "\"", 899, 1);
#nullable restore
#line 18 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
WriteAttributeValue("", 883, ModuleData.Name, 883, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"text-item-module\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
                Write((String.IsNullOrEmpty(ModuleData.Alias)) ? ModuleData.Name : ModuleData.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"select-item-menu\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\'", 1175, "\'", 1226, 1);
#nullable restore
#line 24 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
WriteAttributeValue("", 1181, SpinViewPage.RelativePath("select-menu.png"), 1181, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n            </a>\r\n        </div>\r\n        <div class=\"division-dashboard\">\r\n            <img");
            BeginWriteAttribute("src", " src=\'", 1348, "\'", 1406, 1);
#nullable restore
#line 29 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
WriteAttributeValue("", 1354, SpinViewPage.RelativePath("division-dashboard.png"), 1354, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"footer-login\">\r\n    <div class=\"row\">\r\n        <div class=\"col\"></div>\r\n        <div class=\"col-12\">\r\n            <img");
            BeginWriteAttribute("src", " src=\'", 1581, "\'", 1653, 1);
#nullable restore
#line 38 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
WriteAttributeValue("", 1587, SpinViewPage.RelativePath("/backend/logo-footer-information.png"), 1587, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"icon-logo-information\" />\r\n            ");
#nullable restore
#line 39 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
       Write(CompanyFactory.Information.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VS ");
#nullable restore
#line 39 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
                                           Write(CompanyFactory.Information.Version);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 39 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
                                                                                 Write(CompanyFactory.Information.TypeVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral(") | © ");
#nullable restore
#line 39 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
                                                                                                                               Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Dashboard\Admin\Views\spin-sys\Home\Index.cshtml"
                                                                                                                                                  Write(CompanyFactory.Information.Copyright);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\"></div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Module>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "334a379e1bd7b6502609cec3d94915adb5a95745"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Util_Admin_Views_spin_sys_Configuration_Index), @"mvc.1.0.view", @"/Spin/Module/Util/Admin/Views/spin-sys/Configuration/Index.cshtml")]
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
#line 1 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
using Spin.Modules.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
using Spin.Modules.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
using Spin.WebSite.Spin.Module.Util.Language;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"334a379e1bd7b6502609cec3d94915adb5a95745", @"/Spin/Module/Util/Admin/Views/spin-sys/Configuration/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Util_Admin_Views_spin_sys_Configuration_Index : Spin.Base.Extend.Page.SpinWebViewPage<IEnumerable<ModuleConfiguration>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
  
    string ModuleName = ViewBag.NameModule;

    Module DataModule = (Module)ViewBag.Module;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"content-configuration\">\r\n    <div class=\"row content-title-configuration\">\r\n        <div class=\"col-9 line-division-title\">\r\n\r\n            <div class=\"configuration-name-module\">\r\n                ");
#nullable restore
#line 19 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
            Write((ModuleName == "") ? "General Configuration" : ModuleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-3\">\r\n            <div class=\"item-button\">\r\n\r\n                <div class=\"item-button-menu\">\r\n                    <a id=\"btnSaveConfiguration\"");
            BeginWriteAttribute("class", " class=\"", 724, "\"", 732, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <i class=""far fa-save""></i>
                    </a>
                </div>

            </div>
        </div>
    </div>

    <from id=""frmConfiguration"">
        <div class=""content-memu"">

            <div class=""panel-group"" id=""accordion"" role=""tablist"" aria-multiselectable=""true"">
");
#nullable restore
#line 39 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
                 foreach (var MenuContent in Model.GroupBy(a => a.GroupConfiguration))
                {
                    string NameGroup = (String.IsNullOrEmpty(MenuContent.Key)) ? "General" : MenuContent.Key;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card card-configuration\">\r\n                        <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\"", 1387, "\"", 1427, 2);
            WriteAttributeValue("", 1392, "heading", 1392, 7, true);
#nullable restore
#line 44 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
WriteAttributeValue("", 1399, NameGroup.Replace(" ",""), 1399, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h5 class=\"mb-0\">\r\n                                <button class=\"btn btn-link collapsed\" data-toggle=\"collapse\" data-target=\"#");
#nullable restore
#line 46 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
                                                                                                        Write(NameGroup.Replace(" ",""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1636, "\"", 1680, 1);
#nullable restore
#line 46 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
WriteAttributeValue("", 1652, NameGroup.Replace(" ",""), 1652, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i");
            BeginWriteAttribute("class", " class=\"", 1722, "\"", 1788, 1);
#nullable restore
#line 47 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
WriteAttributeValue("", 1730, IconsConfiguration.ResourceManager.GetString(NameGroup), 1730, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                    ");
#nullable restore
#line 48 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
                                Write(NameGroup);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </button>\r\n                            </h5>\r\n                        </div>\r\n\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 1986, "\"", 2019, 1);
#nullable restore
#line 53 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
WriteAttributeValue("", 1991, NameGroup.Replace(" ",""), 1991, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2037, "\"", 2083, 1);
#nullable restore
#line 53 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
WriteAttributeValue("", 2055, NameGroup.Replace(" ",""), 2055, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordion\">\r\n                            <div class=\"card-body\">\r\n                                <div class=\"content-row\">\r\n");
#nullable restore
#line 56 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
                                     foreach (var NameMenu in MenuContent.Select(a => a.Name).Distinct())
                                    {
                                        ModuleConfiguration ItemConfiguration = ModuleConfigurationFactory.GetGeneralConfiguration(NameMenu, ModuleName, this.SpinViewPage.Customer.Id, MenuContent.Key);


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"spin-item-form\">\r\n                                            <label>\r\n                                                ");
#nullable restore
#line 62 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
                                           Write(NameMenu.SplitCamelCase());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </label>\r\n                                            <div>\r\n                                                <input");
            BeginWriteAttribute("id", " id=\"", 2933, "\"", 2951, 2);
            WriteAttributeValue("", 2938, "id", 2938, 2, true);
#nullable restore
#line 65 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
WriteAttributeValue("", 2940, NameMenu, 2940, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("configuration-id", " configuration-id=\"", 2952, "\"", 2994, 1);
#nullable restore
#line 65 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
WriteAttributeValue("", 2971, ItemConfiguration.Id, 2971, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2995, "\"", 3015, 2);
            WriteAttributeValue("", 3002, "id", 3002, 2, true);
#nullable restore
#line 65 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
WriteAttributeValue("", 3004, NameMenu, 3004, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3028, "\"", 3062, 1);
#nullable restore
#line 65 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
WriteAttributeValue("", 3036, ItemConfiguration.Value, 3036, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"input-configuration\" />\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 68 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 73 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </from>\r\n\r\n</div>\r\n\r\n<!--Content-->\r\n<div id=\"loadingConfiguration\" class=\"content-loading-configuration\">\r\n\r\n    <div class=\"content-logo-configuration\">\r\n        <img class=\"img-configuration\"");
            BeginWriteAttribute("src", " src=\'", 3630, "\'", 3686, 1);
#nullable restore
#line 87 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Util\Admin\Views\spin-sys\Configuration\Index.cshtml"
WriteAttributeValue("", 3636, SpinViewPage.RelativePath("/backend/loading.gif"), 3636, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"loading png\" />\r\n        <div>Saving....</div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ModuleConfiguration>> Html { get; private set; }
    }
}
#pragma warning restore 1591
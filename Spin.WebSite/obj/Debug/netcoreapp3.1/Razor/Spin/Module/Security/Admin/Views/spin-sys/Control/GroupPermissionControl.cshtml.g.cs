#pragma checksum "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eae9108c741862706ab6e4c6c2b2e8b2311ba3ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Security_Admin_Views_spin_sys_Control_GroupPermissionControl), @"mvc.1.0.view", @"/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml")]
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
#line 1 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
using Spin.Modules.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
using Spin.Base.Generator;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eae9108c741862706ab6e4c6c2b2e8b2311ba3ae", @"/Spin/Module/Security/Admin/Views/spin-sys/Control/GroupPermissionControl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Security_Admin_Views_spin_sys_Control_GroupPermissionControl : Spin.Base.Extend.Page.SpinWebViewPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
  
    this.SpinViewPage.AddJavaScript("/Spin/Module/Security/Resource/spin-sys/js/ExtendGroup.js", false, false, 1);
    this.SpinViewPage.AddStyle("/Spin/Module/Security/Resource/spin-sys/css/GroupPermission.css");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""contentPermission"" class=""content-permission"">
    <div class=""row"">
        <div class=""col-2"">
            <button class=""btn-all-selected"" ng-click=""selectAllPermission()"">
                <i class=""fas fa-list-ul""></i>
                Select All
            </button>
        </div>
        <div class=""col-4"">

        </div>

    </div>
");
#nullable restore
#line 20 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
     foreach (var ModuleItem in ModuleFactory.Modules)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
         if (ModuleItem.Value.BackendContent != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row content-title-module\">\r\n                <div class=\"col-2\">\r\n                    <img class=\"logo-module-item\"");
            BeginWriteAttribute("src", " src=\"", 908, "\"", 953, 3);
            WriteAttributeValue("", 914, "/Spin/Module/", 914, 13, true);
#nullable restore
#line 26 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
WriteAttributeValue("", 927, ModuleItem.Key, 927, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 944, "/Icon.png", 944, 9, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    ");
#nullable restore
#line 27 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
               Write(ModuleItem.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""col-1 title-check-page"">
                    Show
                </div>
                <div class=""col-1 title-check-page"">
                    Edit
                </div>
                <div class=""col-1 title-check-page"">
                    Show Conf
                </div>
                <div class=""col-1 title-check-page"">
                    Show History
                </div>
            </div>
");
#nullable restore
#line 42 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"


            foreach (var Item in ModuleItem.Value.BackendContent.OrderBy(a => a.Value.Name))
            {
                string NameContent = ModuleItem.Key + "Admin" + Item.Value.NameController;
                IBackGeneratorController BakendData = System.Activator.CreateInstance(Item.Value.GenerateType) as IBackGeneratorController;

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
                 if (Item.Key.Length > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("id", " id=\"", 1903, "\"", 1922, 1);
#nullable restore
#line 51 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
WriteAttributeValue("", 1908, NameContent, 1908, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"row content-title-page\">\r\n                        <div class=\"col-2 title-page\">\r\n                            <input class=\"module\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2076, "\"", 2108, 1);
#nullable restore
#line 53 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
WriteAttributeValue("", 2084, ModuleItem.Value.Name, 2084, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <input class=\"controller\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2181, "\"", 2217, 1);
#nullable restore
#line 54 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
WriteAttributeValue("", 2189, Item.Value.NameController, 2189, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <input class=\"id\" type=\"hidden\" value=\"0\" />\r\n                            <input class=\"segment\" type=\"hidden\" value=\"Admin\" />\r\n\r\n                            <i");
            BeginWriteAttribute("class", " class=\"", 2412, "\"", 2472, 1);
#nullable restore
#line 58 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
WriteAttributeValue("", 2420, Item.Value.Logo.Equals("")?"nulo":Item.Value.Logo, 2420, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            ");
#nullable restore
#line 59 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
                       Write(Item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-1 check-page\">\r\n                            <input type=\"checkbox\" class=\"show-check\"");
            BeginWriteAttribute("ng-click", " ng-click=\"", 2676, "\"", 2717, 3);
            WriteAttributeValue("", 2687, "validateEdit(\'", 2687, 14, true);
#nullable restore
#line 62 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
WriteAttributeValue("", 2701, NameContent, 2701, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2715, "\')", 2715, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"col-1 check-page \">\r\n                            <input type=\"checkbox\" class=\"edit-check\"");
            BeginWriteAttribute("ng-click", " ng-click=\"", 2881, "\"", 2922, 3);
            WriteAttributeValue("", 2892, "validateShow(\'", 2892, 14, true);
#nullable restore
#line 65 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
WriteAttributeValue("", 2906, NameContent, 2906, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2920, "\')", 2920, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"col-1 check-page \">\r\n                            <input type=\"checkbox\" class=\"configuration-check\"");
            BeginWriteAttribute("ng-click", " ng-click=\"", 3095, "\"", 3145, 3);
            WriteAttributeValue("", 3106, "validateConfiguration(\'", 3106, 23, true);
#nullable restore
#line 68 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
WriteAttributeValue("", 3129, NameContent, 3129, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3143, "\')", 3143, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n\r\n");
#nullable restore
#line 71 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
                         if (BakendData.EntityType.GetInterface("IEntityHistory", false) != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-1 check-page text-center\">\r\n                                <input type=\"checkbox\" class=\"history-check\"");
            BeginWriteAttribute("ng-click", " ng-click=\"", 3459, "\"", 3503, 3);
            WriteAttributeValue("", 3470, "validateHistory(\'", 3470, 17, true);
#nullable restore
#line 74 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
WriteAttributeValue("", 3487, NameContent, 3487, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3501, "\')", 3501, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </div>\r\n");
#nullable restore
#line 76 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-1 check-page text-center history-no-check\">\r\n                                <div>X</div>\r\n                            </div>\r\n");
#nullable restore
#line 82 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 85 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
                 

            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Module\Security\Admin\Views\spin-sys\Control\GroupPermissionControl.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
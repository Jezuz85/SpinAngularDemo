#pragma checksum "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\RangeDateSpinFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04ff15ddebad27afd6c73213c57d5ab27a209569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Shared_spin_sys_Generator_Controls_RangeDateSpinFilter), @"mvc.1.0.view", @"/Spin/Shared/spin-sys/Generator/Controls/RangeDateSpinFilter.cshtml")]
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
#line 2 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\RangeDateSpinFilter.cshtml"
using Spin.Modules.Entity.Backend.Generator.Select;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04ff15ddebad27afd6c73213c57d5ab27a209569", @"/Spin/Shared/spin-sys/Generator/Controls/RangeDateSpinFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Shared_spin_sys_Generator_Controls_RangeDateSpinFilter : Spin.Base.Extend.Page.SpinWebViewPage<RangeDateSpinField>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<input");
            BeginWriteAttribute("id", " id=\'", 97, "\'", 115, 1);
#nullable restore
#line 7 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\RangeDateSpinFilter.cshtml"
WriteAttributeValue("", 102, Model.Name, 102, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" date-range-picker=\"dateRangeOptions\" search-value");
            BeginWriteAttribute("ng-model", " ng-model=\'", 166, "\'", 229, 2);
            WriteAttributeValue("", 177, "itemListFilter.", 177, 15, true);
#nullable restore
#line 7 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\RangeDateSpinFilter.cshtml"
WriteAttributeValue("", 192, Model.Name.FirstCharacterToLower(), 192, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", "  placeholder=\"", 230, "\"", 328, 1);
#nullable restore
#line 7 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Shared\spin-sys\Generator\Controls\RangeDateSpinFilter.cshtml"
WriteAttributeValue("", 245, !string.IsNullOrEmpty(Model.RemarkFilter)?Model.RemarkFilter:"Enter Keyword..." , 245, 83, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RangeDateSpinField> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "137963f857d55e51bf3caa542c6f657010f74e13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Themes_Shared_spin_sys_Generator_Controls_ImageSpinDetail), @"mvc.1.0.view", @"/Spin/Themes/Shared/spin-sys/Generator/Controls/ImageSpinDetail.cshtml")]
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
#line 2 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
using Spin.Modules.Entity.Backend.Generator.Detail;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"137963f857d55e51bf3caa542c6f657010f74e13", @"/Spin/Themes/Shared/spin-sys/Generator/Controls/ImageSpinDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Themes_Shared_spin_sys_Generator_Controls_ImageSpinDetail : Spin.Base.Extend.Page.SpinWebViewPage<ImageSpinField>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div");
            BeginWriteAttribute("id", " id=\'", 84, "\'", 112, 2);
            WriteAttributeValue("", 89, "contentImage", 89, 12, true);
#nullable restore
#line 6 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 101, Model.Id, 101, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" spin-upload-file");
            BeginWriteAttribute("ng-model", " ng-model=\"", 130, "\"", 159, 1);
#nullable restore
#line 6 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 141, Model.ModelName, 141, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\'", 160, "\'", 212, 3);
            WriteAttributeValue("", 168, "item-image-content", 168, 18, true);
            WriteAttributeValue(" ", 186, "load-files", 187, 11, true);
#nullable restore
#line 6 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue(" ", 197, Model.Style, 198, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("spin-accept", " spin-accept=\"", 213, "\"", 243, 1);
#nullable restore
#line 6 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 227, Model.Extension, 227, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("spin-typeload", " spin-typeload=\"", 244, "\"", 275, 1);
#nullable restore
#line 6 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 260, Model.TypeName, 260, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("spin-namefile", " spin-namefile=\"", 276, "\"", 292, 0);
            EndWriteAttribute();
            WriteLiteral(" spin-randomname=\"true\"");
            BeginWriteAttribute("spin-outData", " spin-outData=\"", 316, "\"", 349, 1);
#nullable restore
#line 6 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 331, Model.ModelName, 331, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" spin-multipleFile=\"false\">\n\n    <input");
            BeginWriteAttribute("id", " id=\'", 389, "\'", 415, 2);
            WriteAttributeValue("", 394, "inputImage", 394, 10, true);
#nullable restore
#line 8 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 404, Model.Id, 404, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"uploadInput\" type=\"file\" />\n    <div class=\"row no-gutters\">\n        <div class=\"col-12 col-sm-5 col-md-5 col-lg-5 col-xl-5\" >\n            <div");
            BeginWriteAttribute("id", " id=\'", 567, "\'", 588, 2);
            WriteAttributeValue("", 572, "image", 572, 5, true);
#nullable restore
#line 11 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 577, Model.Id, 577, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\'content-image\'>\r\n                <img src=\'/img/noImage.png\' class=\'item-image-field\'");
            BeginWriteAttribute("ng-src", " ng-src=\"", 682, "\"", 724, 5);
            WriteAttributeValue("", 691, "{{", 691, 2, true);
#nullable restore
#line 12 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 693, Model.ModelName, 693, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 711, "||", 712, 3, true);
            WriteAttributeValue(" ", 714, "\'//:0\'", 715, 7, true);
            WriteAttributeValue(" ", 721, "}}", 722, 3, true);
            EndWriteAttribute();
            WriteLiteral(" err-src=\"{{\'/img/noImage.png\'}}\" />\r\n            </div>\n        </div>\r\n        <div class=\"col-12 content-image-loading\">\r\n            <div");
            BeginWriteAttribute("id", " id=\'", 866, "\'", 889, 2);
            WriteAttributeValue("", 871, "loading", 871, 7, true);
#nullable restore
#line 16 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 878, Model.Id, 878, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\'", 890, "\'", 898, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img class=\"img-image-loading\"");
            BeginWriteAttribute("src", " src=\"", 948, "\"", 1002, 1);
#nullable restore
#line 17 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 954, SpinViewPage.RelativePath("loadingImage.gif"), 954, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <div class=\"text-image-loading\">\r\n                    0%\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-12 col-sm-7 col-md-7 col-lg-7 col-xl-7\">\n            <div");
            BeginWriteAttribute("class", " class=\'", 1223, "\'", 1231, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <button");
            BeginWriteAttribute("id", " id=\'", 1258, "\'", 1285, 2);
            WriteAttributeValue("", 1263, "uploadImage", 1263, 11, true);
#nullable restore
#line 25 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 1274, Model.Id, 1274, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"uploadImage\" type=\'button\'>\r\n                    <i class=\"fas fa-plus-circle\"></i>\r\n                    Upload Image\r\n                </button>\r\n                <button");
            BeginWriteAttribute("id", " id=\'", 1463, "\'", 1490, 2);
            WriteAttributeValue("", 1468, "deleteImage", 1468, 11, true);
#nullable restore
#line 29 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 1479, Model.Id, 1479, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"deleteImage\"  type=\'button\'");
            BeginWriteAttribute("ng-if", " ng-if=\'", 1526, "\'", 1630, 12);
#nullable restore
#line 29 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 1534, Model.ModelName, 1534, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1552, ".trim()", 1552, 7, true);
            WriteAttributeValue(" ", 1559, "!=", 1560, 3, true);
            WriteAttributeValue(" ", 1562, "\"\"", 1563, 3, true);
            WriteAttributeValue(" ", 1565, "&&", 1566, 3, true);
#nullable restore
#line 29 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue(" ", 1568, Model.ModelName, 1569, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1587, "!=", 1588, 3, true);
            WriteAttributeValue(" ", 1590, "null", 1591, 5, true);
            WriteAttributeValue(" ", 1595, "&&", 1596, 3, true);
#nullable restore
#line 29 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue(" ", 1598, Model.ModelName, 1599, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1617, "!=", 1618, 3, true);
            WriteAttributeValue(" ", 1620, "undefined", 1621, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("ng-click", " ng-click=\"", 1631, "\"", 1674, 3);
            WriteAttributeValue("", 1642, "deleteFile(\'", 1642, 12, true);
#nullable restore
#line 29 "C:\Users\User\Downloads\demo angular\angular10\Spin.WebSite\Spin\Themes\Shared\spin-sys\Generator\Controls\ImageSpinDetail.cshtml"
WriteAttributeValue("", 1654, Model.ModelName, 1654, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1672, "\')", 1672, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\'far fa-trash-alt\' aria-hidden=\'true\'></i>\r\n                    Delete Image\r\n                </button>\r\n            </div>\n        </div>\r\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImageSpinField> Html { get; private set; }
    }
}
#pragma warning restore 1591

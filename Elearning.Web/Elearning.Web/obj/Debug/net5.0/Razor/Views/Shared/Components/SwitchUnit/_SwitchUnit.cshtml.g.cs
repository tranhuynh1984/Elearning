#pragma checksum "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\Shared\Components\SwitchUnit\_SwitchUnit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5011d4190cfb1782500522e265a755cf0078aec0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SwitchUnit__SwitchUnit), @"mvc.1.0.view", @"/Views/Shared/Components/SwitchUnit/_SwitchUnit.cshtml")]
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
#line 1 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\_ViewImports.cshtml"
using Elearning.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\_ViewImports.cshtml"
using Elearning.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5011d4190cfb1782500522e265a755cf0078aec0", @"/Views/Shared/Components/SwitchUnit/_SwitchUnit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"524680586284a3e5ee193eb36d5b0437f597edfa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SwitchUnit__SwitchUnit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Elearning.Web.Models.Users.UserConcurrentlyModel>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\Shared\Components\SwitchUnit\_SwitchUnit.cshtml"
 if (Model != null && Model.AnyConcurrently)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <li class=""nav-item"">
        <div class=""form-group"">
            <div class=""spinner-border spinner-border-sm mt-2 d-none"" role=""status"" style="" vertical-align: bottom;"">
                <span class=""sr-only""></span>
            </div>
            <i class=""far fa-university"" style=""float: left;vertical-align: bottom; font-size: 19px; line-height: calc(2.25rem + 2px);"" title=""Chuyển đơn vị""></i>
            <select id=""swichingUnit"" class=""custom-select form-control-border form-control-sm d-inline-block""
                    style=""float: left; width: auto; vertical-align: middle"">
");
#nullable restore
#line 12 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\Shared\Components\SwitchUnit\_SwitchUnit.cshtml"
                 foreach (var c in Model.UserConcurrently)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5011d4190cfb1782500522e265a755cf0078aec04488", async() => {
#nullable restore
#line 14 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\Shared\Components\SwitchUnit\_SwitchUnit.cshtml"
                                                                     Write($"{c.UnitName}");

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\Shared\Components\SwitchUnit\_SwitchUnit.cshtml"
                        WriteLiteral(c.UnitCode);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\Shared\Components\SwitchUnit\_SwitchUnit.cshtml"
AddHtmlAttributeValue("", 847, c.Selected, 847, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\Shared\Components\SwitchUnit\_SwitchUnit.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n    </li>\r\n");
#nullable restore
#line 19 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\Shared\Components\SwitchUnit\_SwitchUnit.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Elearning.Web.Models.Users.UserConcurrentlyModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

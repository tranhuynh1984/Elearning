#pragma checksum "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c920dfbd0b6849b053a974fb7c3cfb5787bbfed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DMChucDanh_Create), @"mvc.1.0.view", @"/Views/DMChucDanh/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c920dfbd0b6849b053a974fb7c3cfb5787bbfed", @"/Views/DMChucDanh/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"524680586284a3e5ee193eb36d5b0437f597edfa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DMChucDanh_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Elearning.Core.DTO.Response.DM.DMSearchResponseData>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
  
    string viewMode = ViewBag.ViewMode ?? string.Empty;
    string display = Model == null ? "Th??m m???i ch???c danh" : ViewBag.ViewMode == "view" ? "Th??ng tin ch???c danh" : "Ch???nh s???a th??ng tin ch???c danh";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <input type=\"hidden\" id=\"___record\"");
            BeginWriteAttribute("value", " value=\"", 329, "\"", 351, 1);
#nullable restore
#line 7 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
WriteAttributeValue("", 337, Model?.MaDM, 337, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card\">\r\n\r\n            <div class=\"card-body\">\r\n                \r\n");
#nullable restore
#line 13 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
                 if (viewMode.Equals("view"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""dmchucdanh"">M?? ch???c danh</label>
                                <input id=""txtmachucdanh""");
            BeginWriteAttribute("value", " value=\"", 813, "\"", 835, 1);
#nullable restore
#line 19 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
WriteAttributeValue("", 821, Model?.MaDM, 821, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control form-control-sm"" disabled />
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""dmchucdanh"">T??n ch???c danh</label>
                                <input id=""txttenchucdanh""");
            BeginWriteAttribute("value", " value=\"", 1194, "\"", 1217, 1);
#nullable restore
#line 25 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
WriteAttributeValue("", 1202, Model?.TenDM, 1202, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control form-control-sm"" disabled />
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Tr???ng th??i:</label>
                                <div class=""input-group"">
                                    <select class=""form-control form-control-sm"" id=""ddlStatuschucdanh"" disabled>
");
#nullable restore
#line 33 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
                                         if(Model?.IsActive== 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c920dfbd0b6849b053a974fb7c3cfb5787bbfed7194", async() => {
                WriteLiteral("V?? hi???u");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c920dfbd0b6849b053a974fb7c3cfb5787bbfed8709", async() => {
                WriteLiteral("K??ch ho???t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c920dfbd0b6849b053a974fb7c3cfb5787bbfed10245", async() => {
                WriteLiteral("V?? hi???u");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c920dfbd0b6849b053a974fb7c3cfb5787bbfed11450", async() => {
                WriteLiteral("K??ch ho???t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 42 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </select>
                                </div>
                            
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Th???i gian t???o</label>
                                <input class=""form-control form-control-sm""");
            BeginWriteAttribute("value", " value=\'", 2724, "\'", 2781, 1);
#nullable restore
#line 51 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
WriteAttributeValue("", 2732, Model?.Createdate.ToString("dd/MM/yyyy HH:mm"), 2732, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled />
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Th??? t???:</label>
                                <input");
            BeginWriteAttribute("value", " value=\"", 3060, "\"", 3081, 1);
#nullable restore
#line 57 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
WriteAttributeValue("", 3068, Model?.Stt, 3068, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control form-control-sm\"");
            BeginWriteAttribute("disabled", " disabled=\"", 3119, "\"", 3157, 1);
#nullable restore
#line 57 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
WriteAttributeValue("", 3130, viewMode .Equals("view"), 3130, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" maxlength=""4""/>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Th???i gian s???a</label>
                                <input class=""form-control form-control-sm""");
            BeginWriteAttribute("value", " value=\'", 3495, "\'", 3553, 1);
#nullable restore
#line 63 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
WriteAttributeValue("", 3503, Model?.Updatedate?.ToString("dd/MM/yyyy HH:mm"), 3503, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 67 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""dmdoituong"">M?? Ch???c Danh</label><label class=""labelrequired"">*</label>
");
#nullable restore
#line 74 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
                                 if(String.IsNullOrEmpty(Model?.MaDM))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input id=\"txtmachucdanh\"");
            BeginWriteAttribute("value", " value=\"", 4149, "\"", 4157, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control form-control-sm\"");
            BeginWriteAttribute("disabled", " disabled=\"", 4195, "\"", 4233, 1);
#nullable restore
#line 76 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
WriteAttributeValue("", 4206, viewMode .Equals("view"), 4206, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" maxlength=\"10\" />\r\n");
#nullable restore
#line 77 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input id=\"txtmachucdanh\"");
            BeginWriteAttribute("value", " value=\"", 4423, "\"", 4445, 1);
#nullable restore
#line 80 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
WriteAttributeValue("", 4431, Model?.MaDM, 4431, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly=\"readonly\"  class=\"form-control form-control-sm\"");
            BeginWriteAttribute("disabled", " disabled=\"", 4504, "\"", 4542, 1);
#nullable restore
#line 80 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
WriteAttributeValue("", 4515, viewMode .Equals("view"), 4515, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" maxlength=\"10\" />\r\n");
#nullable restore
#line 81 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""dmchucdanh"">T??n Ch???c Danh</label><label class=""labelrequired"">*</label>
                                <input id=""txttenchucdanh""");
            BeginWriteAttribute("value", " value=\"", 4943, "\"", 4966, 1);
#nullable restore
#line 87 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
WriteAttributeValue("", 4951, Model?.TenDM, 4951, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control form-control-sm"" maxlength=""200""/>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Tr???ng th??i:</label>
                                <div class=""input-group"">
                                    <select class=""form-control form-control-sm"" id=""ddlStatuschucdanh"">
");
#nullable restore
#line 95 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
                                         if(Model?.IsActive== 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c920dfbd0b6849b053a974fb7c3cfb5787bbfed20441", async() => {
                WriteLiteral("V?? hi???u");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c920dfbd0b6849b053a974fb7c3cfb5787bbfed21957", async() => {
                WriteLiteral("K??ch ho???t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 99 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c920dfbd0b6849b053a974fb7c3cfb5787bbfed23494", async() => {
                WriteLiteral("V?? hi???u");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c920dfbd0b6849b053a974fb7c3cfb5787bbfed24699", async() => {
                WriteLiteral("K??ch ho???t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 104 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </select>
                                </div>
                            
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Th??? t???:</label><label class=""labelrequired"">*</label>
                                <input id=""txtstt""");
            BeginWriteAttribute("value", " value=\"", 6477, "\"", 6536, 1);
#nullable restore
#line 113 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
WriteAttributeValue("", 6485, Model?.MaDM == null ? Model?.MaxStt : Model?.Stt, 6485, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control form-control-sm\"");
            BeginWriteAttribute("disabled", " disabled=\"", 6574, "\"", 6612, 1);
#nullable restore
#line 113 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
WriteAttributeValue("", 6585, viewMode .Equals("view"), 6585, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" oninput=\"this.value=this.value.replace(/\\D/g,\'\').replace(/^0+(?=\\d)/,\'\')\" maxlength=\"4\"/>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 117 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\DMChucDanh\Create.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $(""#txtmachucdanh"").change(function () {
        $(""#txtmachucdanh"").removeClass('itemerror');
    });
    $(""#txttenchucdanh"").change(function () {
        $(""#txttenchucdanh"").removeClass('itemerror');
    });
    $(""#txtstt"").change(function () {
        $(""#txtstt"").removeClass('itemerror');
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Elearning.Core.DTO.Response.DM.DMSearchResponseData> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

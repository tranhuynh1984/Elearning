#pragma checksum "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "983867cc78a9a78da8609739526e714358ddb72e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CashFollow__ViewHistory), @"mvc.1.0.view", @"/Views/CashFollow/_ViewHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983867cc78a9a78da8609739526e714358ddb72e", @"/Views/CashFollow/_ViewHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"524680586284a3e5ee193eb36d5b0437f597edfa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CashFollow__ViewHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Elearning.Core.DTO.Response.CostEstimate.CostEstimateLogResponse>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\" id=\"viewHistories\">\r\n    <div class=\"col-12 col-sm-12\">\r\n");
#nullable restore
#line 5 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"
          
            if (Model.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-12 text-right mb-2"">
                    <a class=""badge badge-success p-2 fs-90"" href=""#"" onclick=""costJsBase.HistoriesFilter('all');"">
                        Tất cả
                    </a>
                    <a class=""badge badge-success p-2 fs-90"" href=""#"" onclick=""costJsBase.HistoriesFilter('approval');"">
                        <i class=""fad fa-check mr-1""></i> Đã duyệt
                    </a>
                    <a class=""badge badge-danger p-2 fs-90"" href=""#"" onclick=""costJsBase.HistoriesFilter('decline');"">
                        <i class=""fad fa-times mr-1""></i> Từ chối
                    </a>
                </div>
");
#nullable restore
#line 19 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"

                foreach (var costEstimateItemLogResponse in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"timeline\"");
            BeginWriteAttribute("prop-stats", " prop-stats=\"", 1032, "\"", 1128, 1);
#nullable restore
#line 22 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"
WriteAttributeValue("", 1045, string.IsNullOrEmpty(costEstimateItemLogResponse.Reason) ? "approval": "decline", 1045, 83, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div>\r\n");
            WriteLiteral("                            <div class=\"timeline-item\">\r\n                                <span class=\"time\" style=\"font-size: 0.9rem\"><i class=\"fas fa-clock\"></i> ");
#nullable restore
#line 27 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"
                                                                                                      Write(costEstimateItemLogResponse.TimeChange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <h3 class=\"timeline-header\"><a class=\"blue-color\" onclick=\"javascript: void (0);\">");
#nullable restore
#line 28 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"
                                                                                                              Write(costEstimateItemLogResponse.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <div class=\"timeline-body\">\r\n                                    <b class=\"blue-color font-weight-bold\">Người duyệt:</b> ");
#nullable restore
#line 30 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"
                                                                                        Write(costEstimateItemLogResponse.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                    <b class=\"blue-color font-italic\">Chức vụ:</b> ");
#nullable restore
#line 31 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"
                                                                               Write(costEstimateItemLogResponse.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                    <b class=\"blue-color font-italic\">Trạng thái:</b> <span");
            BeginWriteAttribute("class", " class=\"", 2111, "\"", 2210, 1);
#nullable restore
#line 32 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"
WriteAttributeValue("", 2119, string.IsNullOrEmpty(costEstimateItemLogResponse.Reason) ? "text-success": "text-danger", 2119, 91, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"
                                                                                                                                                                                            Write(costEstimateItemLogResponse.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n\r\n");
#nullable restore
#line 34 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"
                                     if (!string.IsNullOrEmpty(costEstimateItemLogResponse.Reason))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <b>Lý do:</b><br />\r\n");
#nullable restore
#line 37 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"
                                    Write(costEstimateItemLogResponse.Reason);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"
                                                                             
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 43 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-center\"");
            BeginWriteAttribute("style", "\r\n           style=\"", 2797, "\"", 2863, 2);
            WriteAttributeValue("", 2817, "display:", 2817, 8, true);
#nullable restore
#line 47 "D:\Elearning\Elearning.Web\Elearning.Web\Elearning.Web\Views\CashFollow\_ViewHistory.cshtml"
WriteAttributeValue(" ", 2825, Model.Count > 0 ? "none" : "block", 2826, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            Chưa có lịch sử phê duyệt!\r\n        </p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Elearning.Core.DTO.Response.CostEstimate.CostEstimateLogResponse>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

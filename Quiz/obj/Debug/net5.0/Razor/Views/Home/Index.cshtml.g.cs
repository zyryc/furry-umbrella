#pragma checksum "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a94c43b4e1e826f2a7c713282e348c8d761c8ccb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/_ViewImports.cshtml"
using MyQuiz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/_ViewImports.cshtml"
using MyQuiz.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a94c43b4e1e826f2a7c713282e348c8d761c8ccb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18d6199b56dd1beece38483cfa1ec1f10f4afe34", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyQuiz.Models.QuizVewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Answers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to Knowledge Test</h1>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"m-md-4\">\r\n\r\n");
#nullable restore
#line 13 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
         foreach (var item in Model.Questions)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card border-primary mb-3\" style=\"width: 60rem;\">\r\n                <div class=\"card-header border-primary\">\r\n                    <h6 class=\"card-title\">Question No. ");
#nullable restore
#line 17 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
                                                   Write(item.SerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <p class=\"card-text text-break\">");
#nullable restore
#line 18 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
                                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
                <div class=""card-body"">
                    <ul class=""list-group list-group-flush"">
                        <li class=""list-group-item"">
                            <label>
                                <input class=""radio"" type=""radio"" name=""rdbOption"" data-answer=""");
#nullable restore
#line 24 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
                                                                                           Write(item.Option1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("id", " id=", 899, "", 911, 1);
#nullable restore
#line 24 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
WriteAttributeValue("", 903, item.Id, 903, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"true\" />\r\n                                ");
#nullable restore
#line 25 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
                           Write(item.Option1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </label>\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n\r\n                            <label>\r\n                                <input class=\"radio\" type=\"radio\" data-answer=\"");
#nullable restore
#line 31 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
                                                                          Write(item.Option2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"rdbOption\"");
            BeginWriteAttribute("id", " id=", 1248, "", 1260, 1);
#nullable restore
#line 31 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
WriteAttributeValue("", 1252, item.Id, 1252, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"false\" />\r\n                                ");
#nullable restore
#line 32 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
                           Write(item.Option2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </label>\r\n\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            <label>\r\n                                <input class=\"radio\" type=\"radio\" data-answer=\"");
#nullable restore
#line 38 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
                                                                          Write(item.Option3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"rdbOption\"");
            BeginWriteAttribute("id", " id=", 1598, "", 1610, 1);
#nullable restore
#line 38 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
WriteAttributeValue("", 1602, item.Id, 1602, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"false\" />\r\n                                ");
#nullable restore
#line 39 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
                           Write(item.Option3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </label>\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            <label>\r\n                                <input class=\"radio\" type=\"radio\" data-answer=\"");
#nullable restore
#line 44 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
                                                                          Write(item.Option4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"rdbOption\"");
            BeginWriteAttribute("id", " id=", 1946, "", 1958, 1);
#nullable restore
#line 44 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
WriteAttributeValue("", 1950, item.Id, 1950, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"false\" />\r\n                                ");
#nullable restore
#line 45 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
                           Write(item.Option4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </label>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"card-footer border-primary\">\r\n\r\n");
#nullable restore
#line 52 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
                      
                        var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
                        var nextDisabled = !Model.HasNextPage ? "disabled" : "";
                        var submittDisabled = !Model.HasNextPage ? "" : "disabled";
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    \r\n\r\n<br>                      \r\n<br>                      \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a94c43b4e1e826f2a7c713282e348c8d761c8ccb10765", async() => {
                WriteLiteral("\r\n                        <input type=\"text\"");
                BeginWriteAttribute("hidden", " hidden=\"", 2678, "\"", 2687, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"question_id\"");
                BeginWriteAttribute("id", " id=\"", 2707, "\"", 2712, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2713, "\"", 2729, 1);
#nullable restore
#line 63 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
WriteAttributeValue("", 2721, item.Id, 2721, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"text\"");
                BeginWriteAttribute("hidden", " hidden=\"", 2775, "\"", 2784, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"answer\" id=\"answer\">\r\n                        <input type=\"text\"");
                BeginWriteAttribute("hidden", " hidden=\"", 2856, "\"", 2865, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"next\" id=\"next\"");
                BeginWriteAttribute("value", " value=\"", 2888, "\"", 2918, 1);
#nullable restore
#line 65 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
WriteAttributeValue("", 2896, Model.PageIndex + 1, 2896, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"text\"");
                BeginWriteAttribute("hidden", " hidden=\"", 2964, "\"", 2973, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"correctANser\"");
                BeginWriteAttribute("id", " id=\"", 2994, "\"", 2999, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3000, "\"", 3020, 1);
#nullable restore
#line 66 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
WriteAttributeValue("", 3008, item.Answer, 3008, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a94c43b4e1e826f2a7c713282e348c8d761c8ccb13254", async() => {
                    WriteLiteral("Previous");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
                                                     WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3143, "btn", 3143, 3, true);
                AddHtmlAttributeValue(" ", 3146, "btn-primary", 3147, 12, true);
#nullable restore
#line 68 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
AddHtmlAttributeValue(" ", 3158, prevDisabled, 3159, 13, false);

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
                WriteLiteral("\r\n                       <button type=\"submit\" id=\"submit_button\" class=\"btn btn-primary\">Next</button>\r\n                       ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 73 "/home/danruiyot/Documents/gigs/kim/asp/Quiz/Quiz/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            if ($(""#next"").val() >10) {
                $(""#submit"").html(""Submit"");
            }
		$('#qustion_id').val($(""#question"").data(""qid""));
            $('.radio').change(function () {
                console.log(""changed"");
                if( $(this).is("":checked"") ){
                    
                    console.log($(this).data(""answer""));
                    
                    $('#answer').val($(this).data(""answer""));
                    
                }
            })

        });


    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyQuiz.Models.QuizVewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fb313dc8c35e2389c2a61a3cfd0854b0dfdecea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Parallax_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Parallax/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminPanel/Views/Parallax/Index.cshtml", typeof(AspNetCore.Areas_AdminPanel_Views_Parallax_Index))]
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
#line 1 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Final_Projectt.Models;

#line default
#line hidden
#line 2 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Final_Projectt.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb313dc8c35e2389c2a61a3cfd0854b0dfdecea", @"/Areas/AdminPanel/Views/Parallax/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d8ba71763a6b6623f284227857fa6a3b4439634", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Parallax_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Parallax>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Yenilə"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left: 40px;margin-left: 12px;width: 117px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(71, 284, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header card-header-rose card-header-icon"">
                </div>
                <div class=""offset-md-10 col-md-2 col-sm-5"">
");
            EndContext();
#line 13 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                     foreach (var paralla in Model)
                    {

#line default
#line hidden
            BeginContext(431, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(455, 260, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "122af19e0a594de3a494a10010003674", async() => {
                BeginContext(603, 108, true);
                WriteLiteral("\r\n                            <i class=\"fas fa-edit\" style=\"font-size: 22px;\"></i>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                                 WriteLiteral(paralla.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(715, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(740, 634, true);
            WriteLiteral(@"                    </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th class=""text-center"">№</th>
                                    <th>Image</th>
                                    <th>Title</th>
                                    <th>Description</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 33 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                  
                                    int count = 0;

                                

#line default
#line hidden
            BeginContext(1499, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                 foreach (var parallax in Model)
                                {
                                    count++;

#line default
#line hidden
            BeginContext(1648, 106, true);
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"text-center\">");
            EndContext();
            BeginContext(1755, 5, false);
#line 42 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                                           Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1760, 97, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(1857, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2804b2fa185d4252b70aa378230ed408", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1867, "~/img/", 1867, 6, true);
#line 44 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
AddHtmlAttributeValue("", 1873, parallax.Image, 1873, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1921, 95, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
            EndContext();
#line 47 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                             if (parallax.Title1.Length > 30)
                                            {
                                                

#line default
#line hidden
            BeginContext(2191, 50, false);
#line 49 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                           Write(Html.Raw(parallax.Title1.Substring(0, 30) + "..."));

#line default
#line hidden
            EndContext();
#line 49 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                                                                                   
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
            BeginContext(2436, 25, false);
#line 53 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                           Write(Html.Raw(parallax.Title1));

#line default
#line hidden
            EndContext();
#line 53 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                                                          
                                            }

#line default
#line hidden
            BeginContext(2510, 93, true);
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n");
            EndContext();
#line 57 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                             if (parallax.Title2.Length > 30)
                                            {
                                                

#line default
#line hidden
            BeginContext(2778, 50, false);
#line 59 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                           Write(Html.Raw(parallax.Title2.Substring(0, 30) + "..."));

#line default
#line hidden
            EndContext();
#line 59 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                                                                                   
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
            BeginContext(3023, 25, false);
#line 63 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                           Write(Html.Raw(parallax.Title2));

#line default
#line hidden
            EndContext();
#line 63 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                                                          
                                            }

#line default
#line hidden
            BeginContext(3097, 90, true);
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 67 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Areas\AdminPanel\Views\Parallax\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3222, 182, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Parallax>> Html { get; private set; }
    }
}
#pragma warning restore 1591

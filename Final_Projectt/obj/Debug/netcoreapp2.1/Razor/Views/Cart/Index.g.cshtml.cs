#pragma checksum "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edf4f6a1a3ba99a19270b231aac889cdd070725f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 1 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\_ViewImports.cshtml"
using Final_Projectt.Models;

#line default
#line hidden
#line 2 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\_ViewImports.cshtml"
using Final_Projectt.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf4f6a1a3ba99a19270b231aac889cdd070725f", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d8ba71763a6b6623f284227857fa6a3b4439634", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasketProduct>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:90px !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
 if (Model.ToList().Count == 0)
{

#line default
#line hidden
            BeginContext(114, 178, true);
            WriteLiteral("    <div class=\"alert alert-danger\" style=\"height:200px;margin-top:15px;\"> \r\n        <p style=\"font-size: 35px;padding-top: 54px;color:#232F3E\">Səbətiniz boşdur</p>\r\n    </div>\r\n");
            EndContext();
#line 11 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(304, 1660, true);
            WriteLiteral(@"    <!-- breadcrumb-area start -->
    <div class=""breadcrumb-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <ul class=""breadcrumb-list"">
                        <li class=""breadcrumb-item""><a href=""index.html"">Əsas səhifə</a></li>
                        <li class=""breadcrumb-item active""><i class=""fas fa-chevron-right""></i> Səbət</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb-area end -->
    <!-- content-wraper start -->
    <div class=""content-wraper bg-gray"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""cart-table mt-60"">
                        <div class=""table-content table-responsive"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                           ");
            WriteLiteral(@"             <th class=""plantmore-product-remove"">sil</th>
                                        <th class=""plantmore-product-thumbnail"">şəkil</th>
                                        <th class=""cart-product-name"">məhsul</th>
                                        <th class=""plantmore-product-price"">tək qiymət</th>
                                        <th class=""plantmore-product-quantity"">sayı</th>
                                        <th class=""plantmore-product-subtotal"">toplam</th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 47 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
                                     foreach (var product in Model)
                                    {

#line default
#line hidden
            BeginContext(2072, 129, true);
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"plantmore-product-remove\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2201, "\"", 2232, 2);
            WriteAttributeValue("", 2208, "/Cart/Remove/", 2208, 13, true);
#line 50 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2221, product.Id, 2221, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2233, 123, true);
            WriteLiteral("><i class=\"fa fa-times\"></i></a></td>\r\n                                            <td class=\"plantmore-product-thumbnail\">");
            EndContext();
            BeginContext(2356, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d2c0a4a9ec6e4f1a875953be32985622", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2366, "~/img/", 2366, 6, true);
#line 51 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 2372, product.Image, 2372, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2419, 86, true);
            WriteLiteral("</td>\r\n                                            <td class=\"plantmore-product-name\">");
            EndContext();
            BeginContext(2506, 22, false);
#line 52 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
                                                                          Write(Html.Raw(product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2528, 160, true);
            WriteLiteral("</td>\r\n                                            <td class=\"plantmore-product-price\">\r\n                                                <span class=\"amount\">\r\n");
            EndContext();
#line 55 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
                                                     if (product.Discount != null && product.Discount.Value != 0)
                                                    {

#line default
#line hidden
            BeginContext(2858, 124, true);
            WriteLiteral("                                                        <span>\r\n                                                            ");
            EndContext();
            BeginContext(2984, 75, false);
#line 58 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
                                                        Write((product.Price - (product.Price * product.Discount) / 100)*product.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3060, 69, true);
            WriteLiteral(" ₼\r\n                                                        </span>\r\n");
            EndContext();
#line 60 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(3297, 62, true);
            WriteLiteral("                                                        <span>");
            EndContext();
            BeginContext(3360, 13, false);
#line 63 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
                                                         Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3373, 11, true);
            WriteLiteral(" ₼</span>\r\n");
            EndContext();
#line 64 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(3439, 241, true);
            WriteLiteral("                                                </span>\r\n                                            </td>\r\n                                            <td class=\"plantmore-product-quantity\">\r\n                                                ");
            EndContext();
            BeginContext(3681, 16, false);
#line 68 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
                                           Write(product.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3697, 217, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"product-subtotal\"><span class=\"amount\">70.00 Azn</span></td>\r\n                                        </tr>\r\n");
            EndContext();
#line 72 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3953, 892, true);
            WriteLiteral(@"
                                </tbody>
                            </table>
                        </div>

                        <div class=""row"">
                            <div class=""col-md-5 ml-auto"">
                                <div class=""cart-page-total"">
                                    <h2>Toplam</h2>
                                    <ul>
                                        <li>Cəm <span>170.00 Azn</span></li>
                                        <li>Ümumi <span>170.00 Azn</span></li>
                                    </ul>
                                    <a href=""#"">Sifarişi tamamlayın</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- content-wraper end -->
");
            EndContext();
#line 96 "C:\Users\Code Academy\Desktop\Final_Projectt\Final_Projectt\Views\Cart\Index.cshtml"

}

#line default
#line hidden
            BeginContext(4850, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasketProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591

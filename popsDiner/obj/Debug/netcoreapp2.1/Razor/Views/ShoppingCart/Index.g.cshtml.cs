#pragma checksum "C:\Users\nares\Desktop\Azure\pops Dinner\popsDiner\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9320d12e050642d735f3f646c961422967b72734"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShoppingCart/Index.cshtml", typeof(AspNetCore.Views_ShoppingCart_Index))]
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
#line 1 "C:\Users\nares\Desktop\Azure\pops Dinner\popsDiner\Views\_ViewImports.cshtml"
using popsDiner.Models;

#line default
#line hidden
#line 2 "C:\Users\nares\Desktop\Azure\pops Dinner\popsDiner\Views\_ViewImports.cshtml"
using popsDiner.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9320d12e050642d735f3f646c961422967b72734", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e02d66c8b328b4de4dde81f8fb802aa25fca2623", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(31, 375, true);
            WriteLiteral(@"
<h2>Your shopping cart</h2>
<h4>Here are the delicious items in your shopping cart.</h4>
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Selected amount</th>
            <th>Item</th>
            <th class=""text-right"">Price</th>
            <th class=""text-right"">Subtotal</th>
           
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 17 "C:\Users\nares\Desktop\Azure\pops Dinner\popsDiner\Views\ShoppingCart\Index.cshtml"
         foreach (var line in Model.ShoppingCart.ShoppingCartItems)
        {

#line default
#line hidden
            BeginContext(484, 57, true);
            WriteLiteral("            <tr>\n                <td class=\"text-center\">");
            EndContext();
            BeginContext(542, 11, false);
#line 20 "C:\Users\nares\Desktop\Azure\pops Dinner\popsDiner\Views\ShoppingCart\Index.cshtml"
                                   Write(line.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(553, 44, true);
            WriteLiteral("</td>\n                <td class=\"text-left\">");
            EndContext();
            BeginContext(598, 14, false);
#line 21 "C:\Users\nares\Desktop\Azure\pops Dinner\popsDiner\Views\ShoppingCart\Index.cshtml"
                                 Write(line.Item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(612, 45, true);
            WriteLiteral("</td>\n                <td class=\"text-right\">");
            EndContext();
            BeginContext(658, 29, false);
#line 22 "C:\Users\nares\Desktop\Azure\pops Dinner\popsDiner\Views\ShoppingCart\Index.cshtml"
                                  Write(line.Item.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(687, 66, true);
            WriteLiteral("</td>\n                <td class=\"text-right\">\n                    ");
            EndContext();
            BeginContext(755, 45, false);
#line 24 "C:\Users\nares\Desktop\Azure\pops Dinner\popsDiner\Views\ShoppingCart\Index.cshtml"
                Write((line.Amount * line.Item.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(801, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 27 "C:\Users\nares\Desktop\Azure\pops Dinner\popsDiner\Views\ShoppingCart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(852, 149, true);
            WriteLiteral("    </tbody>\n    <tfoot>\n        <tr>\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\n            <td class=\"text-right\">\n                ");
            EndContext();
            BeginContext(1002, 37, false);
#line 33 "C:\Users\nares\Desktop\Azure\pops Dinner\popsDiner\Views\ShoppingCart\Index.cshtml"
           Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 86, true);
            WriteLiteral("\n            </td>\n        </tr>\n    </tfoot>\n</table>\n\n<div class=\"text-center\">\n    ");
            EndContext();
            BeginContext(1125, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d3a0e1d2ca9485abc4eda28eae60c8c", async() => {
                BeginContext(1197, 14, true);
                WriteLiteral("Check out now!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1215, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

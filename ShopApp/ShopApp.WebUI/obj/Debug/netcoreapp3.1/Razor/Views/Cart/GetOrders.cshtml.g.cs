#pragma checksum "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f00f5c3770d6e2dad6fa61b112ddefd16d98900"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_GetOrders), @"mvc.1.0.view", @"/Views/Cart/GetOrders.cshtml")]
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
#line 1 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f00f5c3770d6e2dad6fa61b112ddefd16d98900", @"/Views/Cart/GetOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca08fd1dcab1ecd8698044055cea4e62edd6bd18", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_GetOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
  
    ViewData["Title"] = "GetOrders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1> Siparişlerim </h1>\r\n<hr/>\r\n\r\n");
#nullable restore
#line 9 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
 foreach(var order in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered table-sm mb-3\">\r\n\r\n        <thead class=\"bg-primary text-white\">\r\n            <tr>\r\n                <td colspan=\"2\"> Order Id: #");
#nullable restore
#line 15 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                       Write(order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <th> Price</th>\r\n                <th> Quantity</th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n");
#nullable restore
#line 22 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
             foreach(var orderItem in order.OrderItems)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td style=\"width:60px;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f00f5c3770d6e2dad6fa61b112ddefd16d989004960", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 637, "~/img/", 637, 6, true);
#nullable restore
#line 26 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
AddHtmlAttributeValue("", 643, orderItem.ImageUrl, 643, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 29 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                   Write(orderItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td> \r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                   Write(orderItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>  \r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                   Write(orderItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 38 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n\r\n            <tr>\r\n                <td colspan =\"2\"> Customer Name:</td>\r\n                <td>");
#nullable restore
#line 44 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                Write(order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td rowspan=\"3\"> Total: ");
#nullable restore
#line 45 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                                   Write(order.TotalPrice());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          </tr>\r\n            <tr>\r\n                <td colspan=\"2\"> Address:</td>\r\n                <td> ");
#nullable restore
#line 49 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td colspan=\"2\"> Phone:</td>\r\n                <td> ");
#nullable restore
#line 54 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                Write(order.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            \r\n            <tr>\r\n                <td colspan=\"2\"> Email:</td>\r\n                <td> ");
#nullable restore
#line 59 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                Write(order.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n                   \r\n            <tr>\r\n                <td colspan=\"2\"> Payment Status:</td>\r\n                <td> ");
#nullable restore
#line 64 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                Write(order.PaymentTypes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n                             \r\n            <tr>\r\n                <td colspan=\"2\"> Order Status:</td>\r\n                <td> ");
#nullable restore
#line 69 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
                Write(order.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 75 "D:\Proje\Güncel\ShopApp\ShopApp.WebUI\Views\Cart\GetOrders.cshtml"
       }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\ThankYou1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbd770475b61ae43e11bbd03208934e082194ce0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ThankYou1), @"mvc.1.0.view", @"/Views/Home/ThankYou1.cshtml")]
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
#line 1 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\_ViewImports.cshtml"
using NewCoreCoffeeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\_ViewImports.cshtml"
using NewCoreCoffeeApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd770475b61ae43e11bbd03208934e082194ce0", @"/Views/Home/ThankYou1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52da7a1ba92b31db1d1820e2d5733108b317a469", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ThankYou1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewCoreCoffeeApp.Models.WebUser>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd770475b61ae43e11bbd03208934e082194ce03321", async() => {
                WriteLiteral(@"
    <style>
        div.cart {
            position: fixed;
            top: 225px;
            right: 150px;
            width: 700px;
            border: 1px solid #000000;
            background: border-box
        }

        div.label {
            position: fixed;
            top: 200px;
            right: 150px;
            width: 700px;
            border: 1px solid #000000;
            background: border-box
        }

        body {
            background-color: darkred;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd770475b61ae43e11bbd03208934e082194ce04821", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 34 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\ThankYou1.cshtml"
  
    ViewData["Title"] = "ThankYou1";
    decimal totalCost = 0.00m;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1><h1>Pick Up Receipt: Order No. 445</h1></h1>\r\n\r\n<p>Thank you for your order ");
#nullable restore
#line 41 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\ThankYou1.cshtml"
                       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>\r\n\r\n<p>It will be ready at ");
#nullable restore
#line 43 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\ThankYou1.cshtml"
                  Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<div class=\"cart\">\r\n");
#nullable restore
#line 46 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\ThankYou1.cshtml"
      foreach (var coffee in WebUser.Cart)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                ");
#nullable restore
#line 50 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\ThankYou1.cshtml"
           Write(coffee);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <hr />\r\n            </div>\r\n");
#nullable restore
#line 53 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\ThankYou1.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\ThankYou1.cshtml"
       foreach (var coffee in WebUser.Cart)
        {
            totalCost += coffee.Price;
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    Total Amount Owed: ");
#nullable restore
#line 62 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\ThankYou1.cshtml"
                  Write(totalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewCoreCoffeeApp.Models.WebUser> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\RegistrationComplete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "310aca69423946d07b07026c6d3491a56671879d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegistrationComplete), @"mvc.1.0.view", @"/Views/Home/RegistrationComplete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310aca69423946d07b07026c6d3491a56671879d", @"/Views/Home/RegistrationComplete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52da7a1ba92b31db1d1820e2d5733108b317a469", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegistrationComplete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewCoreCoffeeApp.Models.WebUser>
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
            WriteLiteral("\r\n    <!DOCTYPE html>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "310aca69423946d07b07026c6d3491a56671879d3384", async() => {
                WriteLiteral("\r\n        <style>\r\n            body {\r\n                background-color: darkred;\r\n            }\r\n        </style>\r\n    ");
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
            WriteLiteral("\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "310aca69423946d07b07026c6d3491a56671879d4490", async() => {
                WriteLiteral("\r\n    ");
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 17 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\RegistrationComplete.cshtml"
      
        ViewData["Title"] = "RegistrationComplete";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1 style=\"color:forestgreen\">Success!</h1>\r\n\r\n    <h2>Welcome to CAFEVANIA, ");
#nullable restore
#line 23 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\RegistrationComplete.cshtml"
                         Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\RegistrationComplete.cshtml"
                                          Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" from ");
#nullable restore
#line 23 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\RegistrationComplete.cshtml"
                                                               Write(Model.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h2>\r\n    <br />\r\n    <br />\r\n\r\n    <p>Your Roast Preference of ");
#nullable restore
#line 27 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\RegistrationComplete.cshtml"
                           Write(Model.RoastPreference);

#line default
#line hidden
#nullable disable
            WriteLiteral(" will be set to your profile.</p>\r\n    <p>Website Ambience saved to ");
#nullable restore
#line 28 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\RegistrationComplete.cshtml"
                            Write(Model.MusicPreference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <br />\r\n\r\n    <p>An email will be sent to ");
#nullable restore
#line 31 "C:\Users\RVICKERY\source\repos\NewCoreCoffeeApp\NewCoreCoffeeApp\Views\Home\RegistrationComplete.cshtml"
                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with more details!</p>\r\n\r\n    <a href=\"/Home/Menu\">Click here to begin your order</a>\r\n\r\n");
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

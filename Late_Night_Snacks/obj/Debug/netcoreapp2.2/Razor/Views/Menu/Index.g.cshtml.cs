#pragma checksum "C:\Users\tyron\source\repos\LaunchCodeLiftoffProjects\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f06161f2032d1afdb4d1c255325b658f50ff281a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menu/Index.cshtml", typeof(AspNetCore.Views_Menu_Index))]
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
#line 1 "C:\Users\tyron\source\repos\LaunchCodeLiftoffProjects\Late_Night_Snacks\Late_Night_Snacks\Views\_ViewImports.cshtml"
using Late_Night_Snacks;

#line default
#line hidden
#line 2 "C:\Users\tyron\source\repos\LaunchCodeLiftoffProjects\Late_Night_Snacks\Late_Night_Snacks\Views\_ViewImports.cshtml"
using Late_Night_Snacks.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f06161f2032d1afdb4d1c255325b658f50ff281a", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f92cb929d5a457d845567a7fec9ecd70b29da2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 123, true);
            WriteLiteral("\r\n\r\n<h1>Menu Items Here</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Item</th>\r\n        <th>Price</th>\r\n    </tr>\r\n");
            EndContext();
#line 10 "C:\Users\tyron\source\repos\LaunchCodeLiftoffProjects\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
     foreach(Menu m in ViewBag.menus)
    {

#line default
#line hidden
            BeginContext(169, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(200, 10, false);
#line 13 "C:\Users\tyron\source\repos\LaunchCodeLiftoffProjects\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
           Write(m.MenuItem);

#line default
#line hidden
            EndContext();
            BeginContext(210, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(234, 18, false);
#line 14 "C:\Users\tyron\source\repos\LaunchCodeLiftoffProjects\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
           Write(m.Price.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(252, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 16 "C:\Users\tyron\source\repos\LaunchCodeLiftoffProjects\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(281, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
#line 19 "C:\Users\tyron\source\repos\LaunchCodeLiftoffProjects\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
 if(ViewBag.menus.Count == 0)
{

#line default
#line hidden
            BeginContext(327, 32, true);
            WriteLiteral("    <p>NO FOOD FOR YOU!!!!</p>\r\n");
            EndContext();
#line 22 "C:\Users\tyron\source\repos\LaunchCodeLiftoffProjects\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

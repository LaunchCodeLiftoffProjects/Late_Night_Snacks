#pragma checksum "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21312d973436f9fcbc852428120d47dd27f31ba8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Late_Night_Snacks_Views_Menu_Index), @"mvc.1.0.view", @"/Late_Night_Snacks/Views/Menu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Late_Night_Snacks/Views/Menu/Index.cshtml", typeof(AspNetCore.Late_Night_Snacks_Views_Menu_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21312d973436f9fcbc852428120d47dd27f31ba8", @"/Late_Night_Snacks/Views/Menu/Index.cshtml")]
    public class Late_Night_Snacks_Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 116, true);
            WriteLiteral("\r\n<h1>Menu Items</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Item</th>\r\n        <th>Price</th>\r\n    </tr>\r\n");
            EndContext();
#line 9 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
     foreach(Menu m in Model)
    {

#line default
#line hidden
            BeginContext(154, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(185, 10, false);
#line 12 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
           Write(m.MenuItem);

#line default
#line hidden
            EndContext();
            BeginContext(195, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(219, 18, false);
#line 13 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
           Write(m.Price.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(237, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 15 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(266, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
#line 18 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
 if(Model.Count == 0)
{

#line default
#line hidden
            BeginContext(304, 32, true);
            WriteLiteral("    <p>NO FOOD FOR YOU!!!!</p>\r\n");
            EndContext();
#line 21 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
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

#pragma checksum "C:\Users\miaz\Workspace\ECUtbildning\SillyStyles\Views\Product\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c994d71c70be9eb1c2b048bfd8fd248f30dd915"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Show), @"mvc.1.0.view", @"/Views/Product/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Show.cshtml", typeof(AspNetCore.Views_Product_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c994d71c70be9eb1c2b048bfd8fd248f30dd915", @"/Views/Product/Show.cshtml")]
    public class Views_Product_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SillyStyles.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\miaz\Workspace\ECUtbildning\SillyStyles\Views\Product\Show.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(117, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(124, 11, false);
#line 9 "C:\Users\miaz\Workspace\ECUtbildning\SillyStyles\Views\Product\Show.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(135, 10, true);
            WriteLiteral("</h2>\r\n<p>");
            EndContext();
            BeginContext(146, 17, false);
#line 10 "C:\Users\miaz\Workspace\ECUtbildning\SillyStyles\Views\Product\Show.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(163, 30, true);
            WriteLiteral("</p>\r\n<img class=\"product-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 193, "\"", 214, 1);
#line 11 "C:\Users\miaz\Workspace\ECUtbildning\SillyStyles\Views\Product\Show.cshtml"
WriteAttributeValue("", 199, Model.ImageUrl, 199, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(215, 5, true);
            WriteLiteral("></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SillyStyles.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
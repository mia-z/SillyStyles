#pragma checksum "C:\Users\miaz\Workspace\ECUtbildning\SillyStyles\Views\Product\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79b64ad273e0124687e43bbc4ac59d67ad19b574"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79b64ad273e0124687e43bbc4ac59d67ad19b574", @"/Views/Product/Show.cshtml")]
    public class Views_Product_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SillyStyles.Domain.Entities.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(99, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\miaz\Workspace\ECUtbildning\SillyStyles\Views\Product\Show.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(133, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(140, 11, false);
#line 9 "C:\Users\miaz\Workspace\ECUtbildning\SillyStyles\Views\Product\Show.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(151, 10, true);
            WriteLiteral("</h2>\r\n<p>");
            EndContext();
            BeginContext(162, 17, false);
#line 10 "C:\Users\miaz\Workspace\ECUtbildning\SillyStyles\Views\Product\Show.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(179, 30, true);
            WriteLiteral("</p>\r\n<img class=\"product-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 209, "\"", 230, 1);
#line 11 "C:\Users\miaz\Workspace\ECUtbildning\SillyStyles\Views\Product\Show.cshtml"
WriteAttributeValue("", 215, Model.ImageUrl, 215, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(231, 5, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SillyStyles.Domain.Entities.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591

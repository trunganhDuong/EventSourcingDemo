#pragma checksum "E:\EventSourcing\EventSourcing\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af7be11113762c016b4ac117997b983092bd6317"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\EventSourcing\EventSourcing\Views\_ViewImports.cshtml"
using EventSourcing;

#line default
#line hidden
#line 2 "E:\EventSourcing\EventSourcing\Views\_ViewImports.cshtml"
using EventSourcing.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7be11113762c016b4ac117997b983092bd6317", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7891c605131dfe79e80ad90a532d87033c994fed", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ship>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\EventSourcing\EventSourcing\Views\Home\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(45, 10, true);
            WriteLiteral("    <ul>\r\n");
            EndContext();
#line 6 "E:\EventSourcing\EventSourcing\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(104, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(121, 9, false);
#line 8 "E:\EventSourcing\EventSourcing\Views\Home\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(130, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 9 "E:\EventSourcing\EventSourcing\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(148, 11, true);
            WriteLiteral("    </ul>\r\n");
            EndContext();
#line 11 "E:\EventSourcing\EventSourcing\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ship>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "D:\CoreMVC\HouseSpy\HouseSpy\Views\Shared\_TableButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f08da0aa2f1bd97afdebb4f967ba30b474342f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_TableButtonPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TableButtonPartial.cshtml", typeof(AspNetCore.Views_Shared__TableButtonPartial))]
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
#line 1 "D:\CoreMVC\HouseSpy\HouseSpy\Views\_ViewImports.cshtml"
using HouseSpy;

#line default
#line hidden
#line 2 "D:\CoreMVC\HouseSpy\HouseSpy\Views\_ViewImports.cshtml"
using HouseSpy.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f08da0aa2f1bd97afdebb4f967ba30b474342f8", @"/Views/Shared/_TableButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a3bdf5ba33cdc1b88e392283a0862e24bd79360", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(132, 120, true);
            WriteLiteral("\r\n\r\n<td style=\"width:150px\">\r\n    <div class=\"btn-group\" role=\"group\">\r\n        <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 252, "\"", 285, 1);
#line 8 "D:\CoreMVC\HouseSpy\HouseSpy\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 259, Url.Action("Edit/"+Model), 259, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(286, 82, true);
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n        <a type=\"button\" class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 368, "\"", 404, 1);
#line 9 "D:\CoreMVC\HouseSpy\HouseSpy\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 375, Url.Action("Details/"+Model), 375, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(405, 85, true);
            WriteLiteral("><i class=\"fas fa-list-alt\"></i></a>\r\n        <a type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 490, "\"", 525, 1);
#line 10 "D:\CoreMVC\HouseSpy\HouseSpy\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 497, Url.Action("Delete/"+Model), 497, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(526, 56, true);
            WriteLiteral("><i class=\"fas fa-trash-alt\"></i></a>\r\n    </div>\r\n</td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591

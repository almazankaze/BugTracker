#pragma checksum "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\ReportNotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9064c67c0f9c796f56b927c66673b0029198e25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_ReportNotFound), @"mvc.1.0.view", @"/Views/Report/ReportNotFound.cshtml")]
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
#line 1 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\_ViewImports.cshtml"
using BugTracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\_ViewImports.cshtml"
using BugTracker.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9064c67c0f9c796f56b927c66673b0029198e25", @"/Views/Report/ReportNotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55fb10b3d524212a23f0871bf38301056d12dd25", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_ReportNotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\ReportNotFound.cshtml"
  
    ViewBag.Title = "404 Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div style=\"padding-top:20px\">\r\n        <div class=\"card shadow\" style=\"padding:20px;\">\r\n            <h1 style=\"font-weight:700\">Sorry, that page does not exist</h1>\r\n            <br />\r\n            <h5>Report with Id ");
#nullable restore
#line 12 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\ReportNotFound.cshtml"
                          Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" does not exist, try searching for another.</h5>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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

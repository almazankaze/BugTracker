#pragma checksum "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e8eb1528f3e4811344bfe078427c0f9ce54318a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DashBoard), @"mvc.1.0.view", @"/Views/Home/DashBoard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e8eb1528f3e4811344bfe078427c0f9ce54318a", @"/Views/Home/DashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55fb10b3d524212a23f0871bf38301056d12dd25", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "createreport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "issuedetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DataTable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
  
    ViewBag.Title = "DashBoard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Begin Page Content -->\r\n<div class=\"container-fluid\">\r\n\r\n    <!-- Page Heading -->\r\n    <div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n        <h1 class=\"h3 mb-0 text-gray-800\">DashBoard</h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e8eb1528f3e4811344bfe078427c0f9ce54318a5595", async() => {
                WriteLiteral("<i class=\"fas fa-download fa-sm text-white-50\"></i> Generate Report");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <!-- Show this to admin or operations -->\r\n");
#nullable restore
#line 17 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
     if (User.IsInRole("Admin") || User.IsInRole("Operations"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- Top Row Content -->\r\n");
            WriteLiteral(@"        <div class=""row"">

            <div class=""col-xl-3 col-md-6 mb-4"">
                <div class=""card border-left-info shadow h-100 py-2"">
                    <div class=""card-body"">
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col mr-2"">
                                <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">Tasks</div>
                                <div class=""row no-gutters align-items-center"">
                                    <div class=""col-auto"">
                                        <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">50%</div>
                                    </div>
                                    <div class=""col"">
                                        <div class=""progress progress-sm mr-2"">
                                            <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valu");
            WriteLiteral(@"emax=""100""></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-auto"">
                                <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Pending Requests Card Example -->
            <div class=""col-xl-3 col-md-6 mb-4"">
                <div class=""card border-left-warning shadow h-100 py-2"">
                    <div class=""card-body"">
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col mr-2"">
                                <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">Pending Resolution</div>
                                <div class=""h5 mb-0 font-weight-bold text-gra");
            WriteLiteral("y-800\">");
#nullable restore
#line 55 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                                                               Write(Model.NeedReview.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                            <div class=""col-auto"">
                                <i class=""fas fa-comments fa-2x text-gray-300""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 65 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""row"">

        <div class=""col-xl-5 col-lg-6"">

            <!-- Reported Table -->
            <div class=""card shadow mb-4"">
                <!-- Card Header -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h6 class=""m-0 font-weight-bold text-primary"">Reported Bugs</h6>
                </div>
                <!-- Card Body -->
                <div class=""card-body"">
                    <table id=""reportedTable"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Updated</th>
                                <th>Resolution</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 88 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                             foreach (var report in Model.ReportedBugs)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e8eb1528f3e4811344bfe078427c0f9ce54318a11832", async() => {
#nullable restore
#line 91 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                                                                                                  Write(report.Id);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                                                                               WriteLiteral(report.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 92 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                   Write(report.LastUpdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 93 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                   Write(report.Resolution);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                </tr>\r\n");
#nullable restore
#line 95 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n\r\n");
#nullable restore
#line 101 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <!-- Needs Users Table -->
                <div class=""card shadow mb-4"">
                    <!-- Card Header -->
                    <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                        <h6 class=""m-0 font-weight-bold text-primary"">New Bugs</h6>
                    </div>
                    <!-- Card Body -->
                    <div class=""card-body"">
                        <table id=""newTable"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Severity</th>
                                    <th>Post Time</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 120 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                 foreach (var report in Model.NeedUsers)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e8eb1528f3e4811344bfe078427c0f9ce54318a17055", async() => {
#nullable restore
#line 123 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                                                                                                      Write(report.Id);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 123 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                                                                                   WriteLiteral(report.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 124 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                       Write(report.Severity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 125 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                       Write(report.PostTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    </tr>\r\n");
#nullable restore
#line 127 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral(@"                <!-- Needs Review Table -->
                <div class=""card shadow mb-4"">
                    <!-- Card Header -->
                    <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                        <h6 class=""m-0 font-weight-bold text-primary"">Pending Resolution</h6>
                    </div>
                    <!-- Card Body -->
                    <div class=""card-body"">
                        <table id=""resolveTable"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Assigned</th>
                                    <th>Last Update</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 150 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                 foreach (var report in Model.NeedReview)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e8eb1528f3e4811344bfe078427c0f9ce54318a22123", async() => {
#nullable restore
#line 153 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                                                                                                      Write(report.Id);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 153 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                                                                                   WriteLiteral(report.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 154 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                       Write(report.AssignedToUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 155 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                       Write(report.LastUpdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    </tr>\r\n");
#nullable restore
#line 157 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 162 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 164 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
             if (User.IsInRole("Operations") || User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <!-- Assigned Table -->
                <div class=""card shadow mb-4"">
                    <!-- Card Header -->
                    <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                        <h6 class=""m-0 font-weight-bold text-primary"">Assigned Bugs</h6>
                    </div>
                    <!-- Card Body -->
                    <div class=""card-body"">
                        <table id=""assignedTable"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Severity</th>
                                    <th>Resolution</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 183 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                 foreach (var report in Model.AssignedBugs)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e8eb1528f3e4811344bfe078427c0f9ce54318a27656", async() => {
#nullable restore
#line 186 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                                                                                                      Write(report.Id);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 186 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                                                                                   WriteLiteral(report.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 187 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                       Write(report.Severity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 188 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                       Write(report.Resolution);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    </tr>\r\n");
#nullable restore
#line 190 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 195 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Home\DashBoard.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>

        <!-- Content Column -->
        <div class=""col-lg-7 mb-4"">

            <!-- Project Card Example -->
            <div class=""card shadow mb-4"">
                <div class=""card-header py-3"">
                    <h6 class=""m-0 font-weight-bold text-primary"">Projects</h6>
                </div>
                <div class=""card-body"">
                    <h4 class=""small font-weight-bold"">Server Migration <span class=""float-right"">20%</span></h4>
                    <div class=""progress mb-4"">
                        <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 20%"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <h4 class=""small font-weight-bold"">Sales Tracking <span class=""float-right"">40%</span></h4>
                    <div class=""progress mb-4"">
                        <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 40%"" aria-valuenow=""40"" aria-valuemin=""0"" ");
            WriteLiteral(@"aria-valuemax=""100""></div>
                    </div>
                    <h4 class=""small font-weight-bold"">Customer Database <span class=""float-right"">60%</span></h4>
                    <div class=""progress mb-4"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 60%"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <h4 class=""small font-weight-bold"">Payout Details <span class=""float-right"">80%</span></h4>
                    <div class=""progress mb-4"">
                        <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 80%"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <h4 class=""small font-weight-bold"">Account Setup <span class=""float-right"">Complete!</span></h4>
                    <div class=""progress"">
                        <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 100%"" aria-valu");
            WriteLiteral("enow=\"100\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e8eb1528f3e4811344bfe078427c0f9ce54318a34064", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

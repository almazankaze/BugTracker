#pragma checksum "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0c8f45c2b4d614bbaa20d1fa6ee3399f5424119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_IssueDetails), @"mvc.1.0.view", @"/Views/Report/IssueDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0c8f45c2b4d614bbaa20d1fa6ee3399f5424119", @"/Views/Report/IssueDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55fb10b3d524212a23f0871bf38301056d12dd25", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_IssueDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IssueDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "openbug", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "viewuser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deletereport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
  
    ViewBag.Title = "Issue Details";
    var teamOwner = ViewBag.TeamOwner;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Begin Page Content -->
<div class=""container-fluid"">

    <!-- Page Heading -->
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
        <h1 class=""h3 mb-0 text-gray-800"">Issue Details</h1>
    </div>

    <!-- Only show this if user belongs this this organization -->
");
#nullable restore
#line 17 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
     if (teamOwner == Model.TeamOwner)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- Only show these buttons to Admin-->\r\n");
#nullable restore
#line 21 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
         if (User.IsInRole("Admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <!-- If report is closed -->\r\n");
#nullable restore
#line 25 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                 if (Model.Resolution == "Closed")
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0c8f45c2b4d614bbaa20d1fa6ee3399f54241198349", async() => {
                WriteLiteral("Open");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                                                                              WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0c8f45c2b4d614bbaa20d1fa6ee3399f542411911105", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <button type=\"button\" class=\"d-none d-sm-inline-block btn btn-sm btn-danger shadow-sm\" data-toggle=\"modal\" data-target=\"#myModal\">Delete</button>\r\n            </div>\r\n");
            WriteLiteral("            <br />\r\n");
#nullable restore
#line 39 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- Only show to Operations -->\r\n");
#nullable restore
#line 42 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
         if (User.IsInRole("Operations"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
             if (Model.Resolution == "Open")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0c8f45c2b4d614bbaa20d1fa6ee3399f542411914832", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 51 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""table-responsive"">
        <table class=""table table-bordered table-condensed"">
            <tbody>
                <tr>
                    <th>Id</th>
                    <th>Project</th>
                    <th>Category</th>
                    <th>View Status</th>
                    <th>Date Submitted</th>
                    <th>Last Update</th>
                </tr>
                <tr>
                    <td>");
#nullable restore
#line 67 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 68 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                   Write(Model.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 69 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                   Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>Public</td>\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                   Write(Model.PostTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 72 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                   Write(Model.LastUpdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr class=\"spacer\">\r\n                    <td colspan=\"6\"></td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <th>Reporter</th>\r\n                    <td>");
#nullable restore
#line 81 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                   Write(Model.Reporter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <th>Assigned To</th>\r\n                    <td>");
#nullable restore
#line 83 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                   Write(Model.AssignedTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td colspan=\"2\"></td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <th>Priority</th>\r\n                    <td>");
#nullable restore
#line 89 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                   Write(Model.Priority);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <th>Severity</th>\r\n                    <td>");
#nullable restore
#line 91 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                   Write(Model.Severity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <th>Reproducibility</th>\r\n                    <td></td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <th>Status</th>\r\n                    <td>");
#nullable restore
#line 98 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                   Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <th>Resolution</th>\r\n                    <td>");
#nullable restore
#line 100 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                   Write(Model.Resolution);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td colspan=\"2\"></td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <th>Summary</th>\r\n                    <td colspan=\"5\">");
#nullable restore
#line 106 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                               Write(Model.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <th>Description</th>\r\n                    <td colspan=\"5\">");
#nullable restore
#line 111 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                               Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </tbody>
        </table>
    </div>

    <!-- Note Section -->
    <div class=""card"">

        <!-- Header -->
        <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between bg-primary"">
            <h6 class=""m-0 font-weight-bold text-white"">Issue Activity</h6>
        </div>

        <!-- Card Body -->
        <div class=""card-body"">

");
#nullable restore
#line 128 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
             if (Model.Notes.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                 foreach (var note in Model.Notes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card-group"">

                        <!-- Profile Info -->
                        <div class=""card shadow bg-light"">
                            <div class=""card-block"">
                                <div class=""row"" style=""padding:20px"">
                                    <div class=""col-md-4"">

");
#nullable restore
#line 140 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                                         if (note.PhotoPath == null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <img src=\"\\images\\default-user.png\" style=\"width:100px; height:auto\" />\r\n");
#nullable restore
#line 143 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <img");
            BeginWriteAttribute("src", " src=\"", 5012, "\"", 5041, 2);
            WriteAttributeValue("", 5018, "\\images\\", 5018, 8, true);
#nullable restore
#line 146 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
WriteAttributeValue("", 5026, note.PhotoPath, 5026, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px; height:auto\" />\r\n");
#nullable restore
#line 147 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <div>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0c8f45c2b4d614bbaa20d1fa6ee3399f542411925972", async() => {
#nullable restore
#line 152 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                                                                                                                              Write(note.PostedByUserName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 152 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                                                                                                WriteLiteral(note.EncryptedUserId);

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
            WriteLiteral("\r\n                                        </div>\r\n                                        <div>\r\n                                            <b>");
#nullable restore
#line 155 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                                          Write(note.PostTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Note Description -->
                        <div class=""card shadow bg-light"" style=""flex-grow: 2"">
                            <div class=""card-block"">
                                <div style=""padding:20px"">
                                    <p>
                                        ");
#nullable restore
#line 167 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                                   Write(note.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <br />\r\n");
#nullable restore
#line 175 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 175 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5 class=\"card-title text-center\">\r\n                    No Activity\r\n                </h5>\r\n");
#nullable restore
#line 182 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>

<!-- Modal -->
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h1 class=""modal-title col-12 text-center"" id=""myModalLabel"">Warning</h1>
            </div>
            <div class=""modal-body"">
                <h3 class=""col-12 text-center"">Are you sure?</h3>
                <h5 class=""text-black-50 col-12 text-center"">This action cannot be undone</h5>
            </div>
            <div class=""modal-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0c8f45c2b4d614bbaa20d1fa6ee3399f542411931622", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0c8f45c2b4d614bbaa20d1fa6ee3399f542411931901", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 200 "C:\Users\almaz\Documents\Git\BugProject\BugTracker\Views\Report\IssueDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancel</button>\r\n                    <button type=\"submit\" class=\"btn btn-danger\">Ok</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IssueDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

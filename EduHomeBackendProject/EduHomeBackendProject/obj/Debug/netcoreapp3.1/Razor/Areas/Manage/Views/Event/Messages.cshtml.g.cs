#pragma checksum "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd20bef17640148f2a3269ce1fa20dfe9c9b7382"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Event_Messages), @"mvc.1.0.view", @"/Areas/Manage/Views/Event/Messages.cshtml")]
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
#line 1 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\_ViewImports.cshtml"
using EduHomeBackendProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\_ViewImports.cshtml"
using EduHomeBackendProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\_ViewImports.cshtml"
using EduHomeBackendProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\_ViewImports.cshtml"
using EduHomeBackendProject.Areas.Manage.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd20bef17640148f2a3269ce1fa20dfe9c9b7382", @"/Areas/Manage/Views/Event/Messages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b160bbc7b078de1272fb836be84816df7d533e38", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Event_Messages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EventMessages>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MessageDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
  
    ViewData["Title"] = "Messages";
    Layout = "~/Areas/Manage/Views/Shared/_Layout.cshtml";
    int order = (ViewBag.SelectedPage - 1) * 2 + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
<h1>Messages</h1>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">FullName</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">CreatedAt</th>
                <th scope=""col"">Subject</th>
                <th scope=""col"">Message</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 26 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                           Write(order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 27 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                 if (item.AppUserId != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 29 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                   Write(item.appUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                   Write(item.appUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 34 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 37 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
               Write(item.SendedAt.ToString("HH:mm dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 39 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                 if (item.Message.Length > 60)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                Write(item.Message.Substring(0,60) + " ......");

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                                                               
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 45 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                   Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 46 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd20bef17640148f2a3269ce1fa20dfe9c9b738211327", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-messageId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-messageId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n            </tr>\r\n");
#nullable restore
#line 49 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"

                order++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 55 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
     if (ViewBag.TotalPage>1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <nav aria-label=\"...\" class=\"formargin\" style=\"margin-left:650px; margin-top:70px;\">\r\n            <ul class=\"pagination\">\r\n");
#nullable restore
#line 59 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                 if (ViewBag.SelectedPage == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item disabled\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd20bef17640148f2a3269ce1fa20dfe9c9b738214822", async() => {
                WriteLiteral("Prev");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                                                                         WriteLiteral(ViewBag.SelectedPage);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                                                                                                                    WriteLiteral(ViewBag.eventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-eventId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 64 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd20bef17640148f2a3269ce1fa20dfe9c9b738218405", async() => {
                WriteLiteral("Prev");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                                                                         WriteLiteral(ViewBag.SelectedPage-1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                                                                                                                      WriteLiteral(ViewBag.eventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-eventId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 70 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                 for (int i = 1; i <= ViewBag.TotalPage; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 2599, "\"", 2655, 2);
            WriteAttributeValue("", 2607, "page-item", 2607, 9, true);
#nullable restore
#line 73 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
WriteAttributeValue(" ", 2616, i==ViewBag.SelectedPage?"active":"", 2617, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd20bef17640148f2a3269ce1fa20dfe9c9b738222706", async() => {
#nullable restore
#line 73 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                                                                                                                                                                                Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                                                                                                                                WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                                                                                                                                                       WriteLiteral(ViewBag.eventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-eventId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 74 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                 if (ViewBag.SelectedPage == ViewBag.TotalPage)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item disabled\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd20bef17640148f2a3269ce1fa20dfe9c9b738226956", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                                                                        WriteLiteral(ViewBag.SelectedPage);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                                                                                                                   WriteLiteral(ViewBag.eventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-eventId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 80 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd20bef17640148f2a3269ce1fa20dfe9c9b738230537", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                                                                        WriteLiteral(ViewBag.SelectedPage+1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                                                                                                                     WriteLiteral(ViewBag.eventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-eventId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 86 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </nav>\r\n");
#nullable restore
#line 89 "E:\BE\p220_be_21_backendproject-Kanan172411\EduHomeBackendProject\EduHomeBackendProject\Areas\Manage\Views\Event\Messages.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EventMessages>> Html { get; private set; }
    }
}
#pragma warning restore 1591
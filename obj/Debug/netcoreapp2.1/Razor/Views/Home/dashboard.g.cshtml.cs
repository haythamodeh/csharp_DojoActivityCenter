#pragma checksum "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4b413d720f766fa21ae2be36cf3b50c852a93a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_dashboard), @"mvc.1.0.view", @"/Views/Home/dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/dashboard.cshtml", typeof(AspNetCore.Views_Home_dashboard))]
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
#line 1 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/_ViewImports.cshtml"
using ExamBelt;

#line default
#line hidden
#line 2 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/_ViewImports.cshtml"
using ExamBelt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4b413d720f766fa21ae2be36cf3b50c852a93a1", @"/Views/Home/dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbf9fcec9ebc867f77b43973476af08be62c7ddf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AnActivity>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 136, true);
            WriteLiteral("\n<div class=\"center jumbotron\">\n    <h2 class=\"text-success\" style=\"display: inline-block\" id=\"header\">Dojo Activity Center  -- Welcome ");
            EndContext();
            BeginContext(161, 22, false);
#line 4 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
                                                                                                   Write(ViewBag.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(183, 97, true);
            WriteLiteral("</h2>\n    <a class=\"btn btn-danger logout\" style=\"float:right;\" href=\"/logout\">Logout</a>\n</div>\n");
            EndContext();
#line 7 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
 if(TempData["passedDue"] != null)
{

#line default
#line hidden
            BeginContext(317, 38, true);
            WriteLiteral("  <h3 class=\"text-center text-danger\">");
            EndContext();
            BeginContext(356, 21, false);
#line 9 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
                                 Write(TempData["passedDue"]);

#line default
#line hidden
            EndContext();
            BeginContext(377, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 10 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
}

#line default
#line hidden
            BeginContext(385, 338, true);
            WriteLiteral(@"<table class=""table table-striped text-center "">
  <thead>
    <tr>
      <th scope=""col"">Actvity</th>
      <th scope=""col"">Date And Time</th>
      <th scope=""col"">Duration</th>
      <th scope=""col"">Event Coordinator</th>
      <th scope=""col"">No. of Participants</th>
      <th scope=""col"">Actions</th>
    </tr>
  </thead>
  <tbody>
");
            EndContext();
#line 23 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
        
        foreach(var a in @Model)
        {

#line default
#line hidden
            BeginContext(775, 31, true);
            WriteLiteral("          <tr>\n          <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 806, "\"", 840, 2);
            WriteAttributeValue("", 813, "view/activity/", 813, 14, true);
#line 27 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
WriteAttributeValue("", 827, a.ActivityID, 827, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(841, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(843, 7, false);
#line 27 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
                                               Write(a.Title);

#line default
#line hidden
            EndContext();
            BeginContext(850, 24, true);
            WriteLiteral("</a></td>\n          <td>");
            EndContext();
            BeginContext(875, 24, false);
#line 28 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
         Write(a.Date.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
            BeginContext(899, 4, true);
            WriteLiteral(" At ");
            EndContext();
            BeginContext(904, 26, false);
#line 28 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
                                      Write(a.Time.ToString("h:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(930, 20, true);
            WriteLiteral("</td>\n          <td>");
            EndContext();
            BeginContext(951, 10, false);
#line 29 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
         Write(a.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(961, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(963, 13, false);
#line 29 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
                     Write(a.TimeChooser);

#line default
#line hidden
            EndContext();
            BeginContext(976, 20, true);
            WriteLiteral("</td>\n          <td>");
            EndContext();
            BeginContext(997, 18, false);
#line 30 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
         Write(a.CreatorNameFirst);

#line default
#line hidden
            EndContext();
            BeginContext(1015, 20, true);
            WriteLiteral("</td>\n          <td>");
            EndContext();
            BeginContext(1036, 23, false);
#line 31 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
         Write(a.AllParticipants.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1059, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 32 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
           if(a.UserID == ViewBag.User.UserID)
          {

#line default
#line hidden
            BeginContext(1124, 41, true);
            WriteLiteral("            <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1165, "\"", 1202, 2);
            WriteAttributeValue("", 1172, "/delete/activity/", 1172, 17, true);
#line 34 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
WriteAttributeValue("", 1189, a.ActivityID, 1189, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1203, 17, true);
            WriteLiteral(">Delete</a></td>\n");
            EndContext();
#line 35 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
          }else if(a.UserID != ViewBag.User.UserID && !a.AllParticipants.Any(u => u.UserID == ViewBag.User.UserID))
          {

#line default
#line hidden
            BeginContext(1348, 42, true);
            WriteLiteral("            <td><a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1390, "\"", 1425, 2);
            WriteAttributeValue("", 1397, "/join/activity/", 1397, 15, true);
#line 37 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
WriteAttributeValue("", 1412, a.ActivityID, 1412, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1426, 15, true);
            WriteLiteral(">Join</a></td>\n");
            EndContext();
#line 38 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
          }else {

#line default
#line hidden
            BeginContext(1459, 42, true);
            WriteLiteral("            <td><a class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1501, "\"", 1537, 2);
            WriteAttributeValue("", 1508, "/leave/activity/", 1508, 16, true);
#line 39 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
WriteAttributeValue("", 1524, a.ActivityID, 1524, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1538, 16, true);
            WriteLiteral(">Leave</a></td>\n");
            EndContext();
#line 40 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
          }

#line default
#line hidden
            BeginContext(1566, 16, true);
            WriteLiteral("          </tr>\n");
            EndContext();
#line 42 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/dashboard.cshtml"
        }
      

#line default
#line hidden
            BeginContext(1600, 105, true);
            WriteLiteral("  </tbody>\n</table>\n<a class=\"btn btn-primary\" style=\"float:right;\" href=\"/activity/new\">New Activity</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AnActivity>> Html { get; private set; }
    }
}
#pragma warning restore 1591

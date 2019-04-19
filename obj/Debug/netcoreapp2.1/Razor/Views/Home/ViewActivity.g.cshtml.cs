#pragma checksum "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38d6448e453a5800ee15aae082c91d434980e40e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewActivity), @"mvc.1.0.view", @"/Views/Home/ViewActivity.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewActivity.cshtml", typeof(AspNetCore.Views_Home_ViewActivity))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38d6448e453a5800ee15aae082c91d434980e40e", @"/Views/Home/ViewActivity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbf9fcec9ebc867f77b43973476af08be62c7ddf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewActivity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnActivity>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 174, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-6\">\n        <a class=\"btn btn-primary\" href=\"/Dashboard\">Dashboard</a>\n        <a class=\"btn btn-danger\" href=\"/logout\">Log Out</a>\n");
            EndContext();
#line 7 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
         if(Model.UserID == ViewBag.User.UserID)
        {

#line default
#line hidden
            BeginContext(251, 37, true);
            WriteLiteral("            <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 288, "\"", 329, 2);
            WriteAttributeValue("", 295, "/delete/activity/", 295, 17, true);
#line 9 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
WriteAttributeValue("", 312, Model.ActivityID, 312, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(330, 12, true);
            WriteLiteral(">Delete</a>\n");
            EndContext();
#line 10 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
        }else if(Model.UserID != ViewBag.User.UserID && !@Model.AllParticipants.Any(u => u.UserID == ViewBag.User.UserID))
        {

#line default
#line hidden
            BeginContext(475, 38, true);
            WriteLiteral("            <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 513, "\"", 552, 2);
            WriteAttributeValue("", 520, "/join/activity/", 520, 15, true);
#line 12 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
WriteAttributeValue("", 535, Model.ActivityID, 535, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(553, 10, true);
            WriteLiteral(">Join</a>\n");
            EndContext();
#line 13 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
        }else {

#line default
#line hidden
            BeginContext(579, 38, true);
            WriteLiteral("            <a class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 617, "\"", 657, 2);
            WriteAttributeValue("", 624, "/leave/activity/", 624, 16, true);
#line 14 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
WriteAttributeValue("", 640, Model.ActivityID, 640, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(658, 11, true);
            WriteLiteral(">Leave</a>\n");
            EndContext();
#line 15 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
        }

#line default
#line hidden
            BeginContext(679, 12, true);
            WriteLiteral("        <h1>");
            EndContext();
            BeginContext(692, 11, false);
#line 16 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(703, 50, true);
            WriteLiteral("</h1>\n        <hr>\n        <h4>Event Coordinator: ");
            EndContext();
            BeginContext(754, 27, false);
#line 18 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
                          Write(ViewBag.whomadeit.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(781, 60, true);
            WriteLiteral("</h4>\n        <hr>\n        <h4>Description:</h4>\n        <p>");
            EndContext();
            BeginContext(842, 17, false);
#line 21 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(859, 49, true);
            WriteLiteral("</p>\n        <hr>\n        <h5>Participants:</h5>\n");
            EndContext();
#line 24 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
          
            foreach(var g in @Model.AllParticipants)
            {

#line default
#line hidden
            BeginContext(986, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(1007, 16, false);
#line 27 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
               Write(g.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1023, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1025, 15, false);
#line 27 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
                                 Write(g.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1040, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 28 "/Users/HOdehLion/Desktop/c#/Exam/ExamBelt/Views/Home/ViewActivity.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1070, 17, true);
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnActivity> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56d1f0511a2e607f15a41c3966fca26a968e5f45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_Index), @"mvc.1.0.view", @"/Views/Reviews/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reviews/Index.cshtml", typeof(AspNetCore.Views_Reviews_Index))]
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
#line 5 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Index.cshtml"
using TravelBlog.Models;

#line default
#line hidden
#line 6 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56d1f0511a2e607f15a41c3966fca26a968e5f45", @"/Views/Reviews/Index.cshtml")]
    public class Views_Reviews_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TravelBlog.Models.Review>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(136, 18, true);
            WriteLiteral("\r\n<h1>Reviews for ");
            EndContext();
            BeginContext(155, 18, false);
#line 9 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Index.cshtml"
           Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(173, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(204, 8, true);
            WriteLiteral("  <ul>\r\n");
            EndContext();
#line 14 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Index.cshtml"
     foreach (Review review in Model)
    {

#line default
#line hidden
            BeginContext(258, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(269, 81, false);
#line 16 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Index.cshtml"
     Write(Html.ActionLink($"{review.Description}", "Details", new { id = review.ReviewId }));

#line default
#line hidden
            EndContext();
            BeginContext(350, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 17 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(364, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
#line 19 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Index.cshtml"
} 
else
{

#line default
#line hidden
            BeginContext(386, 44, true);
            WriteLiteral("  <h3>No reviews have been added yet!</h3>\r\n");
            EndContext();
#line 23 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Index.cshtml"
}

#line default
#line hidden
            BeginContext(433, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(439, 43, false);
#line 25 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Index.cshtml"
Write(Html.ActionLink("Add new review", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(482, 11, true);
            WriteLiteral("</p>\r\n\r\n<p>");
            EndContext();
            BeginContext(494, 40, false);
#line 27 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(534, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TravelBlog.Models.Review>> Html { get; private set; }
    }
}
#pragma warning restore 1591
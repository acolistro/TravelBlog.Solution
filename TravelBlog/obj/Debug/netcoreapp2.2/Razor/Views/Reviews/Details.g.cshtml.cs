#pragma checksum "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8def7857e9ac20f89d2078bba27eee5877a84d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_Details), @"mvc.1.0.view", @"/Views/Reviews/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reviews/Details.cshtml", typeof(AspNetCore.Views_Reviews_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8def7857e9ac20f89d2078bba27eee5877a84d1", @"/Views/Reviews/Details.cshtml")]
    public class Views_Reviews_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelBlog.Models.Review>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(65, 39, true);
            WriteLiteral("\r\n<h2>Review Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(105, 47, false);
#line 9 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(152, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(155, 43, false);
#line 9 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(198, 65, true);
            WriteLiteral("</h3>\r\n\r\n\r\n  <h4>Destination the Review belongs to:</h4>\r\n\r\n  <p>");
            EndContext();
            BeginContext(264, 19, false);
#line 14 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Details.cshtml"
Write(Model.DestinationId);

#line default
#line hidden
            EndContext();
            BeginContext(283, 13, true);
            WriteLiteral("</p>\r\n\r\n\r\n<p>");
            EndContext();
            BeginContext(297, 40, false);
#line 17 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(337, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(347, 67, false);
#line 18 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Details.cshtml"
Write(Html.ActionLink("Edit Review", "Edit", new { id = Model.ReviewId }));

#line default
#line hidden
            EndContext();
            BeginContext(414, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(424, 83, false);
#line 19 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Details.cshtml"
Write(Html.ActionLink("Add a Destination", "AddDestination", new { id = Model.ReviewId }));

#line default
#line hidden
            EndContext();
            BeginContext(507, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(517, 71, false);
#line 20 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Reviews\Details.cshtml"
Write(Html.ActionLink("Delete Review", "Delete", new { id = Model.ReviewId }));

#line default
#line hidden
            EndContext();
            BeginContext(588, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelBlog.Models.Review> Html { get; private set; }
    }
}
#pragma warning restore 1591
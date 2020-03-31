#pragma checksum "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d554d4c9b888c6fd983b28d9c7ddf08aa1b85d65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destinations_Details), @"mvc.1.0.view", @"/Views/Destinations/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Destinations/Details.cshtml", typeof(AspNetCore.Views_Destinations_Details))]
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
#line 4 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml"
using TravelBlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d554d4c9b888c6fd983b28d9c7ddf08aa1b85d65", @"/Views/Destinations/Details.cshtml")]
    public class Views_Destinations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelBlog.Models.Destination>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(96, 44, true);
            WriteLiteral("\r\n<h2>Destination Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(141, 44, false);
#line 9 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(185, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(188, 40, false);
#line 9 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(228, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml"
 if(@Model.Reviews.Count == 0)
{

#line default
#line hidden
            BeginContext(272, 57, true);
            WriteLiteral("  <p>This destination doesn\'t have any reviews yet!</p>\r\n");
            EndContext();
#line 14 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(341, 29, true);
            WriteLiteral("  <h4>Reviews:</h4>\r\n  <ul>\r\n");
            EndContext();
#line 19 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml"
   foreach(Review review in Model.Reviews)
  {

#line default
#line hidden
            BeginContext(419, 16, true);
            WriteLiteral("    <li>Review: ");
            EndContext();
            BeginContext(436, 12, false);
#line 21 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml"
           Write(review.Title);

#line default
#line hidden
            EndContext();
            BeginContext(448, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 22 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml"
  }

#line default
#line hidden
            BeginContext(460, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
#line 24 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml"
}

#line default
#line hidden
            BeginContext(472, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(478, 43, false);
#line 26 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml"
Write(Html.ActionLink("Back to reviews", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(521, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(531, 77, false);
#line 27 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml"
Write(Html.ActionLink("Edit Destination", "Edit", new { id = Model.DestinationId }));

#line default
#line hidden
            EndContext();
            BeginContext(608, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(618, 81, false);
#line 28 "C:\Users\ThinkPad\desktop\TravelBlog.Solution\TravelBlog\Views\Destinations\Details.cshtml"
Write(Html.ActionLink("Delete Destination", "Delete", new { id = Model.DestinationId }));

#line default
#line hidden
            EndContext();
            BeginContext(699, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelBlog.Models.Destination> Html { get; private set; }
    }
}
#pragma warning restore 1591
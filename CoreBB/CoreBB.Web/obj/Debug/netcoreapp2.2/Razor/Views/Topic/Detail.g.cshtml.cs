#pragma checksum "\\Mac\Home\Documents\Projects\CoreBB\CoreBB.Web\Views\Topic\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3464fff1b68fd5abf5838ba1fb47ea76c5a5561"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topic_Detail), @"mvc.1.0.view", @"/Views/Topic/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Topic/Detail.cshtml", typeof(AspNetCore.Views_Topic_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3464fff1b68fd5abf5838ba1fb47ea76c5a5561", @"/Views/Topic/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Topic_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreBB.Web.Models.Topic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "\\Mac\Home\Documents\Projects\CoreBB\CoreBB.Web\Views\Topic\Detail.cshtml"
  
    ViewBag.Title = Model.Title;

#line default
#line hidden
            BeginContext(73, 21, true);
            WriteLiteral("\r\n<h3>Original</h3>\r\n");
            EndContext();
            BeginContext(95, 36, false);
#line 7 "\\Mac\Home\Documents\Projects\CoreBB\CoreBB.Web\Views\Topic\Detail.cshtml"
Write(Html.Partial("_TopicReading", Model));

#line default
#line hidden
            EndContext();
            BeginContext(131, 28, true);
            WriteLiteral("\r\n<hr />\r\n<h3>Replies</h3>\r\n");
            EndContext();
#line 10 "\\Mac\Home\Documents\Projects\CoreBB\CoreBB.Web\Views\Topic\Detail.cshtml"
 foreach (var t in Model.InverseReplyToTopic) {
    

#line default
#line hidden
            BeginContext(213, 32, false);
#line 11 "\\Mac\Home\Documents\Projects\CoreBB\CoreBB.Web\Views\Topic\Detail.cshtml"
Write(Html.Partial("_TopicReading", t));

#line default
#line hidden
            EndContext();
#line 11 "\\Mac\Home\Documents\Projects\CoreBB\CoreBB.Web\Views\Topic\Detail.cshtml"
                                     ;
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreBB.Web.Models.Topic> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "G:\WORK\Teaching\CoreExample\CoreExample\Pages\Signup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db112d4b0d1adf18fef9f30b471674cb22808c71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreExample.Pages.Pages_Signup), @"mvc.1.0.razor-page", @"/Pages/Signup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Signup.cshtml", typeof(CoreExample.Pages.Pages_Signup), null)]
namespace CoreExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "G:\WORK\Teaching\CoreExample\CoreExample\Pages\_ViewImports.cshtml"
using CoreExample;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db112d4b0d1adf18fef9f30b471674cb22808c71", @"/Pages/Signup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f6265027f0d771b8ac6c4014ed51f8a52887def", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Signup : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "G:\WORK\Teaching\CoreExample\CoreExample\Pages\Signup.cshtml"
  
    ViewData["Title"] = "Signup";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 21, true);
            WriteLiteral("\r\n<h2>Signup</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreExample.Pages.SignupModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoreExample.Pages.SignupModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoreExample.Pages.SignupModel>)PageContext?.ViewData;
        public CoreExample.Pages.SignupModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

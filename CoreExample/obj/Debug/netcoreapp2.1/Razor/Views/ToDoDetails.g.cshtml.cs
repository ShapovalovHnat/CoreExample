#pragma checksum "G:\WORK\Teaching\CoreExample\CoreExample\Views\ToDoDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d5b0ab3ad3480e1d144bc4153100d4641dfdda2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoDetails), @"mvc.1.0.view", @"/Views/ToDoDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ToDoDetails.cshtml", typeof(AspNetCore.Views_ToDoDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d5b0ab3ad3480e1d144bc4153100d4641dfdda2", @"/Views/ToDoDetails.cshtml")]
    public class Views_ToDoDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreExample.Models.ToDo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\WORK\Teaching\CoreExample\CoreExample\Views\ToDoDetails.cshtml"
  
    ViewData["Title"] = "ToDoDetails";

#line default
#line hidden
            BeginContext(81, 126, true);
            WriteLiteral("\r\n<h2>ToDoDetails</h2>\r\n\r\n<div>\r\n    <h4>ToDo</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(208, 68, false);
#line 16 "G:\WORK\Teaching\CoreExample\CoreExample\Views\ToDoDetails.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(276, 56, true);
            WriteLiteral(" |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreExample.Models.ToDo> Html { get; private set; }
    }
}
#pragma warning restore 1591
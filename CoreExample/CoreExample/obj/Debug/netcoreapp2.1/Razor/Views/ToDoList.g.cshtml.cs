#pragma checksum "G:\WORK\Teaching\CoreExample\CoreExample\Views\ToDoList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98153e467b87f672f5aeb739a672c22333978a1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoList), @"mvc.1.0.view", @"/Views/ToDoList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ToDoList.cshtml", typeof(AspNetCore.Views_ToDoList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98153e467b87f672f5aeb739a672c22333978a1d", @"/Views/ToDoList.cshtml")]
    public class Views_ToDoList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreExample.Models.ToDo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\WORK\Teaching\CoreExample\CoreExample\Views\ToDoList.cshtml"
  
    ViewData["Title"] = "ToDoList";

#line default
#line hidden
            BeginContext(91, 192, true);
            WriteLiteral("\r\n<h2>ToDoList</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 19 "G:\WORK\Teaching\CoreExample\CoreExample\Views\ToDoList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(315, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(364, 65, false);
#line 22 "G:\WORK\Teaching\CoreExample\CoreExample\Views\ToDoList.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(429, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(450, 71, false);
#line 23 "G:\WORK\Teaching\CoreExample\CoreExample\Views\ToDoList.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(521, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(542, 69, false);
#line 24 "G:\WORK\Teaching\CoreExample\CoreExample\Views\ToDoList.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(611, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 27 "G:\WORK\Teaching\CoreExample\CoreExample\Views\ToDoList.cshtml"
}

#line default
#line hidden
            BeginContext(650, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreExample.Models.ToDo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
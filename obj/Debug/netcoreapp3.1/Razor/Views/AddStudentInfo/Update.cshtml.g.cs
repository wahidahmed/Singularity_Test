#pragma checksum "H:\Development\myProject\Singularity_Test\Views\AddStudentInfo\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "056bca3d6e340d07e5c7f98e6a02df27da60d3c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddStudentInfo_Update), @"mvc.1.0.view", @"/Views/AddStudentInfo/Update.cshtml")]
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
#line 1 "H:\Development\myProject\Singularity_Test\Views\AddStudentInfo\Update.cshtml"
using Singularity_Test.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"056bca3d6e340d07e5c7f98e6a02df27da60d3c7", @"/Views/AddStudentInfo/Update.cshtml")]
    public class Views_AddStudentInfo_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentInfoViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "H:\Development\myProject\Singularity_Test\Views\AddStudentInfo\Update.cshtml"
  
    ViewData["Title"] = "Update";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "056bca3d6e340d07e5c7f98e6a02df27da60d3c73014", async() => {
                WriteLiteral("\r\n\r\n    <form action=\"/AddStudentInfo/Update\" method=\"post\">\r\n        <input name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 227, "\"", 244, 1);
#nullable restore
#line 12 "H:\Development\myProject\Singularity_Test\Views\AddStudentInfo\Update.cshtml"
WriteAttributeValue("", 235, Model.Id, 235, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" />\r\n        <label for=\"StudentName\">First name:</label><br>\r\n        <input type=\"text\" id=\"fname\" name=\"StudentName\"");
                BeginWriteAttribute("value", "value=\"", 378, "\"", 403, 1);
#nullable restore
#line 14 "H:\Development\myProject\Singularity_Test\Views\AddStudentInfo\Update.cshtml"
WriteAttributeValue("", 385, Model.StudentName, 385, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br>\r\n        <label for=\"Address\">Address:</label><br>\r\n        <input type=\"text\" id=\"lname\" name=\"Address\"");
                BeginWriteAttribute("value", "value=\"", 514, "\"", 535, 1);
#nullable restore
#line 16 "H:\Development\myProject\Singularity_Test\Views\AddStudentInfo\Update.cshtml"
WriteAttributeValue("", 521, Model.Address, 521, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br><br>\r\n        <input type=\"submit\" value=\"Submit\">\r\n    </form>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "H:\Development\myProject\Singularity_Test\Views\AddStudentInfo\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e9ead36f3e6a4f5bd5be46f974538f8e7a056fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddStudentInfo_Delete), @"mvc.1.0.view", @"/Views/AddStudentInfo/Delete.cshtml")]
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
#line 1 "H:\Development\myProject\Singularity_Test\Views\AddStudentInfo\Delete.cshtml"
using Singularity_Test.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9ead36f3e6a4f5bd5be46f974538f8e7a056fe", @"/Views/AddStudentInfo/Delete.cshtml")]
    public class Views_AddStudentInfo_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentInfoViewModel>
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
#line 3 "H:\Development\myProject\Singularity_Test\Views\AddStudentInfo\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e9ead36f3e6a4f5bd5be46f974538f8e7a056fe3014", async() => {
                WriteLiteral("\r\n\r\n    <form action=\"/AddStudentInfo/Delete\" method=\"post\">\r\n        <label for=\"StudentName\">Id:</label><br>\r\n        <input name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 277, "\"", 294, 1);
#nullable restore
#line 13 "H:\Development\myProject\Singularity_Test\Views\AddStudentInfo\Delete.cshtml"
WriteAttributeValue("", 285, Model.Id, 285, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly /><br>\r\n        <label for=\"StudentName\">First name:</label><br>\r\n        <input type=\"text\" id=\"fname\" name=\"StudentName\"");
                BeginWriteAttribute("value", " value=\"", 427, "\"", 453, 1);
#nullable restore
#line 15 "H:\Development\myProject\Singularity_Test\Views\AddStudentInfo\Delete.cshtml"
WriteAttributeValue("", 435, Model.StudentName, 435, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly><br>\r\n        <label for=\"Address\">Address:</label><br>\r\n        <input type=\"text\" id=\"lname\" name=\"Address\"");
                BeginWriteAttribute("value", " value=\"", 573, "\"", 595, 1);
#nullable restore
#line 17 "H:\Development\myProject\Singularity_Test\Views\AddStudentInfo\Delete.cshtml"
WriteAttributeValue("", 581, Model.Address, 581, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly><br><br>\r\n        <input type=\"submit\" value=\"Submit\">\r\n    </form>\r\n");
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
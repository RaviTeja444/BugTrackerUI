#pragma checksum "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46cf75a573afd1fcdfe7ffc5bb6d6e931d4752a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Register.cshtml", typeof(AspNetCore.Views_Home_Register))]
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
#line 1 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\_ViewImports.cshtml"
using BugManagerUI;

#line default
#line hidden
#line 2 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\_ViewImports.cshtml"
using BugManagerUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46cf75a573afd1fcdfe7ffc5bb6d6e931d4752a6", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"339893a7cd3da4f58a646879c2a5eaa755202ce2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BugManagerUI.Models.Register>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(82, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(92, 17, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b287f1018b9643c2b14cba56093e7b69", async() => {
                BeginContext(98, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(109, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(111, 2223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cce222ae0548dfa1576db266fea904", async() => {
                BeginContext(117, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 11 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Register.cshtml"
     using (Html.BeginForm("RegisterDetails", "Home", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(199, 347, true);
                WriteLiteral(@"    <div class=""top-buffer"" style=""padding:70px;""></div>
    <div class=""panel panel-primary"">
        <div class=""panel-heading"">Enter Details to Register</div>
        <div class=""form-horizontal"">
            <div class=""panel-body"">
                <label class=""control-label text-secondary col-md-2"">First Name</label>
                ");
                EndContext();
                BeginContext(547, 33, false);
#line 19 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Register.cshtml"
           Write(Html.TextBoxFor(x => x.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(580, 164, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                <label class=\"control-label text-secondary col-md-2\">Last Name</label>\r\n                ");
                EndContext();
                BeginContext(745, 32, false);
#line 23 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Register.cshtml"
           Write(Html.TextBoxFor(x => x.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(777, 160, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                <label class=\"control-label text-secondary col-md-2\">Email</label>\r\n                ");
                EndContext();
                BeginContext(938, 29, false);
#line 27 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Register.cshtml"
           Write(Html.TextBoxFor(x => x.Email));

#line default
#line hidden
                EndContext();
                BeginContext(967, 167, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                <label class=\"control-label text-secondary col-md-2\">Phone Number</label>\r\n                ");
                EndContext();
                BeginContext(1135, 31, false);
#line 31 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Register.cshtml"
           Write(Html.TextBoxFor(x => x.Contact));

#line default
#line hidden
                EndContext();
                BeginContext(1166, 167, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                <label class=\"control-label text-secondary col-md-2\">Organization</label>\r\n                ");
                EndContext();
                BeginContext(1334, 36, false);
#line 35 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Register.cshtml"
           Write(Html.TextBoxFor(x => x.Organization));

#line default
#line hidden
                EndContext();
                BeginContext(1370, 161, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                <label class=\"control-label text-secondary col-md-2\">Gender</label>\r\n                ");
                EndContext();
                BeginContext(1532, 93, false);
#line 39 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Register.cshtml"
           Write(Html.DropDownListFor(x => x.Gender, new SelectList(Enum.GetValues(typeof(Gender))), "Select"));

#line default
#line hidden
                EndContext();
                BeginContext(1625, 163, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                <label class=\"control-label text-secondary col-md-2\">Password</label>\r\n                ");
                EndContext();
                BeginContext(1789, 31, false);
#line 43 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Register.cshtml"
           Write(Html.PasswordFor(x=>x.Password));

#line default
#line hidden
                EndContext();
                BeginContext(1820, 171, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                <label class=\"control-label text-secondary col-md-2\">Confirm Password</label>\r\n                ");
                EndContext();
                BeginContext(1992, 38, false);
#line 47 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Register.cshtml"
           Write(Html.PasswordFor(x=>x.ConfirmPassword));

#line default
#line hidden
                EndContext();
                BeginContext(2030, 290, true);
                WriteLiteral(@"
            </div>

            <div class=""panel-body"">
                <div class=""btn-group"" style=""padding-left:200px;"">
                    <input class=""btn btn-primary"" type=""submit"" value=""Register"" />
                </div>
            </div>
        </div>
    </div> 
");
                EndContext();
#line 57 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Register.cshtml"
    }

#line default
#line hidden
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
            EndContext();
            BeginContext(2334, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BugManagerUI.Models.Register> Html { get; private set; }
    }
}
#pragma warning restore 1591
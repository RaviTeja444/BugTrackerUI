#pragma checksum "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bb1d047f2acb2ccc6f902b939068c00665b7adf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bb1d047f2acb2ccc6f902b939068c00665b7adf", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"339893a7cd3da4f58a646879c2a5eaa755202ce2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BugManagerUI.Models.Dashboard>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "15", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(89, 2486, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
    });
    function openStory(num, name, descr) {
        $('#projectstorymodal1 #projName1').val(name);
        $('#projectstorymodal1 #description1').val(descr);
        $('#projectstorymodal1 #storynumber').val(num);
        $('#projectstorymodal1').modal(""show"");
    }

    function openDefect(num, name, descr) {
        $('#projectdefectmodal1 #projName').val(name);
        $('#projectdefectmodal1 #description').val(descr);
        $('#projectdefectmodal1 #storynum').val(num);
        $('#projectdefectmodal1').modal(""show"");
    }

    function SaveStory() {
        var usname = document.getElementById('projName1');
        var usnum = document.getElementById('storynumber');
        var usstatus = document.getElementById('status1');
        var descr = document.getElementById('description1');
        
        $.ajax({
    ");
            WriteLiteral(@"        url: ""/Home/SaveUS?usname"" + usname + ""&usno="" + usnum + ""&usstatus="" + usstatus+""&usdesc=""+descr,
            contentType: ""application/json"",
            type: ""post"",
            success: function (data) {
                window.location.href = ""/Home/Dashboard"";
            }
        })
    }
    function SaveDefect() {
        var defname = document.getElementById('projName');
        var defno = document.getElementById('storynum');
        var defstatus = document.getElementById('status');
        var defdesc = document.getElementById('description');

        $.ajax({
            url: ""/Home/SaveDefect?defname"" + defname + ""&defno="" + defno + ""&defstatus="" + defstatus + ""&defdesc="" + defdesc,
            contentType: ""application/json"",
            type: ""post"",
            success: function (data) {
                window.location.href = ""/Home/Dashboard"";
            }
        })
    }
    
        //$('#usnum').click(function (num, name, desc) {
        //    $('proje");
            WriteLiteral(@"ctstorymodal1 #projName1').val(name);

        //    //$.ajax( {
        //    //    url: ""/Home/CreateUserStory"",
        //    //    data: JSON.stringify(project),
        //    //    contentType: ""application/json"",
        //    //    type: ""post"",
        //    //    success: function (data) {
        //    //        window.location.href = ""/Home/Dashboard"";
        //    //})
        //})
    })

</script>
<html>
");
            EndContext();
            BeginContext(2575, 8075, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9549baf0bed47b587d365ccf4acbc19", async() => {
                BeginContext(2581, 156, true);
                WriteLiteral("\r\n    <div class=\"top-buffer\"></div>\r\n    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\"></div>\r\n        <div class=\"panel-body\">\r\n\r\n");
                EndContext();
#line 77 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Dashboard.cshtml"
             for (int i = 0; i <= Model.Count; i++)
            {

#line default
#line hidden
                BeginContext(2805, 479, true);
                WriteLiteral(@"                <table class=""table table-bordered"">
                    <thead class=""navbar-header"">
                        <tr>
                            <th>ProjectName</th>
                            <th>User Story Number</th>
                            <th>Defect Number</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                ");
                EndContext();
                BeginContext(3285, 20, false);
#line 90 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Dashboard.cshtml"
                           Write(Model[i].projectname);

#line default
#line hidden
                EndContext();
                BeginContext(3305, 131, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <a href=\"javascript:void(0)\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3436, "\"", 3537, 7);
                WriteAttributeValue("", 3446, "openStory(", 3446, 10, true);
#line 93 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 3456, Model[i].userstorynumber, 3456, 25, false);

#line default
#line hidden
                WriteAttributeValue("", 3481, ",", 3481, 1, true);
#line 93 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 3482, Model[i].userstoryname, 3482, 23, false);

#line default
#line hidden
                WriteAttributeValue("", 3505, ",", 3505, 1, true);
#line 93 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 3506, Model[i].userstorydescription, 3506, 30, false);

#line default
#line hidden
                WriteAttributeValue("", 3536, ")", 3536, 1, true);
                EndWriteAttribute();
                BeginContext(3538, 12, true);
                WriteLiteral(" id=\"usnum\">");
                EndContext();
                BeginContext(3551, 24, false);
#line 93 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Dashboard.cshtml"
                                                                                                                                                                         Write(Model[i].userstorynumber);

#line default
#line hidden
                EndContext();
                BeginContext(3575, 135, true);
                WriteLiteral("</a>\r\n                            </td>\r\n                            <td>\r\n                                <a href=\"javascript:void(0)\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3710, "\"", 3803, 7);
                WriteAttributeValue("", 3720, "openDefect(", 3720, 11, true);
#line 96 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 3731, Model[i].defectnumber, 3731, 22, false);

#line default
#line hidden
                WriteAttributeValue("", 3753, ",", 3753, 1, true);
#line 96 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 3754, Model[i].defectname, 3754, 20, false);

#line default
#line hidden
                WriteAttributeValue("", 3774, ",", 3774, 1, true);
#line 96 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 3775, Model[i].defectdescription, 3775, 27, false);

#line default
#line hidden
                WriteAttributeValue("", 3802, ")", 3802, 1, true);
                EndWriteAttribute();
                BeginContext(3804, 13, true);
                WriteLiteral(" id=\"defnum\">");
                EndContext();
                BeginContext(3818, 21, false);
#line 96 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Dashboard.cshtml"
                                                                                                                                                                  Write(Model[i].defectnumber);

#line default
#line hidden
                EndContext();
                BeginContext(3839, 128, true);
                WriteLiteral("</a>\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n");
                EndContext();
#line 101 "C:\Users\Ravi Teja\source\repos\BugTrackerApplicationUI\BugManagerUI\Views\Home\Dashboard.cshtml"
            }

#line default
#line hidden
                BeginContext(3982, 224, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"container\">\r\n        <div class=\"modal\" id=\"projectstorymodal1\" role=\"dialog\">\r\n            <div class=\"modal-dialog modal-lg\">\r\n                <div class=\"modal-content\">\r\n");
                EndContext();
                BeginContext(4465, 1034, true);
                WriteLiteral(@"                    <div class=""modal-body"">
                        <div class=""panel panel-primary"">
                            <div class=""panel-heading""><h4>User Story</h4><button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button></div>
                            <div class=""panel-body"">
                                <div class=""form-row"">
                                    <label class=""text-secondary col-md-3"">User Story Name</label>&nbsp;&nbsp;
                                    <input type=""text"" class=""text-success"" id=""projName1"" /><br /><br />
                                </div>
                                <div class=""form-row"">
                                    <label class=""text-secondary col-md-3"">User Story Number</label>&nbsp;&nbsp;
                                    <input type=""text"" class=""text-success"" id=""storynumber"" readonly /><br /><br />
                                </div>

                                <div class=""form-horizontal form-");
                WriteLiteral("inline\">\r\n");
                EndContext();
                BeginContext(5565, 328, true);
                WriteLiteral(@"                                    <label class=""text-secondary col-md-3"">
                                        Status
                                    </label>&nbsp;&nbsp;
                                    <select class=""form-control small"" id=""status1"" style=""width:35%;"">
                                        ");
                EndContext();
                BeginContext(5893, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fd2d46e7a564976875ee019ca34a2a4", async() => {
                    BeginContext(5911, 4, true);
                    WriteLiteral("Open");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5924, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(5966, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1836e17ea5a430a9b9f34ded3467b52", async() => {
                    BeginContext(5985, 7, true);
                    WriteLiteral("Working");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6001, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(6043, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d8b9f313c07498db9ee6c1cddb76e31", async() => {
                    BeginContext(6062, 9, true);
                    WriteLiteral("Completed");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6080, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(6122, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5eb5f590367b4ecaa85c63c64dcd03d0", async() => {
                    BeginContext(6141, 6, true);
                    WriteLiteral("Closed");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6156, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(6198, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "154b70398b2c4fee9a57c9e94df1a008", async() => {
                    BeginContext(6217, 8, true);
                    WriteLiteral("Deferred");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6234, 61, true);
                WriteLiteral("\r\n                                    </select><br /><br />\r\n");
                EndContext();
                BeginContext(6343, 1185, true);
                WriteLiteral(@"                                </div>
                                <div class=""form-row"">
                                    <label class=""text-secondary col-md-3"">Description</label>&nbsp;&nbsp;
                                    <input type=""text"" class=""text-success"" id=""description1"" /><br /><br />
                                </div>


                                <div class=""form-row"">
                                    <div class=""btn-group"" style=""padding-left:250px;"">
                                        <a class=""btn btn-primary"" id=""Create"" onclick=""SaveStory();"">
                                            <i class=""glyphicon-log-in""></i> Save
                                        </a>
                                    </div>


                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""container"">
 ");
                WriteLiteral("       <div class=\"modal\" id=\"projectdefectmodal1\" role=\"dialog\">\r\n            <div class=\"modal-dialog modal-lg\">\r\n                <div class=\"modal-content\">\r\n");
                EndContext();
                BeginContext(7787, 1017, true);
                WriteLiteral(@"                    <div class=""modal-body"">
                        <div class=""panel panel-primary"">
                            <div class=""panel-heading""><h4>Defect</h4><button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button></div>
                            <div class=""panel-body"">
                                <div class=""form-row"">
                                    <label class=""text-secondary col-md-3"">Defect Name</label>&nbsp;&nbsp;
                                    <input type=""text"" class=""text-success"" id=""projName"" /><br /><br />
                                </div>
                                <div class=""form-row"">
                                    <label class=""text-secondary col-md-3"">Defect Number</label>&nbsp;&nbsp;
                                    <input type=""text"" class=""text-success"" id=""storynum"" readonly/><br /><br />
                                </div>

                                <div class=""form-horizontal form-inline"">
");
                EndContext();
                BeginContext(8870, 327, true);
                WriteLiteral(@"                                    <label class=""text-secondary col-md-3"">
                                        Status
                                    </label>&nbsp;&nbsp;
                                    <select class=""form-control small"" id=""status"" style=""width:35%;"">
                                        ");
                EndContext();
                BeginContext(9197, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbdc26e44032483088187054167633a9", async() => {
                    BeginContext(9215, 4, true);
                    WriteLiteral("Open");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9228, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(9270, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6a1450eb3cb4b56aa94fa21a0dab627", async() => {
                    BeginContext(9289, 7, true);
                    WriteLiteral("Working");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9305, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(9347, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7508891a3393468a98d603cea9095d8c", async() => {
                    BeginContext(9366, 9, true);
                    WriteLiteral("Completed");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9384, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(9426, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e20dcea9e0748b9b595f413e1d213ea", async() => {
                    BeginContext(9445, 6, true);
                    WriteLiteral("Closed");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9460, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(9502, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "243579bb88bc44c0a0cd4285c379a028", async() => {
                    BeginContext(9521, 12, true);
                    WriteLiteral("Not A Defect");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9542, 61, true);
                WriteLiteral("\r\n                                    </select><br /><br />\r\n");
                EndContext();
                BeginContext(9651, 992, true);
                WriteLiteral(@"                                </div>
                                <div class=""form-row"">
                                    <label class=""text-secondary col-md-3"">Description</label>&nbsp;&nbsp;
                                    <input type=""text"" class=""text-success"" id=""description"" /><br /><br />
                                </div>


                                <div class=""form-row"">
                                    <div class=""btn-group"" style=""padding-left:250px;"">
                                        <a class=""btn btn-primary"" id=""Create"" onclick=""SaveDefect();"">
                                            <i class=""glyphicon-log-in""></i> Save
                                        </a>
                                    </div>


                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
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
            BeginContext(10650, 13, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BugManagerUI.Models.Dashboard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
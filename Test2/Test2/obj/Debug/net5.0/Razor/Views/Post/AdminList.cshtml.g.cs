#pragma checksum "C:\Users\naman\Documents\GitHub\Daihoc_FPT_News\Test2\Test2\Views\Post\AdminList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdb1a0e83739df7d295105cb08637cddbbdeb2a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_AdminList), @"mvc.1.0.view", @"/Views/Post/AdminList.cshtml")]
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
#line 1 "C:\Users\naman\Documents\GitHub\Daihoc_FPT_News\Test2\Test2\Views\_ViewImports.cshtml"
using Daihoc_FPT_News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\naman\Documents\GitHub\Daihoc_FPT_News\Test2\Test2\Views\_ViewImports.cshtml"
using Daihoc_FPT_News.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdb1a0e83739df7d295105cb08637cddbbdeb2a1", @"/Views/Post/AdminList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0920572bf03d2705c1affc844da3453f7db91f", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_AdminList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\naman\Documents\GitHub\Daihoc_FPT_News\Test2\Test2\Views\Post\AdminList.cshtml"
  
    ViewData["Title"] = "B??i vi???t";
    Layout = "_Layout - Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdb1a0e83739df7d295105cb08637cddbbdeb2a14254", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <!-- Latest compiled and minified JS -->\r\n");
                WriteLiteral(@" 
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
    <script src=""https://cdn.ckeditor.com/ckeditor5/33.0.0/classic/ckeditor.js""></script>
    <title>Document</title>

    <script>
        $(document).ready(function () {
            $('#example').DataTable();
        });
    </script>
    <style>
        .modal-footer .btn + .btn {
            margin-bottom: 10px;
        }
    </style>

");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdb1a0e83739df7d295105cb08637cddbbdeb2a15919", async() => {
                WriteLiteral(@"
    <button onclick=""window.location.href='/post/add/post'"" style=""width:100px;height:40px;background-color:lightgreen;border-color:white;float:right;margin-bottom:1%;"">Add</button>
    <table id=""example"" class=""display"" style=""width:100%;"">
        <thead>
            <tr>
                <th>T??n</th>
                <th>M?? t???</th>
                <th>T??c gi???</th>
                <th>Chi ti???t</th>
                <th>X??a</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 50 "C:\Users\naman\Documents\GitHub\Daihoc_FPT_News\Test2\Test2\Views\Post\AdminList.cshtml"
             for (int i = 0; i < ViewBag.PostCount; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\naman\Documents\GitHub\Daihoc_FPT_News\Test2\Test2\Views\Post\AdminList.cshtml"
                   Write(ViewBag.Posts[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "C:\Users\naman\Documents\GitHub\Daihoc_FPT_News\Test2\Test2\Views\Post\AdminList.cshtml"
                   Write(ViewBag.Posts[i].Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 55 "C:\Users\naman\Documents\GitHub\Daihoc_FPT_News\Test2\Test2\Views\Post\AdminList.cshtml"
                   Write(ViewBag.Posts[i].PostAccountId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><button");
                BeginWriteAttribute("onclick", " onclick=\"", 1777, "\"", 1813, 3);
                WriteAttributeValue("", 1787, "Edit(", 1787, 5, true);
#nullable restore
#line 56 "C:\Users\naman\Documents\GitHub\Daihoc_FPT_News\Test2\Test2\Views\Post\AdminList.cshtml"
WriteAttributeValue("", 1792, ViewBag.Posts[i].Id, 1792, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1812, ")", 1812, 1, true);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"modal\" data-target=\"#modal-id\">S???a</button></td>\r\n                    <td><button");
                BeginWriteAttribute("onclick", " onclick=\"", 1909, "\"", 1951, 3);
                WriteAttributeValue("", 1919, "DeleteItem(", 1919, 11, true);
#nullable restore
#line 57 "C:\Users\naman\Documents\GitHub\Daihoc_FPT_News\Test2\Test2\Views\Post\AdminList.cshtml"
WriteAttributeValue("", 1930, ViewBag.Posts[i].Id, 1930, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1950, ")", 1950, 1, true);
                EndWriteAttribute();
                WriteLiteral(">X??a</button></td>\r\n                </tr>\r\n");
#nullable restore
#line 59 "C:\Users\naman\Documents\GitHub\Daihoc_FPT_News\Test2\Test2\Views\Post\AdminList.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <th>T??n</th>
                <th>M?? t???</th>
                <th>T??c gi???</th>
                <th>Chi ti???t</th>
                <th>X??a</th>
            </tr>
        </tfoot>
    </table>
    <div class=""modal fade"" id=""modal-id"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header bg-gradient-info"">
                </div>
                <div class=""modal-body"">
                    <div>
                        <span>
                            <label for=""id"">ID</label><span style=""color:red"">*</span>
                            <input type=""text"" id=""id"" readonly />
                        </span>
                        <span>
                            <label for=""posttypeid"">Post Type</label><span style=""color:red"">*</span>
                            <select id=""posttypeid"">
                            </select>
                        </");
                WriteLiteral(@"span>
                    </div>
                    <div>
                        <label for=""postcategoryid"">Post Category</label>
                        <div>
                            <select id=""postcategoryid"">
                            </select>
                        </div>
                    </div>
                    <label for=""postaccountid"">Author</label><span style=""color:red"">*</span>
                    <div><input type=""text"" id=""postaccountid"" readonly /></div>
                    <label for=""postlayoutid"">Post Layout</label><span style=""color:red"">*</span>
                    <div>
                        <select id=""postlayoutid"">
                        </select>
                    </div>
                    <label");
                BeginWriteAttribute("for", " for=\"", 3803, "\"", 3809, 0);
                EndWriteAttribute();
                WriteLiteral(">Post Publish</label><span style=\"color:red\">*</span>\r\n                    <div>\r\n                        <select id=\"postpublishid\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdb1a0e83739df7d295105cb08637cddbbdeb2a111535", async() => {
                    WriteLiteral("Public");
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
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdb1a0e83739df7d295105cb08637cddbbdeb2a112787", async() => {
                    WriteLiteral("Private");
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
                WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 4161, "\"", 4167, 0);
                EndWriteAttribute();
                WriteLiteral(">Post Comment</label><span style=\"color:red\">*</span>\r\n                    <div>\r\n                        <select id=\"postcommentstatusid\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdb1a0e83739df7d295105cb08637cddbbdeb2a114434", async() => {
                    WriteLiteral("Public");
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
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdb1a0e83739df7d295105cb08637cddbbdeb2a115686", async() => {
                    WriteLiteral("Private");
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
                WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 4525, "\"", 4531, 0);
                EndWriteAttribute();
                WriteLiteral(@">Url</label>
                    <div><input type=""text"" id=""url"" readonly /></div>
                    <label for=""Photo"">Photo</label>
                    <div><input type=""text"" id=""photo"" /></div>
                    <label for=""Video"">Video</label>
                    <div><input type=""text"" id=""video"" /></div>
                    <label for=""Name"">Name</label>
                    <div><input type=""text"" id=""name"" /></div>
                    <label for=""description"">Description</label>
                    <div><textarea id=""description""></textarea></div>
                    <label");
                BeginWriteAttribute("for", " for=\"", 5135, "\"", 5141, 0);
                EndWriteAttribute();
                WriteLiteral(">Content</label>\r\n                    <div id=\"editor\" class=\"Text\"></div>\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 5244, "\"", 5250, 0);
                EndWriteAttribute();
                WriteLiteral(@">Published Time</label>
                    <div><input type=""datetime-local"" id=""publishtime"" /></div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default""
                            data-dismiss=""modal"">
                        Close
                    </button>
                    <button type=""button"" class=""btn btn-primary"" id=""btnUpdateItem"" onclick=""Submit()"">
                        Save
                        changes
                    </button>
                </div>
            </div>
        </div>
    </div>
");
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
            WriteLiteral(@"

</html>
<script>
    var posttext;
    ClassicEditor
        .create(document.querySelector('#editor'))
        .then(editor => {
            posttext = editor
        })
        .catch(error => {
            console.error(error);
        });


    function LoadDataPostType() {
        $.ajax({
            url: ""https://localhost:5001/posttype/api/list"",
            type: ""GET"",
            async: 'true',
            contentType: ""application/json"",
            success: function (responseData) {
                postLayoutData = JSON.parse(responseData);
                $.each(postLayoutData, function (index, item) {
                    var data = {
                        id: item.Id,
                        text: item.Name
                    };
                    var newOption = new Option(data.text, data.id, false, false);
                    $(""#posttypeid"").append(newOption).trigger('change');
                });
            },
            error: function (e) {

     ");
            WriteLiteral(@"       }
        });
    }
    function LoadDataPostLayout() {
        $.ajax({
            url: ""https://localhost:5001/postlayout/api/list"",
            type: ""GET"",
            async: 'true',
            contentType: ""application/json"",
            success: function (responseData) {
                postLayoutData = JSON.parse(responseData);
                $.each(postLayoutData, function (index, item) {
                    var data = {
                        id: item.Id,
                        text: item.Name
                    };
                    var newOption = new Option(data.text, data.id, false, false);
                    $(""#postlayoutid"").append(newOption).trigger('change');
                });
            },
            error: function (e) {

            }
        });
    }
    function LoadDataPostCategory() {
        $.ajax({
            url: ""https://localhost:5001/postcategory/api/list"",
            type: ""GET"",
            async: 'true',
            content");
            WriteLiteral(@"Type: 'application/json',
            success: function (responseData) {
                postcategorydata = JSON.parse(responseData);
                $.each(postcategorydata, function (index, item) {
                    var data = {
                        id: item.Id,
                        text: item.Name
                    };
                    var newOption = new Option(data.text, data.id, false, false);
                    $(""#postcategoryid"").append(newOption).trigger('change');
                });
            }
        })
    }
    
    function Submit() {
        Swal.fire({
            type: 'question',
            title: 'Confirm?',
            text: 'Do you want to edit this post ?',
            showCloseButton: true,
            showCancelButton: true
        }).then((result) => {
            if (result.isConfirmed) {
                var data = posttext.getData();
                var obj = {
                    ""ID"": $(""#id"").val(),
                    ""PostTypeID"": $");
            WriteLiteral(@"(""#posttypeid"").val(),
                    ""PostAccountID"": 10001,
                    ""PostLayoutID"": $(""#postlayoutid"").val(),
                    ""PostPublishStatusID"": $(""#postpublishid"").val(),
                    ""PostCommentStatusID"": $(""#postcommentstatusid"").val(),
                    ""Active"": 1,
                    ""Url"": $(""#url"").val(),
                    ""Photo"": $(""#photo"").val(),
                    ""Video"": $(""#video"").val(),
                    ""Name"": $(""#name"").val(),
                    ""Description"": $(""#description"").val(),
                    ""Text"": data,
                    ""PublishedTime"": $(""#publishtime"").val()
                }
                $.ajax({
                    url: ""https://localhost:5001/post/api/edit"",
                    type: ""POST"",
                    contentType: ""application/json"",
                    data: JSON.stringify(obj),
                    success: function (responseData) {
                        Swal.fire({
                     ");
            WriteLiteral(@"       type: 'confirm',
                            title: '<strong>???? ch???nh s???a b??i vi???t!</strong>',
                            showCloseButton: true,
                            focusConfirm: false,
                        });
                        location.reload();
                    }
                })
            } else if (result.isDenied) {

            }
        })
    }

    async function GetDetailItem(id) {
        return new Promise((resolve, reject) => {
            $.ajax({
                url: ""https://localhost:5001/post/api/detail/"" + id,
                type: ""GET"",
                async: 'true',
                contentType: ""application/json"",
                success: function (responseData) {
                    Item = JSON.parse(responseData);
                    resolve(Item)
                },
                error: function (e) {
                    reject(e);
                }
            });
        })
    }

    async function Edit(id) {
      ");
            WriteLiteral(@"  $(""#modal-id"").show();
        $('#postcategoryid').find('option').remove().end();
        $('#posttypeid').find('option').remove().end();
        $('#postlayoutid').find('option').remove().end();
        LoadDataPostType();
        LoadDataPostLayout();
        LoadDataPostCategory();
        var obj = await GetDetailItem(id);
        $('#id').val(id);
        $('#postcategoryid option[value=' + obj[0].PostCategoryID + ']').attr('selected', 'selected');
        $('#posttypeid option[value=' + obj[0].PostTypeID + ']').attr('selected', 'selected');
        $('#postlayoutid option[value=' + obj[0].PostLayoutID + ']').attr('selected', 'selected');
        $('#postpublishid option[value=' + obj[0].PostPublishStatusID + ']').attr('selected', 'selected');
        $('#postcommentstatusid option[value=' + obj[0].PostCommentStatusID + ']').attr('selected', 'selected');
        posttext.setData(obj[0].Text);
        $(""#name"").val(obj[0].Name);
        if (obj[0].Photo != null) {
            $(""#phot");
            WriteLiteral(@"o"").val(obj[0].Photo);
        } else {

        }
        if (obj[0].Video != null) {
            $(""#video"").val(obj[0].Video);
        } else {

        }
        $(""#url"").val(obj[0].Url);
        $(""#description"").val(obj[0].Description);
        $(""#publishtime"").val(obj[0].PublishedTime);
    }

    async function DeleteItem(id) {
        Swal.fire({
            icon: 'question',
            title: 'Do you want to delete item',
            showCancelButton: true,
            showCloseButton: true
        }).then((result) => {
            if (result.isConfirmed) {
                var obj = await GetDetailItem(id);
                $.ajax({
                    url: ""https://localhost:5001/post/api/delete"",
                    type: 'POST',
                    contentType: 'application/JSON',
                    data: JSON.stringify({ ""id"": id }),
                    success: function (responseData) {
                        Swal.fire('Deleted!',
                            'I");
            WriteLiteral("tem \' + obj.name + \' has been deleted.\',\r\n                            \'success\');\r\n                        location.reload();\r\n                    }\r\n                })\r\n            }\r\n        })\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a963f7fee56abf5bc5b096c2a702196d5cc7cfc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
#line 1 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\_ViewImports.cshtml"
using TallerWeb.Web;

#line default
#line hidden
#line 2 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\_ViewImports.cshtml"
using TallerWeb.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a963f7fee56abf5bc5b096c2a702196d5cc7cfc0", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba114fa634ffee02de40e7691cee14555eb37eb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TallerWeb.Web.Data.Entities.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
      
        ViewData["Title"] = "Index";
    

#line default
#line hidden
            BeginContext(109, 128, true);
            WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css\" />\r\n    <br />\r\n\r\n    <p>\r\n");
            EndContext();
#line 11 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
         if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
        {

#line default
#line hidden
            BeginContext(319, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(331, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efd47e443539433db471a1e16cca437c", async() => {
                BeginContext(378, 52, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-plus\"></i> New Teacher");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(434, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(447, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 15 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
         if (User.Identity.IsAuthenticated && User.IsInRole("Teacher"))
        {

#line default
#line hidden
            BeginContext(531, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(543, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d58c2f3ac1cf4196aade462cf080aea4", async() => {
                BeginContext(592, 51, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-plus\"></i> New Member");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(647, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(660, 522, true);
            WriteLiteral(@"    </p>

    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h3 class=""panel-title"">Users</h3>
                </div>
                <div class=""panel-body"">
                    <table class=""table table-hover table-responsive table-striped"" id=""MyTable"">
                        <thead>
                            <tr>
                                <th>
                                    ");
            EndContext();
            BeginContext(1183, 44, false);
#line 32 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1343, 44, false);
#line 35 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.UserType));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1503, 41, false);
#line 38 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1544, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1660, 45, false);
#line 41 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Church.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1705, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1821, 47, false);
#line 44 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Church.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1868, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1984, 51, false);
#line 47 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Profession.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2035, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(2151, 43, false);
#line 50 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2194, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(2310, 47, false);
#line 53 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2357, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(2473, 49, false);
#line 56 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.ImageFullPath));

#line default
#line hidden
            EndContext();
            BeginContext(2522, 143, true);
            WriteLiteral("\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 61 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                             if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                            {
                                

#line default
#line hidden
#line 63 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(2884, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3017, 43, false);
#line 67 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(3060, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3200, 43, false);
#line 70 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.UserType));

#line default
#line hidden
            EndContext();
            BeginContext(3243, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3383, 40, false);
#line 73 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3423, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3563, 46, false);
#line 76 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Church.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3609, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3749, 50, false);
#line 79 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Profession.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3799, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3939, 42, false);
#line 82 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(3981, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4121, 46, false);
#line 85 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(4167, 143, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4310, "\"", 4335, 1);
#line 88 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 4316, item.ImageFullPath, 4316, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4336, 144, true);
            WriteLiteral(" style=\"width:80px;height:80px;border-radius:50%\" />\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 91 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                }

#line default
#line hidden
#line 91 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                 
                            }

#line default
#line hidden
            BeginContext(4546, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 93 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                             if (User.Identity.IsAuthenticated && User.IsInRole("Teacher"))
                            {
                                int ii = 0;
                                

#line default
#line hidden
#line 96 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                 foreach (var item in Model)
                                {
                                    Convert.ChangeType(item.UserType, typeof(String));
                                    if ("Teacher".Equals(Convert.ChangeType(item.UserType, typeof(String))))
                                    {
                                        ii = item.Church.Id;
                                    }
                                }

#line default
#line hidden
#line 105 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                 foreach (var item in Model)
                                {

                                    if (item.Church.Id == ii)
                                    {

#line default
#line hidden
            BeginContext(5420, 144, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5565, 43, false);
#line 112 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(5608, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5760, 43, false);
#line 115 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.UserType));

#line default
#line hidden
            EndContext();
            BeginContext(5803, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5955, 40, false);
#line 118 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(5995, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(6147, 46, false);
#line 121 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Church.Name));

#line default
#line hidden
            EndContext();
            BeginContext(6193, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(6345, 50, false);
#line 124 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Profession.Name));

#line default
#line hidden
            EndContext();
            BeginContext(6395, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(6547, 42, false);
#line 127 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(6589, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(6741, 46, false);
#line 130 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(6787, 155, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6942, "\"", 6967, 1);
#line 133 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 6948, item.ImageFullPath, 6948, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6968, 152, true);
            WriteLiteral(" style=\"width:80px;height:80px;border-radius:50%\" />\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 136 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#line 137 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
                                 
                            }

#line default
#line hidden
            BeginContext(7225, 138, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7382, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 147 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Account\Index.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(7456, 315, true);
                WriteLiteral(@"        <script src=""//cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>
        <script src=""/js/deleteDialog.js""></script>

        <script type=""text/javascript"">
            $(document).ready(function () {
                $('#MyTable').DataTable();
            });
        </script>
    ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TallerWeb.Web.Data.Entities.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591

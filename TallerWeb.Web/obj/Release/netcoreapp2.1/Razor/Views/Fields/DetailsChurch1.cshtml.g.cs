#pragma checksum "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60ba70e2ce72d8bdab0e2dc1a69636fa49bb3ea2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fields_DetailsChurch1), @"mvc.1.0.view", @"/Views/Fields/DetailsChurch1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fields/DetailsChurch1.cshtml", typeof(AspNetCore.Views_Fields_DetailsChurch1))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60ba70e2ce72d8bdab0e2dc1a69636fa49bb3ea2", @"/Views/Fields/DetailsChurch1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e711358a6536510e742a51e7365507fbad6578", @"/Views/_ViewImports.cshtml")]
    public class Views_Fields_DetailsChurch1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TallerWeb.Web.Data.Entities.Church>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddMeeting1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditMeeting1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeleteDialog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Vereyon.Web.FlashTagHelper __Vereyon_Web_FlashTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(88, 109, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css\" />\r\n<br />\r\n");
            EndContext();
            BeginContext(197, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("flash", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8269f9ab5d8541c48c11fa489fecf771", async() => {
            }
            );
            __Vereyon_Web_FlashTagHelper = CreateTagHelper<global::Vereyon.Web.FlashTagHelper>();
            __tagHelperExecutionContext.Add(__Vereyon_Web_FlashTagHelper);
#line 9 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
__Vereyon_Web_FlashTagHelper.Dismissable = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("dismissable", __Vereyon_Web_FlashTagHelper.Dismissable, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(225, 128, true);
            WriteLiteral("\r\n<h2>Manage Meetings</h2>\r\n\r\n<div>\r\n    <h4>Church</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(354, 40, false);
#line 17 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(394, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(438, 36, false);
#line 20 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(474, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(521, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36c7fb476ad7405984ba6d88014a0162", async() => {
                BeginContext(598, 47, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-plus\"></i>Metting");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
                                  WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(649, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(655, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "066b8e65abfa4c969c2fb2188b3a125c", async() => {
                BeginContext(727, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
                             WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(743, 485, true);
            WriteLiteral(@"
</div>
<br />

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">Meetings</h3>
            </div>
            <div class=""panel-body"">
                <table class=""table table-hover table-responsive table-striped"" id=""MyTable"">
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(1229, 66, false);
#line 41 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
                           Write(Html.DisplayNameFor(model => model.Meetings.FirstOrDefault().Name));

#line default
#line hidden
            EndContext();
            BeginContext(1295, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1399, 66, false);
#line 44 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
                           Write(Html.DisplayNameFor(model => model.Meetings.FirstOrDefault().Date));

#line default
#line hidden
            EndContext();
            BeginContext(1465, 166, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 50 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
                         foreach (var item in Model.Meetings)
                        {

#line default
#line hidden
            BeginContext(1721, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1830, 39, false);
#line 54 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1869, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1985, 39, false);
#line 57 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2139, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8576f2e0e1b545c6bda343f91dd97c8a", async() => {
                BeginContext(2216, 42, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-pencil\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2262, 55, true);
            WriteLiteral("\r\n                                    <button data-id=\"");
            EndContext();
            BeginContext(2318, 7, false);
#line 61 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
                                                Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2325, 210, true);
            WriteLiteral("\" class=\"btn btn-danger deleteItem\" data-toggle=\"modal\" data-target=\"#deleteDialog\"><i class=\"glyphicon glyphicon-trash\"></i></button>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 64 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
                        }

#line default
#line hidden
            BeginContext(2562, 114, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2676, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dabf26a203af4c94b3330932a274e8c8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2708, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2730, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 75 "C:\Users\Joyner Garcia\Documents\Project\juankmazo2020\TallerWeb\TallerWeb.Web\Views\Fields\DetailsChurch1.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(2800, 422, true);
                WriteLiteral(@"    <script src=""//cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>
    <script src=""/js/deleteDialog.js""></script>

    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#MyTable').DataTable();

            // Delete item
            sc_deleteDialog.openModal('deleteItem', true, 'btnYesDelete', '/Fields/DeleteMeeting/', false);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TallerWeb.Web.Data.Entities.Church> Html { get; private set; }
    }
}
#pragma warning restore 1591

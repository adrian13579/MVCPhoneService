#pragma checksum "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1443d97086ce158d10ec9ec7c25775c8e2e94824"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LandlinePhoneCalls_Index), @"mvc.1.0.view", @"/Views/LandlinePhoneCalls/Index.cshtml")]
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
#line 1 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/_ViewImports.cshtml"
using MVCPhoneServiceWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1443d97086ce158d10ec9ec7c25775c8e2e94824", @"/Views/LandlinePhoneCalls/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b079a1b91f763a65c62bc3475ec22a4692397af7", @"/Views/_ViewImports.cshtml")]
    public class Views_LandlinePhoneCalls_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.Models.LandlinePhoneCall>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1443d97086ce158d10ec9ec7c25775c8e2e948243676", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 17 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Extension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 20 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.LandlinePhoneCallDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 26 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 29 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.LandlinePhoneCallDuration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 32 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.LandlinePhoneCallAddressee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 35 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.LandlinePhoneCallCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Extension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Employee.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LandlinePhoneCallDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LandlinePhoneCallDuration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LandlinePhoneCallAddressee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LandlinePhoneCallCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {extension = item.Extension, dateTime = item.LandlinePhoneCallDateTime, employeeId = item.EmployeeId /* id=item.PrimaryKey */}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 67 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {extension = item.Extension, dateTime = item.LandlinePhoneCallDateTime, employeeId = item.EmployeeId /* id=item.PrimaryKey */}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 68 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {extension = item.Extension, dateTime = item.LandlinePhoneCallDateTime, employeeId = item.EmployeeId /* id=item.PrimaryKey */}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 71 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/LandlinePhoneCalls/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.Models.LandlinePhoneCall>> Html { get; private set; }
    }
}
#pragma warning restore 1591
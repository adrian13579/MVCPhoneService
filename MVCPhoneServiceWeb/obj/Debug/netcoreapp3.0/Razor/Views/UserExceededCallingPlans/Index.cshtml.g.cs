#pragma checksum "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c843aae25549bbcd87a9af10281a527f15fed7ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserExceededCallingPlans_Index), @"mvc.1.0.view", @"/Views/UserExceededCallingPlans/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c843aae25549bbcd87a9af10281a527f15fed7ba", @"/Views/UserExceededCallingPlans/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"761e4d19a9ce39eeacb30215e660ca001e815f86", @"/Views/_ViewImports.cshtml")]
    public class Views_UserExceededCallingPlans_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.ViewModels.UserExceededCallingPlan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""border backgroundWhite"">
    <div class=""row"">
        <div class=""col-12"">
            <h2 class=""text-black"">
                Users who have exceeded calling plans
            </h2>
        </div>
    </div>
    <br />

    <table class=""table table-striped border"">
        <tr>
            <th>
                ");
#nullable restore
#line 23 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlanId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MinutesExceeded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MessagesExceeded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 42 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PlanId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MinutesExceeded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MessagesExceeded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 69 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededCallingPlans/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.ViewModels.UserExceededCallingPlan>> Html { get; private set; }
    }
}
#pragma warning restore 1591

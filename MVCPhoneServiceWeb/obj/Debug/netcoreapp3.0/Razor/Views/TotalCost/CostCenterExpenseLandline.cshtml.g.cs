#pragma checksum "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/TotalCost/CostCenterExpenseLandline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79f0ec8e8930185aa3d40a81433ef3273b76eb2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TotalCost_CostCenterExpenseLandline), @"mvc.1.0.view", @"/Views/TotalCost/CostCenterExpenseLandline.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79f0ec8e8930185aa3d40a81433ef3273b76eb2d", @"/Views/TotalCost/CostCenterExpenseLandline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"761e4d19a9ce39eeacb30215e660ca001e815f86", @"/Views/_ViewImports.cshtml")]
    public class Views_TotalCost_CostCenterExpenseLandline : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.ViewModels.TotalCostViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/TotalCost/CostCenterExpenseLandline.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""border backgroundWhite"">
    <div class=""row"">
        <h2 class=""text-black"">
            Cost Center Expenses
        </h2>
    </div>
    <br />

    <table class=""table table-striped border"">
        <tr>
            <th>
                ");
#nullable restore
#line 21 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/TotalCost/CostCenterExpenseLandline.cshtml"
           Write(Html.DisplayNameFor(model => model.CostCenter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/TotalCost/CostCenterExpenseLandline.cshtml"
           Write(Html.DisplayNameFor(model => model.Expense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 28 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/TotalCost/CostCenterExpenseLandline.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/TotalCost/CostCenterExpenseLandline.cshtml"
               Write(Html.DisplayFor(modelItem => item.CostCenter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/TotalCost/CostCenterExpenseLandline.cshtml"
               Write(Html.DisplayFor(modelItem => item.Expense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 43 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/TotalCost/CostCenterExpenseLandline.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.ViewModels.TotalCostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

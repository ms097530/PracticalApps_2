#pragma checksum "E:\Coding\PracticalApps_2\NorthwindMvc\Views\Home\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b28bb82a4493e6cda8f7255c29a99a5f7e90828"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetail), @"mvc.1.0.view", @"/Views/Home/ProductDetail.cshtml")]
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
#line 1 "E:\Coding\PracticalApps_2\NorthwindMvc\Views\_ViewImports.cshtml"
using NorthwindMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Coding\PracticalApps_2\NorthwindMvc\Views\_ViewImports.cshtml"
using NorthwindMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b28bb82a4493e6cda8f7255c29a99a5f7e90828", @"/Views/Home/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10324db967624bce2cebb2dbfaf1321bdbfb158", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Packt.Shared.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Coding\PracticalApps_2\NorthwindMvc\Views\Home\ProductDetail.cshtml"
  
    ViewData["Title"] = "Product Detail - " + Model.ProductName;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Product Detail</h2>\r\n<hr />\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>Product ID</dt>\r\n        <dd>");
#nullable restore
#line 11 "E:\Coding\PracticalApps_2\NorthwindMvc\Views\Home\ProductDetail.cshtml"
       Write(Model.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt>Product Name</dt>\r\n        <dd>");
#nullable restore
#line 13 "E:\Coding\PracticalApps_2\NorthwindMvc\Views\Home\ProductDetail.cshtml"
       Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt>Category ID</dt>\r\n        <dd>");
#nullable restore
#line 15 "E:\Coding\PracticalApps_2\NorthwindMvc\Views\Home\ProductDetail.cshtml"
       Write(Model.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt>Unit Price</dt>\r\n        <dd>");
#nullable restore
#line 17 "E:\Coding\PracticalApps_2\NorthwindMvc\Views\Home\ProductDetail.cshtml"
       Write(Model.UnitPrice.Value.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt>Units In Stock</dt>\r\n        <dd>");
#nullable restore
#line 19 "E:\Coding\PracticalApps_2\NorthwindMvc\Views\Home\ProductDetail.cshtml"
       Write(Model.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Packt.Shared.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591

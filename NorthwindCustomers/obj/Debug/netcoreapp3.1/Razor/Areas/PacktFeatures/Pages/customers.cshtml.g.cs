#pragma checksum "E:\Coding\PracticalApps_2\NorthwindCustomers\Areas\PacktFeatures\Pages\customers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d54c37f3983a9e36eb2a911ffc0c58fe0cbac60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PacktFeatures_Pages_customers), @"mvc.1.0.razor-page", @"/Areas/PacktFeatures/Pages/customers.cshtml")]
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
#line 2 "E:\Coding\PracticalApps_2\NorthwindCustomers\Areas\PacktFeatures\Pages\customers.cshtml"
using Packt.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d54c37f3983a9e36eb2a911ffc0c58fe0cbac60", @"/Areas/PacktFeatures/Pages/customers.cshtml")]
    public class Areas_PacktFeatures_Pages_customers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h1 class=\"display-2\">Customers</h1>\r\n</div>\r\n<div class=\"row\">\r\n   \r\n");
#nullable restore
#line 11 "E:\Coding\PracticalApps_2\NorthwindCustomers\Areas\PacktFeatures\Pages\customers.cshtml"
     foreach(Customer customer in Model.Customers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-6\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 326, "\"", 370, 2);
            WriteAttributeValue("", 333, "shared/_Customer/", 333, 17, true);
#nullable restore
#line 14 "E:\Coding\PracticalApps_2\NorthwindCustomers\Areas\PacktFeatures\Pages\customers.cshtml"
WriteAttributeValue("", 350, customer.CustomerID, 350, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ><h5>");
#nullable restore
#line 14 "E:\Coding\PracticalApps_2\NorthwindCustomers\Areas\PacktFeatures\Pages\customers.cshtml"
                                                            Write(customer.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 14 "E:\Coding\PracticalApps_2\NorthwindCustomers\Areas\PacktFeatures\Pages\customers.cshtml"
                                                                                    Write(customer.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></a>\r\n        </div>\r\n");
#nullable restore
#line 16 "E:\Coding\PracticalApps_2\NorthwindCustomers\Areas\PacktFeatures\Pages\customers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PacktFeatures.Pages.CustomersPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PacktFeatures.Pages.CustomersPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PacktFeatures.Pages.CustomersPageModel>)PageContext?.ViewData;
        public PacktFeatures.Pages.CustomersPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

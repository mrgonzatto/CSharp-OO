#pragma checksum "D:\Unoesc\EAD\2022\PROG_OO\UNOESC\UNOESCWeb\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59d61896e6d3cfb3ff37eea4e0c181ce6817114c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "D:\Unoesc\EAD\2022\PROG_OO\UNOESC\UNOESCWeb\Views\_ViewImports.cshtml"
using UNOESCWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Unoesc\EAD\2022\PROG_OO\UNOESC\UNOESCWeb\Views\_ViewImports.cshtml"
using UNOESCWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Unoesc\EAD\2022\PROG_OO\UNOESC\UNOESCWeb\Views\_ViewImports.cshtml"
using UNOESC.BL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59d61896e6d3cfb3ff37eea4e0c181ce6817114c", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c91a0be42e9dd48bf23a89a189980385a080e0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Customer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Unoesc\EAD\2022\PROG_OO\UNOESC\UNOESCWeb\Views\Customer\Index.cshtml"
 foreach( var customer in Model )
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h3>");
#nullable restore
#line 9 "D:\Unoesc\EAD\2022\PROG_OO\UNOESC\UNOESCWeb\Views\Customer\Index.cshtml"
       Write(customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h4>");
#nullable restore
#line 10 "D:\Unoesc\EAD\2022\PROG_OO\UNOESC\UNOESCWeb\Views\Customer\Index.cshtml"
       Write(customer.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 174, "\"", 209, 2);
            WriteAttributeValue("", 181, "mailto:", 181, 7, true);
#nullable restore
#line 11 "D:\Unoesc\EAD\2022\PROG_OO\UNOESC\UNOESCWeb\Views\Customer\Index.cshtml"
WriteAttributeValue("", 188, customer.EmailAddres, 188, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 12 "D:\Unoesc\EAD\2022\PROG_OO\UNOESC\UNOESCWeb\Views\Customer\Index.cshtml"
       Write(customer.EmailAddres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </div>\r\n");
#nullable restore
#line 15 "D:\Unoesc\EAD\2022\PROG_OO\UNOESC\UNOESCWeb\Views\Customer\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Customer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
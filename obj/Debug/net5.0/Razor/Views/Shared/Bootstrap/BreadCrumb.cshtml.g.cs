#pragma checksum "D:\Projects\Mvc_LoginApp\Views\Shared\Bootstrap\BreadCrumb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b706919f2104ecc9a1aa4abcba8c0eaa83a7cebe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Bootstrap_BreadCrumb), @"mvc.1.0.view", @"/Views/Shared/Bootstrap/BreadCrumb.cshtml")]
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
#line 1 "D:\Projects\Mvc_LoginApp\Views\_ViewImports.cshtml"
using Mvc_Apteka;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Mvc_LoginApp\Views\_ViewImports.cshtml"
using Mvc_Apteka.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b706919f2104ecc9a1aa4abcba8c0eaa83a7cebe", @"/Views/Shared/Bootstrap/BreadCrumb.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b65ed4c61a0589435cd60768a6bc663fc1d06125", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Bootstrap_BreadCrumb : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IDictionary<string, string>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\Mvc_LoginApp\Views\Shared\Bootstrap\BreadCrumb.cshtml"
 if(Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\">Установите атрибут Model</div>\r\n");
#nullable restore
#line 5 "D:\Projects\Mvc_LoginApp\Views\Shared\Bootstrap\BreadCrumb.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <nav aria-label=\"breadcrumb\">\r\n        <ol class=\"breadcrumb\">\r\n");
#nullable restore
#line 10 "D:\Projects\Mvc_LoginApp\Views\Shared\Bootstrap\BreadCrumb.cshtml"
             foreach(var kv in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"breadcrumb-item active\"");
            BeginWriteAttribute("onclick", " onclick=\"", 309, "\"", 345, 3);
            WriteAttributeValue("", 319, "location.href=\'", 319, 15, true);
#nullable restore
#line 12 "D:\Projects\Mvc_LoginApp\Views\Shared\Bootstrap\BreadCrumb.cshtml"
WriteAttributeValue("", 334, kv.Value, 334, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 343, "\';", 343, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "D:\Projects\Mvc_LoginApp\Views\Shared\Bootstrap\BreadCrumb.cshtml"
                                                                                   Write(kv.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 13 "D:\Projects\Mvc_LoginApp\Views\Shared\Bootstrap\BreadCrumb.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ol>\r\n    </nav>    \r\n");
#nullable restore
#line 16 "D:\Projects\Mvc_LoginApp\Views\Shared\Bootstrap\BreadCrumb.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IDictionary<string, string>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c45bcd7be72d385b05cafba5bc5a257ff3064c3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_ProductHolders_History), @"mvc.1.0.view", @"/Areas/User/Views/ProductHolders/History.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects\Mvc_LoginApp\Areas\User\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Mvc_LoginApp\Areas\User\Views\_ViewImports.cshtml"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Mvc_LoginApp\Areas\User\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Mvc_LoginApp\Areas\User\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Mvc_LoginApp\Areas\User\Views\_ViewImports.cshtml"
using pickpoint_delivery_service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Mvc_LoginApp\Areas\User\Views\_ViewImports.cshtml"
using Mvc_LoginApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c45bcd7be72d385b05cafba5bc5a257ff3064c3e", @"/Areas/User/Views/ProductHolders/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb546d46c45126843c38a158e4213a5e45a66ae4", @"/Areas/User/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_User_Views_ProductHolders_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <h2>История изменений товаров каталога</h2>
    <div>
        <a href=""/Home/ClearHistory"">отчистить</a>
    </div>
    <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Время</th>
                    <th scope=""col"">ИД</th>
                    <th scope=""col"">Наименование</th>
                    <th scope=""col"">Изм. объёма</th>
                    <th scope=""col"">Тек. объём</th>
                    <th scope=""col"">Изм. цены</th>
                    <th scope=""col"">Текущая цена</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 20 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"
                 try{
                
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"
                     foreach(var next in appDbContext.ProductActivities)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"col\">");
#nullable restore
#line 27 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"
                                       Write(next.BeginDate.ToLongTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 28 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"
                                       Write(next.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 29 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"
                                       Write(next.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 30 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"
                                       Write(next.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 31 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"
                                       Write(next.ProductCountDev);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 32 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"
                                       Write(next.ProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 33 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"
                                       Write(next.ProductPriceDev);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"col\">");
#nullable restore
#line 34 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"
                                       Write(next.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        </tr>\r\n");
#nullable restore
#line 36 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"
                     
                }
                catch(Exception ex)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"8\">\r\n                            <div class=\"alert alert-danger\">");
#nullable restore
#line 42 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"
                                                       Write(ex.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </td>\r\n                             \r\n                    </tr>\r\n");
#nullable restore
#line 46 "D:\Projects\Mvc_LoginApp\Areas\User\Views\ProductHolders\History.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </tbody>\r\n    </table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AppDbContext appDbContext { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
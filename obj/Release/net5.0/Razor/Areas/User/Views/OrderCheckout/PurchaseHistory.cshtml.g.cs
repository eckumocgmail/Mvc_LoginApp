#pragma checksum "D:\Projects\Mvc_LoginApp\Areas\User\Views\OrderCheckout\PurchaseHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acc433038743ed211b6ef1f861b07c21cd1da684"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_OrderCheckout_PurchaseHistory), @"mvc.1.0.razor-page", @"/Areas/User/Views/OrderCheckout/PurchaseHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/purchase-history")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acc433038743ed211b6ef1f861b07c21cd1da684", @"/Areas/User/Views/OrderCheckout/PurchaseHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb546d46c45126843c38a158e4213a5e45a66ae4", @"/Areas/User/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_User_Views_OrderCheckout_PurchaseHistory : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\Mvc_LoginApp\Areas\User\Views\OrderCheckout\PurchaseHistory.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div align=""center"">
    <h2> История покупок </h2>

    <div class=""card"" style=""margin: 20px;"" align=""left"">
            <div class=""card-header"">
                Покупка 1
            </div>
            <div class=""card-body"">
                <h5 class=""card-title""> Список товаров </h5>
                <div class=""card-text""> 
                    <p>Дата 01.01.2020</p>
                    <p>Сумма 200</p>                    
                    <div class=""card"" style=""margin: 5px;"">
                            <div class=""card-header"">
                                Товар 1
                            </div>
                            <div class=""card-body"">
                                <h5 class=""card-title""> Наименование товара </h5>
                                <div class=""card-text""> 
                                    <p>Кол-во 1</p>
                                    <p>Цена 100</p>
                                    <p>Итого 100</p>                                    
                   ");
            WriteLiteral(@"             </div>                         
                            </div>
                    </div>    
                    <div class=""card"" style=""margin: 5px;"">
                            <div class=""card-header"">
                                Товар 2
                            </div>
                            <div class=""card-body"">
                                <h5 class=""card-title""> Наименование товара </h5>
                                <div class=""card-text""> 
                                    <p>Кол-во 1</p>
                                    <p>Цена 100</p>
                                    <p>Итого 100</p>
                                </div>                           
                            </div>
                    </div>                  
                </div>
                <div align=""right"" style=""margin: 10px;"">
                    <a href=""#"" class=""btn btn-primary btn-sm""> Просмотреть подробную информацию </a>
                </div>
            </div>
    <");
            WriteLiteral(@"/div> 

    <div class=""card"" style=""margin: 20px;"" align=""left"">
            <div class=""card-header"">
                Покупка 2
            </div>
            <div class=""card-body"">
                <h5 class=""card-title""> Список товаров </h5>
                <div class=""card-text""> 
                    <p>Дата 01.01.2020</p>
                    <p>Сумма 200</p>                    
                    <div class=""card"" style=""margin: 5px;"">
                            <div class=""card-header"">
                                Товар 1
                            </div>
                            <div class=""card-body"">
                                <h5 class=""card-title""> Наименование товара </h5>
                                <div class=""card-text""> 
                                    <p>Кол-во 1</p>
                                    <p>Цена 100</p>
                                    <p>Итого 100</p>                                    
                                </div>                         
");
            WriteLiteral(@"                            </div>
                    </div>    
                    <div class=""card"" style=""margin: 5px;"">
                            <div class=""card-header"">
                                Товар 2
                            </div>
                            <div class=""card-body"">
                                <h5 class=""card-title""> Наименование товара </h5>
                                <div class=""card-text""> 
                                    <p>Кол-во 1</p>
                                    <p>Цена 100</p>
                                    <p>Итого 100</p>
                                </div>                           
                            </div>
                    </div>                  
                </div>
                <div align=""right"" style=""margin: 10px;"">
                    <a href=""#"" class=""btn btn-primary btn-sm""> Просмотреть подробную информацию </a>
                </div>
            </div>
    </div>            
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_User_Views_OrderCheckout_PurchaseHistory> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_User_Views_OrderCheckout_PurchaseHistory> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_User_Views_OrderCheckout_PurchaseHistory>)PageContext?.ViewData;
        public Areas_User_Views_OrderCheckout_PurchaseHistory Model => ViewData.Model;
    }
}
#pragma warning restore 1591

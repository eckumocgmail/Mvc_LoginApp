#pragma checksum "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cc33cb5620c58b0bff61f70a6a5b913a003d937"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_SearchProducts_ProductList), @"mvc.1.0.view", @"/Areas/User/Views/SearchProducts/ProductList.cshtml")]
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
#nullable restore
#line 1 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
using Mvc_Apteka.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cc33cb5620c58b0bff61f70a6a5b913a003d937", @"/Areas/User/Views/SearchProducts/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb546d46c45126843c38a158e4213a5e45a66ae4", @"/Areas/User/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_User_Views_SearchProducts_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderCheckoutModel<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("?????????? ???? ????????????????"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card p-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/User/SearchProducts/OrderCheckout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
  
    Layout = "_Layout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
 if( Model == null )
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\"> ???????????? ???? ?????????????????????????? </div>\r\n");
#nullable restore
#line 14 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
}
else
{
    


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n  <main>\r\n \r\n    <div class=\"py-5 text-center\">\r\n\r\n        <h2>???????????????? ????????????</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cc33cb5620c58b0bff61f70a6a5b913a003d9377823", async() => {
                WriteLiteral("\r\n            <div class=\"input-group\">\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4cc33cb5620c58b0bff61f70a6a5b913a003d9378138", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 27 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.PageNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4cc33cb5620c58b0bff61f70a6a5b913a003d9379851", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 28 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.TotalResults);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4cc33cb5620c58b0bff61f70a6a5b913a003d93711566", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 29 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.TotalPages);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4cc33cb5620c58b0bff61f70a6a5b913a003d93713280", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 30 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.SearchQuery);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              <button type=\"submit\" class=\"btn btn-secondary\">??????????</button>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


    </div>
    <div class=""row g-5"">

      <div class=""col-md-5 col-lg-4 order-md-last"">
        <script>
            const focusController = {
                on: function( table ){
                    document.getElementById('focusProductInfoBlock').style.display='block';
                    document.getElementById('focusProductInfoBlock').innerHTML = table;
                    document.getElementById('selectedProductsBlock').style.display='none';
                },
                off: function(){
                    document.getElementById('focusProductInfoBlock').style.display='none';

                    document.getElementById('selectedProductsBlock').style.display='block';

                }
            }
        </script>
        <div id=""focusProductInfoBlock"" style=""display: none;"">

        </div>
        <div id=""selectedProductsBlock"">
<h4 class=""d-flex justify-content-between align-items-center mb-3"">
          <span class=""text-primary""> ???????????????????? ???????????? </span>");
            WriteLiteral("\r\n          <span class=\"badge bg-primary rounded-pill\"> 3 </span>\r\n        </h4>\r\n        <ul class=\"list-group mb-3\">\r\n");
#nullable restore
#line 64 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
             if(Model==null||Model.Selected==null || Model.Selected.Count()==0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-info\"> ???????????? ???? ?????????????? </div> \r\n");
#nullable restore
#line 67 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                 foreach(var item in Model.Selected)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between lh-sm\">\r\n                        <div>\r\n                            <div>\r\n                              <h6 class=\"my-0\"> ");
#nullable restore
#line 75 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                              <small class=\"text-muted\"> \r\n                                  ");
#nullable restore
#line 77 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                             Write(item.ProductCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                              </small>\r\n                            </div>\r\n                            <span class=\"text-muted\">");
#nullable restore
#line 80 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                                                Write(item.ProductCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div align=\"center\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2934, "\"", 2989, 2);
            WriteAttributeValue("", 2941, "/User/SearchProducts/RemoveFromOrder?ID=", 2941, 40, true);
#nullable restore
#line 83 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
WriteAttributeValue("", 2981, item.ID, 2981, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">??????????????</a>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 86 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n\r\n          <li class=\"list-group-item d-flex justify-content-between bg-danger text-white\">\r\n            <span>?????????? (USD)</span>\r\n            <strong>$");
#nullable restore
#line 92 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                Write(Model.Selected.Sum( p => p!=null?p.ProductCost:0 ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n          </li>\r\n        </ul>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cc33cb5620c58b0bff61f70a6a5b913a003d93721435", async() => {
                WriteLiteral(@"
          <div class=""input-group"">
            <input type=""text"" class=""form-control"" placeholder=""??????. ?????????? ??????"">
            <button type=""submit"" class=""btn btn-secondary"">??????????????????</button>
          </div>
          <div class=""input-group"">
              <hr/>
          </div>
          <div class=""input-group"">
            <button type=""submit"" class=""btn btn-primary w-100"">????????????????</button>
          </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n\r\n     \r\n      <div class=\"col-md-7 col-lg-8\">\r\n\r\n\r\n");
#nullable restore
#line 115 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
         if(Model == null || Model.SearchResults==null || Model.SearchResults.Count()  == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-info\"> ???????????? ???? ?????????????? </div>           \r\n");
#nullable restore
#line 118 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
        }else{
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
             foreach(Product item in Model.SearchResults)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\"");
            BeginWriteAttribute("onmouseover", " onmouseover=\"", 4276, "\"", 4339, 3);
            WriteAttributeValue("", 4290, "focusController.on(\'", 4290, 20, true);
#nullable restore
#line 121 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
WriteAttributeValue("", 4310, item.ProductIndicatorsJson, 4310, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4337, "\')", 4337, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                   onmouseleave=\"focusController.off()\" >\r\n                    <div class=\"card-header\" onmouseover=\"this.classList.add(\'active\')\" onmouseleave=\"this.classList.remove(\'active\')\">\r\n                        ");
#nullable restore
#line 124 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\"> ");
#nullable restore
#line 127 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                        <script> alert($table(JSON.parse(\'");
#nullable restore
#line 128 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                                                     Write(item.ProductIndicatorsJson);

#line default
#line hidden
#nullable disable
            WriteLiteral("\')));</script>\r\n                        <div class=\"card-text\">  \r\n                           \r\n");
#nullable restore
#line 131 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                             if(item.ProductImages!=null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\"");
            BeginWriteAttribute("onmouseover", "\r\n                                     onmouseover=\"", 5123, "\"", 5252, 4);
            WriteAttributeValue("", 5175, "setInterval(()=>{", 5175, 17, true);
            WriteAttributeValue(" ", 5192, "document.getElementById(\'nextImage_", 5193, 36, true);
#nullable restore
#line 134 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
WriteAttributeValue("", 5228, item.ID, 5228, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5236, "\').click()},100)", 5236, 16, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                  <div class=\"carousel-inner\"");
            BeginWriteAttribute("id", " id=\"", 5317, "\"", 5339, 2);
            WriteAttributeValue("", 5322, "carousel_", 5322, 9, true);
#nullable restore
#line 135 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
WriteAttributeValue("", 5331, item.ID, 5331, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 136 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                                       foreach( var img in item.ProductImages)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"carousel-item\">\r\n                                              <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 5611, "\"", 5654, 2);
            WriteAttributeValue("", 5617, "/User/SearchProducts/Image?ID=", 5617, 30, true);
#nullable restore
#line 139 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
WriteAttributeValue("", 5647, img.ID, 5647, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"First slide\">\r\n                                            </div>\r\n");
#nullable restore
#line 141 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   \r\n                                  </div>\r\n                                  <script>\r\n                                      document.getElementById(\'carousel_");
#nullable restore
#line 145 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                                                                   Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"').children[2].classList.add('active');
                                  </script>
                                  <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                    <span class=""sr-only"">Previous</span>
                                  </a>
                                  <a class=""carousel-control-next""");
            BeginWriteAttribute("id", " id=\"", 6479, "\"", 6502, 2);
            WriteAttributeValue("", 6484, "nextImage_", 6484, 10, true);
#nullable restore
#line 151 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
WriteAttributeValue("", 6494, item.ID, 6494, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                                    <span class=""sr-only"">Next</span>
                                  </a>
                                </div>
");
#nullable restore
#line 156 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
                                
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <a href=\"javascript:$dialog(console.log)\"\r\n                           class=\"btn btn-primary btn-sm\"\r\n                            > ?????????? ???????????? </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 7124, "\"", 7175, 2);
            WriteAttributeValue("", 7131, "/User/SearchProducts/PushToOrder?ID=", 7131, 36, true);
#nullable restore
#line 162 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
WriteAttributeValue("", 7167, item.ID, 7167, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                           class=\"btn btn-primary btn-sm\"\r\n                            > ???????????????? ?? ?????????????? </a>\r\n                    </div>\r\n                </div> \r\n");
#nullable restore
#line 167 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
          
                 
                            
      </div>
    </div>
  </main>

  <footer class=""my-5 pt-5 text-muted text-center text-small"">
    <p class=""mb-1"">&copy; 2022</p>
    <ul class=""list-inline"">
      <li class=""list-inline-item""><a href=""#""> ???????????????? </a></li>
      <li class=""list-inline-item""><a href=""#""> ???????????????????????? </a></li>
      <li class=""list-inline-item""><a href=""#""> ?????????????????? </a></li>
    </ul>
  </footer>
</div>
");
#nullable restore
#line 186 "D:\Projects\Mvc_LoginApp\Areas\User\Views\SearchProducts\ProductList.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public DeliveryDbContext db { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderCheckoutModel<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

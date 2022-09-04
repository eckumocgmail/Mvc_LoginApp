#pragma checksum "D:\Projects\Mvc_LoginApp\Views\Shared\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd277bdb794fc31c6354205ae3564744db051341"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Product), @"mvc.1.0.razor-page", @"/Views/Shared/Product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd277bdb794fc31c6354205ae3564744db051341", @"/Views/Shared/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b65ed4c61a0589435cd60768a6bc663fc1d06125", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Product : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd277bdb794fc31c6354205ae3564744db0513413222", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 231, "\"", 241, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""author"" content=""Mark Otto, Jacob Thornton, and Bootstrap contributors"">
    <meta name=""generator"" content=""Hugo 0.84.0"">
    <title>Product example · Bootstrap v5.0</title>

    <link rel=""canonical"" href=""https://getbootstrap.com/docs/5.0/examples/product/"">



    <!-- Bootstrap core CSS -->
    <link href=""https://getbootstrap.com/docs/5.0/dist/css/bootstrap.min.css"" rel=""stylesheet"">

    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        user-select: none;
      }

      ");
                WriteLiteral(@"@media (min-width: 768px) {
        .bd-placeholder-img-lg {
          font-size: 3.5rem;
        }
      }
    </style>


    <!-- Custom styles for this template -->
    <link href=""https://getbootstrap.com/docs/5.0/examples/product/product.css"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd277bdb794fc31c6354205ae3564744db0513415459", async() => {
                WriteLiteral(@"

    <header class=""site-header sticky-top py-1"">
        <nav class=""container d-flex flex-column flex-md-row justify-content-between"">
            <a class=""py-2"" href=""#"" aria-label=""Product"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" fill=""none"" stroke=""currentColor"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" class=""d-block mx-auto"" role=""img"" viewBox=""0 0 24 24""><title>Product</title><circle cx=""12"" cy=""12"" r=""10"" /><path d=""M14.31 8l5.74 9.94M9.69 8h11.48M7.38 12l5.74-9.94M9.69 16L3.95 6.06M14.31 16H2.83m13.79-4l-5.74 9.94"" /></svg>
            </a>
            <a class=""py-2 d-none d-md-inline-block"" href=""#"">Tour</a>
            <a class=""py-2 d-none d-md-inline-block"" href=""#"">Product</a>
            <a class=""py-2 d-none d-md-inline-block"" href=""#"">Features</a>
            <a class=""py-2 d-none d-md-inline-block"" href=""#"">Enterprise</a>
            <a class=""py-2 d-none d-md-inline-block"" href=""#"">Support</a>
            <a class");
                WriteLiteral(@"=""py-2 d-none d-md-inline-block"" href=""#"">Pricing</a>
            <a class=""py-2 d-none d-md-inline-block"" href=""#"">Cart</a>
        </nav>
    </header>

    <main>
        <div class=""position-relative overflow-hidden p-3 p-md-5 m-md-3 text-center bg-light"">
            <div class=""col-md-5 p-lg-5 mx-auto my-5"">
                <h1 class=""display-4 fw-normal"">Punny headline</h1>
                <p class=""lead fw-normal"">And an even wittier subheading to boot. Jumpstart your marketing efforts with this example based on Apple’s marketing pages.</p>
                <a class=""btn btn-outline-secondary"" href=""#"">Coming soon</a>
            </div>
            <div class=""product-device shadow-sm d-none d-md-block""></div>
            <div class=""product-device product-device-2 shadow-sm d-none d-md-block""></div>
        </div>

        <div class=""d-md-flex flex-md-equal w-100 my-md-3 ps-md-3"">
            <div class=""bg-dark me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center text-white overflow-hidden");
                WriteLiteral(@""">
                <div class=""my-3 py-3"">
                    <h2 class=""display-5"">Another headline</h2>
                    <p class=""lead"">And an even wittier subheading.</p>
                </div>
                <div class=""bg-light shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
            </div>
            <div class=""bg-light me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
                <div class=""my-3 p-3"">
                    <h2 class=""display-5"">Another headline</h2>
                    <p class=""lead"">And an even wittier subheading.</p>
                </div>
                <div class=""bg-dark shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
            </div>
        </div>

        <div class=""d-md-flex flex-md-equal w-100 my-md-3 ps-md-3"">
            <div class=""bg-light me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
                <div class=""my-3 p-");
                WriteLiteral(@"3"">
                    <h2 class=""display-5"">Another headline</h2>
                    <p class=""lead"">And an even wittier subheading.</p>
                </div>
                <div class=""bg-dark shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
            </div>
            <div class=""bg-primary me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center text-white overflow-hidden"">
                <div class=""my-3 py-3"">
                    <h2 class=""display-5"">Another headline</h2>
                    <p class=""lead"">And an even wittier subheading.</p>
                </div>
                <div class=""bg-light shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
            </div>
        </div>

        <div class=""d-md-flex flex-md-equal w-100 my-md-3 ps-md-3"">
            <div class=""bg-light me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
                <div class=""my-3 p-3"">
                    <");
                WriteLiteral(@"h2 class=""display-5"">Another headline</h2>
                    <p class=""lead"">And an even wittier subheading.</p>
                </div>
                <div class=""bg-body shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
            </div>
            <div class=""bg-light me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
                <div class=""my-3 py-3"">
                    <h2 class=""display-5"">Another headline</h2>
                    <p class=""lead"">And an even wittier subheading.</p>
                </div>
                <div class=""bg-body shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
            </div>
        </div>

        <div class=""d-md-flex flex-md-equal w-100 my-md-3 ps-md-3"">
            <div class=""bg-light me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
                <div class=""my-3 p-3"">
                    <h2 class=""display-5"">Another headline</h");
                WriteLiteral(@"2>
                    <p class=""lead"">And an even wittier subheading.</p>
                </div>
                <div class=""bg-body shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
            </div>
            <div class=""bg-light me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
                <div class=""my-3 py-3"">
                    <h2 class=""display-5"">Another headline</h2>
                    <p class=""lead"">And an even wittier subheading.</p>
                </div>
                <div class=""bg-body shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
            </div>
        </div>
    </main>

    <footer class=""container py-5"">
        <div class=""row"">
            <div class=""col-12 col-md"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" fill=""none"" stroke=""currentColor"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" class=""d-bloc");
                WriteLiteral(@"k mb-2"" role=""img"" viewBox=""0 0 24 24""><title>Product</title><circle cx=""12"" cy=""12"" r=""10"" /><path d=""M14.31 8l5.74 9.94M9.69 8h11.48M7.38 12l5.74-9.94M9.69 16L3.95 6.06M14.31 16H2.83m13.79-4l-5.74 9.94"" /></svg>
                <small class=""d-block mb-3 text-muted"">&copy; 2017–2021</small>
            </div>
            <div class=""col-6 col-md"">
                <h5>Features</h5>
                <ul class=""list-unstyled text-small"">
                    <li><a class=""link-secondary"" href=""#"">Cool stuff</a></li>
                    <li><a class=""link-secondary"" href=""#"">Random feature</a></li>
                    <li><a class=""link-secondary"" href=""#"">Team feature</a></li>
                    <li><a class=""link-secondary"" href=""#"">Stuff for developers</a></li>
                    <li><a class=""link-secondary"" href=""#"">Another one</a></li>
                    <li><a class=""link-secondary"" href=""#"">Last time</a></li>
                </ul>
            </div>
            <div class=""col-6 col-md"">
                WriteLiteral(@"
                <h5>Resources</h5>
                <ul class=""list-unstyled text-small"">
                    <li><a class=""link-secondary"" href=""#"">Resource name</a></li>
                    <li><a class=""link-secondary"" href=""#"">Resource</a></li>
                    <li><a class=""link-secondary"" href=""#"">Another resource</a></li>
                    <li><a class=""link-secondary"" href=""#"">Final resource</a></li>
                </ul>
            </div>
            <div class=""col-6 col-md"">
                <h5>Resources</h5>
                <ul class=""list-unstyled text-small"">
                    <li><a class=""link-secondary"" href=""#"">Business</a></li>
                    <li><a class=""link-secondary"" href=""#"">Education</a></li>
                    <li><a class=""link-secondary"" href=""#"">Government</a></li>
                    <li><a class=""link-secondary"" href=""#"">Gaming</a></li>
                </ul>
            </div>
            <div class=""col-6 col-md"">
                <h5>About</h5>
                WriteLiteral(@"
                <ul class=""list-unstyled text-small"">
                    <li><a class=""link-secondary"" href=""#"">Team</a></li>
                    <li><a class=""link-secondary"" href=""#"">Locations</a></li>
                    <li><a class=""link-secondary"" href=""#"">Privacy</a></li>
                    <li><a class=""link-secondary"" href=""#"">Terms</a></li>
                </ul>
            </div>
        </div>
    </footer>


    <script src=""https://getbootstrap.com/docs/5.0/dist/js/bootstrap.bundle.min.js""></script>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blazor.Bootstrap.Pages.ProductModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Blazor.Bootstrap.Pages.ProductModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Blazor.Bootstrap.Pages.ProductModel>)PageContext?.ViewData;
        public Blazor.Bootstrap.Pages.ProductModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
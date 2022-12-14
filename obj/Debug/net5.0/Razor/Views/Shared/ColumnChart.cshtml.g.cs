#pragma checksum "D:\Projects\Mvc_LoginApp\Views\Shared\ColumnChart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d977d684d69e351521a97c939965c2af248ca7a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ColumnChart), @"mvc.1.0.view", @"/Views/Shared/ColumnChart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d977d684d69e351521a97c939965c2af248ca7a9", @"/Views/Shared/ColumnChart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b65ed4c61a0589435cd60768a6bc663fc1d06125", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_ColumnChart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IDictionary<string,int>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\Mvc_LoginApp\Views\Shared\ColumnChart.cshtml"
 if(Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\">Не задан атрибут Model</div>\r\n");
#nullable restore
#line 6 "D:\Projects\Mvc_LoginApp\Views\Shared\ColumnChart.cshtml"
}
else
{
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



  <script type=""text/javascript"">
    google.charts.load(""current"", {packages:['corechart']});
    google.charts.setOnLoadCallback(drawChart);
    function drawChart() {
      var data = google.visualization.arrayToDataTable([
        [""Element"", ""Density"", { role: ""style"" } ],
        [""Copper"", 8.94, ""#b87333""],
        [""Silver"", 10.49, ""silver""],
        [""Gold"", 19.30, ""gold""],
        [""Platinum"", 21.45, ""color: #e5e4e2""]
      ]);

      var view = new google.visualization.DataView(data);
      view.setColumns([0, 1,
                       { calc: ""stringify"",
                         sourceColumn: 1,
                         type: ""string"",
                         role: ""annotation"" },
                       2]);

      var options = {
        title: ""Density of Precious Metals, in g/cm^3"",
        width: 600,
        height: 400,
        bar: {groupWidth: ""95%""},
        legend: { position: ""none"" },
      };
      var chart = new google.visualization.ColumnChart(d");
            WriteLiteral("ocument.getElementById(\"columnchart_values\"));\r\n      chart.draw(view, options);\r\n  }\r\n  </script>\r\n<div id=\"columnchart_values\" style=\"width: 900px; height: 300px;\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IDictionary<string,int>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\MyFirstProgram\MyFirstProject\Pages\Forums.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "355ac3edfb9206df098873a4c8a9dd63a33c0304"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyFirstProject.Pages.Pages_Forums), @"mvc.1.0.razor-page", @"/Pages/Forums.cshtml")]
namespace MyFirstProject.Pages
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
#line 1 "D:\MyFirstProgram\MyFirstProject\Pages\_ViewImports.cshtml"
using MyFirstProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"355ac3edfb9206df098873a4c8a9dd63a33c0304", @"/Pages/Forums.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48265038771f2dc70cd398bc348589450407462c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Forums : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\MyFirstProgram\MyFirstProject\Pages\Forums.cshtml"
  
    ViewData["Title"] = "Forums";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "D:\MyFirstProgram\MyFirstProject\Pages\Forums.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<p>How to prevent covid-19?</p>
<br />
<br />
<a href=""https://localhost:44373/News"" title=""News"">News</a>
<br />
<br />
<a href=""https://localhost:44373/Index"" title=""Index"">Index</a>
<br />
<br />
<a href=""https://localhost:44373/Accounts"" title=""Accounts"">Accounts</a>
<br />
<br />
<a href=""https://localhost:44373/AboutUs"" title=""AboutUs"">AboutUs</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForumsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForumsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForumsModel>)PageContext?.ViewData;
        public ForumsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

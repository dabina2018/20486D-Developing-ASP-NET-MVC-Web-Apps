#pragma checksum "C:\Users\daveena\source\repos\20486D-Developing-ASP-NET-MVC-Web-Apps\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\TestPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c007b041dac9a3905efe92e6349362a70a9ddb84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ActorsRazorPages.Pages.Pages_TestPage), @"mvc.1.0.razor-page", @"/Pages/TestPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/TestPage.cshtml", typeof(ActorsRazorPages.Pages.Pages_TestPage), null)]
namespace ActorsRazorPages.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\daveena\source\repos\20486D-Developing-ASP-NET-MVC-Web-Apps\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\_ViewImports.cshtml"
using ActorsRazorPages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c007b041dac9a3905efe92e6349362a70a9ddb84", @"/Pages/TestPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1881739dfeb8e15a9e209a6efbe3d40e3613740", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TestPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\daveena\source\repos\20486D-Developing-ASP-NET-MVC-Web-Apps\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\TestPage.cshtml"
  
    ViewData["Title"] = "Test Page";

#line default
#line hidden
            BeginContext(74, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(81, 17, false);
#line 7 "C:\Users\daveena\source\repos\20486D-Developing-ASP-NET-MVC-Web-Apps\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_begin\ActorsRazorPages\ActorsRazorPages\Pages\TestPage.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(98, 37, true);
            WriteLiteral("</h1>\r\n<h2>This is a Test Page</h2>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestPageModel>)PageContext?.ViewData;
        public TestPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\Survey\Views\Home\DisplaySurvey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cfcb6d23c7f6aa0dcd01a9ab718df1a5ff5207c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplaySurvey), @"mvc.1.0.view", @"/Views/Home/DisplaySurvey.cshtml")]
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
#line 1 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\Survey\Views\_ViewImports.cshtml"
using Survey;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\Survey\Views\_ViewImports.cshtml"
using Survey.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cfcb6d23c7f6aa0dcd01a9ab718df1a5ff5207c", @"/Views/Home/DisplaySurvey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ca22d04279975cf66881929195da49b57ca387", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplaySurvey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <h2>Name: ");
#nullable restore
#line 2 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\Survey\Views\Home\DisplaySurvey.cshtml"
         Write(ViewBag.NewSurvey.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h2>Dojo Location: ");
#nullable restore
#line 3 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\Survey\Views\Home\DisplaySurvey.cshtml"
                  Write(ViewBag.NewSurvey.Dojo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h2>Favorite Language: ");
#nullable restore
#line 4 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\Survey\Views\Home\DisplaySurvey.cshtml"
                      Write(ViewBag.NewSurvey.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h2>Comments: ");
#nullable restore
#line 5 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\Survey\Views\Home\DisplaySurvey.cshtml"
             Write(ViewBag.NewSurvey.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
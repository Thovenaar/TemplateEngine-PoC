#pragma checksum "C:\projects\TemplatePoc\TemplatePoc\Views\Shared\DisplayTemplates\Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "912c24d3998102fe4e7d12901071ce8ca8ca8030"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_Footer), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/Footer.cshtml")]
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
#line 1 "C:\projects\TemplatePoc\TemplatePoc\Views\_ViewImports.cshtml"
using TemplatePoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\TemplatePoc\TemplatePoc\Views\_ViewImports.cshtml"
using TemplatePoc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"912c24d3998102fe4e7d12901071ce8ca8ca8030", @"/Views/Shared/DisplayTemplates/Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbee2b484f1b5c111e1547c2df8d1e949a61e417", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TemplatePoc.Models.Footer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<hr />\r\n");
#nullable restore
#line 4 "C:\projects\TemplatePoc\TemplatePoc\Views\Shared\DisplayTemplates\Footer.cshtml"
Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TemplatePoc.Models.Footer> Html { get; private set; }
    }
}
#pragma warning restore 1591

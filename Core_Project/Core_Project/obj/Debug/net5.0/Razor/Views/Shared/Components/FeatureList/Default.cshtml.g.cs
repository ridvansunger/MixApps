#pragma checksum "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Shared\Components\FeatureList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deabb3893181a4e50840fd076ac01322fec56732"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FeatureList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FeatureList/Default.cshtml")]
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
#line 1 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\_ViewImports.cshtml"
using Core_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\_ViewImports.cshtml"
using Core_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Shared\Components\FeatureList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deabb3893181a4e50840fd076ac01322fec56732", @"/Views/Shared/Components/FeatureList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93bae4d5cbbd9b3edbd35b79b5b210735ad680e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FeatureList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feature>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/images/illustrations/hello3.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("hello"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<header>\n    <div class=\"cover bg-light\">\n        <div class=\"container px-3\">\n            <div class=\"row\">\n                <div class=\"col-lg-6 p-2\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "deabb3893181a4e50840fd076ac01322fec567324663", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\n                <div class=\"col-lg-6\">\n");
#nullable restore
#line 10 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Shared\Components\FeatureList\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"mt-5\">\n                            <p class=\"lead text-uppercase mb-1\">");
#nullable restore
#line 13 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Shared\Components\FeatureList\Default.cshtml"
                                                           Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>\n                            <h1 class=\"intro-title marker\" data-aos=\"fade-left\" data-aos-delay=\"50\">");
#nullable restore
#line 14 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Shared\Components\FeatureList\Default.cshtml"
                                                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                            <p class=\"lead fw-normal mt-3\" data-aos=\"fade-up\" data-aos-delay=\"100\">");
#nullable restore
#line 15 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Shared\Components\FeatureList\Default.cshtml"
                                                                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <div class=""social-nav"" data-aos=""fade-up"" data-aos-delay=""200"">
                                <nav role=""navigation"">
                                    <ul class=""nav justify-content-left"">
                                        <li class=""nav-item""><a class=""nav-link"" href=""https://twitter.com/templateflip"" title=""Twitter""><i class=""fab fa-twitter""></i><span class=""menu-title sr-only"">Twitter</span></a></li>
                                        <li class=""nav-item""><a class=""nav-link"" href=""https://www.facebook.com/templateflip"" title=""Facebook""><i class=""fab fa-facebook""></i><span class=""menu-title sr-only"">Facebook</span></a></li>
                                        <li class=""nav-item""><a class=""nav-link"" href=""https://www.instagram.com/templateflip"" title=""Instagram""><i class=""fab fa-instagram""></i><span class=""menu-title sr-only"">Instagram</span></a></li>
                                        <li class=""nav-item""><a class=""nav-link"" href=""https://www.linke");
            WriteLiteral(@"din.com/"" title=""LinkedIn""><i class=""fab fa-linkedin""></i><span class=""menu-title sr-only"">LinkedIn</span></a></li>
                                        <li class=""nav-item""><a class=""nav-link"" href=""https://www.behance.net/templateflip"" title=""Behance""><i class=""fab fa-behance""></i><span class=""menu-title sr-only"">Behance</span></a></li>
                                    </ul>
                                </nav>
                            </div>
                            <div class=""mt-3"" data-aos=""fade-up"" data-aos-delay=""200""><a class=""btn btn-primary shadow-sm mt-1 hover-effect"" href=""#contact"">Bana Ulaşın <i class=""fas fa-arrow-right""></i></a></div>
                        </div>
");
#nullable restore
#line 29 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Shared\Components\FeatureList\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n    <div class=\"wave-bg\"></div>\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feature>> Html { get; private set; }
    }
}
#pragma warning restore 1591
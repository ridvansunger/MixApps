#pragma checksum "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e8827fb0ab7669395ad150712f37574592674c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_EditPortfolio), @"mvc.1.0.view", @"/Views/Portfolio/EditPortfolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e8827fb0ab7669395ad150712f37574592674c0", @"/Views/Portfolio/EditPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93bae4d5cbbd9b3edbd35b79b5b210735ad680e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_EditPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Portfolio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
  
    ViewData["Title"] = "EditPortfolio";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Proje Düzenleme Sayfası</h3>\r\n</div>\r\n");
#nullable restore
#line 11 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
 using (Html.BeginForm("EditPortfolio", "Portfolio", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.HiddenFor(x => x.PortfolioID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.Label("Proje Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Görsel 1</label>\r\n");
#nullable restore
#line 20 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Görsel 2</label>\r\n");
#nullable restore
#line 24 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl2, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ImageUrl2));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Project URL</label>\r\n");
#nullable restore
#line 28 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ProjectUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ProjectUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Fiyat</label>\r\n");
#nullable restore
#line 32 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Tamamlanma Oranı</label>\r\n");
#nullable restore
#line 36 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Value, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Platfotrm</label>\r\n");
#nullable restore
#line 40 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Platform, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Platform));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-info\">Kaydet</button>\r\n");
#nullable restore
#line 47 "D:\YEDEK\Desktop\gitHup\Core_Project\Core_Project\Views\Portfolio\EditPortfolio.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Portfolio> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ozgur\source\repos\ShopApp\ShopApp.WebUI\Views\Shared\_resultmessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5a1b8be4f08f6822831b381dd1909584068cd0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__resultmessage), @"mvc.1.0.view", @"/Views/Shared/_resultmessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_resultmessage.cshtml", typeof(AspNetCore.Views_Shared__resultmessage))]
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
#line 1 "C:\Users\ozgur\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#line 2 "C:\Users\ozgur\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Extensions;

#line default
#line hidden
#line 3 "C:\Users\ozgur\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5a1b8be4f08f6822831b381dd1909584068cd0e", @"/Views/Shared/_resultmessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bba9d18e6cd03824774928bc0c6e7efed7781353", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__resultmessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 62, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 84, "\"", 114, 3);
            WriteAttributeValue("", 92, "alert", 92, 5, true);
            WriteAttributeValue(" ", 97, "alert-", 98, 7, true);
#line 5 "C:\Users\ozgur\source\repos\ShopApp\ShopApp.WebUI\Views\Shared\_resultmessage.cshtml"
WriteAttributeValue("", 104, Model.Css, 104, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(115, 39, true);
            WriteLiteral(">\r\n            <h4 class=\"alert-title\">");
            EndContext();
            BeginContext(155, 11, false);
#line 6 "C:\Users\ozgur\source\repos\ShopApp\ShopApp.WebUI\Views\Shared\_resultmessage.cshtml"
                               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(166, 22, true);
            WriteLiteral("</h4>\r\n            <p>");
            EndContext();
            BeginContext(189, 13, false);
#line 7 "C:\Users\ozgur\source\repos\ShopApp\ShopApp.WebUI\Views\Shared\_resultmessage.cshtml"
          Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(202, 40, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591

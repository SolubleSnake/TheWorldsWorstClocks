#pragma checksum "C:\Users\User\source\repos\The Wolrd's Worst Clocks\The World's Worst Clocks\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8af0c160f6442991caf253764d6d15756ef63629"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(The_World_s_Worst_Clocks.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace The_World_s_Worst_Clocks.Pages
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
#line 1 "C:\Users\User\source\repos\The Wolrd's Worst Clocks\The World's Worst Clocks\Pages\_ViewImports.cshtml"
using The_World_s_Worst_Clocks;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8af0c160f6442991caf253764d6d15756ef63629", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3005c80ad951c1c122fec2c2e0f8a538cd84ea07", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\source\repos\The Wolrd's Worst Clocks\The World's Worst Clocks\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<meta http-equiv=\"Refresh\" content=\"1\" />\r\n<style>\r\n    body {\r\n        background-color: rgb(");
#nullable restore
#line 10 "C:\Users\User\source\repos\The Wolrd's Worst Clocks\The World's Worst Clocks\Pages\Index.cshtml"
                         Write(Model.RGBRed);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 10 "C:\Users\User\source\repos\The Wolrd's Worst Clocks\The World's Worst Clocks\Pages\Index.cshtml"
                                        Write(Model.RGBGreen);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 10 "C:\Users\User\source\repos\The Wolrd's Worst Clocks\The World's Worst Clocks\Pages\Index.cshtml"
                                                         Write(Model.RGBBlue);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n         }\r\n</style>\r\n\r\n<div class=\"text-center\"");
            BeginWriteAttribute("style", " style=\"", 265, "\"", 341, 7);
            WriteAttributeValue("", 273, "background-color:rgb(", 273, 21, true);
#nullable restore
#line 14 "C:\Users\User\source\repos\The Wolrd's Worst Clocks\The World's Worst Clocks\Pages\Index.cshtml"
WriteAttributeValue("", 294, Model.RGBRed, 294, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 307, ",", 307, 1, true);
#nullable restore
#line 14 "C:\Users\User\source\repos\The Wolrd's Worst Clocks\The World's Worst Clocks\Pages\Index.cshtml"
WriteAttributeValue(" ", 308, Model.RGBGreen, 309, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 324, ",", 324, 1, true);
#nullable restore
#line 14 "C:\Users\User\source\repos\The Wolrd's Worst Clocks\The World's Worst Clocks\Pages\Index.cshtml"
WriteAttributeValue(" ", 325, Model.RGBBlue, 326, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 340, ")", 340, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <h1 class=\"display-4\">Welcome To The World\'s Worst Clocks ");
#nullable restore
#line 15 "C:\Users\User\source\repos\The Wolrd's Worst Clocks\The World's Worst Clocks\Pages\Index.cshtml"
                                                         Write(Model.TimeColour);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\User\source\repos\The Wolrd's Worst Clocks\The World's Worst Clocks\Pages\Index.cshtml"
                                                                           Write(Model.pi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

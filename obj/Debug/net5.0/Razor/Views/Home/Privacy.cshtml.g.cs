#pragma checksum "C:\Users\HP\Desktop\IFEDAYO SP\RegisterMvc\Registermvc\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d18514b1f9f2b564464a85012dfb2ae9faf21dd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\IFEDAYO SP\RegisterMvc\Registermvc\Views\_ViewImports.cshtml"
using Registermvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\IFEDAYO SP\RegisterMvc\Registermvc\Views\_ViewImports.cshtml"
using Registermvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d18514b1f9f2b564464a85012dfb2ae9faf21dd7", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79b049190e1301a1031a46f1afae7c0472cc992e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Register>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\HP\Desktop\IFEDAYO SP\RegisterMvc\Registermvc\Views\Home\Privacy.cshtml"
  

    ViewData["Title"] = "Welcome!!!!!!!";

#line default
#line hidden
#nullable disable
            WriteLiteral("     <h4> <b>");
#nullable restore
#line 7 "C:\Users\HP\Desktop\IFEDAYO SP\RegisterMvc\Registermvc\Views\Home\Privacy.cshtml"
        Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\r\n");
            WriteLiteral("<h1>");
#nullable restore
#line 10 "C:\Users\HP\Desktop\IFEDAYO SP\RegisterMvc\Registermvc\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<style>
    .big-container {
 background-color: #ddd;
  background-attachment: fixed;
  background-size: cover;
  background-repeat: no-repeat;
  border-radius: 10px;
  padding: 100px;
  margin: 100px;
}

h3{
    color: grey;
}
</style>

<div class=""big-container"">
<p> <b>You details has been saved ,take note of your net income below .</b></p>



<h3> Email:  ");
#nullable restore
#line 32 "C:\Users\HP\Desktop\IFEDAYO SP\RegisterMvc\Registermvc\Views\Home\Privacy.cshtml"
        Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3> Phone Number : ");
#nullable restore
#line 33 "C:\Users\HP\Desktop\IFEDAYO SP\RegisterMvc\Registermvc\Views\Home\Privacy.cshtml"
               Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3> Salary : ");
#nullable restore
#line 34 "C:\Users\HP\Desktop\IFEDAYO SP\RegisterMvc\Registermvc\Views\Home\Privacy.cshtml"
         Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3> Net Income : ");
#nullable restore
#line 35 "C:\Users\HP\Desktop\IFEDAYO SP\RegisterMvc\Registermvc\Views\Home\Privacy.cshtml"
             Write(Model.NetIncome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Register> Html { get; private set; }
    }
}
#pragma warning restore 1591

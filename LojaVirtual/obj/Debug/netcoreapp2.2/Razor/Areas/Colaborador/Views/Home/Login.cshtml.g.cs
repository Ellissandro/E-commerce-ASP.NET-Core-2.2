#pragma checksum "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bbc65db8be5f7f90293aea604177e86d5e1d871"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Home_Login), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Colaborador/Views/Home/Login.cshtml", typeof(AspNetCore.Areas_Colaborador_Views_Home_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bbc65db8be5f7f90293aea604177e86d5e1d871", @"/Areas/Colaborador/Views/Home/Login.cshtml")]
    public class Areas_Colaborador_Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Colaborador>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 331, true);
            WriteLiteral(@"
<main role=""main"">
    <br />
    <br />
    <section class=""container"">
        <aside class=""col-sm-6"">
            <h3 class=""subtitle-doc"">
                Login do Colaborador
            </h3>
            <div id=""code_login_1"">
                <div class=""card"">
                    <article class=""card-body"">
");
            EndContext();
#line 18 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Home\Login.cshtml"
                         if (ViewData["MSG_E"] != null)
                        {

#line default
#line hidden
            BeginContext(542, 58, true);
            WriteLiteral("                            <p class=\"alert alert-danger\">");
            EndContext();
            BeginContext(601, 27, false);
#line 20 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Home\Login.cshtml"
                                                     Write(Html.Raw(ViewData["MSG_E"]));

#line default
#line hidden
            EndContext();
            BeginContext(628, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 21 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Home\Login.cshtml"

                        }                  

#line default
#line hidden
            BeginContext(681, 1167, true);
            WriteLiteral(@"                        <h4 class=""card-title mb-4 mt-1"">Entrar</h4>
                        <form method=""post"">
                            <div class=""form-group"">
                                <label>E-mail</label>
                                <input asp-for=""Email"" class=""form-control"" placeholder=""Email"" type=""email"">
                            </div> <!-- form-group// -->
                            <div class=""form-group"">
                                <a class=""float-right"" href=""#"">Esqueceu?</a>
                                <label>Senha</label>
                                <input asp-for=""Senha"" class=""form-control"" placeholder=""******"" type=""password"">
                            </div> <!-- form-group// -->
                            <div class=""form-group"">
                                <button type=""submit"" class=""btn btn-primary btn-block""> Acessar </button>
                            </div> <!-- form-group// -->
                        </form>
                 ");
            WriteLiteral("   </article>\r\n                </div> <!-- card.// -->\r\n            </div> <!-- code-wrap.// -->\r\n        </aside>\r\n    </section>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Colaborador> Html { get; private set; }
    }
}
#pragma warning restore 1591

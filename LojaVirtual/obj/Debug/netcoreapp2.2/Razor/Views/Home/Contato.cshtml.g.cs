#pragma checksum "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "092a4c9a8ca36e9d1c53b917256c3853624e1de1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contato), @"mvc.1.0.view", @"/Views/Home/Contato.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contato.cshtml", typeof(AspNetCore.Views_Home_Contato))]
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
#line 2 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"092a4c9a8ca36e9d1c53b917256c3853624e1de1", @"/Views/Home/Contato.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe432dc0fde64388285e47294a860c879dd4e8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/ContatoAcao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
  
    ViewData["Title"] = "Contato";
    LojaVirtual.Models.Contato contato = (LojaVirtual.Models.Contato) ViewData["CONTATO"];

#line default
#line hidden
            BeginContext(137, 1466, true);
            WriteLiteral(@"
    <main role=""main"">
        <br />
        <br />
        <div class=""container"">
            <div class=""row"">
                <aside class=""col-md-6"">
                    <h4 class=""subtitle-doc"">
                        # Outros contatos
                        <a href=""#"" data-html=""code_desc_simple"" class=""showcode"">[code]</a>
                    </h4>
                    <div id=""code_desc_simple"">
                        <div class=""box"">
                            <dl>
                                <dt>Devolução/Garantia: </dt>
                                <dd>devolucao@lojavirtual.com.br</dd>
                            </dl>
                            <dl>
                                <dt>Televendas: </dt>
                                <dd>(61) 4000-2000</dd>
                            </dl>
                            <dl>
                                <dt>SAC:</dt>
                                <dd>sac@lojavirtual.com.br</dd>
                           ");
            WriteLiteral(@" </dl>
                        </div> <!-- box.// -->
                    </div> <!-- code-wrap.// -->
                </aside>
                <aside class=""col-sm-6"">

                    <h4 class=""subtitle-doc"">
                        # Contato
                       
                    </h4>
                    <div>
                        <article class=""card"">
                            <div class=""card-body p-5"">
");
            EndContext();
#line 43 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                                 if (ViewData["MSG_S"] != null)
                                {

#line default
#line hidden
            BeginContext(1703, 67, true);
            WriteLiteral("                                    <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(1771, 17, false);
#line 45 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                                                              Write(ViewData["MSG_S"]);

#line default
#line hidden
            EndContext();
            BeginContext(1788, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 46 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"

                                }

#line default
#line hidden
            BeginContext(1831, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                                 if (ViewData["MSG_E"] != null)
                                {

#line default
#line hidden
            BeginContext(1933, 66, true);
            WriteLiteral("                                    <p class=\"alert alert-danger\">");
            EndContext();
            BeginContext(2000, 27, false);
#line 51 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                                                             Write(Html.Raw(ViewData["MSG_E"]));

#line default
#line hidden
            EndContext();
            BeginContext(2027, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 52 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"

                                }

#line default
#line hidden
            BeginContext(2070, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2104, 2577, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "092a4c9a8ca36e9d1c53b917256c3853624e1de18191", async() => {
                BeginContext(2163, 632, true);
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <label for=""nome"">Nome</label>
                                        <div class=""input-group"">
                                            <div class=""input-group-prepend"">
                                                <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                            </div>
                                            <input type=""text"" id=""nome"" class=""form-control"" name=""nome"" placeholder=""""
                                                   required=""""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2795, "\"", 2841, 1);
#line 63 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
WriteAttributeValue("", 2803, contato != null ? contato.Nome : "", 2803, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2842, 713, true);
                WriteLiteral(@">
                                        </div> <!-- input-group.// -->
                                    </div> <!-- form-group.// -->

                                    <div class=""form-group"">
                                        <label for=""email"">E-mail</label>
                                        <div class=""input-group"">
                                            <div class=""input-group-prepend"">
                                                <span class=""input-group-text""><i class=""fa fa-at""></i></span>
                                            </div>
                                            <input type=""text"" id=""email"" class=""form-control"" name=""email"" placeholder=""""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3555, "\"", 3602, 1);
#line 73 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
WriteAttributeValue("", 3563, contato != null ? contato.Email : "", 3563, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3603, 649, true);
                WriteLiteral(@">
                                        </div> <!-- input-group.// -->
                                    </div> <!-- form-group.// -->

                                    <div class=""row"">
                                        <div class=""col-sm-12"">
                                            <div class=""form-group"">
                                                <label for=""texto""><span class=""hidden-xs"">Texto</span> </label>
                                                <div class=""form-inline"">
                                                    <textarea class=""form-control"" name=""texto"" id=""texto"" style=""width:100%"">");
                EndContext();
                BeginContext(4254, 35, false);
#line 82 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                                                                                                                          Write(contato != null ? contato.Nome : "");

#line default
#line hidden
                EndContext();
                BeginContext(4290, 384, true);
                WriteLiteral(@"</textarea>

                                                </div>
                                            </div>
                                        </div>
                                    </div> <!-- row.// -->
                                    <button class=""subscribe btn btn-primary btn-block"" type=""submit""> Enviar </button>
                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4681, 246, true);
            WriteLiteral("\r\n                            </div> <!-- card-body.// -->\r\n                        </article> <!-- card.// -->\r\n\r\n                    </div> <!-- code-wrap.// -->\r\n\r\n                </aside>\r\n            </div>\r\n        </div>\r\n    </main>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

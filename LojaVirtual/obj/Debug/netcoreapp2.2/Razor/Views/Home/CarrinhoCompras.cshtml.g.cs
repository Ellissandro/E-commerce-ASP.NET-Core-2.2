#pragma checksum "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\Home\CarrinhoCompras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a38ebf9e8132b3e72b9fe35f3233b341e7f96e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarrinhoCompras), @"mvc.1.0.view", @"/Views/Home/CarrinhoCompras.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CarrinhoCompras.cshtml", typeof(AspNetCore.Views_Home_CarrinhoCompras))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a38ebf9e8132b3e72b9fe35f3233b341e7f96e7", @"/Views/Home/CarrinhoCompras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe432dc0fde64388285e47294a860c879dd4e8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CarrinhoCompras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\eliss\source\repos\LojaVirtual\LojaVirtual\Views\Home\CarrinhoCompras.cshtml"
  
    ViewData["Title"] = "CarrinhoCompras";

#line default
#line hidden
            BeginContext(53, 2213, true);
            WriteLiteral(@"
    <main role=""main"">





        <section class=""container"" id=""order"" style=""margin-top: 50px"">

            <h2 class=""title-doc""># Order </h2>


            <h4 class=""subtitle-doc"">
                # Shopping cart
                <a href=""#"" data-html=""code_cart"" class=""showcode"">[code]</a>
            </h4>
            <div id=""code_cart"">
                <div class=""card"">
                    <table class=""table table-hover shopping-cart-wrap"">
                        <thead class=""text-muted"">
                            <tr>
                                <th scope=""col"">Product</th>
                                <th scope=""col"" width=""120"">Quantity</th>
                                <th scope=""col"" width=""120"">Price</th>
                                <th scope=""col"" width=""200"" class=""text-right"">Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                       ");
            WriteLiteral(@"         <td>
                                    <figure class=""media"">
                                        <div class=""img-wrap""><img src=""images/items/1.jpg"" class=""img-thumbnail img-sm""></div>
                                        <figcaption class=""media-body"">
                                            <h6 class=""title text-truncate"">Product name goes here </h6>
                                            <dl class=""dlist-inline small"">
                                                <dt>Size: </dt>
                                                <dd>XXL</dd>
                                            </dl>
                                            <dl class=""dlist-inline small"">
                                                <dt>Color: </dt>
                                                <dd>Orange color</dd>
                                            </dl>
                                        </figcaption>
                                    </figure>
                   ");
            WriteLiteral("             </td>\r\n                                <td>\r\n                                    <select class=\"form-control\">\r\n                                        ");
            EndContext();
            BeginContext(2266, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a38ebf9e8132b3e72b9fe35f3233b341e7f96e75713", async() => {
                BeginContext(2274, 1, true);
                WriteLiteral("1");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2284, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2326, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a38ebf9e8132b3e72b9fe35f3233b341e7f96e76924", async() => {
                BeginContext(2334, 1, true);
                WriteLiteral("2");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2344, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2386, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a38ebf9e8132b3e72b9fe35f3233b341e7f96e78135", async() => {
                BeginContext(2394, 1, true);
                WriteLiteral("3");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2404, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2446, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a38ebf9e8132b3e72b9fe35f3233b341e7f96e79346", async() => {
                BeginContext(2454, 1, true);
                WriteLiteral("4");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2464, 2149, true);
            WriteLiteral(@"
                                    </select>
                                </td>
                                <td>
                                    <div class=""price-wrap"">
                                        <var class=""price"">USD 145</var>
                                        <small class=""text-muted"">(USD5 each)</small>
                                    </div> <!-- price-wrap .// -->
                                </td>
                                <td class=""text-right"">
                                    <a title="""" href="""" class=""btn btn-outline-success"" data-toggle=""tooltip""
                                       data-original-title=""Save to Wishlist""> <i class=""fa fa-heart""></i></a>
                                    <a href="""" class=""btn btn-outline-danger""> × Remove</a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <figure class");
            WriteLiteral(@"=""media"">
                                        <div class=""img-wrap""><img src=""images/items/2.jpg"" class=""img-thumbnail img-sm""></div>
                                        <figcaption class=""media-body"">
                                            <h6 class=""title text-truncate"">Product name goes here </h6>
                                            <dl class=""dlist-inline small"">
                                                <dt>Size: </dt>
                                                <dd>XXL</dd>
                                            </dl>
                                            <dl class=""dlist-inline small"">
                                                <dt>Color: </dt>
                                                <dd>Orange color</dd>
                                            </dl>
                                        </figcaption>
                                    </figure>
                                </td>
                                <td>
      ");
            WriteLiteral("                              <select class=\"form-control\">\r\n                                        ");
            EndContext();
            BeginContext(4613, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a38ebf9e8132b3e72b9fe35f3233b341e7f96e712772", async() => {
                BeginContext(4621, 1, true);
                WriteLiteral("1");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4631, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4673, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a38ebf9e8132b3e72b9fe35f3233b341e7f96e713984", async() => {
                BeginContext(4681, 1, true);
                WriteLiteral("2");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4691, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4733, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a38ebf9e8132b3e72b9fe35f3233b341e7f96e715196", async() => {
                BeginContext(4741, 1, true);
                WriteLiteral("3");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4751, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4793, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a38ebf9e8132b3e72b9fe35f3233b341e7f96e716408", async() => {
                BeginContext(4801, 1, true);
                WriteLiteral("4");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4811, 2159, true);
            WriteLiteral(@"
                                    </select>
                                </td>
                                <td>
                                    <div class=""price-wrap"">
                                        <var class=""price"">USD 35</var>
                                        <small class=""text-muted"">(USD10 each)</small>
                                    </div> <!-- price-wrap .// -->
                                </td>
                                <td class=""text-right"">
                                    <a title="""" href="""" class=""btn btn-outline-success"" data-toggle=""tooltip""
                                       data-original-title=""Save to Wishlist""> <i class=""fa fa-heart""></i></a>
                                    <a href="""" class=""btn btn-outline-danger btn-round""> × Remove</a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <fi");
            WriteLiteral(@"gure class=""media"">
                                        <div class=""img-wrap""><img src=""images/items/3.jpg"" class=""img-thumbnail img-sm""></div>
                                        <figcaption class=""media-body"">
                                            <h6 class=""title text-truncate"">Product name goes here </h6>
                                            <dl class=""dlist-inline small"">
                                                <dt>Size: </dt>
                                                <dd>XXL</dd>
                                            </dl>
                                            <dl class=""dlist-inline small"">
                                                <dt>Color: </dt>
                                                <dd>Orange color</dd>
                                            </dl>
                                        </figcaption>
                                    </figure>
                                </td>
                                <t");
            WriteLiteral("d>\r\n                                    <select class=\"form-control\">\r\n                                        ");
            EndContext();
            BeginContext(6970, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a38ebf9e8132b3e72b9fe35f3233b341e7f96e719847", async() => {
                BeginContext(6978, 1, true);
                WriteLiteral("1");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6988, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(7030, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a38ebf9e8132b3e72b9fe35f3233b341e7f96e721059", async() => {
                BeginContext(7038, 1, true);
                WriteLiteral("2");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7048, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(7090, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a38ebf9e8132b3e72b9fe35f3233b341e7f96e722271", async() => {
                BeginContext(7098, 1, true);
                WriteLiteral("3");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7108, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(7150, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a38ebf9e8132b3e72b9fe35f3233b341e7f96e723483", async() => {
                BeginContext(7158, 1, true);
                WriteLiteral("4");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7168, 5006, true);
            WriteLiteral(@"
                                    </select>
                                </td>
                                <td>
                                    <div class=""price-wrap"">
                                        <var class=""price"">USD 45</var>
                                        <small class=""text-muted"">(USD15 each)</small>
                                    </div> <!-- price-wrap .// -->
                                </td>
                                <td class=""text-right"">
                                    <a title="""" href="""" class=""btn btn-outline-success"" data-toggle=""tooltip""
                                       data-original-title=""Save to Wishlist""> <i class=""fa fa-heart""></i></a>
                                    <a href="""" class=""btn btn-outline-danger btn-round""> × Remove</a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div> <!-- card.// -->
      ");
            WriteLiteral(@"      </div> <!-- code-wrap.// -->
        </section>
        <br />
        <br />
        <section class=""container"">
            <div class=""row"">
                <aside class=""col-md-4"">
                    <h4 class=""subtitle-doc"">
                        # Cálculo de frete
                        <a href=""#"" data-html=""code_desc_simple"" class=""showcode"">[code]</a>
                    </h4>
                    <div id=""code_desc_simple"">
                        <div class=""box"">
                            <dl>
                                <dt>Some info: </dt>
                                <dd>
                                    Dolor sit amet, consectetur adipisicing elit do eiusmod
                                    tempor incididunt
                                </dd>
                            </dl>
                            <dl>
                                <dt>Parameter: </dt>
                                <dd>Value name</dd>
                            </dl>");
            WriteLiteral(@"
                            <dl>
                                <dt>Discount:</dt>
                                <dd>USD 658</dd>
                            </dl>
                        </div> <!-- box.// -->
                    </div> <!-- code-wrap.// -->
                </aside>
                <aside class=""col-md-4"">
                    <h4 class=""subtitle-doc"">
                        # Cupom desconto
                        <a href=""#"" data-html=""code_desc_align"" class=""showcode"">[code]</a>
                    </h4>
                    <div id=""code_desc_align"">
                        <div class=""box"">
                            <dl class=""dlist-align"">
                                <dt>Some info: </dt>
                                <dd> Everything in this life is always tempporary</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Parameter: </dt>
                                <dd>Value name");
            WriteLiteral(@"</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Color:</dt>
                                <dd>Orange and Black</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Material:</dt>
                                <dd>Leather</dd>
                            </dl>
                        </div> <!-- box.// -->
                    </div> <!-- code-wrap.// -->
                </aside>
                <aside class=""col-md-4"">
                    <h4 class=""subtitle-doc"">
                        # Total a pagar
                        <a href=""#"" data-html=""code_desc_right"" class=""showcode"">[code]</a>
                    </h4>
                    <div id=""code_desc_right"">
                        <div class=""box"">
                            <dl class=""dlist-align"">
                                <dt>Parameter: </dt>
                     ");
            WriteLiteral(@"           <dd class=""text-right"">Value name</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Color:</dt>
                                <dd class=""text-right"">Orange and Black</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Material:</dt>
                                <dd class=""text-right"">Leather</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Total cost: </dt>
                                <dd class=""text-right h5 b""> USD195 </dd>
                            </dl>
                        </div> <!-- box.// -->
                    </div> <!-- code-wrap.// -->
                </aside>
            </div>
        </section>
    </main>

");
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

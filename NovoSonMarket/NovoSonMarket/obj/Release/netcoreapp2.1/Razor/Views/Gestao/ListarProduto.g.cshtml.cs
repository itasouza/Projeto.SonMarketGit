#pragma checksum "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb2866d80c4f98a72a5e9387b15f2ef6b9fbb8ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_ListarProduto), @"mvc.1.0.view", @"/Views/Gestao/ListarProduto.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gestao/ListarProduto.cshtml", typeof(AspNetCore.Views_Gestao_ListarProduto))]
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
#line 1 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\_ViewImports.cshtml"
using NovoSonMarket;

#line default
#line hidden
#line 2 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\_ViewImports.cshtml"
using NovoSonMarket.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb2866d80c4f98a72a5e9387b15f2ef6b9fbb8ac", @"/Views/Gestao/ListarProduto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdafbbbd56e614db22d54e7099318f037ccd131a", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_ListarProduto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SysSonMarket.Models.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
  
    ViewData["Title"] = "ListarProduto";

#line default
#line hidden
            BeginContext(100, 2625, true);
            WriteLiteral(@"

<!-- BEGIN CONTENT -->
<div class=""page-content-wrapper"">
    <!-- BEGIN CONTENT BODY -->
    <div class=""page-content"">
        <!-- BEGIN PAGE HEADER-->
        <!-- BEGIN PAGE BAR -->
        <div class=""page-bar"">
            <ul class=""page-breadcrumb"">
                <li>
                    <a href=""#"">Home</a>
                    <i class=""fa fa-circle""></i>
                </li>
                <li>
                    <span>Listagem de Produto</span>
                </li>
            </ul>

        </div>
        <!-- END PAGE BAR -->
        <!-- BEGIN PAGE TITLE-->
        <h1 class=""page-title""></h1>

        <!-- Tela de cadastro genérico-->
        <div class=""row"">
            <div class=""col-md-12"">
                <!-- BEGIN EXAMPLE TABLE PORTLET-->
                <div class=""portlet light bordered"">
                    <div class=""portlet-title"">
                        <div class=""caption font-dark"">
                            <i class=""icon-settings fon");
            WriteLiteral(@"t-dark""></i>
                            <span class=""caption-subject bold uppercase"">Lista de Produto</span>
                        </div>
                        <div class=""tools""> </div>
                    </div>
                    <div class=""portlet-body"">

                        <table class=""table table-striped table-bordered table-hover"" id=""sample_1"">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Nome</th>
                                    <th>Categoria</th>
                                    <th>Fornecedor</th>
                                    <th>Preço de Custo</th>
                                    <th>Preço de Venda</th>
                                    <th>Medição</th>
                                    <th>Ações</th>
                                </tr>
                            </thead>
                            <tfoot>
                  ");
            WriteLiteral(@"              <tr>
                                    <th>Id</th>
                                    <th>Nome</th>
                                    <th>Categoria</th>
                                    <th>Fornecedor</th>
                                    <th>Preço de Custo</th>
                                    <th>Preço de Venda</th>
                                    <th>Medição</th>
                                    <th>Ações</th>
                                </tr>
                            </tfoot>
                            <tbody>

");
            EndContext();
#line 71 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
                                 foreach (var produto in Model)
                                {

#line default
#line hidden
            BeginContext(2825, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2904, 10, false);
#line 74 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
                                   Write(produto.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2914, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2962, 12, false);
#line 75 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
                                   Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2974, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3022, 22, false);
#line 76 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
                                   Write(produto.Categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3044, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3092, 23, false);
#line 77 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
                                   Write(produto.Fornecedor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3115, 51, true);
            WriteLiteral("</td>\r\n                                    <td>(R$)");
            EndContext();
            BeginContext(3167, 20, false);
#line 78 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
                                       Write(produto.PrecoDeCusto);

#line default
#line hidden
            EndContext();
            BeginContext(3187, 51, true);
            WriteLiteral("</td>\r\n                                    <td>(R$)");
            EndContext();
            BeginContext(3239, 20, false);
#line 79 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
                                       Write(produto.PrecoDeVenda);

#line default
#line hidden
            EndContext();
            BeginContext(3259, 49, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n");
            EndContext();
#line 81 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
                                         if (@produto.Medicao == 0)
                                        {

#line default
#line hidden
            BeginContext(3418, 18, true);
            WriteLiteral("<span>Litro</span>");
            EndContext();
#line 82 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
                                                           }
                                        else if (@produto.Medicao == 1)
                                        {

#line default
#line hidden
            BeginContext(3553, 19, true);
            WriteLiteral(" <span>Kilo</span> ");
            EndContext();
#line 84 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
                                                            }
                                        else
                                        {

#line default
#line hidden
            BeginContext(3662, 20, true);
            WriteLiteral("<span>Unidade</span>");
            EndContext();
#line 86 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
                                                             }

#line default
#line hidden
            BeginContext(3685, 153, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3838, "\"", 3878, 2);
            WriteAttributeValue("", 3845, "/Gestao/EditarProduto/", 3845, 22, true);
#line 90 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
WriteAttributeValue("", 3867, produto.Id, 3867, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3879, 55, true);
            WriteLiteral(">Editar</a>\r\n\r\n                                        ");
            EndContext();
            BeginContext(3934, 325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8446a2dc2c00401e933b64f1c5d3a776", async() => {
                BeginContext(4010, 84, true);
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"id\" id=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4094, "\"", 4113, 1);
#line 93 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
WriteAttributeValue("", 4102, produto.Id, 4102, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4114, 138, true);
                WriteLiteral(" />\r\n                                            <button class=\"btn btn-danger\">Deletar</button>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(4259, 86, true);
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
            EndContext();
#line 99 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarProduto.cshtml"
                                }

#line default
#line hidden
            BeginContext(4380, 337, true);
            WriteLiteral(@"
                            </tbody>
                        </table>
                    </div>
                </div>
                <!-- END EXAMPLE TABLE PORTLET-->
            </div>
        </div>
        <!-- fim Tela de cadastro genérico-->


    </div>
    <!-- END CONTENT BODY -->
</div>
<!-- END CONTENT -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SysSonMarket.Models.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

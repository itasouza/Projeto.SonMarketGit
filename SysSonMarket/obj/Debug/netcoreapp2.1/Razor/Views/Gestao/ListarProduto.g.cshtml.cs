#pragma checksum "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d4aa7440cde111852f88c7fd6dffd7f4495a484"
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
#line 1 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\_ViewImports.cshtml"
using SysSonMarket;

#line default
#line hidden
#line 2 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\_ViewImports.cshtml"
using SysSonMarket.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d4aa7440cde111852f88c7fd6dffd7f4495a484", @"/Views/Gestao/ListarProduto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99bb91ac996a6c945ffd3736355a56d8f94cfa04", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_ListarProduto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SysSonMarket.Models.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoProduto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
  
    ViewData["Title"] = "ListarProduto";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(152, 36, true);
            WriteLiteral("\r\n<h2>Listar Produtos</h2>\r\n<hr />\r\n");
            EndContext();
            BeginContext(188, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff15e05a38ce4e3a8d006365c3243180", async() => {
                BeginContext(264, 18, true);
                WriteLiteral("Criar novo Produto");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(286, 16, true);
            WriteLiteral("\r\n\r\n<hr />\r\n\r\n\r\n");
            EndContext();
            DefineSection("scriptgeral", async() => {
                BeginContext(329, 149, true);
                WriteLiteral("\r\n    <script type=\"Text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\"#produtos\").DataTable();\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(481, 388, true);
            WriteLiteral(@"

<table id=""produtos"" class=""table table-striped table-bordered"">
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
    <tbody>
");
            EndContext();
#line 39 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
         foreach (var produto in Model)
        {

#line default
#line hidden
            BeginContext(921, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(952, 10, false);
#line 42 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
           Write(produto.Id);

#line default
#line hidden
            EndContext();
            BeginContext(962, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(986, 12, false);
#line 43 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
           Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(998, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1022, 22, false);
#line 44 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
           Write(produto.Categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1044, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1068, 23, false);
#line 45 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
           Write(produto.Fornecedor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1091, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1115, 20, false);
#line 46 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
           Write(produto.PrecoDeCusto);

#line default
#line hidden
            EndContext();
            BeginContext(1135, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1159, 20, false);
#line 47 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
           Write(produto.PrecoDeVenda);

#line default
#line hidden
            EndContext();
            BeginContext(1179, 25, true);
            WriteLiteral("</td>\r\n            <td>\r\n");
            EndContext();
#line 49 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
                 if (@produto.Medicao == 0)
                {

#line default
#line hidden
            BeginContext(1266, 18, true);
            WriteLiteral("<span>Litro</span>");
            EndContext();
#line 50 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
                                   }
                else if (@produto.Medicao == 1)
                {

#line default
#line hidden
            BeginContext(1353, 19, true);
            WriteLiteral(" <span>Kilo</span> ");
            EndContext();
#line 52 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
                                    }
                else
                {

#line default
#line hidden
            BeginContext(1414, 20, true);
            WriteLiteral("<span>Unidade</span>");
            EndContext();
#line 54 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
                                     }

#line default
#line hidden
            BeginContext(1437, 83, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1520, "\"", 1560, 2);
            WriteAttributeValue("", 1527, "/Gestao/EditarProduto/", 1527, 22, true);
#line 59 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
WriteAttributeValue("", 1549, produto.Id, 1549, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1561, 31, true);
            WriteLiteral(">Editar</a>\r\n\r\n                ");
            EndContext();
            BeginContext(1592, 253, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac6a083b7da3453fbc298a12b9085be8", async() => {
                BeginContext(1668, 60, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\" id=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1728, "\"", 1747, 1);
#line 62 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
WriteAttributeValue("", 1736, produto.Id, 1736, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1748, 90, true);
                WriteLiteral(" />\r\n                    <button class=\"btn btn-danger\">Deletar</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1845, 19, true);
            WriteLiteral("\r\n\r\n        </tr>\r\n");
            EndContext();
#line 67 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarProduto.cshtml"
        }

#line default
#line hidden
            BeginContext(1875, 32, true);
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n\r\n\r\n");
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

#pragma checksum "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarPromocao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "392a65b3af48af82c8674838ee8ee642a648b42e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_ListarPromocao), @"mvc.1.0.view", @"/Views/Gestao/ListarPromocao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gestao/ListarPromocao.cshtml", typeof(AspNetCore.Views_Gestao_ListarPromocao))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"392a65b3af48af82c8674838ee8ee642a648b42e", @"/Views/Gestao/ListarPromocao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99bb91ac996a6c945ffd3736355a56d8f94cfa04", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_ListarPromocao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SysSonMarket.Models.Promocao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoPromocao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Promocao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarPromocao.cshtml"
  
    ViewData["Title"] = "ListarPromocao";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(156, 38, true);
            WriteLiteral("\r\n\r\n<h2>Listar Promoção</h2>\r\n<hr />\r\n");
            EndContext();
            BeginContext(194, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81e5757503324275b65b67e985375bf4", async() => {
                BeginContext(271, 19, true);
                WriteLiteral("Criar nova Promoção");
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
            BeginContext(294, 375, true);
            WriteLiteral(@"

<hr />



    <table id=""dados"" class=""table table-striped table-bordered responsive nowrap"" style=""width:100%"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Produto</th>
                <th>Porcentagem</th>
                <th>Ações</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 29 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarPromocao.cshtml"
             foreach (var promocao in Model)
            {

#line default
#line hidden
            BeginContext(730, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(777, 11, false);
#line 32 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarPromocao.cshtml"
                   Write(promocao.Id);

#line default
#line hidden
            EndContext();
            BeginContext(788, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(820, 13, false);
#line 33 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarPromocao.cshtml"
                   Write(promocao.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(833, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(865, 21, false);
#line 34 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarPromocao.cshtml"
                   Write(promocao.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(886, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(918, 20, false);
#line 35 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarPromocao.cshtml"
                   Write(promocao.Porcentagem);

#line default
#line hidden
            EndContext();
            BeginContext(938, 83, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1021, "\"", 1063, 2);
            WriteAttributeValue("", 1028, "/Gestao/EditarPromocao/", 1028, 23, true);
#line 37 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarPromocao.cshtml"
WriteAttributeValue("", 1051, promocao.Id, 1051, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1064, 39, true);
            WriteLiteral(">Editar</a>\r\n\r\n                        ");
            EndContext();
            BeginContext(1103, 279, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5df0c8fc9b8b437dad77683d3514682a", async() => {
                BeginContext(1180, 68, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"id\" id=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1248, "\"", 1268, 1);
#line 40 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarPromocao.cshtml"
WriteAttributeValue("", 1256, promocao.Id, 1256, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1269, 106, true);
                WriteLiteral(" />\r\n                            <button class=\"btn btn-danger\">Deletar</button>\r\n                        ");
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
            BeginContext(1382, 27, true);
            WriteLiteral("\r\n\r\n                </tr>\r\n");
            EndContext();
#line 45 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarPromocao.cshtml"
            }

#line default
#line hidden
            BeginContext(1424, 40, true);
            WriteLiteral("\r\n        </tbody>\r\n\r\n    </table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SysSonMarket.Models.Promocao>> Html { get; private set; }
    }
}
#pragma warning restore 1591

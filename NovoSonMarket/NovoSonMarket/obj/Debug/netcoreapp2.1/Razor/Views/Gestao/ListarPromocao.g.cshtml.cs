#pragma checksum "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarPromocao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d84958d33d3b89afdcb229cc4b1318b0984a5a2e"
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
#line 1 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\_ViewImports.cshtml"
using NovoSonMarket;

#line default
#line hidden
#line 2 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\_ViewImports.cshtml"
using NovoSonMarket.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d84958d33d3b89afdcb229cc4b1318b0984a5a2e", @"/Views/Gestao/ListarPromocao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdafbbbd56e614db22d54e7099318f037ccd131a", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_ListarPromocao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SysSonMarket.Models.Promocao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Promocao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarPromocao.cshtml"
  
    ViewData["Title"] = "ListarPromocao";

#line default
#line hidden
            BeginContext(102, 2273, true);
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
                    <span>Listagem de Promoção</span>
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
                            <i class=""icon-settings fo");
            WriteLiteral(@"nt-dark""></i>
                            <span class=""caption-subject bold uppercase"">Lista de Promoção</span>
                        </div>
                        <div class=""tools""> </div>
                    </div>
                    <div class=""portlet-body"">

                        <table class=""table table-striped table-bordered table-hover"" id=""sample_1"">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Nome</th>
                                    <th>Produto</th>
                                    <th>Porcentagem</th>
                                    <th>Ações</th>
                                </tr>
                            </thead>
                            <tfoot>
                                <tr>
                                    <th>Id</th>
                                    <th>Nome</th>
                                    <th>Produto</th>
 ");
            WriteLiteral("                                   <th>Porcentagem</th>\r\n                                    <th>Ações</th>\r\n                                </tr>\r\n                            </tfoot>\r\n                            <tbody>\r\n\r\n");
            EndContext();
#line 65 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarPromocao.cshtml"
                                 foreach (var promocao in Model)
                                {

#line default
#line hidden
            BeginContext(2476, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2555, 11, false);
#line 68 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarPromocao.cshtml"
                                   Write(promocao.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2566, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2614, 13, false);
#line 69 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarPromocao.cshtml"
                                   Write(promocao.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2627, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2675, 21, false);
#line 70 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarPromocao.cshtml"
                                   Write(promocao.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2696, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2744, 20, false);
#line 71 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarPromocao.cshtml"
                                   Write(promocao.Porcentagem);

#line default
#line hidden
            EndContext();
            BeginContext(2764, 116, true);
            WriteLiteral("%</td>\r\n                                    <td>\r\n                                        <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2880, "\"", 2922, 2);
            WriteAttributeValue("", 2887, "/Gestao/EditarPromocao/", 2887, 23, true);
#line 73 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarPromocao.cshtml"
WriteAttributeValue("", 2910, promocao.Id, 2910, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2923, 55, true);
            WriteLiteral(">Editar</a>\r\n\r\n                                        ");
            EndContext();
            BeginContext(2978, 327, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1213ac056bd74014862ec7dece22d4c7", async() => {
                BeginContext(3055, 84, true);
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"id\" id=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3139, "\"", 3159, 1);
#line 76 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarPromocao.cshtml"
WriteAttributeValue("", 3147, promocao.Id, 3147, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3160, 138, true);
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
            BeginContext(3305, 86, true);
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
            EndContext();
#line 82 "C:\GitHub\Projeto.SonMarketGit\NovoSonMarket\NovoSonMarket\Views\Gestao\ListarPromocao.cshtml"
                                }

#line default
#line hidden
            BeginContext(3426, 337, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SysSonMarket.Models.Promocao>> Html { get; private set; }
    }
}
#pragma warning restore 1591

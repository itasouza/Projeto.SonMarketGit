#pragma checksum "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarCategoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "909d3c6f6ca9fc74c483a2a0f4064e1196d24893"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_ListarCategoria), @"mvc.1.0.view", @"/Views/Gestao/ListarCategoria.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gestao/ListarCategoria.cshtml", typeof(AspNetCore.Views_Gestao_ListarCategoria))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"909d3c6f6ca9fc74c483a2a0f4064e1196d24893", @"/Views/Gestao/ListarCategoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99bb91ac996a6c945ffd3736355a56d8f94cfa04", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_ListarCategoria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SysSonMarket.Models.Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovaCategoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarCategoria.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(146, 38, true);
            WriteLiteral("\r\n<h2>Listar Categorias</h2>\r\n<hr />\r\n");
            EndContext();
            BeginContext(184, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1afeb3c845ee453c83a15f4be0bad7f6", async() => {
                BeginContext(262, 20, true);
                WriteLiteral("Criar nova categoria");
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
            BeginContext(286, 14, true);
            WriteLiteral("\r\n\r\n<hr />\r\n\r\n");
            EndContext();
            DefineSection("scriptgeral", async() => {
                BeginContext(323, 151, true);
                WriteLiteral("\r\n    <script type=\"Text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\"#categorias\").DataTable();\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(477, 221, true);
            WriteLiteral("\r\n\r\n<table id=\"categorias\" class=\"table table-striped table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Nome</th>\r\n            <th>Ações</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarCategoria.cshtml"
         foreach (var categoria in Model)
        {

#line default
#line hidden
            BeginContext(752, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(791, 12, false);
#line 36 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarCategoria.cshtml"
               Write(categoria.Id);

#line default
#line hidden
            EndContext();
            BeginContext(803, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(831, 14, false);
#line 37 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarCategoria.cshtml"
               Write(categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(845, 54, true);
            WriteLiteral("</td>\r\n                <td> <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 899, "\"", 943, 2);
            WriteAttributeValue("", 906, "/Gestao/EditarCategoria/", 906, 24, true);
#line 38 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarCategoria.cshtml"
WriteAttributeValue("", 930, categoria.Id, 930, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(944, 33, true);
            WriteLiteral(">Editar</a>  \r\n\r\n                ");
            EndContext();
            BeginContext(977, 256, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25b57f15790546d6a8260f868714cfc8", async() => {
                BeginContext(1055, 60, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\" id=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1115, "\"", 1136, 1);
#line 41 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarCategoria.cshtml"
WriteAttributeValue("", 1123, categoria.Id, 1123, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1137, 89, true);
                WriteLiteral("/>\r\n                    <button class=\"btn btn-danger\">Deletar</button>\r\n                ");
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
            BeginContext(1233, 43, true);
            WriteLiteral("\r\n                    \r\n            </tr>\r\n");
            EndContext();
#line 46 "C:\GitHub\Projeto.SonMarketGit\SysSonMarket\Views\Gestao\ListarCategoria.cshtml"
        }

#line default
#line hidden
            BeginContext(1287, 32, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SysSonMarket.Models.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591

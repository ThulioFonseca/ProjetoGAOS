#pragma checksum "C:\Dev\POO_II\ProjetoGAOS\Views\Ordens\CriaOrdem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23bf7313fc36c3df87a220e8d437dc7163c09353"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ordens_CriaOrdem), @"mvc.1.0.view", @"/Views/Ordens/CriaOrdem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23bf7313fc36c3df87a220e8d437dc7163c09353", @"/Views/Ordens/CriaOrdem.cshtml")]
    public class Views_Ordens_CriaOrdem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoGAOS.Models.OrdemDeServico>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Ordens/CriaOrdem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3 mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    \r\n");
#nullable restore
#line 5 "C:\Dev\POO_II\ProjetoGAOS\Views\Ordens\CriaOrdem.cshtml"
      

        Layout="_Layout";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container flex-column justfy-content-center bg-light p-5 h-100\">\r\n\r\n    <div class=\"d-flex justify-content-center\">\r\n        <h1 class=\"text-dark\">Criar Ordem de Serviço</h1>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23bf7313fc36c3df87a220e8d437dc7163c093534810", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 483, "\"", 500, 1);
#nullable restore
#line 18 "C:\Dev\POO_II\ProjetoGAOS\Views\Ordens\CriaOrdem.cshtml"
WriteAttributeValue("", 491, Model.Id, 491, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\r\n        <div class=\"col-6\">\r\n            <label for=\"txtIdentificador\">Identificador:</label><br>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23bf7313fc36c3df87a220e8d437dc7163c093535590", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 21 "C:\Dev\POO_II\ProjetoGAOS\Views\Ordens\CriaOrdem.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Identificador);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "C:\Dev\POO_II\ProjetoGAOS\Views\Ordens\CriaOrdem.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.AllDispositivos;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <label for=\"txtModelo\">Modelo do Dispositivo:</label><br>\r\n            <input type=\"text\" class=\"form-control\" name=\"Modelo\" id=\"txtModelo\" placeholder=\"Ex: Galaxy A10\"");
                BeginWriteAttribute("value", " value=\"", 953, "\"", 961, 0);
                EndWriteAttribute();
                WriteLiteral(@"  readonly>
        </div>
        <div class=""col-md-6"">
            <label for=""txtFabricante"">Fabricante:</label><br>
            <input type=""text"" class=""form-control"" name=""Fabricante"" id=""txtFabricante""  placeholder=""Ex: Samsung""  readonly>
        </div>
        <div class=""col-md-6"">
            <label for=""txtModelo"">Cliente:</label><br>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23bf7313fc36c3df87a220e8d437dc7163c093538395", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 33 "C:\Dev\POO_II\ProjetoGAOS\Views\Ordens\CriaOrdem.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Cliente);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Dev\POO_II\ProjetoGAOS\Views\Ordens\CriaOrdem.cshtml"
                                                             WriteLiteral(ViewBag.AllClients);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
        
       
        <div class=""col-md-6"">
            <label for=""txtMotivo"">Motivo da Manutenção:</label><br>
            <textarea class=""form-control"" id=""txtMotivo"" rows=""3""></textarea>
        </div>
        <div class=""col-md-3"">
            <label for=""txtCategoria"">Categoria:</label><br>
             <input id=""txtCategoria"" class=""form-select""  readonly>
               
        </div>
        <div class=""col-md-3"">
            <label for=""txtData"">Data de entrada:</label><br>
            <input type=""date"" class=""form-control"" name=""Data"" id=""txtData""");
                BeginWriteAttribute("value", " value=\"", 2027, "\"", 2046, 1);
#nullable restore
#line 48 "C:\Dev\POO_II\ProjetoGAOS\Views\Ordens\CriaOrdem.cshtml"
WriteAttributeValue("", 2035, Model.Data, 2035, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        </div>

        <div class=""d-flex flex-row justify-content-center m-3 "">
        <button class=""btn btn-outline-success btn-lg me-4"" type=""submit"">Salvar</button>
        <a class=""btn btn-outline-danger btn-lg"" href=""/Home/Index"" type=""reset"">Cancelar</a>           
        </div >
        
           
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    




<!--
        <div class=""d-flex justify-content-center "">
            <h1 class=""text-dark"">Criar nova Ordem de Serviço</h1>
        </div>
        <div class=""d-flex justify-content-center mt-4"">
            <form method=""post"" class=""w-25 fs-5 "">
                <div>
                    <label for=""txtModelo"">Modelo do Dispositivo:</label><br>
                    <input type=""text"" class=""form-control"" name=""Modelo"" id=""txtModelo"" placeholder=""Ex: Galaxy A10"">
                </div>
                <div>
                    <label for=""txtFabricante"">Fabricante:</label><br>
                    <input type=""text"" class=""form-control"" name=""Fabricante"" id=""txtFabricante""  placeholder=""Ex: Samsung"">
                </div>
                <div>
                    <label for=""txtIdentificador"">Identificador:</label><br>
                    <input type=""text"" class=""form-control"" name=""Identificador"" id=""txtIdentificador"" placeholder=""Ex: 12345678910"">
                </div>
");
            WriteLiteral(@"                <div>
                    <label for=""txtCategoria"">Categoria:</label><br>
                    <input type=""text"" class=""form-control"" name=""Categoria"" id=""txtCategoria"" placeholder=""Smartphone"" >
                </div>
                <div>
                    <label for=""txtProprietario"">Proprietário:</label><br>
                    <input type=""text"" class=""form-control"" name=""Proprietario"" id=""txtProprietario"">
                </div>
                <div>
                    <label for=""txtData"">Data de entrada:</label><br>
                    <input type=""text"" class=""form-control"" name=""Data"" id=""txtData"">
                </div>
                <div>
                    <label for=""txtMotivo"">Motivo da Manutenção:</label><br>
                    <input type=""text"" class=""form-control"" name=""Motivo"" id=""txtMotivo"">
                </div>
                <div class=""d-flex flex-row justify-content-center m-3 "">
                    <button class=""btn btn-outline-success btn");
            WriteLiteral("-lg me-4\" type=\"submit\">Criar</button>\r\n                    <a class=\"btn btn-outline-danger btn-lg\" href=\"/Home/Index\" type=\"reset\">Cancelar</a>           \r\n                    </div >\r\n            </form>\r\n     </div>-->\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoGAOS.Models.OrdemDeServico> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Dev\POO_II\ProjetoGAOS\Views\Dispositivo\DeletarDispositivo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "233082699a9db99c9c6857d0c0a64688e19a3335"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dispositivo_DeletarDispositivo), @"mvc.1.0.view", @"/Views/Dispositivo/DeletarDispositivo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"233082699a9db99c9c6857d0c0a64688e19a3335", @"/Views/Dispositivo/DeletarDispositivo.cshtml")]
    public class Views_Dispositivo_DeletarDispositivo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoGAOS.Models.Dispositivo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("   \r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Dev\POO_II\ProjetoGAOS\Views\Dispositivo\DeletarDispositivo.cshtml"
      

        Layout="_Layout";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container flex-column bg-light p-5 h-100\">\r\n        \r\n        <div");
            BeginWriteAttribute("class", " class=\"", 173, "\"", 181, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h1 class=\"text-black fw-bold\"> Excluir Dispositivo</h1>\r\n            <hr>\r\n            <h4 class=\"text-secondary fw-light\">Deseja realmente excluir <span class=\"text-primary fst-italic\">");
#nullable restore
#line 13 "C:\Dev\POO_II\ProjetoGAOS\Views\Dispositivo\DeletarDispositivo.cshtml"
                                                                                                          Write(Model.Identificador);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>?</h4>\r\n            <form method=\"post\" action=\"/Dispositivo/DeletarDispositivo\" class=\"w-25\">\r\n                        <input type=\"hidden\" name=\"id\" id=\"Identificador\"");
            BeginWriteAttribute("value", " value=\"", 580, "\"", 608, 1);
#nullable restore
#line 15 "C:\Dev\POO_II\ProjetoGAOS\Views\Dispositivo\DeletarDispositivo.cshtml"
WriteAttributeValue("", 588, Model.Identificador, 588, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""mt-5"">
                             <a class=""btn btn-outline-success btn-lg"" href=""/Dispositivo/ListaDispositivos"" type=""reset"">Cancelar</a>
                              <button class=""btn btn-outline-danger btn-lg mx-3""  type=""submit"">Excluir</button>
                        </div>
            </form>
        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoGAOS.Models.Dispositivo> Html { get; private set; }
    }
}
#pragma warning restore 1591
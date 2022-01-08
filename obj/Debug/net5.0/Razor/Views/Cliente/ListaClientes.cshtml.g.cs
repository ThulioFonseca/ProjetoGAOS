#pragma checksum "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "135065ffe73a6b64b2de5dd8c74895ed60801820"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_ListaClientes), @"mvc.1.0.view", @"/Views/Cliente/ListaClientes.cshtml")]
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
#nullable restore
#line 1 "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml"
using ProjetoGAOS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"135065ffe73a6b64b2de5dd8c74895ed60801820", @"/Views/Cliente/ListaClientes.cshtml")]
    public class Views_Cliente_ListaClientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml"
  

    Layout="_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n\r\n");
#nullable restore
#line 10 "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml"
     if (Model.Count() > 0) {




#line default
#line hidden
#nullable disable
            WriteLiteral(@"         <table class=""table table-striped table-bordered"">
    
        <thead>
            <tr class=""text-center"">
                <th>CPF</th>
                <th>Nome</th>
                <th>E-mail</th>
                <th>Telefone</th>
                <th class=""px-5"" >Ações</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 27 "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml"
             foreach (var Cliente in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"align-middle text-center \">\r\n    \r\n                    <td class=\"fw-bold\">");
#nullable restore
#line 31 "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml"
                                   Write(Cliente.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml"
                   Write(Cliente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml"
                   Write(Cliente.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml"
                   Write(Cliente.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"d-flex flex-row justify-content-center px-5\">\r\n                        <a class=\"btn btn-outline-danger  btn-lg me-4\"");
            BeginWriteAttribute("href", " href=\"", 974, "\"", 1017, 2);
            WriteAttributeValue("", 981, "/Cliente/DeletarCliente/", 981, 24, true);
#nullable restore
#line 36 "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml"
WriteAttributeValue("", 1005, Cliente.Cpf, 1005, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("type=\"reset\">Excluir</a>\r\n                        <a class=\"btn btn-outline-primary btn-lg me-1\"");
            BeginWriteAttribute("href", " href=\"", 1114, "\"", 1158, 2);
            WriteAttributeValue("", 1121, "/Cliente/CadastroCliente/", 1121, 25, true);
#nullable restore
#line 37 "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml"
WriteAttributeValue("", 1146, Cliente.Cpf, 1146, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\">Alterar</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml"
    
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    \r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 46 "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml"



    }

    else{ 


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Nenhum cliente cadastrado!</h4>\r\n");
#nullable restore
#line 54 "C:\Dev\POO_II\ProjetoGAOS\Views\Cliente\ListaClientes.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        \r\n\r\n   \r\n    \r\n   \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\PacotesTuristicos\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43f85fa38bf7f03c462dfee4b33fcd4dc046d956"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PacotesTuristicos_Lista), @"mvc.1.0.view", @"/Views/PacotesTuristicos/Lista.cshtml")]
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
#line 1 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\_ViewImports.cshtml"
using Viagem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\_ViewImports.cshtml"
using Viagem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43f85fa38bf7f03c462dfee4b33fcd4dc046d956", @"/Views/PacotesTuristicos/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3502097358ea1718afb407c575fb88a4e8be5a45", @"/Views/_ViewImports.cshtml")]
    public class Views_PacotesTuristicos_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PacotesTuristicos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\PacotesTuristicos\Lista.cshtml"
      
        ViewData["Title"]= "Listagem de Pacotes Turisticos";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Listagem de Pacotes Turisticos</h2>\r\n  \r\n        \r\n       <div class=\"container\">\r\n           <div class=\"row\">\r\n               <div class=\" d-flex flex-row\">\r\n");
#nullable restore
#line 12 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\PacotesTuristicos\Lista.cshtml"
                     foreach (PacotesTuristicos p in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""container "">
                    <div class="" center d-flex flex-row"">
                        


                             <div class=""d-flex flex-column  mb-3  mb-3""> 
                           
                                <div class=""p-2 "">
                                    
                                    <td>");
#nullable restore
#line 23 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\PacotesTuristicos\Lista.cshtml"
                                   Write(p.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </div>\r\n                                <div class=\"p-2 \">\r\n                                    <th >Origem</th>\r\n                                    <td>");
#nullable restore
#line 27 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\PacotesTuristicos\Lista.cshtml"
                                   Write(p.Origem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </div>\r\n                                <div class=\"p-2 \">\r\n                                    <th >Destino</th>\r\n                                    <td>");
#nullable restore
#line 31 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\PacotesTuristicos\Lista.cshtml"
                                   Write(p.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </div>\r\n                                <div class=\"p-2\">\r\n                                    \r\n                                    <td>");
#nullable restore
#line 35 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\PacotesTuristicos\Lista.cshtml"
                                   Write(p.Atrativos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </div>\r\n                                <div class=\"p-2\">\r\n                                    <th >Data de Saida</th>\r\n                                    <td>");
#nullable restore
#line 39 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\PacotesTuristicos\Lista.cshtml"
                                   Write(p.Atrativos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </div>\r\n                                <div class=\"p-2 \">\r\n                                    <th>Data de Retorno</th>\r\n                                    <td>");
#nullable restore
#line 43 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\PacotesTuristicos\Lista.cshtml"
                                   Write(p.Atrativos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </div>\r\n                                <div class=\"p-2 \">\r\n                                    <th>Data saida</th>\r\n                                    <td>");
#nullable restore
#line 47 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\PacotesTuristicos\Lista.cshtml"
                                   Write(p.DataSaida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </div>\r\n                                <div class=\"p-2 \">\r\n                                    <th>Data retorno</th>\r\n                                    <td>");
#nullable restore
#line 51 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\PacotesTuristicos\Lista.cshtml"
                                   Write(p.DataRetorno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </div>\r\n                          \r\n\r\n\r\n                     </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 59 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\implementar banco de dados\Viagem\Views\PacotesTuristicos\Lista.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("               </div>\r\n           </div>\r\n       </div>\r\n           \r\n        \r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PacotesTuristicos>> Html { get; private set; }
    }
}
#pragma warning restore 1591

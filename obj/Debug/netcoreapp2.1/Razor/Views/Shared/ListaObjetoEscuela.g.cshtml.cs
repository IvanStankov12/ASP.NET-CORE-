#pragma checksum "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Shared\ListaObjetoEscuela.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bdd168fcc4c4c8ec71859ecf9a65f4dabccc77a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ListaObjetoEscuela), @"mvc.1.0.view", @"/Views/Shared/ListaObjetoEscuela.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ListaObjetoEscuela.cshtml", typeof(AspNetCore.Views_Shared_ListaObjetoEscuela))]
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
#line 1 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\_ViewImports.cshtml"
using platzi_asp_net_core;

#line default
#line hidden
#line 2 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\_ViewImports.cshtml"
using platzi_asp_net_core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bdd168fcc4c4c8ec71859ecf9a65f4dabccc77a", @"/Views/Shared/ListaObjetoEscuela.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa5759f893e3c062982c7ef96ef27fe37864c36", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ListaObjetoEscuela : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 161, true);
            WriteLiteral("\n\n<table class=\"table table-dark table-hover\">\n  <thead>\n    <tr>\n      <th scope=\"col\">Nombre</th>\n      <th scope=\"col\">Id</th>\n    </tr>\n  </thead>\n  <tbody>\n");
            EndContext();
#line 13 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Shared\ListaObjetoEscuela.cshtml"
 foreach(var obj in Model)
{

#line default
#line hidden
            BeginContext(226, 19, true);
            WriteLiteral("    <tr>\n      <td>");
            EndContext();
            BeginContext(246, 10, false);
#line 16 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Shared\ListaObjetoEscuela.cshtml"
     Write(obj.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(256, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(273, 6, false);
#line 17 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Shared\ListaObjetoEscuela.cshtml"
     Write(obj.Id);

#line default
#line hidden
            EndContext();
            BeginContext(279, 16, true);
            WriteLiteral("</td>\n    </tr>\n");
            EndContext();
#line 19 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Shared\ListaObjetoEscuela.cshtml"
}

#line default
#line hidden
            BeginContext(297, 19, true);
            WriteLiteral("  </tbody>\n</table>");
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

#pragma checksum "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Asignatura\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c2d824e5820d3ecdeb26e4ccd3504ad33c3bf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asignatura_Index), @"mvc.1.0.view", @"/Views/Asignatura/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Asignatura/Index.cshtml", typeof(AspNetCore.Views_Asignatura_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c2d824e5820d3ecdeb26e4ccd3504ad33c3bf3", @"/Views/Asignatura/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa5759f893e3c062982c7ef96ef27fe37864c36", @"/Views/_ViewImports.cshtml")]
    public class Views_Asignatura_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asignatura>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ObjetoEscuelaSimple", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Asignatura\Index.cshtml"
  
    ViewData["Title"] = "Información Asignatura";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(97, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(103, 17, false);
#line 8 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Asignatura\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(120, 61, true);
            WriteLiteral("</h1>\n\n<strong>Desde la vista normal</strong>\n<p>\n    Nombre:");
            EndContext();
            BeginContext(182, 12, false);
#line 12 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Asignatura\Index.cshtml"
      Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(194, 16, true);
            WriteLiteral(" <br/>\n    Id : ");
            EndContext();
            BeginContext(211, 8, false);
#line 13 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Asignatura\Index.cshtml"
    Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(219, 47, true);
            WriteLiteral("\n</p>\n\n<strong>Desde la vista parcial</strong>\n");
            EndContext();
            BeginContext(266, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2089d8fccd0744ceaa965d603b101775", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(304, 9, true);
            WriteLiteral("\n\n\n<p><i>");
            EndContext();
            BeginContext(314, 13, false);
#line 20 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Asignatura\Index.cshtml"
 Write(ViewBag.Fecha);

#line default
#line hidden
            EndContext();
            BeginContext(327, 8, true);
            WriteLiteral("</i></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asignatura> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Curso\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d53adfa29103e9382c5ff41d96ee40872072628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_Delete), @"mvc.1.0.view", @"/Views/Curso/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Curso/Delete.cshtml", typeof(AspNetCore.Views_Curso_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d53adfa29103e9382c5ff41d96ee40872072628", @"/Views/Curso/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa5759f893e3c062982c7ef96ef27fe37864c36", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Curso>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(14, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Curso\Delete.cshtml"
  
    ViewData["Title"] = "Borrar datos de curso";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(99, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(106, 17, false);
#line 9 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Curso\Delete.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(123, 11, true);
            WriteLiteral("</h1>\r\n<h2>");
            EndContext();
            BeginContext(135, 20, false);
#line 10 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Curso\Delete.cshtml"
Write(ViewBag.MensajeExtra);

#line default
#line hidden
            EndContext();
            BeginContext(155, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(164, 469, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c96f357c31d46249990fa664421595a", async() => {
                BeginContext(184, 141, true);
                WriteLiteral("\r\n   \r\n    <strong>¿ Estas seguro en borrar los datos de este curso ?</strong>\r\n    <div></div>\r\n<p>\r\n    <strong>Nombre del curso:</strong> ");
                EndContext();
                BeginContext(326, 12, false);
#line 17 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Curso\Delete.cshtml"
                                  Write(Model.Nombre);

#line default
#line hidden
                EndContext();
                BeginContext(338, 40, true);
                WriteLiteral(" <br/>\r\n    <strong>Dirección:</strong> ");
                EndContext();
                BeginContext(379, 15, false);
#line 18 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Curso\Delete.cshtml"
                           Write(Model.Dirección);

#line default
#line hidden
                EndContext();
                BeginContext(394, 38, true);
                WriteLiteral("<br/>\r\n    <strong>Jornada:</strong>  ");
                EndContext();
                BeginContext(433, 13, false);
#line 19 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Curso\Delete.cshtml"
                          Write(Model.Jornada);

#line default
#line hidden
                EndContext();
                BeginContext(446, 34, true);
                WriteLiteral(" <br/>\r\n    <strong>Id :</strong> ");
                EndContext();
                BeginContext(481, 8, false);
#line 20 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Curso\Delete.cshtml"
                     Write(Model.Id);

#line default
#line hidden
                EndContext();
                BeginContext(489, 137, true);
                WriteLiteral("\r\n</p>\r\n\r\n<input onclick= \"document.location.href= \'//localhost:5001/Curso\'\" type=\"submit\" class=\"btn btn-sucecess\" value=\"Borrar\" />\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(633, 12, true);
            WriteLiteral("\r\n\r\n\r\n<p><i>");
            EndContext();
            BeginContext(646, 13, false);
#line 28 "c:\Users\IvanStankov\Documents\platzi\asp.net_pagina_wb\Views\Curso\Delete.cshtml"
 Write(ViewBag.Fecha);

#line default
#line hidden
            EndContext();
            BeginContext(659, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Curso> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\PrestamoSet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15e3cd7fe1ec0a2ea3f72bb2fbaa92a4a92c3735"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PrestamoSet_Index), @"mvc.1.0.view", @"/Views/PrestamoSet/Index.cshtml")]
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
#line 1 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\_ViewImports.cshtml"
using ASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\_ViewImports.cshtml"
using ASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15e3cd7fe1ec0a2ea3f72bb2fbaa92a4a92c3735", @"/Views/PrestamoSet/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1380f5418ca4a9a4a07dd423700cc0ce146df93", @"/Views/_ViewImports.cshtml")]
    public class Views_PrestamoSet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASPNET.Models.PrestamoSet>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\PrestamoSet\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Mis Préstamos</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\PrestamoSet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LibroLibro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\PrestamoSet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\PrestamoSet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\PrestamoSet\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaDevolucion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\PrestamoSet\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 684, "\"", 730, 1);
#nullable restore
#line 28 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\PrestamoSet\Index.cshtml"
WriteAttributeValue("", 689, item.FechaFin+","+item.FechaDevolucion, 689, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\PrestamoSet\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LibroLibro.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\PrestamoSet\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\PrestamoSet\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\PrestamoSet\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaDevolucion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\IVAN\Desktop\ASP_IVAN\ASP\Views\PrestamoSet\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""tbody"").children().each(function () {

                var fechaFinString = $(this).attr(""id"").split("","")[0].split("" "")[0];
                var fechaFinSplit = fechaFinString.split(""/"");
                var fechaFinDate = new Date(+fechaFinSplit[2], fechaFinSplit[1] - 1, +fechaFinSplit[0]); 

                //FechaFin es igual a """" si no tiene una fecha de fin
                var fechaDevString = $(this).attr(""id"").split("","")[1].split("" "")[0];

                if (fechaDevString == """") {
                    if (fechaFinDate < Date.now()) {
                        $(this).attr(""class"", ""table-danger"");
                    } else if (fechaFinDate > Date.now()) {
                        $(this).attr(""class"", ""table-success"");
                    }
                }
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASPNET.Models.PrestamoSet>> Html { get; private set; }
    }
}
#pragma warning restore 1591

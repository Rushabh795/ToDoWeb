#pragma checksum "/Users/rushabhshah/Desktop/WebDevelopment/ToDoWeb/ToDo/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c776d85b1cf660509dca1d39a08083a45fc5f72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/rushabhshah/Desktop/WebDevelopment/ToDoWeb/ToDo/Views/_ViewImports.cshtml"
using ToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/rushabhshah/Desktop/WebDevelopment/ToDoWeb/ToDo/Views/_ViewImports.cshtml"
using ToDo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/rushabhshah/Desktop/WebDevelopment/ToDoWeb/ToDo/Views/_ViewImports.cshtml"
using ToDo.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c776d85b1cf660509dca1d39a08083a45fc5f72", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3adc231ee653ea6398adb0484ec0db9462fcff5e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row justify-content-center"">
    <div class=""col-xl-6 col-lg-8 col-md-8 col-sm-10"">
        <table class=""table"">
            <thead>
                <tr class=""table-primary"">
                    <th scope=""col"">Id</th>
                    <th scope=""col"">NAME</th>
                    <th scope=""col"">IsCompleted</th>

                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 16 "/Users/rushabhshah/Desktop/WebDevelopment/ToDoWeb/ToDo/Views/Home/Index.cshtml"
                 foreach (var t in Model.TodoList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th class=\"todos-column\" scope=\"row\">");
#nullable restore
#line 19 "/Users/rushabhshah/Desktop/WebDevelopment/ToDoWeb/ToDo/Views/Home/Index.cshtml"
                                                    Write(t.intID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <td class=\"todos-column\">");
#nullable restore
#line 20 "/Users/rushabhshah/Desktop/WebDevelopment/ToDoWeb/ToDo/Views/Home/Index.cshtml"
                                        Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"todos-column\">");
#nullable restore
#line 21 "/Users/rushabhshah/Desktop/WebDevelopment/ToDoWeb/ToDo/Views/Home/Index.cshtml"
                                        Write(t.isComplete);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                    <td class=\"buttons-column\">\n                        <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\"");
            BeginWriteAttribute("onClick", " onClick=\"", 874, "\"", 904, 3);
            WriteAttributeValue("", 884, "deleteTodo(", 884, 11, true);
#nullable restore
#line 24 "/Users/rushabhshah/Desktop/WebDevelopment/ToDoWeb/ToDo/Views/Home/Index.cshtml"
WriteAttributeValue("", 895, t.intID, 895, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 903, ")", 903, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                        <input type=\"submit\" class=\"btn btn-primary\" value=\"Update\"");
            BeginWriteAttribute("onClick", " onClick=\"", 992, "\"", 1024, 3);
            WriteAttributeValue("", 1002, "populateForm(", 1002, 13, true);
#nullable restore
#line 25 "/Users/rushabhshah/Desktop/WebDevelopment/ToDoWeb/ToDo/Views/Home/Index.cshtml"
WriteAttributeValue("", 1015, t.intID, 1015, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1023, ")", 1023, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                    </td>\n\n                </tr>\n");
#nullable restore
#line 29 "/Users/rushabhshah/Desktop/WebDevelopment/ToDoWeb/ToDo/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\DECAGON\source\repos\MOIFTODOLIST\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c17751068fe0709857e9140447758f6eaff0903"
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
#line 1 "C:\Users\DECAGON\source\repos\MOIFTODOLIST\Views\_ViewImports.cshtml"
using MOIFTODOLIST;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DECAGON\source\repos\MOIFTODOLIST\Views\_ViewImports.cshtml"
using MOIFTODOLIST.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DECAGON\source\repos\MOIFTODOLIST\Views\_ViewImports.cshtml"
using MOIFTODOLIST.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c17751068fe0709857e9140447758f6eaff0903", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b132e32751145085382e61b24b5fd25385c72669", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
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
			<th scope=""col"">Name</th>
			<th scope=""col""></th>

		</tr>
	</thead>
	<tbody>
");
#nullable restore
#line 15 "C:\Users\DECAGON\source\repos\MOIFTODOLIST\Views\Home\Index.cshtml"
         foreach(var t in Model.Todolist)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td class=\"todos-column\" scope=\"row\">");
#nullable restore
#line 18 "C:\Users\DECAGON\source\repos\MOIFTODOLIST\Views\Home\Index.cshtml"
                                                Write(t.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td class=\"todos-column\">");
#nullable restore
#line 19 "C:\Users\DECAGON\source\repos\MOIFTODOLIST\Views\Home\Index.cshtml"
                                    Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td class=\"buttons-column\">\r\n\t\t\t\t\t<input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\"");
            BeginWriteAttribute("onClick", " onClick=\"", 541, "\"", 568, 3);
            WriteAttributeValue("", 551, "deleteTodo(", 551, 11, true);
#nullable restore
#line 21 "C:\Users\DECAGON\source\repos\MOIFTODOLIST\Views\Home\Index.cshtml"
WriteAttributeValue("", 562, t.Id, 562, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 567, ")", 567, 1, true);
            EndWriteAttribute();
            WriteLiteral("/>\r\n\t\t\t\t\t<input type=\"submit\" class=\"btn btn-primary\" value=\"Update\"");
            BeginWriteAttribute("onClick", " onClick=\"", 637, "\"", 666, 3);
            WriteAttributeValue("", 647, "populateForm(", 647, 13, true);
#nullable restore
#line 22 "C:\Users\DECAGON\source\repos\MOIFTODOLIST\Views\Home\Index.cshtml"
WriteAttributeValue("", 660, t.Id, 660, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 665, ")", 665, 1, true);
            EndWriteAttribute();
            WriteLiteral("/>\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 25 "C:\Users\DECAGON\source\repos\MOIFTODOLIST\Views\Home\Index.cshtml"

		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
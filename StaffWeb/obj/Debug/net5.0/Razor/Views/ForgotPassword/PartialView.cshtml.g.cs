#pragma checksum "C:\Users\user\Desktop\1HOME_DemoProject_EDA\StaffWeb\Views\ForgotPassword\PartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "899814d6b7bd208d1c9bfdcfed51e6f467352749"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ForgotPassword_PartialView), @"mvc.1.0.view", @"/Views/ForgotPassword/PartialView.cshtml")]
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
#line 1 "C:\Users\user\Desktop\1HOME_DemoProject_EDA\StaffWeb\Views\_ViewImports.cshtml"
using StaffWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\1HOME_DemoProject_EDA\StaffWeb\Views\_ViewImports.cshtml"
using StaffWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"899814d6b7bd208d1c9bfdcfed51e6f467352749", @"/Views/ForgotPassword/PartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8753f646c2bd59cb832b6ec86fa41ae0cb3eb471", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ForgotPassword_PartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.login>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""modal fade "" id=""Reset"">
	<div class=""modal-dialog"">
		<div class="" model-content"">


			<div class=""modal-header"">
				<h4 class=""modal-tittle"" id=""Reset"">Reset</h4>
				<button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">
					<span>X</span>
				</button>

				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
					<button type=""button"" class=""btn btn-primary"" data-save=""modal"">Save</button>
				</div>
				
			</div>
		</div>
	</div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model.login> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
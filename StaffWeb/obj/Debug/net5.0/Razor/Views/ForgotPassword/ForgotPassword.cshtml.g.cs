#pragma checksum "C:\Users\user\Desktop\1HOME_DemoProject_EDA\StaffWeb\Views\ForgotPassword\ForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf2dc958883f47c23e7d3d378cb8ba3fea1a03f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ForgotPassword_ForgotPassword), @"mvc.1.0.view", @"/Views/ForgotPassword/ForgotPassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf2dc958883f47c23e7d3d378cb8ba3fea1a03f0", @"/Views/ForgotPassword/ForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8753f646c2bd59cb832b6ec86fa41ae0cb3eb471", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ForgotPassword_ForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("ResetPassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\user\Desktop\1HOME_DemoProject_EDA\StaffWeb\Views\ForgotPassword\ForgotPassword.cshtml"
  
    ViewBag.Title = "Forgot Password";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf2dc958883f47c23e7d3d378cb8ba3fea1a03f04866", async() => {
                WriteLiteral("\r\n\t<title></title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf2dc958883f47c23e7d3d378cb8ba3fea1a03f05858", async() => {
                WriteLiteral("\r\n\t<div id=\"PlaceHolderHere\"></div>\r\n<h2>Forgot Password</h2>\r\n\r\n\r\n \r\n\r\n");
                WriteLiteral("\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf2dc958883f47c23e7d3d378cb8ba3fea1a03f06238", async() => {
                    WriteLiteral("\r\n    <div class=\"form-horizontal\">\r\n        <hr />\r\n        <div class=\"text-success\">\r\n            ");
#nullable restore
#line 26 "C:\Users\user\Desktop\1HOME_DemoProject_EDA\StaffWeb\Views\ForgotPassword\ForgotPassword.cshtml"
       Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
        </div>

				
				<div class=""form-group"">
            <label class=""control-label col-md-2"">Email</label>
          
		   <input class=""form-control"" id=""Username"" name=""Username"" type=""text""  required>

		   
        </div>
		
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Reset Password"" class=""btn btn-success"" onclick=""submit() "" data-toggle=""ajax-modal""/>
");
                    WriteLiteral("\"\r\n            </div>\r\n        </div>\r\n    </div>\r\n\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n\r\n\t\r\n\r\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\user\Desktop\1HOME_DemoProject_EDA\StaffWeb\Views\ForgotPassword\ForgotPassword.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                }
                );
                WriteLiteral("<script type=\"text/javascript\" src=\"//ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js\"></script>\r\n\r\n\r\n\r\n\r\n");
                WriteLiteral(@"<script>

$(function (){
	var PlaceHolderHere=$('#PlaceHolderHere')
	$('button[data-toggle=""ajax-modal""]').click(function (event){
		var url = $ (this).data('url');
		$.get(url).done(funtion(data)){
			PlaceHolderElement.html(data);
			PlaceHolderElement.find('.modal').modal(""show"");

		}
	})
})

</script>

 <script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
    <script type=""text/javascript"">
        $(""body"").on(""submit"", ""#Form1"", function () {
            return confirm(""Do you want to submit?"");
        });
    </script>
");
#nullable restore
#line 104 "C:\Users\user\Desktop\1HOME_DemoProject_EDA\StaffWeb\Views\ForgotPassword\ForgotPassword.cshtml"
     if (ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script type=\"text/javascript\">\r\n            window.onload = function () {\r\n                alert(\'");
#nullable restore
#line 108 "C:\Users\user\Desktop\1HOME_DemoProject_EDA\StaffWeb\Views\ForgotPassword\ForgotPassword.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n            };\r\n        </script>\r\n");
#nullable restore
#line 111 "C:\Users\user\Desktop\1HOME_DemoProject_EDA\StaffWeb\Views\ForgotPassword\ForgotPassword.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

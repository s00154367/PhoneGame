#pragma checksum "C:\Users\seang\Desktop\IN DEV\PhoneGame\Views\Users\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a1ae3fa5047fc926571687e7e5046a17dd714f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Game), @"mvc.1.0.view", @"/Views/Users/Game.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Game.cshtml", typeof(AspNetCore.Views_Users_Game))]
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
#line 1 "C:\Users\seang\Desktop\IN DEV\PhoneGame\Views\_ViewImports.cshtml"
using PhoneGame;

#line default
#line hidden
#line 2 "C:\Users\seang\Desktop\IN DEV\PhoneGame\Views\_ViewImports.cshtml"
using PhoneGame.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a1ae3fa5047fc926571687e7e5046a17dd714f0", @"/Views/Users/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e95d575da7f29f7742fecc5448f4899d7519d236", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhoneGame.Models.Session>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\seang\Desktop\IN DEV\PhoneGame\Views\Users\Game.cshtml"
  
    ViewData["Title"] = "Game";

#line default
#line hidden
            BeginContext(75, 136, true);
            WriteLiteral("\r\n<h2>Game</h2>\r\n\r\n<div>\r\n    <h4>Waiting For All Players...</h4>\r\n    <hr />\r\n    <div class=\"jumbotron\">\r\n        <h2>Join Code:   <b>");
            EndContext();
            BeginContext(212, 34, false);
#line 13 "C:\Users\seang\Desktop\IN DEV\PhoneGame\Views\Users\Game.cshtml"
                       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(246, 139, true);
            WriteLiteral("</b></h2>\r\n    </div>\r\n    <button id=\"btnReady\" class=\"btn btn-danger jumbotron\">\r\n        <h2>Ready:   </h2>\r\n        <b id=\"ReadyCheck\">");
            EndContext();
            BeginContext(386, 37, false);
#line 17 "C:\Users\seang\Desktop\IN DEV\PhoneGame\Views\Users\Game.cshtml"
                      Write(Html.DisplayFor(model => model.Ready));

#line default
#line hidden
            EndContext();
            BeginContext(423, 70, true);
            WriteLiteral("</b>\r\n    </button>\r\n    <div id=\"divload\"></div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(493, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dd32507346d45fe8ba66a978e21cf30", async() => {
                BeginContext(539, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\seang\Desktop\IN DEV\PhoneGame\Views\Users\Game.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(547, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(555, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c973cfab22347ce9498ad7b2db95535", async() => {
                BeginContext(577, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(593, 234, true);
            WriteLiteral("\r\n</div>\r\n<script>\r\n    \r\n    $(document).ready(function () {\r\n        $(\"#btnReady\").click(function () {    \r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \"/Users/ReadyUp\",\r\n                data: { \"id\": ");
            EndContext();
            BeginContext(828, 8, false);
#line 32 "C:\Users\seang\Desktop\IN DEV\PhoneGame\Views\Users\Game.cshtml"
                         Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(836, 420, true);
            WriteLiteral(@"},
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    //alert(""Request: "" + XMLHttpRequest.toString() + ""\n\nStatus: "" + textStatus + ""\n\nError: "" + errorThrown);
                },
                complete: function (jqXHR, status) {
                    //$(""#ReadyCheck"").html() = ""No"";
                }
            });
    });
    
        
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhoneGame.Models.Session> Html { get; private set; }
    }
}
#pragma warning restore 1591

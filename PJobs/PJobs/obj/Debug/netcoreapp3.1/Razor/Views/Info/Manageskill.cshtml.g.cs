#pragma checksum "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\Manageskill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "161a2eebc4621a0cc236a6ab3882369621d5d1f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Info_Manageskill), @"mvc.1.0.view", @"/Views/Info/Manageskill.cshtml")]
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
#line 1 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\_ViewImports.cshtml"
using PJobs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\_ViewImports.cshtml"
using PJobs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"161a2eebc4621a0cc236a6ab3882369621d5d1f9", @"/Views/Info/Manageskill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3135dca2db0529a38cb240b18f84cc870d316a9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Info_Manageskill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PJobs.Models.UngVienKiNang>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\Manageskill.cshtml"
  

    Layout = "_Layout1";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- *** Call to Action Start *** -->
<section class=""section section-bg"" id=""call-to-action"" style=""background-image: url(~/wwwroot/images/teles);"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-10 offset-lg-1"">
                <div class=""cta-content"">
                    <br>
                    <br>
                    <h2><em>TH??M K?? N??NG M???I</em></h2>
                    <p style=""color: #232d39"">T??? gi???, b???n c?? th??? ????ng nh???ng c??ng vi???c ????? ???ng vi??n ????ng k??! </p>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- *** Call to Action End *** -->
<!-- *** Fleet Starts *** -->
<section class=""section"" id=""our-classes"">
    <div class=""container"">
        <div class=""main-body"">
            <div class=""content-wrapper"">
                <!-- Content Header (Page header) -->
                <section class=""content-header"">
                    <div class=""container-fluid"">
                        <div class=""row mb-2"">");
            WriteLiteral(@"
                            <div class=""col-sm-12 ml-auto"">
                                <button type=""submit"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal2"">
                                    <i class=""fas fa-upload""></i>
                                    <span>Add</span>
                                </button>
                            </div>

                        </div>
                    </div><!-- /.container-fluid -->
                </section>
                <!-- Main content -->
                <section class=""content"">
                    <div class=""container-fluid"">

                        <!-- /.row -->
                        <div class=""row"">

                            <div class=""col-12"">
                                <div class=""card"">

                                    <!-- /.card-header -->
                                    <div class=""card-body table-responsive p-0"" style=""height: 300px;"">
                           ");
            WriteLiteral(@"             <table class=""table table-head-fixed text-nowrap"">
                                            <thead>
                                                <tr>

                                                    <th>M?? ??ng vi??n </th>
                                                    <th>K?? n??ng</th>
                                                    <th>
                                                        N??t 
                                                        
                                                    </th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 67 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\Manageskill.cshtml"
                                                 foreach (var item in ViewBag.DSUVKN)
                                                {
                                                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr data-widget=\"expandable-table\" aria-expanded=\"false\">\r\n                                                        <td>");
#nullable restore
#line 71 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\Manageskill.cshtml"
                                                       Write(item.MaUngVien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 72 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\Manageskill.cshtml"
                                                       Write(item.MaKiNang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 74 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\Manageskill.cshtml"
                                                       Write(Html.ActionLink("Delete", "XoaManageSkill", "Info", new { id = @item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 77 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\Manageskill.cshtml"
                                                    
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div><!-- /.container-fluid -->
                </section>
                <!-- /.content -->
            </div>
        </div>
    </div>
    }
</section>
");
#nullable restore
#line 93 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\Manageskill.cshtml"
 using (Html.BeginForm("ThemManageSkill", "info", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""modal fade"" id=""exampleModal2"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">B???ng th??m</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "161a2eebc4621a0cc236a6ab3882369621d5d1f99658", async() => {
                WriteLiteral("\r\n                        \r\n                        <div class=\"form-group\">\r\n                             ");
#nullable restore
#line 109 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\Manageskill.cshtml"
                        Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"exampleInputEmail1\">K?? n??ng </label>\r\n                            ");
#nullable restore
#line 113 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\Manageskill.cshtml"
                       Write(Html.DropDownList("MaKiNang", new SelectList(ViewBag.DSKN, "MaKiNang", "TenKiNang"), "Ch???n k?? n??ng"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" id=""form-submit"" class=""btn btn-primary"">
                        SAVE
                    </button>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 127 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\Manageskill.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- *** Fleet Ends *** -->
<!-- jQuery -->
<script src=""assets/js/jquery-2.1.0.min.js""></script>

<!-- Bootstrap -->
<script src=""assets/js/popper.js""></script>
<script src=""assets/js/bootstrap.min.js""></script>

<!-- Plugins -->
<script src=""assets/js/scrollreveal.min.js""></script>
<script src=""assets/js/waypoints.min.js""></script>
<script src=""assets/js/jquery.counterup.min.js""></script>
<script src=""assets/js/imgfix.min.js""></script>
<script src=""assets/js/mixitup.js""></script>
<script src=""assets/js/accordions.js""></script>

<!-- Global Init -->
<script src=""assets/js/custom.js""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PJobs.Models.UngVienKiNang> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\ProfileEmployer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5419cf9fbab2510f65b922877a3656c6ba514620"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Info_ProfileEmployer), @"mvc.1.0.view", @"/Views/Info/ProfileEmployer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5419cf9fbab2510f65b922877a3656c6ba514620", @"/Views/Info/ProfileEmployer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3135dca2db0529a38cb240b18f84cc870d316a9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Info_ProfileEmployer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PJobs.Models.NhaTuyenDung>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\ProfileEmployer.cshtml"
  

    Layout = "_Layout1";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- ***** Call to Action Start ***** -->
<section class=""section section-bg"" id=""call-to-action"" style=""background-image: url(~/wwwroot/images/teles);"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-10 offset-lg-1"">
                <div class=""cta-content"">
                    <br>
                    <br>
                    <h2><em>Thông tin nhà tuyển dụng</em></h2>
                    <p>Bạn có thể thêm/ chỉnh sửa thông tin ở đây</p>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- ***** Call to Action End ***** -->
<!-- ***** Fleet Starts ***** -->
<section class=""section"" id=""our-classes"">
    <div class=""container"">
        <div class=""main-body"">
                <div class=""row gutters-sm"">
                    <div class=""col-md-4 mb-3"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""d-flex flex-column align-item");
            WriteLiteral(@"s-center text-center"">
                                    <img src=""https://bootdey.com/img/Content/avatar/avatar7.png"" alt=""Admin"" class=""rounded-circle"" width=""150"">
                                    <div class=""mt-3"">
                                        <h4>");
#nullable restore
#line 37 "D:\DAclone\thoalongdoan\PJobs\PJobs\Views\Info\ProfileEmployer.cshtml"
                                       Write(ViewBag.DSNTD.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                        <p class=""text-secondary mb-1"">Full Stack Developer</p>
                                        <p class=""text-muted font-size-sm"">Bay Area, San Francisco, CA</p>
                                        <button class=""btn btn-primary"">Follow</button>
                                        <button class=""btn btn-outline-primary"">Message</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""card mt-3"">
                            <ul class=""list-group list-group-flush"">
                                <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                    <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round");
            WriteLiteral(@""" class=""feather feather-globe mr-2 icon-inline""><circle cx=""12"" cy=""12"" r=""10""></circle><line x1=""2"" y1=""12"" x2=""22"" y2=""12""></line><path d=""M12 2a15.3 15.3 0 0 1 4 10 15.3 15.3 0 0 1-4 10 15.3 15.3 0 0 1-4-10 15.3 15.3 0 0 1 4-10z""></path></svg>Website</h6>
                                    <span class=""text-secondary"">https://bootdey.com</span>
                                </li>
                                <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                    <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-github mr-2 icon-inline""><path d=""M9 19c-5 1.5-5-2.5-7-3m14 6v-3.87a3.37 3.37 0 0 0-.94-2.61c3.14-.35 6.44-1.54 6.44-7A5.44 5.44 0 0 0 20 4.77 5.07 5.07 0 0 0 19.91 1S18.73.65 16 2.48a13.38 13.38 0 0 0-7 0C6.27.65 5.09 1 5.09 1A5.07 5.07 0 0 0 5 4.77a5");
            WriteLiteral(@".44 5.44 0 0 0-1.5 3.78c0 5.42 3.3 6.61 6.44 7A3.37 3.37 0 0 0 9 18.13V22""></path></svg>Github</h6>
                                    <span class=""text-secondary"">bootdey</span>
                                </li>
                                <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                    <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-twitter mr-2 icon-inline text-info""><path d=""M23 3a10.9 10.9 0 0 1-3.14 1.53 4.48 4.48 0 0 0-7.86 3v1A10.66 10.66 0 0 1 3 4s-4 9 5 13a11.64 11.64 0 0 1-7 2c9 5 20 0 20-11.5a4.5 4.5 0 0 0-.08-.83A7.72 7.72 0 0 0 23 3z""></path></svg>Twitter</h6>
                                    <span class=""text-secondary"">bootdey</span>
                                </li>
                                <li class=""list-group-item ");
            WriteLiteral(@"d-flex justify-content-between align-items-center flex-wrap"">
                                    <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-instagram mr-2 icon-inline text-danger""><rect x=""2"" y=""2"" width=""20"" height=""20"" rx=""5"" ry=""5""></rect><path d=""M16 11.37A4 4 0 1 1 12.63 8 4 4 0 0 1 16 11.37z""></path><line x1=""17.5"" y1=""6.5"" x2=""17.51"" y2=""6.5""></line></svg>Instagram</h6>
                                    <span class=""text-secondary"">boot</span>
                                </li>
                                <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                    <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoi");
            WriteLiteral(@"n=""round"" class=""feather feather-facebook mr-2 icon-inline text-primary""><path d=""M18 2h-3a5 5 0 0 0-5 5v3H7v4h3v8h4v-8h3l1-4h-4V7a1 1 0 0 1 1-1h3z""></path></svg>Facebook</h6>
                                    <span class=""text-secondary"">bootdey</span>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-md-8"">
                        <div class=""card mb-3"">
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col-sm-3"">
                                        <h6 class=""mb-0"">Full Name</h6>
                                    </div>
                                    <div class=""col-sm-9 text-secondary"">
                                        Kenneth Valdez
                                    </div>
                                </div>
                                <hr>
     ");
            WriteLiteral(@"                           <div class=""row"">
                                    <div class=""col-sm-3"">
                                        <h6 class=""mb-0"">Email</h6>
                                    </div>
                                    <div class=""col-sm-9 text-secondary"">
                                        fip@jukmuh.al
                                    </div>
                                </div>
                                <hr>
                                <div class=""row"">
                                    <div class=""col-sm-3"">
                                        <h6 class=""mb-0"">Phone</h6>
                                    </div>
                                    <div class=""col-sm-9 text-secondary"">
                                        (239) 816-9029
                                    </div>
                                </div>
                                <hr>
                                <div class=""row"">
                         ");
            WriteLiteral(@"           <div class=""col-sm-3"">
                                        <h6 class=""mb-0"">Mobile</h6>
                                    </div>
                                    <div class=""col-sm-9 text-secondary"">
                                        (320) 380-4539
                                    </div>
                                </div>
                                <hr>
                                <div class=""row"">
                                    <div class=""col-sm-3"">
                                        <h6 class=""mb-0"">Address</h6>
                                    </div>
                                    <div class=""col-sm-9 text-secondary"">
                                        Bay Area, San Francisco, CA
                                    </div>
                                </div>
                                <hr>
                                <div class=""row"">
                                    <div class=""col-sm-12"">
                  ");
            WriteLiteral(@"                      <a class=""btn btn-info "" target=""__blank"" href=""https://www.bootdey.com/snippets/view/profile-edit-data-and-skills"">Edit</a>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""row gutters-sm"">
                            <div class=""col-sm-6 mb-3"">
                                <div class=""card h-100"">
                                    <div class=""card-body"">
                                        <h6 class=""d-flex align-items-center mb-3""><i class=""material-icons text-info mr-2"">assignment</i>Project Status</h6>
                                        <small>Web Design</small>
                                        <div class=""progress mb-3"" style=""height: 5px"">
                                            <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 80%"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""><");
            WriteLiteral(@"/div>
                                        </div>
                                        <small>Website Markup</small>
                                        <div class=""progress mb-3"" style=""height: 5px"">
                                            <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 72%"" aria-valuenow=""72"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                        </div>
                                        <small>One Page</small>
                                        <div class=""progress mb-3"" style=""height: 5px"">
                                            <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 89%"" aria-valuenow=""89"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                        </div>
                                        <small>Mobile Template</small>
                                        <div class=""progress mb-3"" style=""height: 5px"">
                              ");
            WriteLiteral(@"              <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 55%"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                        </div>
                                        <small>Backend API</small>
                                        <div class=""progress mb-3"" style=""height: 5px"">
                                            <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 66%"" aria-valuenow=""66"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-sm-6 mb-3"">
                                <div class=""card h-100"">
                                    <div class=""card-body"">
                                        <h6 class=""d-flex align-items-center mb-3""><i class=""material-icons text-info mr-2"">assignment</i");
            WriteLiteral(@">Project Status</h6>
                                        <small>Web Design</small>
                                        <div class=""progress mb-3"" style=""height: 5px"">
                                            <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 80%"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                        </div>
                                        <small>Website Markup</small>
                                        <div class=""progress mb-3"" style=""height: 5px"">
                                            <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 72%"" aria-valuenow=""72"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                        </div>
                                        <small>One Page</small>
                                        <div class=""progress mb-3"" style=""height: 5px"">
                                            <div class=""progress-bar");
            WriteLiteral(@" bg-primary"" role=""progressbar"" style=""width: 89%"" aria-valuenow=""89"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                        </div>
                                        <small>Mobile Template</small>
                                        <div class=""progress mb-3"" style=""height: 5px"">
                                            <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 55%"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                        </div>
                                        <small>Backend API</small>
                                        <div class=""progress mb-3"" style=""height: 5px"">
                                            <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 66%"" aria-valuenow=""66"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                        </div>
                                    </div>
                                </");
            WriteLiteral(@"div>
                            </div>
                        </div>



                    </div>
                </div>
        </div>
    </div>

</section>

<!-- ***** Fleet Ends ***** -->
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
<script src=""assets/js/custom.js""></script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PJobs.Models.NhaTuyenDung> Html { get; private set; }
    }
}
#pragma warning restore 1591
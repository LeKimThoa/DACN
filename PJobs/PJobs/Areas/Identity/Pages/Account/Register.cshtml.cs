﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace PJobs.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
            public string Role { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    //add user to role

                    await _userManager.AddToRoleAsync(user, Input.Role);

                    if (Input.Role == "Candidate")
                    {
                        // add email into ungvien table
                        PJobs.Repository.UngVienRepository UV = new PJobs.Repository.UngVienRepository();
                        PJobs.Models.UngVien ungvien = new PJobs.Models.UngVien();
                        ungvien.Email = Input.Email;
                        //MaUngVien, Email, MatKhau, CMND, HoTen, SDT, ThanhPhoSinhSong, QuanHuyenSinhSong, DiaChiChiTiet, FileCV, AnhDaiDien, LuotXem, NgayTaoTK
                        ungvien.MatKhau = "";
                        ungvien.Cmnd = "";
                        ungvien.HoTen = "";
                        ungvien.Sdt = "";
                        ungvien.ThanhPhoSinhSong = 1;
                        ungvien.QuanHuyenSinhSong = 1;
                        ungvien.DiaChiChiTiet = "";
                        ungvien.FileCv = "";
                        ungvien.LuotXem = 0;
                        ungvien.AnhDaiDien = "";
                        DateTime currentDate = DateTime.Now;
                        ungvien.NgayTaoTk = currentDate;
                        UV.themungvien(ungvien);
                        returnUrl = returnUrl ?? Url.Content("~/");
                    }
                    else if (Input.Role == "Employer")
                    {
                        PJobs.Repository.NhaTuyenDungRepository NTD = new PJobs.Repository.NhaTuyenDungRepository();
                        PJobs.Models.NhaTuyenDung ntd = new PJobs.Models.NhaTuyenDung();
                        ntd.Email = Input.Email;
                        ntd.MatKhau = "";
                        ntd.DiaChiHoatDong = "";
                        ntd.ThanhPhoHoatDong = 1;
                        ntd.QuanHuyenHoatDong = 1;
                        ntd.AnhDaiDien = "";
                        ntd.MoTaCongTy = "";
                        ntd.TenCongTy = "";
                        ntd.MaSoThue = "";
                        ntd.LinhVuc = 1;
                        NTD.themnhatuyendung(ntd);
                        returnUrl = returnUrl ?? Url.Content("~/Info/ProfileEmployer/" + ntd.MaNhaTuyenDung);
                    }
                   
                    //_logger.LogInformation("User created a new account with password.");

                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    ////code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    //var result1 = await _userManager.ConfirmEmailAsync(user, code);
                    //var callbackUrl = Url.Page(
                    //    "/Account/ConfirmEmail",
                    //    pageHandler: null,
                    //    values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                    //    protocol: Request.Scheme);

                    //await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                    //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}

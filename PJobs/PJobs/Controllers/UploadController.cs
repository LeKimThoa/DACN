using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PJobs.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PJobs.Repository;
using System.IO;

namespace PJobs.Controllers
{
    public class UploadController : Controller
    {
        private VIECLAMContext ctx = new VIECLAMContext();

        public UploadController()
        {

        }
        
        public IActionResult Index()
        {
           
            //passing model/data to  view
            return View();
        }
        [HttpPost]
        public IActionResult UploadFile(Microsoft.AspNetCore.Http.IFormFile file)
        {
            String rootpath = System.IO.Directory.GetCurrentDirectory() + @"\wwwroot\upload\" + file.FileName;
            System.IO.FileStream flstream = new System.IO.FileStream(rootpath, FileMode.Create);
            file.CopyTo(flstream);
            ViewBag.ImageName = file.FileName;
            if (User.IsInRole("Employer"))
            {
                VIECLAMContext ctx = new VIECLAMContext();
                var user = User.Identity.Name.ToString();
                NhaTuyenDung ntd = ctx.NhaTuyenDungs.Where(qh => qh.Email == user).SingleOrDefault();
                NhaTuyenDung ntdedit = ctx.NhaTuyenDungs.Where(x => x.MaNhaTuyenDung == ntd.MaNhaTuyenDung).SingleOrDefault();
                ntdedit.AnhDaiDien = @ViewBag.ImageName;
                ctx.SaveChanges();
            }
            else
            {
                VIECLAMContext ctx = new VIECLAMContext();
                var user = User.Identity.Name.ToString();
                UngVien uv = ctx.UngViens.Where(qh => qh.Email == user).SingleOrDefault();
                UngVien uvedit = ctx.UngViens.Where(x => x.MaUngVien == uv.MaUngVien).SingleOrDefault();
                uvedit.AnhDaiDien = @ViewBag.ImageName;
                ctx.SaveChanges();
                

            }
            return View("Index");
        }


    }
}
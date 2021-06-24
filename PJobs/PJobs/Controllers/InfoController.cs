using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PJobs.Models;
using PJobs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PJobs.Controllers
{
   
    public class InfoController : Controller
    {


        private VIECLAMContext ctx = new VIECLAMContext();
        private NhaTuyenDungRepository _nhaTuyenDungRepository = null;
        private UngVienRepository _ungVienRepository = null;
        private KiNangRepository _kiNangRepository = null;
        private UngVienKiNangRepository _ungVienKiNangRepository = null;
   

        public InfoController(NhaTuyenDungRepository nhaTuyenDungRepository, UngVienRepository ungVienRepository, KiNangRepository kiNangRepository, UngVienKiNangRepository ungVienKiNangRepository)
        {

            _nhaTuyenDungRepository = nhaTuyenDungRepository;
            _ungVienRepository = ungVienRepository;
            _kiNangRepository = kiNangRepository;
            _ungVienKiNangRepository = ungVienKiNangRepository;

        }
        public IActionResult Index()
        {
            return View();
        }


        [Authorize(Roles = "Candidate")]
        public IActionResult ProfileCandidate(int id)
        {

            ViewBag.DSUV = _ungVienRepository.timkiemUV_theoid(id);
            UngVien uv = _ungVienRepository.timkiemUV_theoid(id);
            ViewBag.DSTP = ctx.ThanhPhos.Where(qh => qh.MaThanhPho == uv.ThanhPhoSinhSong).SingleOrDefault();
            ViewBag.DSQH = ctx.QuanHuyens.Where(qh => qh.MaQuan == uv.QuanHuyenSinhSong).SingleOrDefault();
            return View(uv);
        }
        [Authorize(Roles = "Candidate")]
        public IActionResult ManageJob()
        {
            var user = User.Identity.Name.ToString();
            UngVien uv = ctx.UngViens.Where(qh => qh.Email == user).SingleOrDefault();
            var uvid = uv.MaUngVien;
            ViewBag.DSJob = ctx.UngVienDangKies.Where(qh => qh.MaUngVien == uvid).ToList();
            return View();
        }

        [Authorize(Roles = "Candidate")]
        public IActionResult ManageSkill ()
        {
            var user = User.Identity.Name.ToString();
            UngVien uv = ctx.UngViens.Where(qh => qh.Email == user).SingleOrDefault();
            var uvid = uv.MaUngVien;
            ViewBag.DSUVKN = ctx.UngVienKiNangs.Where(qh => qh.MaUngVien == uvid).ToList();
            ViewBag.DSKN = ctx.KiNangs.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult ThemManageSkill(UngVienKiNang uvkn)
        {
            var user = User.Identity.Name.ToString();
            UngVien uv = ctx.UngViens.Where(qh => qh.Email == user).SingleOrDefault();
            var uvid = uv.MaUngVien;
            uvkn.MaUngVien = uvid;
            _ungVienKiNangRepository.themUngVienKiNang(uvkn);
            return Redirect("~/Info/ManageSkill");
        }
    
        public IActionResult XoaManageSkill(int id)
        {
            List<UngVienKiNang> ds = _ungVienKiNangRepository.xoaUngVienKiNang(id);
            return RedirectToAction("ManageSkill");
        }

        [Authorize(Roles = "Candidate")]
        public IActionResult SuaUngVien(int id)
        {
            UngVien uv = _ungVienRepository.timkiemUV_theoid(id);
            return View(uv);
        }

        [Authorize(Roles = "Candidate")]
        [HttpPost]
        public IActionResult SuaUngVien(UngVien uv)
        {
            _ungVienRepository.suaungvien(uv);
            return Redirect("~/Info/ProfileCandidate/"+uv.MaUngVien);
        }




        [Authorize(Roles = "Employer")]
        public IActionResult ProfileEmployer(int id)
        {
            ViewBag.DSNTD = _nhaTuyenDungRepository.timkiemNTD_theoid(id);
            NhaTuyenDung ntd = _nhaTuyenDungRepository.timkiemNTD_theoid(id);
            return View(ntd);
        }


    }
}

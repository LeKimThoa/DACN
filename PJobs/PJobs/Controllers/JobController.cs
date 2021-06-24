
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PJobs.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PJobs.Repository;
using Microsoft.AspNetCore.Authorization;

namespace PJobs.Controllers
{
    public class JobController : Controller
    {
        VIECLAMContext ctx = new VIECLAMContext();

        private UngVienDangKiRepository _ungVienDangKiRepository = null;

        public JobController (UngVienDangKiRepository ungVienDangKiRepository)
        {

            _ungVienDangKiRepository = ungVienDangKiRepository;
        }
        public IActionResult Index()
        {

            ViewBag.DSNganhNghe = ctx.ThongTinNganhNghes.ToList();
            var q = (from ttd in ctx.TinTuyenDungs
                     join ntd in ctx.NhaTuyenDungs on ttd.MaCongTy equals ntd.MaNhaTuyenDung
                     join nn in ctx.ThongTinNganhNghes on ttd.ViTriTuyenDung equals nn.MaNghe
                     join lv in ctx.ThongTinLinhVucs on nn.MaLinhVuc equals lv.MaLinhVuc
                     select new NewJoin
                     {
                         HinhAnh = ttd.Hinhanh,
                         MaTinTuyenDung = ttd.MaTinTuyenDung,
                         ViTriTuyenDung = nn.TenNghe,
                         HoSoYeuCau = ttd.HoSoYeuCau,
                         MoTaCongViec = ttd.MoTaCongViec,
                         QuyenLoi = ttd.QuyenLoi,
                         SDTCongTy = ntd.Sdt,
                         ThanhPho = ntd.ThanhPhoHoatDong,
                         QuanHuyen = ntd.QuanHuyenHoatDong,
                         DiaChi = ntd.DiaChiHoatDong,
                         MoTaCongTy = ntd.MoTaCongTy,
                         EmailCongTy = ntd.Email,
                         TieuDe = ttd.Tieude,
                         LinhVuc = lv.TenLinhVuc,
                         MucLuong = ttd.MucLuong,
                         TenCongTy = ntd.TenCongTy,
                         SoLuongTuyen = ttd.SoLuongTuyen
                     });
            //passing model/data to  view
            List<NewJoin> lst = q.ToList();

            JobViewModel model = new JobViewModel()
            {

                DSKiNang = ctx.KiNangs.ToList(),
                NewJoins = lst

            };
            return View(model);
        }


        public IActionResult JobDetails(int id)
        {
            var q = (from ttd in ctx.TinTuyenDungs
                     join ntd in ctx.NhaTuyenDungs on ttd.MaCongTy equals ntd.MaNhaTuyenDung
                     join nn in ctx.ThongTinNganhNghes on ttd.ViTriTuyenDung equals nn.MaNghe
                     join lv in ctx.ThongTinLinhVucs on nn.MaLinhVuc equals lv.MaLinhVuc
                     where ttd.MaTinTuyenDung == id
                     select new NewJoin
                     {
                         HinhAnh = ttd.Hinhanh,
                         MaTinTuyenDung = ttd.MaTinTuyenDung,
                         ViTriTuyenDung = nn.TenNghe,
                         HoSoYeuCau = ttd.HoSoYeuCau,
                         MoTaCongViec = ttd.MoTaCongViec,
                         QuyenLoi = ttd.QuyenLoi,
                         SDTCongTy = ntd.Sdt,
                         ThanhPho = ntd.ThanhPhoHoatDong,
                         QuanHuyen = ntd.QuanHuyenHoatDong,
                         DiaChi = ntd.DiaChiHoatDong,
                         MoTaCongTy = ntd.MoTaCongTy,
                         EmailCongTy = ntd.Email,
                         TieuDe = ttd.Tieude,
                         LinhVuc = lv.TenLinhVuc,
                         MucLuong = ttd.MucLuong,
                         TenCongTy = ntd.TenCongTy,
                         SoLuongTuyen = ttd.SoLuongTuyen,
                         AnhCongTy = ntd.AnhDaiDien
                     });
            //passing model/data to  view
            return View(q);
        }

        [Authorize(Roles = "Candidate")]
        public IActionResult JobInfo(int id)
        {
            var user = User.Identity.Name.ToString();
            UngVien uv = ctx.UngViens.Where(qh => qh.Email == user).SingleOrDefault();
            var uvid = uv.MaUngVien;
            ViewBag.DSUVDK = ctx.UngVienDangKies.Where(qh => qh.MaDangKy == uvid).ToList();
            PJobs.Repository.UngVienDangKiRepository UV = new PJobs.Repository.UngVienDangKiRepository();
            PJobs.Models.UngVienDangKy uvdk = new PJobs.Models.UngVienDangKy();
            uvdk.MaUngVien = uvid;
            uvdk.TinhTrangUngVien = 0;
            uvdk.MaTinTuyenDung = id;
            DateTime currentdate = DateTime.Now;
            uvdk.NgayDangky = currentdate;
            UV.themUngVienDangKi(uvdk);
            return Redirect("~/Job");
        }
        
        //public IActionResult JobInfo()
        //{

        //    var user = User.Identity.Name.ToString();
        //    UngVien uv = ctx.UngViens.Where(qh => qh.Email == user).SingleOrDefault();
        //    var uvid = uv.MaUngVien;


        //    PJobs.Repository.UngVienDangKiRepository UV = new PJobs.Repository.UngVienDangKiRepository();
        //    PJobs.Models.UngVienDangKy uvdk = new PJobs.Models.UngVienDangKy();
        //        uvdk.MaUngVien = uvid;
        //        uvdk.TinhTrangUngVien = 0;
        //        uvdk.MaTinTuyenDung = 0;
        //        DateTime currentdate = DateTime.Now;
        //        uvdk.NgayDangky = currentdate;
        //    UV.themUngVienDangKi(uvdk);
        //    return View();
        //}

    }
}
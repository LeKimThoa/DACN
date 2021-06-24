using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PJobs.Models;
using Microsoft.EntityFrameworkCore;

namespace PJobs.Repository
{
    public class UngVienRepository
    {
        VIECLAMContext ctx = new VIECLAMContext();

        public List<UngVien> getAllUngVien()
        {


            List<UngVien> lst = ctx.UngViens.Include(x => x.UngVienKiNangs).ToList();

            foreach (UngVien u in lst) {
                List<UngVienKiNang> ls = u.UngVienKiNangs.ToList();
               


                foreach (UngVienKiNang uv in ls) {
       

                    uv.MaKiNangNavigation = ctx.KiNangs.Where(x => x.MaKiNang == uv.MaKiNang).Single(); ;
                   
                }
                
                
            }
          
            return lst;
        }
        public UngVien themungvien(UngVien uv)
        {
            ctx.UngViens.Add(uv);
            ctx.SaveChanges();
            return uv;
        }
        public List<UngVien> dsUngVien()
        {
            return ctx.UngViens.ToList();
        }
        public UngVien  timkiemUV_theoid(int id)
        {
            return ctx.UngViens.Where(qh => qh.MaUngVien == id).SingleOrDefault();
        }
        public UngVien suaungvien(UngVien uv)
        {
            UngVien uv_db = ctx.UngViens.Where(x => x.MaUngVien == uv.MaUngVien).SingleOrDefault();
            uv_db.HoTen = uv.HoTen;
            uv_db.Sdt = uv.Sdt;
            uv_db.Cmnd = uv.Cmnd;
            uv_db.DiaChiChiTiet = uv.DiaChiChiTiet;
            uv_db.QuanHuyenSinhSong = uv.QuanHuyenSinhSong;
            uv_db.ThanhPhoSinhSong = uv.ThanhPhoSinhSong;
            uv_db.AnhDaiDien = uv.AnhDaiDien;
            ctx.SaveChanges();
            return uv;
        }
    }
}

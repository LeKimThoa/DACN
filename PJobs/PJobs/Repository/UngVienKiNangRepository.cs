using Microsoft.AspNetCore.Mvc;
using PJobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PJobs.Repository
{
    public class UngVienKiNangRepository : Controller
    {
        VIECLAMContext ctx = new VIECLAMContext();
        public List<UngVienKiNang> getAllUngVienKiNang()
        {
            return ctx.UngVienKiNangs.ToList();
        }


        public UngVienKiNang themUngVienKiNang(UngVienKiNang uvkn)
        {
           
            ctx.UngVienKiNangs.Add(uvkn);
            ctx.SaveChanges();
            return uvkn;
        }

        public List<UngVienKiNang> xoaUngVienKiNang(int tp)
        {

            UngVienKiNang tp_db = ctx.UngVienKiNangs.Where(x => x.Id == tp).SingleOrDefault();
            ctx.UngVienKiNangs.Remove(tp_db);
            ctx.SaveChanges();
            return ctx.UngVienKiNangs.ToList();
        }

        public UngVienKiNang suaUngVienKiNang(UngVienKiNang tp)
        {

            UngVienKiNang tp_db = ctx.UngVienKiNangs.Where(x => x.Id == tp.Id).SingleOrDefault();
            //MaPhanHoi, NoiDungPhanHoi, TinhTrang, NgayPhanHoi, TieuDe, Email, HoTen
            tp_db.MaKiNang = tp.MaKiNang;

            ctx.SaveChanges();
            return tp;
        }
        public UngVienKiNang timkiemUngVienKiNang_theoid(int id)
        {
            return ctx.UngVienKiNangs.Where(qh => qh.Id == id).SingleOrDefault();
        }
    }
}

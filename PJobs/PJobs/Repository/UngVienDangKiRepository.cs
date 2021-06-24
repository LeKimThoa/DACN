using Microsoft.AspNetCore.Mvc;
using PJobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PJobs.Repository
{
    public class UngVienDangKiRepository : Controller
    {
        VIECLAMContext ctx = new VIECLAMContext();
        public List<UngVienDangKy> getAllUngVienDangKy()
        {
            return ctx.UngVienDangKies.ToList();
        }


        public UngVienDangKy themUngVienDangKi(UngVienDangKy uvdk)
        {
           
            ctx.UngVienDangKies.Add(uvdk);
            ctx.SaveChanges();
            return uvdk;
        }

        public List<UngVienDangKy> xoaUngVienDangKy(int tp)
        {

            UngVienDangKy tp_db = ctx.UngVienDangKies.Where(x => x.MaDangKy == tp).SingleOrDefault();
            ctx.UngVienDangKies.Remove(tp_db);
            ctx.SaveChanges();
            return ctx.UngVienDangKies.ToList();
        }

        public UngVienDangKy suaUngVienDangKy(UngVienDangKy tp)
        {

            UngVienDangKy tp_db = ctx.UngVienDangKies.Where(x => x.MaDangKy == tp.MaDangKy).SingleOrDefault();

            tp_db.MaTinTuyenDung = tp.MaTinTuyenDung;

            ctx.SaveChanges();
            return tp;
        }
        public UngVienDangKy timkiemUngVienDangKy_theoid(int id)
        {
            return ctx.UngVienDangKies.Where(qh => qh.MaDangKy == id).SingleOrDefault();
        }
    }
}

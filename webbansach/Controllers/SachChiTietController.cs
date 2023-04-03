using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using webbansach.Data;
using webbansach.Models;

namespace webbansach.Controllers
{
    public class SachChiTietController : Controller
    {
        private readonly ApplicationDbContext _ct;

        public SachChiTietController(ApplicationDbContext ct)
        {
            _ct = ct;
        }
        public IActionResult ChiTiet(int id)
        {
            ViewData["SachInfor"] = getChiTiet(id);
            ViewData["SachInforAll"] = getSach();
            return View();
        }

        public IEnumerable<SachInfor> getChiTiet(int id)
        {
            IEnumerable<SachInfor> sach = from s in _ct.Sach
                                          join tg in _ct.TacGia on s.TacGiaId equals tg.Id
                                          join tl in _ct.TheLoai on s.TheLoaiId equals tl.Id
                                          join nxb in _ct.NXB on s.NhaXuatBanId equals nxb.Id
                                          where s.Id == id
                                          select new SachInfor
                                          {
                                              Id = s.Id,
                                              Ten = s.Ten,
                                              Anh = s.Anh,
                                              GiaBan = s.GiaBan,
                                              GiaNhap = s.GiaNhap,
                                              TenTacGia = tg.TenTG,
                                              TenTheLoai = tl.TenTheLoai,
                                              TenNhaXuatBan = nxb.TenNXB,
                                          };
            return sach;
        }

        public IEnumerable<SachInfor> getSach()
        {
            IEnumerable<SachInfor> sach = from s in _ct.Sach
                                          join tg in _ct.TacGia on s.TacGiaId equals tg.Id
                                          join tl in _ct.TheLoai on s.TheLoaiId equals tl.Id
                                          join nxb in _ct.NXB on s.NhaXuatBanId equals nxb.Id
                                          select new SachInfor
                                          {
                                              Id = s.Id,
                                              Ten = s.Ten,
                                              Anh = s.Anh,
                                              GiaBan = s.GiaBan,
                                              GiaNhap = s.GiaNhap,
                                              TenTacGia = tg.TenTG,
                                              TenTheLoai = tl.TenTheLoai,
                                              TenNhaXuatBan = nxb.TenNXB,
                                          };
            return sach;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using webbansach.Data;
using webbansach.Models;

namespace webbansach.Controllers
{
    public class SachController : Controller
    {
        private readonly ApplicationDbContext _ss;

        public SachController(ApplicationDbContext ss)
        {
            _ss = ss;
        }

        public IActionResult Sach()
        {
            ViewData["Sach"] = GetSach();
            ViewData["TheLoai"] = GetTheLoai();
            ViewData["SachInfor"] = getSach();
            return View();
        }

        public IActionResult SachTheLoai(int id)
        {
            ViewData["Sach"] = GetSachId(id);
            ViewData["TheLoai"] = GetTheLoai();
            return View();
        }

        public IEnumerable<Sach> GetSach()
        {
            IEnumerable<Sach> sach = _ss.Sach;
            return sach;
        }

        public IEnumerable<Sach> GetSachId(int id)
        {
            IEnumerable<Sach> sach = from s in _ss.Sach
                                     where s.TheLoaiId == id
                                     select new Sach
                                     {
                                         Id = s.Id,
                                         Ten = s.Ten,
                                         Anh = s.Anh,
                                         GiaBan = s.GiaBan,
                                         GiaNhap = s.GiaNhap,
                                         TacGiaId = s.TacGiaId,
                                         TheLoaiId = s.TheLoaiId,
                                         NhaXuatBanId = s.NhaXuatBanId,
                                     };
            return sach;
        }
        public IEnumerable<TheLoaiAmount> GetTheLoai()
        {
            IEnumerable<TheLoaiAmount> theloai = from a in _ss.TheLoai
                                                 join b in _ss.Sach on a.Id equals b.TheLoaiId into m
                                                 select new TheLoaiAmount
                                                 {
                                                     Id = a.Id,
                                                     TenTheLoai = a.TenTheLoai,
                                                     SachAmount = m.Count()
                                                 };
            return theloai;
        }
        public IEnumerable<SachInfor> getSach()
        {
            IEnumerable<SachInfor> sach = from s in _ss.Sach
                                          join tg in _ss.TacGia on s.TacGiaId equals tg.Id
                                          join tl in _ss.TheLoai on s.TheLoaiId equals tl.Id
                                          join nxb in _ss.NXB on s.NhaXuatBanId equals nxb.Id
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

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
            return View();
        }

        public IEnumerable<Sach> GetSach()
        {
            IEnumerable<Sach> sach = _ss.Sach;
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
    }
}

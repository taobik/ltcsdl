using Microsoft.EntityFrameworkCore;
using webbansach.Models;

namespace webbansach.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Sach> Sach { get; set; }
        public DbSet<TheLoai> TheLoai { get; set; }    
        public DbSet<NhaXuatBan> NXB { get; set; }
        public DbSet<TacGia> TacGia { get; set; } 

    }
}

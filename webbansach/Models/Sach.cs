using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webbansach.Models
{
    public class Sach
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ten { get; set; }

        public string Anh { get; set;}

        public int GiaNhap { get; set; }

        public int GiaBan { get; set; }

        [ForeignKey("NhaXuatBan")]
        public int NhaXuatBanId { get; set; }
        public NhaXuatBan NhaXuatBan { get; set; }

        [ForeignKey("TacGia")]
        public int TacGiaId { get; set; }
        public TacGia TacGia { get; set; }

        [ForeignKey("TheLoai")]
        public int TheLoaiId { get; set; }
        public TheLoai TheLoai { get; set; }
    }

}

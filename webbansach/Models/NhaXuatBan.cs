using System.ComponentModel.DataAnnotations;

namespace webbansach.Models
{
    public class NhaXuatBan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TenNXB { get; set; }

        public List<Sach> Sach { get; set; }

    }
}

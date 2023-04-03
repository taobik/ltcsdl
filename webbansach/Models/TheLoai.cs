using System.ComponentModel.DataAnnotations;

namespace webbansach.Models
{
    public class TheLoai
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TenTheLoai { get; set; }

        public List<Sach> Sach { get; set; }
    }
}

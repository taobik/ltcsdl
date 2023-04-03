using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webbansach.Models
{
    public class TacGia
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string TenTG { get; set; }

        public List<Sach> Sach { get; set; }
    }
}

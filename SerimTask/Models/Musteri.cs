using System.ComponentModel.DataAnnotations;

namespace SerimTask.Models
{
    public class Musteri
    {
        [Key]
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? TelNo { get; set; }
        public string? Email { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? Cinsiyet { get; set; }
        public bool? Durum { get; set; }
    }
}

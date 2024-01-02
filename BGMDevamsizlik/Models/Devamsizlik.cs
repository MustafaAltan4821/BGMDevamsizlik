namespace BGMDevamsizlik.Models
{
    public class Devamsizlik
    {
        public int Id { get; set; }
        public long TCKimlikNo { get; set; } // Öğrenci TC dir
        public DateTime Zamani { get; set; }
        public string? Aciklama { get; set; }
    }
}

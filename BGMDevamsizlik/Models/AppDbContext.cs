using Microsoft.EntityFrameworkCore;

namespace BGMDevamsizlik.Models
{
    public class AppDbContext: DbContext
    {
        public DbSet<Ogrenci> Ogrencis {  get; set; }
        public DbSet<Devamsizlik> Devamsizliks { get; set; }
        public DbSet<Sinif> Sinifs { get; set; }
        public DbSet<Ders> Derss { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options) { }
    }
}

using Microsoft.EntityFrameworkCore;
using Entities;

namespace DataAccess
{
    public class AppDbCon : DbContext
    {
        public AppDbCon(DbContextOptions<AppDbCon> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=DESKTOP-TMC5GOI\\SQLEXPRESS;Database=ailehekim;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;",
                    b => b.MigrationsAssembly("WebAPI")
                );
            }
        }

        public DbSet<KayitliKisiListe> KayitliKisiListesi { get; set; }
        public DbSet<KabulListe> KabulListeleri { get; set; }
        public DbSet<DoktorKayit> DoktorKayitlari { get; set; }
        public DbSet<DoktorKabulDurumu> DoktorKabulDurumlari { get; set; }
        public DbSet<MhrsKayit> MhrsKayitlar { get; set; }
        public DbSet<Misafir> Misafirler { get; set; }
        public DbSet<Cinsiyet> Cinsiyetler { get; set; }
        public DbSet<TamamlanmaDurumu> TamamlanmaDurumlari { get; set; }
    }
}

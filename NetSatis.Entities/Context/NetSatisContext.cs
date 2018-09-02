using System.Data.Entity;
using NetSatis.Entities.Mapping;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Context
{
    public class NetSatisContext : DbContext
    {
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<StokHareket> StokHareketler { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Fis> Fisler { get; set; }
        public DbSet<KasaHareket> KasaHareketler { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StokMap());
            modelBuilder.Configurations.Add(new CariMap());
            modelBuilder.Configurations.Add(new StokHareketMap());
            modelBuilder.Configurations.Add(new TanimMap());
            modelBuilder.Configurations.Add(new FisMap());
            modelBuilder.Configurations.Add(new KasaHareketMap());
            modelBuilder.Configurations.Add(new DepoMap());
            modelBuilder.Configurations.Add(new KasaMap());
            modelBuilder.Configurations.Add(new OdemeTuruMap());
        }
    }
}
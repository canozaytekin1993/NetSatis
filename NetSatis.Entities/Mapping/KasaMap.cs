using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class KasaMap : EntityTypeConfiguration<Kasa>
    {
        public KasaMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.KasaKodu).HasMaxLength(12);
            Property(p => p.KasaAdi).HasMaxLength(30);
            Property(p => p.YetkiliKodu).HasMaxLength(12);
            Property(p => p.YetkiliAdi).HasMaxLength(50);
            Property(p => p.Aciklama).HasMaxLength(200);

            ToTable("Kasalar");
            Property(p => p.Id).HasColumnName("Id");
            Property(p => p.KasaKodu).HasColumnName("KasaKodu");
            Property(p => p.KasaAdi).HasColumnName("KasaAdi");
            Property(p => p.YetkiliKodu).HasColumnName("YetkiliKodu");
            Property(p => p.YetkiliAdi).HasColumnName("YetkiliAdi");
            Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
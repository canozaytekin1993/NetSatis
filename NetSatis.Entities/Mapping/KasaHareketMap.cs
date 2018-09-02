using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class KasaHareketMap : EntityTypeConfiguration<KasaHareket>
    {
        public KasaHareketMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.FisKodu).HasMaxLength(12);
            Property(p => p.Hareket).HasMaxLength(10);
            Property(p => p.KasaKodu).HasMaxLength(12);
            Property(p => p.KasaAdi).HasMaxLength(30);
            Property(p => p.OdemeTuruKodu).HasMaxLength(12);
            Property(p => p.OdemeTuruAdi).HasMaxLength(30);
            Property(p => p.CariKodu).HasMaxLength(12);
            Property(p => p.CariAdi).HasMaxLength(30);
            Property(p => p.Tarih);
            Property(p => p.Tutar).HasPrecision(12, 2);
            Property(p => p.Aciklama).HasMaxLength(200);

            ToTable("KasaHareketleri");
            Property(p => p.Id).HasColumnName("Id");
            Property(p => p.FisKodu).HasColumnName("FisKodu");
            Property(p => p.Hareket).HasColumnName("Hareket");
            Property(p => p.KasaKodu).HasColumnName("KasaKodu");
            Property(p => p.KasaAdi).HasColumnName("KasaAdi");
            Property(p => p.OdemeTuruKodu).HasColumnName("OdemeTuruKodu");
            Property(p => p.OdemeTuruAdi).HasColumnName("OdemeTuruAdi");
            Property(p => p.CariKodu).HasColumnName("CariKodu");
            Property(p => p.CariAdi).HasColumnName("CariAdi");
            Property(p => p.Tarih).HasColumnName("Tarih");
            Property(p => p.Tutar).HasColumnName("Tutar");
            Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
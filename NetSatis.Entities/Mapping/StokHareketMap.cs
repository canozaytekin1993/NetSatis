using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class StokHareketMap : EntityTypeConfiguration<StokHareket>
    {
        public StokHareketMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.FisKodu).HasMaxLength(12);
            Property(p => p.StokKodu).HasMaxLength(12);
            Property(p => p.Hareket).HasMaxLength(10);
            Property(p => p.StokAdi).HasMaxLength(50);
            Property(p => p.Barkod).HasMaxLength(20);
            Property(p => p.BarkodTuru).HasMaxLength(15);
            Property(p => p.Birimi).HasMaxLength(15);
            Property(p => p.Miktar).HasPrecision(12, 3);
            Property(p => p.BirimFiyati).HasPrecision(12, 2);
            Property(p => p.IndirimOrani).HasPrecision(5, 2);
            Property(p => p.IndirimTutari).HasPrecision(12, 2);
            Property(p => p.ToplamTutar).HasPrecision(12, 2);
            Property(p => p.DepoKodu).HasMaxLength(12);
            Property(p => p.DepoAdi).HasMaxLength(30);
            Property(p => p.SeriNo).HasMaxLength(200);
            Property(p => p.Aciklama).HasMaxLength(200);

            ToTable("StokHareketleri");
            Property(p => p.Id).HasColumnName("Id");
            Property(p => p.FisKodu).HasColumnName("FisKodu");
            Property(p => p.StokKodu).HasColumnName("StokKodu");
            Property(p => p.Hareket).HasColumnName("Hareket");
            Property(p => p.StokAdi).HasColumnName("StokAdi");
            Property(p => p.Barkod).HasColumnName("Barkod");
            Property(p => p.BarkodTuru).HasColumnName("BarkodTuru");
            Property(p => p.Birimi).HasColumnName("Birimi");
            Property(p => p.Miktar).HasColumnName("Miktar");
            Property(p => p.BirimFiyati).HasColumnName("BirimFiyati");
            Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
            Property(p => p.IndirimTutari).HasColumnName("IndirimTutari");
            Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            Property(p => p.DepoKodu).HasColumnName("DepoKodu");
            Property(p => p.DepoAdi).HasColumnName("DepoAdi");
            Property(p => p.SeriNo).HasColumnName("SeriNo");
            Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
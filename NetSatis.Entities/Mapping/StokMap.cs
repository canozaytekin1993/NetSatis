using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class StokMap : EntityTypeConfiguration<Stok>
    {
        public StokMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.StokKodu).HasMaxLength(12);
            Property(p => p.StokAdi).HasMaxLength(50);
            Property(p => p.BarkodKodu).HasMaxLength(20);
            Property(p => p.BarkodTuru).HasMaxLength(15);
            Property(p => p.Birimi).HasMaxLength(15);
            Property(p => p.StokGrubu).HasMaxLength(30);
            Property(p => p.StokAltGrubu).HasMaxLength(30);
            Property(p => p.Marka).HasMaxLength(30);
            Property(p => p.Modeli).HasMaxLength(30);
            Property(p => p.OzelKod1).HasMaxLength(30);
            Property(p => p.OzelKod2).HasMaxLength(30);
            Property(p => p.OzelKod3).HasMaxLength(30);
            Property(p => p.OzelKod4).HasMaxLength(30);
            Property(p => p.GarantiSuresi).HasMaxLength(15);
            Property(p => p.UreticiKodu).HasMaxLength(20);
            Property(p => p.AlisFiyatı1).HasPrecision(12, 2);
            Property(p => p.AlisFiyatı2).HasPrecision(12, 2);
            Property(p => p.AlisFiyatı3).HasPrecision(12, 2);
            Property(p => p.SatisFiyatı1).HasPrecision(12, 2);
            Property(p => p.SatisFiyatı2).HasPrecision(12, 2);
            Property(p => p.SatisFiyatı3).HasPrecision(12, 2);
            Property(p => p.MinStokMiktari).HasPrecision(12, 3);
            Property(p => p.MaxStokMiktari).HasPrecision(12, 3);
            Property(p => p.Aciklama).HasMaxLength(200);

            ToTable("Stoklar");
            Property(p => p.Id).HasColumnName("Id");
            Property(p => p.Durumu).HasColumnName("Durumu");
            Property(p => p.StokKodu).HasColumnName("StokKodu");
            Property(p => p.StokAdi).HasColumnName("StokAdi");
            Property(p => p.BarkodKodu).HasColumnName("BarkodKodu");
            Property(p => p.BarkodTuru).HasColumnName("BarkodTuru");
            Property(p => p.Birimi).HasColumnName("Birimi");
            Property(p => p.StokGrubu).HasColumnName("StokGrubu");
            Property(p => p.StokAltGrubu).HasColumnName("StokAltGrubu");
            Property(p => p.Marka).HasColumnName("Marka");
            Property(p => p.Modeli).HasColumnName("Modeli");
            Property(p => p.OzelKod1).HasColumnName("OzelKod1");
            Property(p => p.OzelKod2).HasColumnName("OzelKod2");
            Property(p => p.OzelKod3).HasColumnName("OzelKod3");
            Property(p => p.OzelKod4).HasColumnName("OzelKod4");
            Property(p => p.GarantiSuresi).HasColumnName("GarantiSuresi");
            Property(p => p.UreticiKodu).HasColumnName("UreticiKodu");
            Property(p => p.AlisFiyatı1).HasColumnName("AlisFiyatı1");
            Property(p => p.AlisFiyatı2).HasColumnName("AlisFiyatı2");
            Property(p => p.AlisFiyatı3).HasColumnName("AlisFiyatı3");
            Property(p => p.MinStokMiktari).HasColumnName("MinStokMiktari");
            Property(p => p.MaxStokMiktari).HasColumnName("MaxStokMiktari");
            Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
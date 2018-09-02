using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class CariMap : EntityTypeConfiguration<Cari>
    {
        public CariMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.CariTuru).HasMaxLength(15);
            Property(p => p.CariKodu).HasMaxLength(12);
            Property(p => p.CariAdi).HasMaxLength(50);
            Property(p => p.YetkiliKisi).HasMaxLength(50);
            Property(p => p.FaturaUnvani).HasMaxLength(50);
            Property(p => p.CepTelefonu).HasMaxLength(20);
            Property(p => p.Telefon).HasMaxLength(20);
            Property(p => p.Fax).HasMaxLength(20);
            Property(p => p.Email).HasMaxLength(50);
            Property(p => p.Web).HasMaxLength(50);
            Property(p => p.Il).HasMaxLength(20);
            Property(p => p.Ilce).HasMaxLength(20);
            Property(p => p.Semt).HasMaxLength(20);
            Property(p => p.Adres).HasMaxLength(100);
            Property(p => p.CariGrubu).HasMaxLength(30);
            Property(p => p.CariAltGrubu).HasMaxLength(30);
            Property(p => p.OzelKod1).HasMaxLength(30);
            Property(p => p.OzelKod2).HasMaxLength(30);
            Property(p => p.OzelKod3).HasMaxLength(30);
            Property(p => p.OzelKod4).HasMaxLength(30);
            Property(p => p.VergiDairesi).HasMaxLength(30);
            Property(p => p.VergiNo).HasMaxLength(15);
            Property(p => p.IskontoOrani).HasPrecision(5, 2);
            Property(p => p.RiskLimiti).HasPrecision(12, 2);
            Property(p => p.AlisOzelFiyati).HasMaxLength(15);
            Property(p => p.SatisOzelFiyati).HasMaxLength(15);
            Property(p => p.Aciklama).HasMaxLength(200);

            ToTable("Cariler");
            Property(p => p.Id).HasColumnName("Id");
            Property(p => p.CariTuru).HasColumnName("CariTuru");
            Property(p => p.CariKodu).HasColumnName("CariKodu");
            Property(p => p.CariAdi).HasColumnName("CariAdi");
            Property(p => p.YetkiliKisi).HasColumnName("YetkiliKisi");
            Property(p => p.FaturaUnvani).HasColumnName("FaturaUnvani");
            Property(p => p.CepTelefonu).HasColumnName("CepTelefonu");
            Property(p => p.Telefon).HasColumnName("Telefon");
            Property(p => p.Fax).HasColumnName("Fax");
            Property(p => p.Email).HasColumnName("Email");
            Property(p => p.Web).HasColumnName("Web");
            Property(p => p.Il).HasColumnName("Il");
            Property(p => p.Ilce).HasColumnName("Ilce");
            Property(p => p.Semt).HasColumnName("Semt");
            Property(p => p.Adres).HasColumnName("Adres");
            Property(p => p.CariGrubu).HasColumnName("CariGrubu");
            Property(p => p.CariAltGrubu).HasColumnName("CariAltGrubu");
            Property(p => p.OzelKod1).HasColumnName("OzelKod1");
            Property(p => p.OzelKod2).HasColumnName("OzelKod2");
            Property(p => p.OzelKod3).HasColumnName("OzelKod3");
            Property(p => p.OzelKod4).HasColumnName("OzelKod4");
            Property(p => p.VergiDairesi).HasColumnName("VergiDairesi");
            Property(p => p.VergiNo).HasColumnName("VergiNo");
            Property(p => p.IskontoOrani).HasColumnName("IskontoOrani");
            Property(p => p.RiskLimiti).HasColumnName("RiskLimiti");
            Property(p => p.AlisOzelFiyati).HasColumnName("AlisOzelFiyati");
            Property(p => p.SatisOzelFiyati).HasColumnName("SatisOzelFiyati");
            Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
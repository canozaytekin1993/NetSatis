using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class FisMap : EntityTypeConfiguration<Fis>
    {
        public FisMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.FisKodu).HasMaxLength(12);
            Property(p => p.FisTuru).HasMaxLength(30);
            Property(p => p.CariKodu).HasMaxLength(12);
            Property(p => p.CariAdi).HasMaxLength(30);
            Property(p => p.CariTuru).HasMaxLength(30);
            Property(p => p.BelgeNo).HasMaxLength(20);
            Property(p => p.PlasiyerKodu).HasMaxLength(12);
            Property(p => p.PlasiyerAdi).HasMaxLength(30);
            Property(p => p.IskontoOrani).HasPrecision(5, 2);
            Property(p => p.IskontoTutar).HasPrecision(5, 2);
            Property(p => p.ToplamTutar).HasPrecision(5, 2);
            Property(p => p.Aciklama).HasMaxLength(200);

            ToTable("Fisler");
            Property(p => p.Id).HasColumnName("Id");
            Property(p => p.FisKodu).HasColumnName("FisKodu");
            Property(p => p.FisTuru).HasColumnName("FisTuru");
            Property(p => p.CariKodu).HasColumnName("CariKodu");
            Property(p => p.CariAdi).HasColumnName("CariAdi");
            Property(p => p.CariTuru).HasColumnName("CariTuru");
            Property(p => p.PlasiyerKodu).HasColumnName("PlasiyerKodu");
            Property(p => p.PlasiyerAdi).HasColumnName("PlasiyerAdi");
            Property(p => p.BelgeNo).HasColumnName("BelgeNo");
            Property(p => p.IskontoOrani).HasColumnName("IskontoOrani");
            Property(p => p.IskontoTutar).HasColumnName("IskontoTutar");
            Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class DepoMap : EntityTypeConfiguration<Depo>
    {
        public DepoMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.DepoKodu).HasMaxLength(12);
            Property(p => p.DepoAdi).HasMaxLength(30);
            Property(p => p.YetkiliKodu).HasMaxLength(12);
            Property(p => p.YetkiliAdi).HasMaxLength(30);
            Property(p => p.Il).HasMaxLength(20);
            Property(p => p.Ilce).HasMaxLength(20);
            Property(p => p.Semt).HasMaxLength(20);
            Property(p => p.Adres).HasMaxLength(100);
            Property(p => p.Telefon).HasMaxLength(20);
            Property(p => p.Aciklama).HasMaxLength(200);

            ToTable("Depolar");
            Property(p => p.Id).HasColumnName("Id");
            Property(p => p.DepoKodu).HasColumnName("DepoKodu");
            Property(p => p.DepoAdi).HasColumnName("DepoAdi");
            Property(p => p.YetkiliKodu).HasColumnName("YetkiliKodu");
            Property(p => p.YetkiliAdi).HasColumnName("YetkiliAdi");
            Property(p => p.Il).HasColumnName("Il");
            Property(p => p.Ilce).HasColumnName("Ilce");
            Property(p => p.Semt).HasColumnName("Semt");
            Property(p => p.Adres).HasColumnName("Adres");
            Property(p => p.Telefon).HasColumnName("Telefon");
            Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
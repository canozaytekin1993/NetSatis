using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class OdemeTuruMap : EntityTypeConfiguration<OdemeTuru>
    {
        public OdemeTuruMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.OdemeTuruKodu).HasMaxLength(12);
            Property(p => p.OdemeTuruAdi).HasMaxLength(30);
            Property(p => p.Aciklama).HasMaxLength(200);

            ToTable("OdemeTurleri");
            Property(p => p.Id).HasColumnName("Id");
            Property(p => p.OdemeTuruKodu).HasColumnName("OdemeTuruKodu");
            Property(p => p.OdemeTuruAdi).HasColumnName("OdemeTuruAdi");
            Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
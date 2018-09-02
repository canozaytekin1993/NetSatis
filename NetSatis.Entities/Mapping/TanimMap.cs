using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class TanimMap : EntityTypeConfiguration<Tanim>
    {
        public TanimMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Turu).HasMaxLength(15);
            Property(p => p.Tanimi).HasMaxLength(30);
            Property(p => p.Aciklama).HasMaxLength(200);

            ToTable("Tanimlar");
            Property(p => p.Id).HasColumnName("Id");
            Property(p => p.Turu).HasColumnName("Turu");
            Property(p => p.Tanimi).HasColumnName("Tanimi");
            Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
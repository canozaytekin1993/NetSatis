using System.Data.Entity.Migrations;
using NetSatis.Entities.Context;

namespace NetSatis.Entities.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<NetSatisContext>
    {
        public Configuration()
        {
            // Otomatik olarak database güncellenmesini sağlar.
            AutomaticMigrationsEnabled = true;
            // Otomatik olarak veri kayıplarını onaylıyorum.
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "NetSatis.Entities.Context.NetSatisContext";
        }

        protected override void Seed(NetSatisContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
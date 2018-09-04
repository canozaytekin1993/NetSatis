using System.Data.Entity.Migrations;

namespace NetSatis.Entities.Migrations
{
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Cariler",
                    c => new
                    {
                        Id = c.Int(false, true),
                        Durumu = c.Boolean(false),
                        CariTuru = c.String(maxLength: 15),
                        CariKodu = c.String(maxLength: 12),
                        CariAdi = c.String(maxLength: 50),
                        YetkiliKisi = c.String(maxLength: 50),
                        FaturaUnvani = c.String(maxLength: 50),
                        CepTelefonu = c.String(maxLength: 20),
                        Telefon = c.String(maxLength: 20),
                        Fax = c.String(maxLength: 20),
                        Email = c.String(maxLength: 50),
                        Web = c.String(maxLength: 50),
                        Il = c.String(maxLength: 20),
                        Ilce = c.String(maxLength: 20),
                        Semt = c.String(maxLength: 20),
                        Adres = c.String(maxLength: 100),
                        CariGrubu = c.String(maxLength: 30),
                        CariAltGrubu = c.String(maxLength: 30),
                        OzelKod1 = c.String(maxLength: 30),
                        OzelKod2 = c.String(maxLength: 30),
                        OzelKod3 = c.String(maxLength: 30),
                        OzelKod4 = c.String(maxLength: 30),
                        VergiDairesi = c.String(maxLength: 30),
                        VergiNo = c.String(maxLength: 15),
                        IskontoOrani = c.Decimal(false, 5, 2),
                        RiskLimiti = c.Decimal(false, 12, 2),
                        AlisOzelFiyati = c.String(maxLength: 15),
                        SatisOzelFiyati = c.String(maxLength: 15),
                        Aciklama = c.String(maxLength: 200)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.Depolar",
                    c => new
                    {
                        Id = c.Int(false, true),
                        DepoKodu = c.String(maxLength: 12),
                        DepoAdi = c.String(maxLength: 30),
                        YetkiliKodu = c.String(maxLength: 12),
                        YetkiliAdi = c.String(maxLength: 30),
                        Il = c.String(maxLength: 20),
                        Ilce = c.String(maxLength: 20),
                        Semt = c.String(maxLength: 20),
                        Adres = c.String(maxLength: 100),
                        Telefon = c.String(maxLength: 20),
                        Aciklama = c.String(maxLength: 200)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.Fisler",
                    c => new
                    {
                        Id = c.Int(false, true),
                        FisKodu = c.String(maxLength: 12),
                        FisTuru = c.String(maxLength: 30),
                        CariKodu = c.String(maxLength: 12),
                        CariTuru = c.String(maxLength: 30),
                        CariAdi = c.String(maxLength: 30),
                        BelgeNo = c.String(maxLength: 20),
                        Tarih = c.DateTime(false),
                        PlasiyerKodu = c.String(maxLength: 12),
                        PlasiyerAdi = c.String(maxLength: 30),
                        IskontoOrani = c.Decimal(false, 5, 2),
                        IskontoTutar = c.Decimal(false, 5, 2),
                        ToplamTutar = c.Decimal(false, 5, 2),
                        Aciklama = c.String(maxLength: 200)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.KasaHareketleri",
                    c => new
                    {
                        Id = c.Int(false, true),
                        FisKodu = c.String(maxLength: 12),
                        Hareket = c.String(maxLength: 10),
                        KasaKodu = c.String(maxLength: 12),
                        KasaAdi = c.String(maxLength: 30),
                        OdemeTuruKodu = c.String(maxLength: 12),
                        OdemeTuruAdi = c.String(maxLength: 30),
                        CariKodu = c.String(maxLength: 12),
                        CariAdi = c.String(maxLength: 30),
                        Tarih = c.DateTime(false),
                        Tutar = c.Decimal(false, 12, 2),
                        Aciklama = c.String(maxLength: 200)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.Kasalar",
                    c => new
                    {
                        Id = c.Int(false, true),
                        KasaKodu = c.String(maxLength: 12),
                        KasaAdi = c.String(maxLength: 30),
                        YetkiliKodu = c.String(maxLength: 12),
                        YetkiliAdi = c.String(maxLength: 50),
                        Aciklama = c.String(maxLength: 200)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.OdemeTurleri",
                    c => new
                    {
                        Id = c.Int(false, true),
                        OdemeTuruKodu = c.String(maxLength: 12),
                        OdemeTuruAdi = c.String(maxLength: 30),
                        Aciklama = c.String(maxLength: 200)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.StokHareketleri",
                    c => new
                    {
                        Id = c.Int(false, true),
                        FisKodu = c.String(maxLength: 12),
                        Hareket = c.String(maxLength: 10),
                        StokKodu = c.String(maxLength: 12),
                        StokAdi = c.String(maxLength: 50),
                        BarkodTuru = c.String(maxLength: 15),
                        Barkod = c.String(maxLength: 20),
                        Birimi = c.String(maxLength: 15),
                        Miktar = c.Decimal(false, 12, 3),
                        Kdv = c.Int(false),
                        BirimFiyati = c.Decimal(false, 12, 2),
                        IndirimOrani = c.Decimal(false, 5, 2),
                        IndirimTutari = c.Decimal(false, 12, 2),
                        ToplamTutar = c.Decimal(false, 12, 2),
                        DepoKodu = c.String(maxLength: 12),
                        DepoAdi = c.String(maxLength: 30),
                        SeriNo = c.String(maxLength: 200),
                        Tarih = c.DateTime(false),
                        Aciklama = c.String(maxLength: 200)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.Stoklar",
                    c => new
                    {
                        Id = c.Int(false, true),
                        Durumu = c.Boolean(false),
                        StokKodu = c.String(maxLength: 12),
                        StokAdi = c.String(maxLength: 50),
                        BarkodKodu = c.String(maxLength: 20),
                        BarkodTuru = c.String(maxLength: 15),
                        Birimi = c.String(maxLength: 15),
                        StokGrubu = c.String(maxLength: 30),
                        StokAltGrubu = c.String(maxLength: 30),
                        Marka = c.String(maxLength: 30),
                        Modeli = c.String(maxLength: 30),
                        OzelKod1 = c.String(maxLength: 30),
                        OzelKod2 = c.String(maxLength: 30),
                        OzelKod3 = c.String(maxLength: 30),
                        OzelKod4 = c.String(maxLength: 30),
                        GarantiSuresi = c.String(maxLength: 15),
                        UreticiKodu = c.String(maxLength: 20),
                        AlisKdv = c.Int(false),
                        SatisKdv = c.Int(false),
                        AlisFiyatı1 = c.Decimal(false, 12, 2),
                        AlisFiyatı2 = c.Decimal(false, 12, 2),
                        AlisFiyatı3 = c.Decimal(false, 12, 2),
                        SatisFiyatı1 = c.Decimal(false, 12, 2),
                        SatisFiyatı2 = c.Decimal(false, 12, 2),
                        SatisFiyatı3 = c.Decimal(false, 12, 2),
                        MinStokMiktari = c.Decimal(false, 12, 3),
                        MaxStokMiktari = c.Decimal(false, 12, 3),
                        Aciklama = c.String(maxLength: 200)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.Tanimlar",
                    c => new
                    {
                        Id = c.Int(false, true),
                        Turu = c.String(maxLength: 15),
                        Tanimi = c.String(maxLength: 30),
                        Aciklama = c.String(maxLength: 200)
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Tanimlar");
            DropTable("dbo.Stoklar");
            DropTable("dbo.StokHareketleri");
            DropTable("dbo.OdemeTurleri");
            DropTable("dbo.Kasalar");
            DropTable("dbo.KasaHareketleri");
            DropTable("dbo.Fisler");
            DropTable("dbo.Depolar");
            DropTable("dbo.Cariler");
        }
    }
}
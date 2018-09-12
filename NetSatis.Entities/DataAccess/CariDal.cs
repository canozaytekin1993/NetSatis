using System.Collections.Generic;
using System.Linq;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;

namespace NetSatis.Entities.DataAccess
{
    public class CariDAL : EntityRepositoryBase<NetSatisContext, Cari, CariValidator>
    {
        public object GetCariler(NetSatisContext context)
        {
            var result = context.Cariler.GroupJoin(context.Fisler, c => c.CariKodu, c => c.CariKodu,
                (cariler, fisler) => new
                {
                    cariler.Id,
                    cariler.Durumu,
                    cariler.CariKodu,
                    cariler.CariAdi,
                    cariler.CariTuru,
                    cariler.YetkiliKisi,
                    cariler.FaturaUnvani,
                    cariler.CepTelefonu,
                    cariler.Telefon,
                    cariler.Fax,
                    cariler.Email,
                    cariler.Web,
                    cariler.Il,
                    cariler.Ilce,
                    cariler.Semt,
                    cariler.Adres,
                    cariler.CariGrubu,
                    cariler.CariAltGrubu,
                    cariler.OzelKod1,
                    cariler.OzelKod2,
                    cariler.OzelKod3,
                    cariler.OzelKod4,
                    cariler.VergiNo,
                    cariler.VergiDairesi,
                    cariler.IskontoOrani,
                    cariler.RiskLimiti,
                    cariler.AlisOzelFiyati,
                    cariler.SatisOzelFiyati,
                    cariler.Aciklama,
                    AlisToplam = fisler.Where(c => c.FisTuru == "Alış Fişi").Sum(c => c.ToplamTutar) ?? 0,
                    SatisToplam = fisler.Where(c => c.FisTuru == "Satış Fişi").Sum(c => c.ToplamTutar) ?? 0
                }).GroupJoin(context.KasaHareketler, c => c.CariKodu, c => c.CariKodu, (cariler, kasahareket) => new
            {
                cariler.Id,
                cariler.Durumu,
                cariler.CariKodu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.CepTelefonu,
                cariler.Telefon,
                cariler.Fax,
                cariler.Email,
                cariler.Web,
                cariler.Il,
                cariler.Ilce,
                cariler.Semt,
                cariler.Adres,
                cariler.CariGrubu,
                cariler.CariAltGrubu,
                cariler.OzelKod1,
                cariler.OzelKod2,
                cariler.OzelKod3,
                cariler.OzelKod4,
                cariler.VergiNo,
                cariler.VergiDairesi,
                cariler.IskontoOrani,
                cariler.RiskLimiti,
                cariler.AlisOzelFiyati,
                cariler.SatisOzelFiyati,
                cariler.Aciklama,
                Alacak =
                    cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                Borc = cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                Bakiye = cariler.AlisToplam +
                         (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) -
                         (cariler.SatisToplam +
                          (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0))
            }).ToList();
            return result;
        }

        public object CariFisAyrinti(NetSatisContext context, string cariKodu)
        {
            var result = context.Fisler.Where(c => c.CariKodu == cariKodu).GroupJoin(
                context.KasaHareketler.Where(c => c.CariKodu == cariKodu), c => c.CariKodu, c => c.CariKodu,
                (fisler, kasahareket) => new
                {
                    fisler.Id,
                    fisler.FisKodu,
                    fisler.FisTuru,
                    fisler.PlasiyerKodu,
                    fisler.PlasiyerAdi,
                    fisler.BelgeNo,
                    fisler.Tarih,
                    fisler.IskontoOrani,
                    fisler.IskontoTutar,
                    fisler.Aciklama,
                    fisler.ToplamTutar,
                    Odenen = context.KasaHareketler.Sum(c => c.Tutar) ?? 0,
                    KalanOdeme = fisler.ToplamTutar - context.KasaHareketler.Sum(c => c.Tutar) ?? 0
                }).ToList();
            return result;}

        public object CariFisGenelToplam(NetSatisContext context, string cariKodu)
        {
            var result = (from c in context.Fisler.Where(c => c.CariKodu == cariKodu)
                group c by new {c.FisTuru, c.ToplamTutar}
                into grp
                select new
                {
                    Bilgi = grp.Key.FisTuru,
                    KayitSayisi = grp.Count(),
                    ToplamTutar = grp.Sum(c => c.ToplamTutar)
                }).ToList();
            return result;
        }

        public object CariGenelToplam(NetSatisContext context, string cariKodu)
        {
            var genelToplamlar = new List<GenelToplam>
            {
                new GenelToplam
                {
                    Bilgi = "Alacak",
                    Tutar = 0
                },
                new GenelToplam
                {
                    Bilgi = "Borç",
                    Tutar = 0
                },
                new GenelToplam
                {
                    Bilgi = "Bakiye",
                    Tutar = 0
                }
            };
            return genelToplamlar;
        }
    }
}
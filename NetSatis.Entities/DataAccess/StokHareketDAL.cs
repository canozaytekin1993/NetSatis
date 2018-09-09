using System.Linq;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;

namespace NetSatis.Entities.DataAccess
{
    public class StokHareketDAL : EntityRepositoryBase<NetSatisContext, StokHareket, StokHareketValidator>
    {
        public object GetGenelStok(NetSatisContext context, string stokKodu)
        {
            var result = (from c in context.StokHareketler.Where(c => c.StokKodu == stokKodu)
                group c by new {c.Hareket}
                into g
                select new
                {
                    Bilgi = g.Key.Hareket,
                    KayitSayisi = g.Count(),
                    Toplam = g.Sum(c => c.Miktar)
                }).ToList();
            return result;
        }

        public object GetDepoStok(NetSatisContext context, string StokKodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketler.Where(c => c.StokKodu == StokKodu),
                c => c.DepoKodu, c => c.DepoKodu, (depolar, stokhareketleri) => new
                {
                    depolar.DepoKodu,
                    depolar.DepoAdi,
                    StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giris").Sum(c => c.Miktar) ?? 0,
                    StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = (stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ??
                                  0) - (stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0)
                }).ToList();
            return result;
        }
    }
}
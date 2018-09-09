using System.Linq;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;

namespace NetSatis.Entities.DataAccess
{
    public class StokDAL : EntityRepositoryBase<NetSatisContext, Stok, StokValidator>
    {
        public object GetAllJoin(NetSatisContext context)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketler, c => c.StokKodu, c => c.StokKodu,
                (Stoklar, StokHareket) => new
                {
                    Stoklar.Id,
                    Stoklar.Durumu,
                    Stoklar.StokKodu,
                    Stoklar.StokAdi,
                    Stoklar.BarkodKodu,
                    Stoklar.BarkodTuru,
                    Stoklar.Birimi,
                    Stoklar.StokGrubu,
                    Stoklar.StokAltGrubu,
                    Stoklar.Marka,
                    Stoklar.Modeli,
                    Stoklar.OzelKod1,
                    Stoklar.OzelKod2,
                    Stoklar.OzelKod3,
                    Stoklar.OzelKod4,
                    Stoklar.GarantiSuresi,
                    Stoklar.UreticiKodu,
                    Stoklar.AlisKdv,
                    Stoklar.SatisKdv,
                    Stoklar.AlisFiyatı1,
                    Stoklar.AlisFiyatı2,
                    Stoklar.AlisFiyatı3,
                    Stoklar.SatisFiyatı1,
                    Stoklar.SatisFiyatı2,
                    Stoklar.SatisFiyatı3,
                    Stoklar.MinStokMiktari,
                    Stoklar.MaxStokMiktari,
                    Stoklar.Aciklama,
                    StokGiris = StokHareket.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = StokHareket.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = StokHareket.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) -
                                 StokHareket.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0
                }).ToList();
            return tablo;
        }
    }
}
﻿using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class Stok : IEntity
    {
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string BarkodKodu { get; set; }
        public string BarkodTuru { get; set; }
        public string Birimi { get; set; }
        public string StokGrubu { get; set; }
        public string StokAltGrubu { get; set; }
        public string Marka { get; set; }
        public string Modeli { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
        public string OzelKod4 { get; set; }
        public string GarantiSuresi { get; set; }
        public string UreticiKodu { get; set; }
        public int AlisKdv { get; set; }
        public int SatisKdv { get; set; }
        public decimal? AlisFiyatı1 { get; set; }
        public decimal? AlisFiyatı2 { get; set; }
        public decimal? AlisFiyatı3 { get; set; }
        public decimal? SatisFiyatı1 { get; set; }
        public decimal? SatisFiyatı2 { get; set; }
        public decimal? SatisFiyatı3 { get; set; }
        public decimal? MinStokMiktari { get; set; }
        public decimal? MaxStokMiktari { get; set; }
        public string Aciklama { get; set; }
    }
}
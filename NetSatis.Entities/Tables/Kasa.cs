﻿using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class Kasa : IEntity
    {
        public int Id { get; set; }
        public string KasaKodu { get; set; }
        public string KasaAdi { get; set; }
        public string YetkiliKodu { get; set; }
        public string YetkiliAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
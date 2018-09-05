using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class OdemeTuru : IEntity
    {
        public int Id { get; set; }
        public string OdemeTuruKodu { get; set; }
        public string OdemeTuruAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
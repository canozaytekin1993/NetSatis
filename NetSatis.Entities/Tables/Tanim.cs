using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class Tanim : IEntity
    {
        public int Id { get; set; }
        public string Turu { get; set; }
        public string Tanimi { get; set; }
        public string Aciklama { get; set; }
    }
}
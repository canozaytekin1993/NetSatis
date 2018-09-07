using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;

namespace NetSatis.BackOffice.Stok_Menü
{
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        private NetSatisContext context = new NetSatisContext();
        public FrmStok()
        {
            InitializeComponent();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
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
                    StokGiris = StokHareket.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.ToplamTutar),
                    StokCikis = StokHareket.Where(c => c.Hareket == "Stok Cikis").Sum(c => c.ToplamTutar),
                    MevcutStok = StokHareket.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.ToplamTutar) -
                                 StokHareket.Where(c => c.Hareket == "Stok Cikis").Sum(c => c.ToplamTutar)
                }).ToList();
            gridControl1.DataSource = tablo;
        }
    }
}
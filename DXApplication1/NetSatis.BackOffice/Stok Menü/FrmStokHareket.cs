using System;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;

namespace NetSatis.BackOffice.Stok_Menü
{
    public partial class FrmStokHareket : XtraForm
    {
        private readonly string _stokKodu;
        private readonly NetSatisContext context = new NetSatisContext();
        private readonly StokHareketDAL stokHareketDal = new StokHareketDAL();

        public FrmStokHareket(string stokKodu, string strongAdi)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
            lblBaslik.Text = _stokKodu + " - " + strongAdi + " Hareketleri ";
        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            gridcontStokHareket.DataSource = stokHareketDal.GetAll(context, c => c.StokKodu == _stokKodu);
            gridcontGenelStok.DataSource = stokHareketDal.GetGenelStok(context, _stokKodu);
            gridcontDepoStok.DataSource = stokHareketDal.GetDepoStok(context, _stokKodu);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.OptionsView.ShowAutoFilterRow)
                gridStokHareket.OptionsView.ShowAutoFilterRow = false;
            else
                gridStokHareket.OptionsView.ShowAutoFilterRow = true;
        }
    }
}
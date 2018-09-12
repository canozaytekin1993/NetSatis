using System;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Tables;

namespace NetSatis.BackOffice.Stok_Menü
{
    public partial class FrmStokIslem : Form
    {
        private readonly Stok _entity;
        private readonly NetSatisContext context = new NetSatisContext();
        private readonly StokDAL stokDal = new StokDAL();

        public FrmStokIslem(Stok entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            txtStokKodu.DataBindings.Add("Text", _entity, "StokKodu");
            txtBarkod.DataBindings.Add("Text", _entity, "BarkodKodu");
            cmbBarkodTuru.DataBindings.Add("Text", _entity, "BarkodTuru");
            txtStokAdi.DataBindings.Add("Text", _entity, "StokAdi");
            btnBirimi.DataBindings.Add("Text", _entity, "Birimi");
            txtUreticiKodu.DataBindings.Add("Text", _entity, "UreticiKodu");
            txtGarantiSuresi.DataBindings.Add("Text", _entity, "GarantiSuresi");

            calcMaxStokMiktarı.DataBindings.Add("Text", _entity, "MaxStokMiktari");
            calcMaxStokMiktarı.DataBindings[0].FormattingEnabled = true;
            calcMaxStokMiktarı.DataBindings[0].FormatString = "N3";

            calcMinStokMiktarı.DataBindings.Add("Text", _entity, "MinStokMiktari");
            calcMinStokMiktarı.DataBindings[0].FormattingEnabled = true;
            calcMinStokMiktarı.DataBindings[0].FormatString = "N3";

            memoAcıklama.DataBindings.Add("Text", _entity, "Aciklama");
            btnStokGrubu.DataBindings.Add("Text", _entity, "StokGrubu");
            btnStokAltGrubu.DataBindings.Add("Text", _entity, "StokAltGrubu");
            btnMarka.DataBindings.Add("Text", _entity, "Marka");
            btnModel.DataBindings.Add("Text", _entity, "Modeli");
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1");
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2");
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3");
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4");

            calcAlisKdv.DataBindings.Add("Text", _entity, "AlisKdv");
            calcAlisKdv.DataBindings[0].FormattingEnabled = true;
            calcAlisKdv.DataBindings[0].FormatString = "'%'0";

            calcSatisKdv.DataBindings.Add("Text", _entity, "SatisKdv");
            calcSatisKdv.DataBindings[0].FormattingEnabled = true;
            calcSatisKdv.DataBindings[0].FormatString = "'%'0";

            calcAlisFiyati1.DataBindings.Add("Text", _entity, "AlisFiyatı1");
            calcAlisFiyati1.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati1.DataBindings[0].FormatString = "C2";

            calcAlisFiyati2.DataBindings.Add("Text", _entity, "AlisFiyatı2");
            calcAlisFiyati2.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati2.DataBindings[0].FormatString = "C2";

            calcAlisFiyati3.DataBindings.Add("Text", _entity, "AlisFiyatı3");
            calcAlisFiyati3.DataBindings[0].FormattingEnabled = true;
            calcAlisFiyati3.DataBindings[0].FormatString = "C2";

            calcSatisFiyati1.DataBindings.Add("Text", _entity, "SatisFiyatı1");
            calcSatisFiyati1.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati1.DataBindings[0].FormatString = "C2";

            calcSatisFiyati2.DataBindings.Add("Text", _entity, "SatisFiyatı2");
            calcSatisFiyati2.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati2.DataBindings[0].FormatString = "C2";

            calcSatisFiyati3.DataBindings.Add("Text", _entity, "SatisFiyatı3");
            calcSatisFiyati3.DataBindings[0].FormattingEnabled = true;
            calcSatisFiyati3.DataBindings[0].FormatString = "C2";
        }

        private void FrmStokIslem_Load(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (stokDal.AddOrUpdate(context, _entity))
            {
                stokDal.Save(context);
                Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
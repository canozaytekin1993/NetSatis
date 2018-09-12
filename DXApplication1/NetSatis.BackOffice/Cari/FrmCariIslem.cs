using System;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;

namespace NetSatis.BackOffice.Cari
{
    public partial class FrmCariIslem : XtraForm
    {
        private readonly Entities.Tables.Cari _entity;
        private readonly CariDAL cariDal = new CariDAL();
        private readonly NetSatisContext context = new NetSatisContext();

        public FrmCariIslem(Entities.Tables.Cari entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu");
            txtCariKodu.DataBindings.Add("Text", _entity, "CariKodu");
            txtCariAdi.DataBindings.Add("Text", _entity, "CariAdi");
            cmbCariTuru.DataBindings.Add("Text", _entity, "CariTuru");
            txtYetkiliKisi.DataBindings.Add("Text", _entity, "YetkiliKisi");
            txtFaturaUnvani.DataBindings.Add("Text", _entity, "FaturaUnvani");
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi");
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo");
            memoAcıklama.DataBindings.Add("Text", _entity, "Aciklama");
            txtCepTelefon.DataBindings.Add("Text", _entity, "CepTelefonu");
            txtSabitTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtFax.DataBindings.Add("Text", _entity, "Fax");
            txtEmail.DataBindings.Add("Text", _entity, "Email");
            txtWeb.DataBindings.Add("Text", _entity, "Web");
            txtIl.DataBindings.Add("Text", _entity, "Il");
            txtIlce.DataBindings.Add("Text", _entity, "Ilce");
            txtSemt.DataBindings.Add("Text", _entity, "Semt");
            memoAdres.DataBindings.Add("Text", _entity, "Adres");
            btnCariGrubu.DataBindings.Add("Text", _entity, "CariGrubu");
            btnCariAltGrubu.DataBindings.Add("Text", _entity, "CariAltGrubu");
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1");
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2");
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3");
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4");
            cmbAlisOzelFiyati.DataBindings.Add("Text", _entity, "AlisOzelFiyati");
            cmbSatisOzelFiyati.DataBindings.Add("Text", _entity, "SatisOzelFiyati");

            cmbIskontoOrani.DataBindings.Add("Text", _entity, "IskontoOrani");
            cmbIskontoOrani.DataBindings[0].FormattingEnabled = true;
            cmbIskontoOrani.DataBindings[0].FormatString = "'%'0";
            cmbIskontoOrani.DataBindings[0].DataSourceNullValue = "0";

            cmbRiskLimiti.DataBindings.Add("Text", _entity, "RiskLimiti");
            cmbRiskLimiti.DataBindings[0].FormattingEnabled = true;
            cmbRiskLimiti.DataBindings[0].FormatString = "C2";
            cmbRiskLimiti.DataBindings[0].DataSourceNullValue = "0";
        }

        private void FrmCariIslem_Load(object sender, EventArgs e)
        {
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cariDal.AddOrUpdate(context, _entity))
            {
                cariDal.Save(context);
                Close();
            }
        }
    }
}
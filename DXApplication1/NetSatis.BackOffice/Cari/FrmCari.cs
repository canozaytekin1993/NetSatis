using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;

namespace NetSatis.BackOffice.Cari
{
    public partial class FrmCari : XtraForm
    {
        private readonly CariDAL cariDal = new CariDAL();
        private readonly NetSatisContext context = new NetSatisContext();
        private string secilen;

        public FrmCari()
        {
            InitializeComponent();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreIptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void FrmCari_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            gridControl1.DataSource = cariDal.GetCariler(context);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinizden emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
                cariDal.Delete(context, c => c.CariKodu == secilen);
                cariDal.Save(context);
                GetAll();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var form = new FrmCariIslem(new Entities.Tables.Cari());
            form.ShowDialog();
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            var form = new FrmCariIslem(cariDal.GetByFilter(context, c => c.CariKodu == secilen));
            form.ShowDialog();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            var cariEntity = new Entities.Tables.Cari();
            cariEntity = cariDal.GetByFilter(context, c => c.CariKodu == secilen);
            cariEntity.Id = -1;
            cariEntity.CariKodu = null;
            var form = new FrmCariIslem(cariEntity);
            form.ShowDialog();
        }
    }
}
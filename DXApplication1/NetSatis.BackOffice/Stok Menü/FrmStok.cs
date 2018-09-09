using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Tables;

namespace NetSatis.BackOffice.Stok_Menü
{
    public partial class FrmStok : XtraForm
    {
        private readonly NetSatisContext context = new NetSatisContext();
        private readonly StokDAL stokDal = new StokDAL();
        private string secilen;

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
            gridControl1.DataSource = stokDal.GetAllJoin(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinizden emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                stokDal.Delete(context, c => c.StokKodu == secilen);
                stokDal.Save(context);
                GetAll();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var form = new FrmStokIslem(new Stok());
            form.ShowDialog();
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            var form = new FrmStokIslem(stokDal.GetByFilter(context, c => c.StokKodu == secilen));
            form.ShowDialog();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            var stokEntity = new Stok();
            stokEntity = stokDal.GetByFilter(context, c => c.StokKodu == secilen);
            stokEntity.Id = -1;
            stokEntity.StokKodu = null;
            var form = new FrmStokIslem(stokEntity);
            form.ShowDialog();
        }

        private void btnStokHareket_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            var secilenAd = gridView1.GetFocusedRowCellValue(colStokAdi).ToString();
            var form = new FrmStokHareket(secilen, secilenAd);
            form.ShowDialog();
        }
    }
}
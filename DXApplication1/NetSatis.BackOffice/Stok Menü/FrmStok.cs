using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;

namespace NetSatis.BackOffice.Stok_Menü
{
    public partial class FrmStok : XtraForm
    {
        private readonly NetSatisContext context = new NetSatisContext();
        StokDAL stokDal = new StokDAL();

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
            this.Close();
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
                string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                stokDal.Delete(context, c => c.StokKodu == secilen);
                stokDal.Save(context);
                GetAll();
            }
            
        }
    }
}
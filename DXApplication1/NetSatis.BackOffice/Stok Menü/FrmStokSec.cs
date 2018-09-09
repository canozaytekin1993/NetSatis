using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Tables;

namespace NetSatis.BackOffice.Stok_Menü
{
    public partial class FrmStokSec : XtraForm
    {
        private readonly NetSatisContext context = new NetSatisContext();
        private readonly StokDAL stokDal = new StokDAL();
        public List<Stok> _secilen = new List<Stok>();

        public FrmStokSec(bool coklusecim)
        {
            InitializeComponent();
            if (coklusecim)
            {
                lblUyari.Visible = true;
                gridStoklar.OptionsSelection.MultiSelect = true;
            }
        }

        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            gridcontStoklar.DataSource = stokDal.GetAllJoin(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            foreach (var row in gridStoklar.GetSelectedRows())
            {
                var stokKodu = gridStoklar.GetRowCellValue(row, colStokKodu).ToString();
                _secilen.Add(context.Stoklar.SingleOrDefault(c => c.StokKodu == stokKodu));
            }

            Close();
        }
    }
}
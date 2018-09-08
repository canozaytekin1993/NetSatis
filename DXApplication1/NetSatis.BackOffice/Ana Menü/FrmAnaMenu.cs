using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using NetSatis.BackOffice.Stok_Menü;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Tables;

namespace NetSatis.BackOffice
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            using (var context = new NetSatisContext())
            {
                // Veri tabanında database varsa, kurulmaz. Yoksa kurulur.
                context.Database.CreateIfNotExists();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var context = new NetSatisContext();
            var cariDal = new CariDAL();
            var entity = new Cari
            {
                CariKodu = "123456789",
                CariAdi = "Can Özaytekin",
                YetkiliKisi = "Can",
                FaturaUnvani = "Özaytekin"
            };
            cariDal.AddOrUpdate(context, entity);
            cariDal.Save(context);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FrmStok();
            form.MdiParent = this;
            form.Show();
        }
    }
}
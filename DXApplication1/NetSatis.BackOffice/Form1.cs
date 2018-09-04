using DevExpress.XtraBars.Ribbon;
using NetSatis.Entities.Context;

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
    }
}
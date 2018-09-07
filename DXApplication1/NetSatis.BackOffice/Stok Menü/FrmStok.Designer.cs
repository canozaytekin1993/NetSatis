namespace NetSatis.BackOffice.Stok_Menü
{
    partial class FrmStok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStok));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKopyala = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDüzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAltGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModeli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGarantiSuresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUreticiKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyatı1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyatı2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyatı3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyatı1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyatı2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyatı3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.Appearance.Image")));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImage = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1167, 55);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Stok Kartları";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnGüncelle);
            this.grpMenu.Controls.Add(this.btnKopyala);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnDüzenle);
            this.grpMenu.Controls.Add(this.btnEkle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 638);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1167, 82);
            this.grpMenu.TabIndex = 1;
            this.grpMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 7;
            this.btnKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnKapat.Location = new System.Drawing.Point(1069, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(86, 47);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Kapat";
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "refresh.png");
            this.imgMenu.Images.SetKeyName(1, "Stok Düzenle.png");
            this.imgMenu.Images.SetKeyName(2, "Stok Ekle.png");
            this.imgMenu.Images.SetKeyName(3, "Stok Kopyala.png");
            this.imgMenu.Images.SetKeyName(4, "Stok Sil.png");
            this.imgMenu.Images.SetKeyName(5, "view.png");
            this.imgMenu.Images.SetKeyName(6, "Stok Kopyala.png");
            this.imgMenu.Images.SetKeyName(7, "folder_out.png");
            this.imgMenu.Images.SetKeyName(8, "funnel.png");
            this.imgMenu.Images.SetKeyName(9, "funnel_delete.png");
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 5;
            this.btnAra.ImageOptions.ImageList = this.imgMenu;
            this.btnAra.Location = new System.Drawing.Point(472, 23);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(86, 47);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Ara";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageOptions.ImageIndex = 0;
            this.btnGüncelle.ImageOptions.ImageList = this.imgMenu;
            this.btnGüncelle.Location = new System.Drawing.Point(380, 23);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(86, 47);
            this.btnGüncelle.TabIndex = 6;
            this.btnGüncelle.Text = "Güncelle";
            // 
            // btnKopyala
            // 
            this.btnKopyala.ImageOptions.ImageIndex = 6;
            this.btnKopyala.ImageOptions.ImageList = this.imgMenu;
            this.btnKopyala.Location = new System.Drawing.Point(288, 23);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(86, 47);
            this.btnKopyala.TabIndex = 5;
            this.btnKopyala.Text = "Kopyala";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 4;
            this.btnSil.ImageOptions.ImageList = this.imgMenu;
            this.btnSil.Location = new System.Drawing.Point(196, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(86, 47);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.ImageOptions.ImageIndex = 1;
            this.btnDüzenle.ImageOptions.ImageList = this.imgMenu;
            this.btnDüzenle.Location = new System.Drawing.Point(104, 23);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(86, 47);
            this.btnDüzenle.TabIndex = 3;
            this.btnDüzenle.Text = "Düzenle";
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 2;
            this.btnEkle.ImageOptions.ImageList = this.imgMenu;
            this.btnEkle.Location = new System.Drawing.Point(12, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 47);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 55);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton3);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1167, 583);
            this.splitContainerControl1.SplitterPosition = 148;
            this.splitContainerControl1.TabIndex = 9;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ImageOptions.ImageIndex = 8;
            this.simpleButton3.ImageOptions.ImageList = this.imgMenu;
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton3.Location = new System.Drawing.Point(969, 91);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(58, 47);
            this.simpleButton3.TabIndex = 10;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.ImageIndex = 9;
            this.simpleButton2.ImageOptions.ImageList = this.imgMenu;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(1033, 91);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(58, 47);
            this.simpleButton2.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.ImageIndex = 7;
            this.simpleButton1.ImageOptions.ImageList = this.imgMenu;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(1097, 91);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(58, 47);
            this.simpleButton1.TabIndex = 8;
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(1167, 148);
            this.filterControl1.TabIndex = 1;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1167, 430);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDurumu,
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkodKodu,
            this.colBarkodTuru,
            this.colBirimi,
            this.colStokGrubu,
            this.colStokAltGrubu,
            this.colMarka,
            this.colModeli,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colGarantiSuresi,
            this.colUreticiKodu,
            this.colAlisKdv,
            this.colSatisKdv,
            this.colAlisFiyatı1,
            this.colAlisFiyatı2,
            this.colAlisFiyatı3,
            this.colSatisFiyatı1,
            this.colSatisFiyatı2,
            this.colSatisFiyatı3,
            this.colMinStokMiktari,
            this.colMaxStokMiktari,
            this.colAciklama,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDurumu
            // 
            this.colDurumu.Caption = "Durum";
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 0;
            this.colDurumu.Width = 50;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 1;
            this.colStokKodu.Width = 86;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 2;
            this.colStokAdi.Width = 285;
            // 
            // colBarkodKodu
            // 
            this.colBarkodKodu.Caption = "Barkod Kodu";
            this.colBarkodKodu.FieldName = "BarkodKodu";
            this.colBarkodKodu.Name = "colBarkodKodu";
            this.colBarkodKodu.OptionsColumn.AllowEdit = false;
            this.colBarkodKodu.Visible = true;
            this.colBarkodKodu.VisibleIndex = 3;
            this.colBarkodKodu.Width = 71;
            // 
            // colBarkodTuru
            // 
            this.colBarkodTuru.Caption = "Barkod Turu";
            this.colBarkodTuru.FieldName = "BarkodTuru";
            this.colBarkodTuru.Name = "colBarkodTuru";
            this.colBarkodTuru.OptionsColumn.AllowEdit = false;
            this.colBarkodTuru.Visible = true;
            this.colBarkodTuru.VisibleIndex = 4;
            this.colBarkodTuru.Width = 68;
            // 
            // colBirimi
            // 
            this.colBirimi.Caption = "Birimi";
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 5;
            this.colBirimi.Width = 55;
            // 
            // colStokGrubu
            // 
            this.colStokGrubu.Caption = "Stok Grubu";
            this.colStokGrubu.FieldName = "StokGrubu";
            this.colStokGrubu.Name = "colStokGrubu";
            this.colStokGrubu.OptionsColumn.AllowEdit = false;
            this.colStokGrubu.Visible = true;
            this.colStokGrubu.VisibleIndex = 6;
            this.colStokGrubu.Width = 79;
            // 
            // colStokAltGrubu
            // 
            this.colStokAltGrubu.Caption = "Stok Alt Grubu";
            this.colStokAltGrubu.FieldName = "StokAltGrubu";
            this.colStokAltGrubu.Name = "colStokAltGrubu";
            this.colStokAltGrubu.OptionsColumn.AllowEdit = false;
            this.colStokAltGrubu.Visible = true;
            this.colStokAltGrubu.VisibleIndex = 7;
            this.colStokAltGrubu.Width = 85;
            // 
            // colMarka
            // 
            this.colMarka.Caption = "Marka";
            this.colMarka.FieldName = "Marka";
            this.colMarka.Name = "colMarka";
            this.colMarka.OptionsColumn.AllowEdit = false;
            // 
            // colModeli
            // 
            this.colModeli.Caption = "Model";
            this.colModeli.FieldName = "Modeli";
            this.colModeli.Name = "colModeli";
            this.colModeli.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.Caption = "Özel Kod 1";
            this.colOzelKod1.FieldName = "OzelKod1";
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.Caption = "Özel Kod 2";
            this.colOzelKod2.FieldName = "OzelKod2";
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod3
            // 
            this.colOzelKod3.Caption = "Özel Kod 3";
            this.colOzelKod3.FieldName = "OzelKod3";
            this.colOzelKod3.Name = "colOzelKod3";
            this.colOzelKod3.OptionsColumn.AllowEdit = false;
            // 
            // colOzelKod4
            // 
            this.colOzelKod4.Caption = "Özel Kod 4";
            this.colOzelKod4.FieldName = "OzelKod4";
            this.colOzelKod4.Name = "colOzelKod4";
            this.colOzelKod4.OptionsColumn.AllowEdit = false;
            // 
            // colGarantiSuresi
            // 
            this.colGarantiSuresi.Caption = "Garanti Süresi";
            this.colGarantiSuresi.FieldName = "GarantiSuresi";
            this.colGarantiSuresi.Name = "colGarantiSuresi";
            this.colGarantiSuresi.OptionsColumn.AllowEdit = false;
            // 
            // colUreticiKodu
            // 
            this.colUreticiKodu.Caption = "Üretici Kodu";
            this.colUreticiKodu.FieldName = "UreticiKodu";
            this.colUreticiKodu.Name = "colUreticiKodu";
            this.colUreticiKodu.OptionsColumn.AllowEdit = false;
            // 
            // colAlisKdv
            // 
            this.colAlisKdv.Caption = "Alış Kdv";
            this.colAlisKdv.FieldName = "AlisKdv";
            this.colAlisKdv.Name = "colAlisKdv";
            this.colAlisKdv.OptionsColumn.AllowEdit = false;
            // 
            // colSatisKdv
            // 
            this.colSatisKdv.Caption = "Stok Kdv";
            this.colSatisKdv.FieldName = "SatisKdv";
            this.colSatisKdv.Name = "colSatisKdv";
            this.colSatisKdv.OptionsColumn.AllowEdit = false;
            // 
            // colAlisFiyatı1
            // 
            this.colAlisFiyatı1.Caption = "Alış Fiyatı 1";
            this.colAlisFiyatı1.FieldName = "AlisFiyatı1";
            this.colAlisFiyatı1.Name = "colAlisFiyatı1";
            this.colAlisFiyatı1.OptionsColumn.AllowEdit = false;
            // 
            // colAlisFiyatı2
            // 
            this.colAlisFiyatı2.Caption = "Alıi Fiyatı 2";
            this.colAlisFiyatı2.FieldName = "AlisFiyatı2";
            this.colAlisFiyatı2.Name = "colAlisFiyatı2";
            this.colAlisFiyatı2.OptionsColumn.AllowEdit = false;
            // 
            // colAlisFiyatı3
            // 
            this.colAlisFiyatı3.Caption = "Alıs Fiyatı 3";
            this.colAlisFiyatı3.FieldName = "AlisFiyatı3";
            this.colAlisFiyatı3.Name = "colAlisFiyatı3";
            this.colAlisFiyatı3.OptionsColumn.AllowEdit = false;
            // 
            // colSatisFiyatı1
            // 
            this.colSatisFiyatı1.Caption = "Satış Fiyatı 1";
            this.colSatisFiyatı1.FieldName = "SatisFiyatı1";
            this.colSatisFiyatı1.Name = "colSatisFiyatı1";
            this.colSatisFiyatı1.OptionsColumn.AllowEdit = false;
            // 
            // colSatisFiyatı2
            // 
            this.colSatisFiyatı2.Caption = "Satış Fiyatı 2";
            this.colSatisFiyatı2.FieldName = "SatisFiyatı2";
            this.colSatisFiyatı2.Name = "colSatisFiyatı2";
            this.colSatisFiyatı2.OptionsColumn.AllowEdit = false;
            // 
            // colSatisFiyatı3
            // 
            this.colSatisFiyatı3.Caption = "Satış Fiyatı 3";
            this.colSatisFiyatı3.FieldName = "SatisFiyatı3";
            this.colSatisFiyatı3.Name = "colSatisFiyatı3";
            this.colSatisFiyatı3.OptionsColumn.AllowEdit = false;
            // 
            // colMinStokMiktari
            // 
            this.colMinStokMiktari.Caption = "Min Stok Miktarı";
            this.colMinStokMiktari.FieldName = "MinStokMiktari";
            this.colMinStokMiktari.Name = "colMinStokMiktari";
            this.colMinStokMiktari.OptionsColumn.AllowEdit = false;
            this.colMinStokMiktari.Visible = true;
            this.colMinStokMiktari.VisibleIndex = 8;
            this.colMinStokMiktari.Width = 84;
            // 
            // colMaxStokMiktari
            // 
            this.colMaxStokMiktari.Caption = "Max Stok Miktarı";
            this.colMaxStokMiktari.FieldName = "MaxStokMiktari";
            this.colMaxStokMiktari.Name = "colMaxStokMiktari";
            this.colMaxStokMiktari.OptionsColumn.AllowEdit = false;
            this.colMaxStokMiktari.Visible = true;
            this.colMaxStokMiktari.VisibleIndex = 9;
            this.colMaxStokMiktari.Width = 93;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 10;
            this.colAciklama.Width = 193;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Stok Giriş";
            this.gridColumn1.FieldName = "StokGiris";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Stok Çıkış";
            this.gridColumn2.FieldName = "Stok Çıkış";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 12;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mevcut Stok";
            this.gridColumn3.FieldName = "Mevcut Stok";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 13;
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 720);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmStok";
            this.Text = "Stok Kartları";
            this.Load += new System.EventHandler(this.FrmStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnDüzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnKopyala;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAltGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private DevExpress.XtraGrid.Columns.GridColumn colModeli;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod1;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod2;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod3;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod4;
        private DevExpress.XtraGrid.Columns.GridColumn colGarantiSuresi;
        private DevExpress.XtraGrid.Columns.GridColumn colUreticiKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyatı1;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyatı2;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyatı3;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyatı1;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyatı2;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyatı3;
        private DevExpress.XtraGrid.Columns.GridColumn colMinStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
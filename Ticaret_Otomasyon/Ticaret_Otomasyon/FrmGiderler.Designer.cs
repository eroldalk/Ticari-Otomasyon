namespace Ticaret_Otomasyon
{
    partial class FrmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.Btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbyil = new System.Windows.Forms.ComboBox();
            this.cmbay = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtekstra = new DevExpress.XtraEditors.TextEdit();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.Btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rchnot = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtelektrik = new DevExpress.XtraEditors.TextEdit();
            this.txtsu = new DevExpress.XtraEditors.TextEdit();
            this.txtgaz = new DevExpress.XtraEditors.TextEdit();
            this.txtnet = new DevExpress.XtraEditors.TextEdit();
            this.txtmaas = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtekstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtelektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Btntemizle
            // 
            this.Btntemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btntemizle.Appearance.Options.UseFont = true;
            this.Btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btntemizle.ImageOptions.Image")));
            this.Btntemizle.Location = new System.Drawing.Point(117, 523);
            this.Btntemizle.Name = "Btntemizle";
            this.Btntemizle.Size = new System.Drawing.Size(172, 33);
            this.Btntemizle.TabIndex = 32;
            this.Btntemizle.Text = "Temizle";
            this.Btntemizle.Click += new System.EventHandler(this.Btntemizle_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.txtmaas);
            this.groupControl1.Controls.Add(this.txtnet);
            this.groupControl1.Controls.Add(this.txtgaz);
            this.groupControl1.Controls.Add(this.txtsu);
            this.groupControl1.Controls.Add(this.txtelektrik);
            this.groupControl1.Controls.Add(this.Btntemizle);
            this.groupControl1.Controls.Add(this.cmbyil);
            this.groupControl1.Controls.Add(this.cmbay);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txtekstra);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.Btnsil);
            this.groupControl1.Controls.Add(this.Btnkaydet);
            this.groupControl1.Controls.Add(this.rchnot);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(1586, -5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(337, 1070);
            this.groupControl1.TabIndex = 7;
            // 
            // cmbyil
            // 
            this.cmbyil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbyil.FormattingEnabled = true;
            this.cmbyil.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbyil.Location = new System.Drawing.Point(118, 98);
            this.cmbyil.Name = "cmbyil";
            this.cmbyil.Size = new System.Drawing.Size(165, 26);
            this.cmbyil.TabIndex = 31;
            // 
            // cmbay
            // 
            this.cmbay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbay.FormattingEnabled = true;
            this.cmbay.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbay.Location = new System.Drawing.Point(117, 66);
            this.cmbay.Name = "cmbay";
            this.cmbay.Size = new System.Drawing.Size(167, 26);
            this.cmbay.TabIndex = 30;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(59, 289);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 18);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Ekstra :";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(61, 322);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(48, 18);
            this.labelControl11.TabIndex = 26;
            this.labelControl11.Text = "Notlar :";
            // 
            // txtekstra
            // 
            this.txtekstra.Location = new System.Drawing.Point(117, 286);
            this.txtekstra.Name = "txtekstra";
            this.txtekstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtekstra.Properties.Appearance.Options.UseFont = true;
            this.txtekstra.Size = new System.Drawing.Size(167, 24);
            this.txtekstra.TabIndex = 25;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(116, 484);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(172, 33);
            this.BtnGuncelle.TabIndex = 23;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // Btnsil
            // 
            this.Btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnsil.Appearance.Options.UseFont = true;
            this.Btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnsil.ImageOptions.Image")));
            this.Btnsil.Location = new System.Drawing.Point(116, 445);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(172, 33);
            this.Btnsil.TabIndex = 22;
            this.Btnsil.Text = "SİL";
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnkaydet.Appearance.Options.UseFont = true;
            this.Btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnkaydet.ImageOptions.Image")));
            this.Btnkaydet.Location = new System.Drawing.Point(116, 406);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(172, 33);
            this.Btnkaydet.TabIndex = 21;
            this.Btnkaydet.Text = "Kaydet";
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // rchnot
            // 
            this.rchnot.Location = new System.Drawing.Point(116, 322);
            this.rchnot.Name = "rchnot";
            this.rchnot.Size = new System.Drawing.Size(169, 77);
            this.rchnot.TabIndex = 20;
            this.rchnot.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(83, 161);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(26, 18);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Su :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(52, 254);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 18);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Maaşlar :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(48, 222);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "İnternet :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(40, 194);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(69, 18);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Doğalgaz :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(55, 133);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Elektrik :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(85, 101);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Yıl :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(84, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ay :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(117, 38);
            this.txtid.Name = "txtid";
            this.txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Properties.Appearance.Options.UseFont = true;
            this.txtid.Size = new System.Drawing.Size(167, 24);
            this.txtid.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(85, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1579, 1061);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // txtelektrik
            // 
            this.txtelektrik.Location = new System.Drawing.Point(118, 130);
            this.txtelektrik.Name = "txtelektrik";
            this.txtelektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtelektrik.Properties.Appearance.Options.UseFont = true;
            this.txtelektrik.Size = new System.Drawing.Size(167, 24);
            this.txtelektrik.TabIndex = 33;
            // 
            // txtsu
            // 
            this.txtsu.Location = new System.Drawing.Point(117, 160);
            this.txtsu.Name = "txtsu";
            this.txtsu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsu.Properties.Appearance.Options.UseFont = true;
            this.txtsu.Size = new System.Drawing.Size(167, 24);
            this.txtsu.TabIndex = 34;
            // 
            // txtgaz
            // 
            this.txtgaz.Location = new System.Drawing.Point(117, 191);
            this.txtgaz.Name = "txtgaz";
            this.txtgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgaz.Properties.Appearance.Options.UseFont = true;
            this.txtgaz.Size = new System.Drawing.Size(167, 24);
            this.txtgaz.TabIndex = 35;
            // 
            // txtnet
            // 
            this.txtnet.Location = new System.Drawing.Point(116, 219);
            this.txtnet.Name = "txtnet";
            this.txtnet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtnet.Properties.Appearance.Options.UseFont = true;
            this.txtnet.Size = new System.Drawing.Size(167, 24);
            this.txtnet.TabIndex = 36;
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(116, 251);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmaas.Properties.Appearance.Options.UseFont = true;
            this.txtmaas.Size = new System.Drawing.Size(167, 24);
            this.txtmaas.TabIndex = 37;
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmGiderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtekstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtelektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaas.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btntemizle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmbyil;
        private System.Windows.Forms.ComboBox cmbay;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtekstra;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton Btnsil;
        private DevExpress.XtraEditors.SimpleButton Btnkaydet;
        private System.Windows.Forms.RichTextBox rchnot;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtmaas;
        private DevExpress.XtraEditors.TextEdit txtnet;
        private DevExpress.XtraEditors.TextEdit txtgaz;
        private DevExpress.XtraEditors.TextEdit txtsu;
        private DevExpress.XtraEditors.TextEdit txtelektrik;
    }
}
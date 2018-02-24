namespace MarketOtomasyonu.Forms
{
    partial class FormSiparisVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiparisVer));
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.pbBarkod = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.cmsSepetMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adediArttırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adediAzaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepettenÇıkartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbKategoriGetir = new System.Windows.Forms.ComboBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.imgSepeteEkle = new System.Windows.Forms.ImageList(this.components);
            this.btnSiparisOlustur = new System.Windows.Forms.Button();
            this.nKdv = new System.Windows.Forms.NumericUpDown();
            this.nToplam = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).BeginInit();
            this.cmsSepetMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(239, 39);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(158, 20);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // pbBarkod
            // 
            this.pbBarkod.Location = new System.Drawing.Point(239, 65);
            this.pbBarkod.Name = "pbBarkod";
            this.pbBarkod.Size = new System.Drawing.Size(158, 63);
            this.pbBarkod.TabIndex = 1;
            this.pbBarkod.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barkod İşlemleri";
            // 
            // lstSepet
            // 
            this.lstSepet.ContextMenuStrip = this.cmsSepetMenu;
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(418, 65);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(208, 225);
            this.lstSepet.TabIndex = 3;
            // 
            // cmsSepetMenu
            // 
            this.cmsSepetMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adediArttırToolStripMenuItem,
            this.adediAzaltToolStripMenuItem,
            this.sepettenÇıkartToolStripMenuItem});
            this.cmsSepetMenu.Name = "cmsSepetMenu";
            this.cmsSepetMenu.Size = new System.Drawing.Size(155, 70);
            // 
            // adediArttırToolStripMenuItem
            // 
            this.adediArttırToolStripMenuItem.Name = "adediArttırToolStripMenuItem";
            this.adediArttırToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.adediArttırToolStripMenuItem.Text = "Adedi Arttır";
            // 
            // adediAzaltToolStripMenuItem
            // 
            this.adediAzaltToolStripMenuItem.Name = "adediAzaltToolStripMenuItem";
            this.adediAzaltToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.adediAzaltToolStripMenuItem.Text = "Adedi Azalt";
            // 
            // sepettenÇıkartToolStripMenuItem
            // 
            this.sepettenÇıkartToolStripMenuItem.Name = "sepettenÇıkartToolStripMenuItem";
            this.sepettenÇıkartToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sepettenÇıkartToolStripMenuItem.Text = "Sepetten Çıkart";
            // 
            // cmbKategoriGetir
            // 
            this.cmbKategoriGetir.FormattingEnabled = true;
            this.cmbKategoriGetir.Location = new System.Drawing.Point(13, 38);
            this.cmbKategoriGetir.Name = "cmbKategoriGetir";
            this.cmbKategoriGetir.Size = new System.Drawing.Size(195, 21);
            this.cmbKategoriGetir.TabIndex = 5;
            this.cmbKategoriGetir.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriGetir_SelectedIndexChanged);
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(12, 309);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(195, 98);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 7;
            this.pbResim.TabStop = false;
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(12, 65);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(196, 238);
            this.lstUrunler.TabIndex = 8;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.White;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.ForeColor = System.Drawing.Color.Black;
            this.btnSepeteEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSepeteEkle.ImageIndex = 0;
            this.btnSepeteEkle.ImageList = this.imgSepeteEkle;
            this.btnSepeteEkle.Location = new System.Drawing.Point(261, 134);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(120, 82);
            this.btnSepeteEkle.TabIndex = 25;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // imgSepeteEkle
            // 
            this.imgSepeteEkle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSepeteEkle.ImageStream")));
            this.imgSepeteEkle.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSepeteEkle.Images.SetKeyName(0, "sepeteekle.png");
            // 
            // btnSiparisOlustur
            // 
            this.btnSiparisOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparisOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisOlustur.ForeColor = System.Drawing.Color.Crimson;
            this.btnSiparisOlustur.Location = new System.Drawing.Point(468, 393);
            this.btnSiparisOlustur.Name = "btnSiparisOlustur";
            this.btnSiparisOlustur.Size = new System.Drawing.Size(158, 34);
            this.btnSiparisOlustur.TabIndex = 42;
            this.btnSiparisOlustur.Text = "Sipariş Oluştur";
            this.btnSiparisOlustur.UseVisualStyleBackColor = true;
            this.btnSiparisOlustur.Click += new System.EventHandler(this.btnSiparisOlustur_Click);
            // 
            // nKdv
            // 
            this.nKdv.DecimalPlaces = 2;
            this.nKdv.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nKdv.Location = new System.Drawing.Point(496, 339);
            this.nKdv.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nKdv.Name = "nKdv";
            this.nKdv.ReadOnly = true;
            this.nKdv.Size = new System.Drawing.Size(130, 37);
            this.nKdv.TabIndex = 41;
            this.nKdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nToplam
            // 
            this.nToplam.DecimalPlaces = 2;
            this.nToplam.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nToplam.Location = new System.Drawing.Point(496, 296);
            this.nToplam.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nToplam.Name = "nToplam";
            this.nToplam.ReadOnly = true;
            this.nToplam.Size = new System.Drawing.Size(130, 37);
            this.nToplam.TabIndex = 40;
            this.nToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(434, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "KDV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(401, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Toplam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Kategori İşlemleri";
            // 
            // FormSiparisVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSiparisOlustur);
            this.Controls.Add(this.nKdv);
            this.Controls.Add(this.nToplam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.cmbKategoriGetir);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBarkod);
            this.Controls.Add(this.txtBarkod);
            this.Name = "FormSiparisVer";
            this.Text = "FormSiparisVer";
            this.Load += new System.EventHandler(this.FormSiparisVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).EndInit();
            this.cmsSepetMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.PictureBox pbBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategoriGetir;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Button btnSiparisOlustur;
        private System.Windows.Forms.NumericUpDown nKdv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip cmsSepetMenu;
        private System.Windows.Forms.ToolStripMenuItem adediArttırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adediAzaltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepettenÇıkartToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown nToplam;
        public System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.ImageList imgSepeteEkle;
    }
}
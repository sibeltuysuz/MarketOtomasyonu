namespace MarketOtomasyonu.Forms
{
    partial class FormUrunler
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
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.lstUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpUrunler = new System.Windows.Forms.GroupBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pbUrunResim = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.nSatisFiyatı = new System.Windows.Forms.NumericUpDown();
            this.nAlisFiyatı = new System.Windows.Forms.NumericUpDown();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSatisFiyatı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlisFiyatı)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(664, 358);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(745, 358);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(75, 23);
            this.btnUrunSil.TabIndex = 1;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(826, 358);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunGuncelle.TabIndex = 2;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // lstUrunler
            // 
            this.lstUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstUrunler.FullRowSelect = true;
            this.lstUrunler.GridLines = true;
            this.lstUrunler.Location = new System.Drawing.Point(12, 34);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(592, 318);
            this.lstUrunler.TabIndex = 5;
            this.lstUrunler.UseCompatibleStateImageBehavior = false;
            this.lstUrunler.View = System.Windows.Forms.View.Details;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Id";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Kodu";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Alış Fiyatı";
            this.columnHeader5.Width = 96;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Satış Fiyatı";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kategori";
            this.columnHeader7.Width = 91;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Stok";
            // 
            // grpUrunler
            // 
            this.grpUrunler.Controls.Add(this.txtStok);
            this.grpUrunler.Controls.Add(this.label10);
            this.grpUrunler.Controls.Add(this.pbUrunResim);
            this.grpUrunler.Controls.Add(this.label7);
            this.grpUrunler.Controls.Add(this.cmbKategori);
            this.grpUrunler.Controls.Add(this.nSatisFiyatı);
            this.grpUrunler.Controls.Add(this.nAlisFiyatı);
            this.grpUrunler.Controls.Add(this.txtUrunKodu);
            this.grpUrunler.Controls.Add(this.txtUrunAdi);
            this.grpUrunler.Controls.Add(this.label6);
            this.grpUrunler.Controls.Add(this.label5);
            this.grpUrunler.Controls.Add(this.label4);
            this.grpUrunler.Controls.Add(this.label2);
            this.grpUrunler.Controls.Add(this.label9);
            this.grpUrunler.Controls.Add(this.label8);
            this.grpUrunler.Location = new System.Drawing.Point(640, 34);
            this.grpUrunler.Name = "grpUrunler";
            this.grpUrunler.Size = new System.Drawing.Size(275, 318);
            this.grpUrunler.TabIndex = 8;
            this.grpUrunler.TabStop = false;
            this.grpUrunler.Text = "Ürünler";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(93, 180);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(152, 20);
            this.txtStok.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Stok";
            // 
            // pbUrunResim
            // 
            this.pbUrunResim.Location = new System.Drawing.Point(93, 215);
            this.pbUrunResim.Name = "pbUrunResim";
            this.pbUrunResim.Size = new System.Drawing.Size(152, 82);
            this.pbUrunResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUrunResim.TabIndex = 33;
            this.pbUrunResim.TabStop = false;
            this.pbUrunResim.Click += new System.EventHandler(this.pbUrunResim_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Resim";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(93, 147);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(152, 21);
            this.cmbKategori.TabIndex = 29;
            // 
            // nSatisFiyatı
            // 
            this.nSatisFiyatı.DecimalPlaces = 3;
            this.nSatisFiyatı.Location = new System.Drawing.Point(93, 115);
            this.nSatisFiyatı.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nSatisFiyatı.Name = "nSatisFiyatı";
            this.nSatisFiyatı.Size = new System.Drawing.Size(152, 20);
            this.nSatisFiyatı.TabIndex = 28;
            this.nSatisFiyatı.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nAlisFiyatı
            // 
            this.nAlisFiyatı.DecimalPlaces = 3;
            this.nAlisFiyatı.Location = new System.Drawing.Point(93, 83);
            this.nAlisFiyatı.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nAlisFiyatı.Name = "nAlisFiyatı";
            this.nAlisFiyatı.Size = new System.Drawing.Size(152, 20);
            this.nAlisFiyatı.TabIndex = 27;
            this.nAlisFiyatı.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(93, 51);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(152, 20);
            this.txtUrunKodu.TabIndex = 25;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(93, 19);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(152, 20);
            this.txtUrunAdi.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Satış Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Alış Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ürün Kodu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ürün Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, -19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ürün Adı";
            // 
            // FormUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 400);
            this.Controls.Add(this.grpUrunler);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunEkle);
            this.Name = "FormUrunler";
            this.Text = "FormUrunler";
            this.Load += new System.EventHandler(this.FormUrunler_Load);
            this.grpUrunler.ResumeLayout(false);
            this.grpUrunler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSatisFiyatı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlisFiyatı)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunGuncelle;
        public System.Windows.Forms.ListView lstUrunler;
        private System.Windows.Forms.GroupBox grpUrunler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.NumericUpDown nSatisFiyatı;
        private System.Windows.Forms.NumericUpDown nAlisFiyatı;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbUrunResim;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}
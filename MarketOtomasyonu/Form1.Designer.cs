namespace MarketOtomasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.imgForm1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSiparisIslemleri = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnSiparisDetayları = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 4;
            this.button1.ImageList = this.imgForm1;
            this.button1.Location = new System.Drawing.Point(66, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ürün İşlemleri";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgForm1
            // 
            this.imgForm1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgForm1.ImageStream")));
            this.imgForm1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgForm1.Images.SetKeyName(0, "stok.jfif");
            this.imgForm1.Images.SetKeyName(1, "cikis.png");
            this.imgForm1.Images.SetKeyName(2, "siparis.jpg");
            this.imgForm1.Images.SetKeyName(3, "siparisdetay.png");
            this.imgForm1.Images.SetKeyName(4, "ürün.png");
            this.imgForm1.Images.SetKeyName(5, "siparis-icon.png");
            this.imgForm1.Images.SetKeyName(6, "stok.png");
            this.imgForm1.Images.SetKeyName(7, "category.png");
            // 
            // btnSiparisIslemleri
            // 
            this.btnSiparisIslemleri.BackColor = System.Drawing.Color.White;
            this.btnSiparisIslemleri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSiparisIslemleri.ImageIndex = 3;
            this.btnSiparisIslemleri.ImageList = this.imgForm1;
            this.btnSiparisIslemleri.Location = new System.Drawing.Point(393, 72);
            this.btnSiparisIslemleri.Name = "btnSiparisIslemleri";
            this.btnSiparisIslemleri.Size = new System.Drawing.Size(123, 85);
            this.btnSiparisIslemleri.TabIndex = 1;
            this.btnSiparisIslemleri.Text = "Sipariş İşlemleri";
            this.btnSiparisIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiparisIslemleri.UseVisualStyleBackColor = false;
            this.btnSiparisIslemleri.Click += new System.EventHandler(this.btnSiparisIslemleri_Click);
            // 
            // btnStok
            // 
            this.btnStok.BackColor = System.Drawing.Color.White;
            this.btnStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStok.ImageIndex = 6;
            this.btnStok.ImageList = this.imgForm1;
            this.btnStok.Location = new System.Drawing.Point(66, 188);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(121, 84);
            this.btnStok.TabIndex = 2;
            this.btnStok.Text = "Stok İşlemleri";
            this.btnStok.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStok.UseVisualStyleBackColor = false;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.White;
            this.btnKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategori.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKategori.ImageIndex = 7;
            this.btnKategori.ImageList = this.imgForm1;
            this.btnKategori.Location = new System.Drawing.Point(231, 72);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(121, 85);
            this.btnKategori.TabIndex = 3;
            this.btnKategori.Text = "Kategori İşlemleri";
            this.btnKategori.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnSiparisDetayları
            // 
            this.btnSiparisDetayları.BackColor = System.Drawing.Color.White;
            this.btnSiparisDetayları.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSiparisDetayları.ImageIndex = 5;
            this.btnSiparisDetayları.ImageList = this.imgForm1;
            this.btnSiparisDetayları.Location = new System.Drawing.Point(231, 188);
            this.btnSiparisDetayları.Name = "btnSiparisDetayları";
            this.btnSiparisDetayları.Size = new System.Drawing.Size(121, 84);
            this.btnSiparisDetayları.TabIndex = 4;
            this.btnSiparisDetayları.Text = "Sipariş Detayları";
            this.btnSiparisDetayları.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiparisDetayları.UseVisualStyleBackColor = false;
            this.btnSiparisDetayları.Click += new System.EventHandler(this.btnSiparisDetayları_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.White;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageIndex = 1;
            this.btnCikis.ImageList = this.imgForm1;
            this.btnCikis.Location = new System.Drawing.Point(393, 186);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(123, 86);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 408);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSiparisDetayları);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnSiparisIslemleri);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Tag = "ı";
            this.Text = "MARKET OTOMASYONU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSiparisIslemleri;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnSiparisDetayları;
        private System.Windows.Forms.ImageList imgForm1;
        private System.Windows.Forms.Button btnCikis;
    }
}


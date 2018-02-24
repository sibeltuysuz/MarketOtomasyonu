namespace MarketOtomasyonu.Forms
{
    partial class FormSiparisOnay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richtxtAdres = new System.Windows.Forms.RichTextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstUrunSiparisOnay = new System.Windows.Forms.ListBox();
            this.btnSiparisOnay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbodemeTuru = new System.Windows.Forms.ComboBox();
            this.grpMusteriSiparisIslemleri = new System.Windows.Forms.GroupBox();
            this.cmbKart = new System.Windows.Forms.ComboBox();
            this.lblKartSecenekleri = new System.Windows.Forms.Label();
            this.txtNakit = new System.Windows.Forms.TextBox();
            this.lblNakit = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.grpMusteriSiparisIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(100, 19);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(165, 20);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(100, 45);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(165, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(100, 71);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(165, 20);
            this.mskTelefon.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adres";
            // 
            // richtxtAdres
            // 
            this.richtxtAdres.Location = new System.Drawing.Point(100, 97);
            this.richtxtAdres.Name = "richtxtAdres";
            this.richtxtAdres.Size = new System.Drawing.Size(165, 84);
            this.richtxtAdres.TabIndex = 8;
            this.richtxtAdres.Text = "";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(80, 265);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(96, 20);
            this.txtToplamTutar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Toplam Tutar";
            // 
            // lstUrunSiparisOnay
            // 
            this.lstUrunSiparisOnay.FormattingEnabled = true;
            this.lstUrunSiparisOnay.Location = new System.Drawing.Point(12, 12);
            this.lstUrunSiparisOnay.Name = "lstUrunSiparisOnay";
            this.lstUrunSiparisOnay.Size = new System.Drawing.Size(164, 238);
            this.lstUrunSiparisOnay.TabIndex = 11;
            // 
            // btnSiparisOnay
            // 
            this.btnSiparisOnay.Location = new System.Drawing.Point(233, 307);
            this.btnSiparisOnay.Name = "btnSiparisOnay";
            this.btnSiparisOnay.Size = new System.Drawing.Size(91, 33);
            this.btnSiparisOnay.TabIndex = 12;
            this.btnSiparisOnay.Text = "Siparişi Onayla";
            this.btnSiparisOnay.UseVisualStyleBackColor = true;
            this.btnSiparisOnay.Click += new System.EventHandler(this.btnSiparisOnay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ödeme Türü";
            // 
            // cmbodemeTuru
            // 
            this.cmbodemeTuru.FormattingEnabled = true;
            this.cmbodemeTuru.Location = new System.Drawing.Point(100, 187);
            this.cmbodemeTuru.Name = "cmbodemeTuru";
            this.cmbodemeTuru.Size = new System.Drawing.Size(165, 21);
            this.cmbodemeTuru.TabIndex = 14;
            this.cmbodemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmbodemeTuru_SelectedIndexChanged);
            // 
            // grpMusteriSiparisIslemleri
            // 
            this.grpMusteriSiparisIslemleri.Controls.Add(this.cmbKart);
            this.grpMusteriSiparisIslemleri.Controls.Add(this.lblKartSecenekleri);
            this.grpMusteriSiparisIslemleri.Controls.Add(this.txtNakit);
            this.grpMusteriSiparisIslemleri.Controls.Add(this.lblNakit);
            this.grpMusteriSiparisIslemleri.Controls.Add(this.txtAd);
            this.grpMusteriSiparisIslemleri.Controls.Add(this.cmbodemeTuru);
            this.grpMusteriSiparisIslemleri.Controls.Add(this.label1);
            this.grpMusteriSiparisIslemleri.Controls.Add(this.label6);
            this.grpMusteriSiparisIslemleri.Controls.Add(this.label2);
            this.grpMusteriSiparisIslemleri.Controls.Add(this.txtSoyad);
            this.grpMusteriSiparisIslemleri.Controls.Add(this.label3);
            this.grpMusteriSiparisIslemleri.Controls.Add(this.mskTelefon);
            this.grpMusteriSiparisIslemleri.Controls.Add(this.label4);
            this.grpMusteriSiparisIslemleri.Controls.Add(this.richtxtAdres);
            this.grpMusteriSiparisIslemleri.Location = new System.Drawing.Point(192, 13);
            this.grpMusteriSiparisIslemleri.Name = "grpMusteriSiparisIslemleri";
            this.grpMusteriSiparisIslemleri.Size = new System.Drawing.Size(289, 288);
            this.grpMusteriSiparisIslemleri.TabIndex = 15;
            this.grpMusteriSiparisIslemleri.TabStop = false;
            this.grpMusteriSiparisIslemleri.Text = "                                       ";
            // 
            // cmbKart
            // 
            this.cmbKart.FormattingEnabled = true;
            this.cmbKart.Location = new System.Drawing.Point(100, 247);
            this.cmbKart.Name = "cmbKart";
            this.cmbKart.Size = new System.Drawing.Size(165, 21);
            this.cmbKart.TabIndex = 18;
            this.cmbKart.Visible = false;
            // 
            // lblKartSecenekleri
            // 
            this.lblKartSecenekleri.AutoSize = true;
            this.lblKartSecenekleri.Location = new System.Drawing.Point(15, 250);
            this.lblKartSecenekleri.Name = "lblKartSecenekleri";
            this.lblKartSecenekleri.Size = new System.Drawing.Size(85, 13);
            this.lblKartSecenekleri.TabIndex = 17;
            this.lblKartSecenekleri.Text = "Kart Seçenekleri";
            this.lblKartSecenekleri.Visible = false;
            // 
            // txtNakit
            // 
            this.txtNakit.Location = new System.Drawing.Point(100, 217);
            this.txtNakit.Name = "txtNakit";
            this.txtNakit.Size = new System.Drawing.Size(165, 20);
            this.txtNakit.TabIndex = 16;
            this.txtNakit.Visible = false;
            // 
            // lblNakit
            // 
            this.lblNakit.AutoSize = true;
            this.lblNakit.Location = new System.Drawing.Point(61, 220);
            this.lblNakit.Name = "lblNakit";
            this.lblNakit.Size = new System.Drawing.Size(32, 13);
            this.lblNakit.TabIndex = 15;
            this.lblNakit.Text = "Nakit";
            this.lblNakit.Visible = false;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(330, 307);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(91, 33);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FormSiparisOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 356);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.grpMusteriSiparisIslemleri);
            this.Controls.Add(this.lstUrunSiparisOnay);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSiparisOnay);
            this.Name = "FormSiparisOnay";
            this.Text = "FormSiparisOnay";
            this.Load += new System.EventHandler(this.FormSiparisOnay_Load);
            this.grpMusteriSiparisIslemleri.ResumeLayout(false);
            this.grpMusteriSiparisIslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richtxtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSiparisOnay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbodemeTuru;
        private System.Windows.Forms.GroupBox grpMusteriSiparisIslemleri;
        private System.Windows.Forms.ComboBox cmbKart;
        private System.Windows.Forms.Label lblKartSecenekleri;
        private System.Windows.Forms.TextBox txtNakit;
        private System.Windows.Forms.Label lblNakit;
        public System.Windows.Forms.ListBox lstUrunSiparisOnay;
        public System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Button btnCikis;
    }
}
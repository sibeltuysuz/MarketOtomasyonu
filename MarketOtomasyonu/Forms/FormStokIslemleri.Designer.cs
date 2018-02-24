namespace MarketOtomasyonu.Forms
{
    partial class FormStokIslemleri
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
            this.lstUrunStok = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpStokEkle = new System.Windows.Forms.GroupBox();
            this.txtStokAdet = new System.Windows.Forms.TextBox();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpStokEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUrunStok
            // 
            this.lstUrunStok.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstUrunStok.FullRowSelect = true;
            this.lstUrunStok.GridLines = true;
            this.lstUrunStok.Location = new System.Drawing.Point(35, 32);
            this.lstUrunStok.Name = "lstUrunStok";
            this.lstUrunStok.Size = new System.Drawing.Size(376, 230);
            this.lstUrunStok.TabIndex = 0;
            this.lstUrunStok.UseCompatibleStateImageBehavior = false;
            this.lstUrunStok.View = System.Windows.Forms.View.Details;
            this.lstUrunStok.SelectedIndexChanged += new System.EventHandler(this.lstUrunStok_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Id";
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Alış Fiyatı";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Satış Fiyatı";
            this.columnHeader5.Width = 64;
            // 
            // grpStokEkle
            // 
            this.grpStokEkle.Controls.Add(this.txtStokAdet);
            this.grpStokEkle.Controls.Add(this.txtUrun);
            this.grpStokEkle.Controls.Add(this.btnEkle);
            this.grpStokEkle.Controls.Add(this.label2);
            this.grpStokEkle.Controls.Add(this.label1);
            this.grpStokEkle.Location = new System.Drawing.Point(440, 74);
            this.grpStokEkle.Name = "grpStokEkle";
            this.grpStokEkle.Size = new System.Drawing.Size(242, 144);
            this.grpStokEkle.TabIndex = 1;
            this.grpStokEkle.TabStop = false;
            this.grpStokEkle.Text = "Stok Ekle";
            // 
            // txtStokAdet
            // 
            this.txtStokAdet.Location = new System.Drawing.Point(64, 54);
            this.txtStokAdet.Name = "txtStokAdet";
            this.txtStokAdet.Size = new System.Drawing.Size(152, 20);
            this.txtStokAdet.TabIndex = 6;
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(64, 20);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(152, 20);
            this.txtUrun.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(107, 88);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürünler";
            // 
            // FormStokIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 340);
            this.Controls.Add(this.grpStokEkle);
            this.Controls.Add(this.lstUrunStok);
            this.Name = "FormStokIslemleri";
            this.Text = "FormStokIslemleri";
            this.Load += new System.EventHandler(this.FormStokIslemleri_Load);
            this.grpStokEkle.ResumeLayout(false);
            this.grpStokEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstUrunStok;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox grpStokEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStokAdet;
        private System.Windows.Forms.TextBox txtUrun;
    }
}
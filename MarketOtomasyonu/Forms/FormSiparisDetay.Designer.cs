namespace MarketOtomasyonu.Forms
{
    partial class FormSiparisDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiparisDetay));
            this.dtptarih1 = new System.Windows.Forms.DateTimePicker();
            this.dtptarih2 = new System.Windows.Forms.DateTimePicker();
            this.btnSiparisYukle = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.lstSiparisDetay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // dtptarih1
            // 
            this.dtptarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptarih1.Location = new System.Drawing.Point(23, 16);
            this.dtptarih1.Name = "dtptarih1";
            this.dtptarih1.Size = new System.Drawing.Size(109, 20);
            this.dtptarih1.TabIndex = 0;
            // 
            // dtptarih2
            // 
            this.dtptarih2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptarih2.Location = new System.Drawing.Point(138, 16);
            this.dtptarih2.Name = "dtptarih2";
            this.dtptarih2.Size = new System.Drawing.Size(112, 20);
            this.dtptarih2.TabIndex = 1;
            // 
            // btnSiparisYukle
            // 
            this.btnSiparisYukle.BackColor = System.Drawing.Color.White;
            this.btnSiparisYukle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSiparisYukle.ImageIndex = 0;
            this.btnSiparisYukle.ImageList = this.ımageList2;
            this.btnSiparisYukle.Location = new System.Drawing.Point(266, 2);
            this.btnSiparisYukle.Name = "btnSiparisYukle";
            this.btnSiparisYukle.Size = new System.Drawing.Size(68, 52);
            this.btnSiparisYukle.TabIndex = 2;
            this.btnSiparisYukle.Text = "Göster";
            this.btnSiparisYukle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiparisYukle.UseVisualStyleBackColor = false;
            this.btnSiparisYukle.Click += new System.EventHandler(this.btnSiparisYukle_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcel.ImageIndex = 1;
            this.btnExcel.ImageList = this.ımageList2;
            this.btnExcel.Location = new System.Drawing.Point(692, 333);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(87, 45);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "      ";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lstSiparisDetay
            // 
            this.lstSiparisDetay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstSiparisDetay.GridLines = true;
            this.lstSiparisDetay.Location = new System.Drawing.Point(12, 60);
            this.lstSiparisDetay.Name = "lstSiparisDetay";
            this.lstSiparisDetay.Size = new System.Drawing.Size(767, 267);
            this.lstSiparisDetay.TabIndex = 6;
            this.lstSiparisDetay.UseCompatibleStateImageBehavior = false;
            this.lstSiparisDetay.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sipariş No";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müşteri No";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ad Soyad";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ürün Adı";
            this.columnHeader6.Width = 97;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fiyat";
            this.columnHeader7.Width = 86;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Miktar";
            this.columnHeader8.Width = 66;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ödeme Türü";
            this.columnHeader9.Width = 133;
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "siparisGoster.jfif");
            this.ımageList2.Images.SetKeyName(1, "Printer_Picture.png");
            // 
            // FormSiparisDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 390);
            this.Controls.Add(this.lstSiparisDetay);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnSiparisYukle);
            this.Controls.Add(this.dtptarih2);
            this.Controls.Add(this.dtptarih1);
            this.Name = "FormSiparisDetay";
            this.Text = "FormSiparisDetay";
            this.Load += new System.EventHandler(this.FormSiparisDetay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtptarih1;
        private System.Windows.Forms.DateTimePicker dtptarih2;
        private System.Windows.Forms.Button btnSiparisYukle;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ListView lstSiparisDetay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ImageList ımageList2;
    }
}
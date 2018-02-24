using MarketOtomasyonu.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.Forms
{
    public partial class FormUrunler : Form
    {

        public FormUrunler()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            foreach (Control item in this.grpUrunler.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
                if (item is NumericUpDown)
                {
                    NumericUpDown nud = item as NumericUpDown;
                    nud.Value = 0.00m;
                }
            }
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                MarketOtomasyonEntities db = new MarketOtomasyonEntities();
                
                var seciliKategori = cmbKategori.SelectedItem as Category;
                if (seciliKategori == null || txtUrunAdi.Text==null || txtUrunKodu==null || nAlisFiyatı.Value==0.00m || nSatisFiyatı.Value==0.00m || txtStok.Text==null)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }
                if (txtUrunKodu.TextLength!=13)
                {
                    MessageBox.Show("Barkod uzunluğu 13 olmalı");
                    return;
                }
                Product product = new Product
                {
                    ProductName = txtUrunAdi.Text,
                    Barcode = txtUrunKodu.Text,
                    UnitPrice = nAlisFiyatı.Value,
                    SalesPrice = nSatisFiyatı.Value,
                    CategoryId = seciliKategori.CategoryId,
                    Stock = int.Parse(txtStok.Text),
                    ProductImage = resimDosyası
                      
                };
                db.Products.Add(product);
                db.SaveChanges();
                resimDosyası = null;
                pbUrunResim.Image = null;
                Temizle();
                VerileriGetir();
                MessageBox.Show($"{product.ProductName} ürünü başarıyla eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormUrunler_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        public void VerileriGetir()
        {
            try
            {
                MarketOtomasyonEntities db = new MarketOtomasyonEntities();

                cmbKategori.DataSource = db.Categories.ToList();
                cmbKategori.DisplayMember = "CategoryName";
                cmbKategori.ValueMember = "CategoryId";

                var urunler = db.Products
                    .Select(x => new UrunViewModel()
                    {
                        UrunId=x.ProductId,
                        UrunAdi = x.ProductName,
                        Barkot = x.Barcode,
                        AlisFiyati = x.UnitPrice ?? 0,
                        SatisFiyatı = x.SalesPrice ?? 0,
                        Kategori = x.Category.CategoryName,
                        Stok=x.Stock ?? 0,
                        Resim=x.ProductImage 
                       
                    }).ToList();
                lstUrunler.Items.Clear();
                urunler.ForEach(x =>
                {
                    ListViewItem viewItem = new ListViewItem(x.UrunId.ToString());
                    viewItem.SubItems.Add(x.UrunAdi);
                    viewItem.SubItems.Add(x.Barkot);
                    viewItem.SubItems.Add($"{x.AlisFiyati:c2}");
                    viewItem.SubItems.Add($"{x.SatisFiyatı:c2}");
                    viewItem.SubItems.Add(x.Kategori);
                    viewItem.SubItems.Add(x.Stok.ToString());

                    lstUrunler.Items.Add(viewItem);
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
          
        //}
        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                MarketOtomasyonEntities db = new MarketOtomasyonEntities();
                int seciliUrun = int.Parse(lstUrunler.SelectedItems[0].Text);
                var sonuc = db.Products.Where(x => x.ProductId == seciliUrun).ToList();
                if (txtUrunKodu.TextLength > 13 || txtUrunKodu.TextLength<13)
                {
                    MessageBox.Show("Yanlış barkod");
                    return;
                }
                sonuc.ForEach(x =>
                {
                    x.ProductName = txtUrunAdi.Text;
                    x.Barcode = txtUrunKodu.Text;
                    x.UnitPrice = nAlisFiyatı.Value;
                    x.SalesPrice = nSatisFiyatı.Value;
                    x.ProductImage = resimDosyası;
                    x.Stock = int.Parse(txtStok.Text);
                
                });
                db.SaveChanges();
                resimDosyası = null;
                pbUrunResim.Image = null;
                Temizle();
                VerileriGetir();
                MessageBox.Show("Ürün Başarıyla Güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            try
            {
                MarketOtomasyonEntities db = new MarketOtomasyonEntities();
                if (lstUrunler.SelectedItems == null) return;

                var seciliUrun = int.Parse(lstUrunler.SelectedItems[0].Text);
                var sonuc = db.Products.Find(seciliUrun);

                db.Products.Remove(sonuc);
                db.SaveChanges();
                resimDosyası = null;
                pbUrunResim.Image = null;
                Temizle();
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
          //Id yi al sorgu at sonra oradan çek.
            if (lstUrunler.SelectedItems == null) return;
            if (lstUrunler.SelectedItems.Count > 0)
            {
                MarketOtomasyonEntities db = new MarketOtomasyonEntities();
                int seciliUrun = int.Parse(lstUrunler.SelectedItems[0].Text);
                var sonuc = db.Products.Where(x => x.ProductId == seciliUrun).ToList();
                sonuc.ForEach(x =>
                {
                    txtUrunAdi.Text = x.ProductName;
                    txtUrunKodu.Text = x.Barcode;
                    nAlisFiyatı.Value = Convert.ToDecimal(x.UnitPrice);
                    nSatisFiyatı.Value = Convert.ToDecimal(x.SalesPrice);
                    cmbKategori.Text = x.Category.CategoryName;
                    txtStok.Text = x.Stock.ToString();
                    if (x.ProductImage != null)
                    {
                        try
                        {
                            pbUrunResim.Image = new Bitmap(new MemoryStream(x.ProductImage));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                        pbUrunResim.Image = null;
                });

            }
        }
        byte[] resimDosyası;
        private void pbUrunResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog
            {
                Title = "Bir resim dosyası seçiniz",
                Multiselect = false,
                Filter = "JPG formatlı (*.jpg)|*.jpg;*.jpg;|PNG Formatlı | *.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            DialogResult result = dosyaAc.ShowDialog();
            MemoryStream memoryStream = new MemoryStream();
            var buffer = new byte[64];
            if (result == DialogResult.OK)
            {
                FileStream fileStream = File.Open(dosyaAc.FileName, FileMode.Open);
                while (fileStream.Read(buffer, 0, 64) != 0)
                {
                    memoryStream.Write(buffer, 0, 64);
                }
                resimDosyası = memoryStream.ToArray();
                pbUrunResim.Image = new Bitmap(memoryStream);
            }
        }
    }
}

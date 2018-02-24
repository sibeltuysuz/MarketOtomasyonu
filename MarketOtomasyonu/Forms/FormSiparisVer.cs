using MarketOtomasyonu.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace MarketOtomasyonu.Forms
{
    public partial class FormSiparisVer : Form
    {
        public FormSiparisVer()
        {
            InitializeComponent();
            adediArttırToolStripMenuItem.Click += SepetYonetimi;
            adediAzaltToolStripMenuItem.Click += SepetYonetimi;
            sepettenÇıkartToolStripMenuItem.Click += SepetYonetimi;
        }
        //void Temizle()
        //{
        //    sepetList = new List<SepetViewModel>();
        //    lstSepet.Items.Clear();
        //    pbResim.Image = null;
        //    rbNakit.Checked = false;
        //    rbKrediKarti.Checked = false;
        //    VerileriGetir();
        //}
        private void SepetYonetimi(object sender, EventArgs e)
        {
            if (lstSepet.SelectedItem == null) return;
            var seciliUrun = lstSepet.SelectedItem as SepetViewModel;

            var menuItem = sender as ToolStripMenuItem;
            if (menuItem.Name == "adediAzaltToolStripMenuItem")
            {
                if (seciliUrun.Quantity >= 2)
                    seciliUrun.Quantity--;
                else if (seciliUrun.Quantity == 1)
                    sepetList.Remove(seciliUrun);
            }
            else if (menuItem.Name == "adediArttırToolStripMenuItem")
            {
                var urun = urunList.Where(x => x.UrunId == seciliUrun.ProductID).FirstOrDefault();
                if (!StokKontrol(urun))
                {
                    MessageBox.Show("Stokta olandan fazlasını sepete ekleyemezsiniz");
                    return;
                }
                seciliUrun.Quantity++;
            }

            else
            {
                sepetList.Remove(seciliUrun);

            }

            SepetGuncelle();
        }
        List<UrunViewModel> urunList = new List<UrunViewModel>();
        private void FormSiparisVer_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            MarketOtomasyonEntities db = new MarketOtomasyonEntities();
            cmbKategoriGetir.DataSource = db.Categories.OrderBy(x => x.CategoryName).ToList();
            cmbKategoriGetir.DisplayMember = "CategoryName";
            cmbKategoriGetir.ValueMember = "CategoryId";
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                MarketOtomasyonEntities db = new MarketOtomasyonEntities();
                var barkot = db.Products.Where(x => x.Barcode.Contains(txtBarkod.Text)).Select(x => x.Barcode).FirstOrDefault();

                if (e.KeyCode == Keys.Enter)
                {
                    //Do Something
                    Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    //textbox’a girdiğimiz textimizin barcode’unu picturebox’ta gösteriyoruz.
                    pbBarkod.Image = barcode.Draw(barkot, 50);
                    SepeteEkle();
                    txtBarkod.Text = "";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Barkod bulunamadı "+ex.Message);
            }
           
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            var seciliUrun = lstUrunler.SelectedItem as UrunViewModel;
            if (seciliUrun.Resim != null)
            {
                try
                {
                    pbResim.Image = new Bitmap(new MemoryStream(seciliUrun.Resim));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                pbResim.Image = null;
            
        }

        bool StokKontrol(UrunViewModel seciliUrun, short adet = 1)
        {
            bool varmi = false, cevap = false;
            sepetList.ForEach(x =>
            {
                if (x.ProductID == seciliUrun.UrunId)
                {
                    varmi = true;
                    if (adet == 1)
                    {
                        if (seciliUrun.Stok > x.Quantity)
                            cevap = true;
                        else
                            cevap = false;
                    }
                    else if (adet > 1)
                    {
                        if (seciliUrun.Stok >= adet)
                            cevap = true;
                        else
                            cevap = false;
                    }

                }
            });

            if (!varmi)
            {
                if (seciliUrun.Stok > 0)
                    cevap = true;
                else
                    cevap = false;
            }
            return cevap;
        }

        List<SepetViewModel> sepetList = new List<SepetViewModel>();
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            SepeteEkle();
        }

        private void SepeteEkle()
        {
            
            if (lstUrunler.SelectedItem == null) return;
            var seciliUrun = lstUrunler.SelectedItem as UrunViewModel;
            bool kontrol = StokKontrol(seciliUrun);
            if (!kontrol)
            {
                MessageBox.Show("Stokta olandan fazlasını sepete ekleyemezsiniz");
                return;
            }
            bool varmi = false;
            sepetList.ForEach(x =>
            {
                if (x.ProductID == seciliUrun.UrunId)
                {
                    varmi = true;
                    x.Quantity++;
                }
            });
            if (!varmi)
            {
                var model = new SepetViewModel()
                {
                    ProductID = seciliUrun.UrunId,
                    ProductName = seciliUrun.UrunAdi,
                    SalesPrice = seciliUrun.SatisFiyatı,
                    
                    
                };
                sepetList.Add(model);
            }
          
            SepetGuncelle();
        }

        void SepetGuncelle()
        {
            MarketOtomasyonEntities db = new MarketOtomasyonEntities();
            lstSepet.Items.Clear();
            sepetList.ForEach(x => lstSepet.Items.Add(x));
            SepetHesapla();
        }
        void SepetHesapla()
        {
            decimal toplam = 0 ,kdv = 0;
            toplam = sepetList.Sum(x =>x.Total);
            if (cmbKategoriGetir.SelectedItem.ToString()=="Atıştırmalık Ürünler" || cmbKategoriGetir.SelectedItem.ToString() == "Giyim" || cmbKategoriGetir.SelectedItem.ToString() == "Kırtasiye")
            {
                kdv = toplam * 0.08m;
            }
            else
            {
                kdv = toplam * 0.18m;
            }
            nToplam.Value = toplam+kdv;
            nKdv.Value = kdv;

        }
      

        private void cmbKategoriGetir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategoriGetir.SelectedItem == null) return;
            var seciliKategori = cmbKategoriGetir.SelectedItem as Category;
            MarketOtomasyonEntities db = new MarketOtomasyonEntities();
            var sonuc = db.Products.Where(x => x.CategoryId == seciliKategori.CategoryId)
                .OrderBy(x => x.ProductName)
                .Select(x => new UrunViewModel()
                {
                    UrunId = x.ProductId,
                    UrunAdi = x.ProductName,
                    Barkot = x.Barcode,
                    AlisFiyati = x.UnitPrice ?? 0,
                    SatisFiyatı = x.SalesPrice ?? 0,
                    Kategori = x.Category.CategoryName,
                    Resim = x.ProductImage,
                    Stok = x.Stock ?? 0
                   
                });
            lstUrunler.DisplayMember = "ProductName";
            lstUrunler.ValueMember = "ProductID";
            lstUrunler.DataSource = sonuc.ToList();
            urunList = sonuc.ToList();

        }

        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {
            MarketOtomasyonEntities db = new MarketOtomasyonEntities();
            FormSiparisOnay sprOnay = new FormSiparisOnay();
            sprOnay.txtToplamTutar.Text = nToplam.Value.ToString("0.00");
            sepetList.ForEach(x => sprOnay.lstUrunSiparisOnay.Items.Add(x));
            foreach (var item in sepetList)
            {
                var sepetim = new basket()
                {
                    ProductId = item.ProductID,
                    ProductName = item.ProductName,
                    Quantity = item.Quantity,
                    SalesPrice = item.SalesPrice

                };
                db.baskets.Add(sepetim);
                db.SaveChanges();
            }
            sprOnay.Show();
        }
    }
}

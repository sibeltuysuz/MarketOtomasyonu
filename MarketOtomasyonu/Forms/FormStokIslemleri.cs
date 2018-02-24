using MarketOtomasyonu.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.Forms
{
    public partial class FormStokIslemleri : Form
    {
        public FormStokIslemleri()
        {
            InitializeComponent();
        }

        private void VerileriGetir()
        {
            try
            {
                MarketOtomasyonEntities db = new MarketOtomasyonEntities();
                var urunler = db.Products.OrderBy(x=>x.ProductName)
                    .Select(x => new UrunViewModel()
                    {
                        UrunId = x.ProductId,
                        UrunAdi = x.ProductName,
                        AlisFiyati = x.UnitPrice ?? 0,
                        SatisFiyatı = x.SalesPrice ?? 0,
                        Stok = x.Stock ?? 0

                    }).ToList();
                lstUrunStok.Items.Clear();
                urunler.ForEach(x =>
                {
                    ListViewItem viewItem = new ListViewItem(x.UrunId.ToString());
                    viewItem.SubItems.Add(x.UrunAdi);
                    viewItem.SubItems.Add(x.Stok.ToString());
                    viewItem.SubItems.Add($"{x.AlisFiyati:c2}");
                    viewItem.SubItems.Add($"{x.SatisFiyatı:c2}");
                    lstUrunStok.Items.Add(viewItem);
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormStokIslemleri_Load(object sender, EventArgs e)
        {
           VerileriGetir();
        }

        private void lstUrunStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunStok.SelectedItems == null) return;
            if (lstUrunStok.SelectedItems.Count > 0)
            {
                MarketOtomasyonEntities db = new MarketOtomasyonEntities();
                int seciliUrun = int.Parse(lstUrunStok.SelectedItems[0].Text);
                var sonuc = db.Products.Where(x => x.ProductId == seciliUrun).ToList();
                sonuc.ForEach(x =>
                {
                    txtUrun.Text = x.ProductName;

                });

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                MarketOtomasyonEntities db = new MarketOtomasyonEntities();
                int seciliUrun = int.Parse(lstUrunStok.SelectedItems[0].Text);
                var sonuc = db.Products.Where(x => x.ProductId == seciliUrun).ToList();
                sonuc.ForEach(x =>
                {
                    x.Stock = int.Parse(txtStokAdet.Text)+x.Stock;
                });
                db.SaveChanges();
                VerileriGetir();
                MessageBox.Show("Stok Eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

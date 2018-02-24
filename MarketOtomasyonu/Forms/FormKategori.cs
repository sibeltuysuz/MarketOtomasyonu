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
    public partial class FormKategori : Form
    {
        public FormKategori()
        {
            InitializeComponent();
        }

        private void FormKategori_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            try
            {
                MarketOtomasyonEntities db = new MarketOtomasyonEntities();

                lstKategori.DataSource = db.Categories.OrderBy(x => x.CategoryName).ToList();
                lstKategori.DisplayMember = "CategoryName";
                lstKategori.ValueMember = "CategoryID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                MarketOtomasyonEntities db = new MarketOtomasyonEntities();
                Category cat = new Category
                {
                    CategoryName = txtKategoriAdi.Text
                };
                db.Categories.Add(cat);
                db.SaveChanges();
                VerileriGetir();
                lstKategori.SelectedValue = cat.CategoryId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;
            var seciliKategori = lstKategori.SelectedItem as Category;

            DialogResult cevap = MessageBox.Show($"{seciliKategori.CategoryName} isimli kategoriyi silmek istiyor musunuz?", "Kategori Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    MarketOtomasyonEntities db = new MarketOtomasyonEntities();
                    seciliKategori = db.Categories.Find(seciliKategori.CategoryId);
                    if (seciliKategori == null)
                    {
                        MessageBox.Show("Silinecek ürün bulunamadı!");
                        VerileriGetir();
                        return;
                    }
                    db.Categories.Remove(seciliKategori);
                    db.SaveChanges();
                    VerileriGetir();
                    MessageBox.Show($"{seciliKategori.CategoryName} isimli kategori silinmiştir");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{seciliKategori.CategoryName} isimli kategori silinememiştir\n " + ex.Message);
                }
            }
        }

        private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;

            var seciliKategori = lstKategori.SelectedItem as Category;
            txtKategoriAdi.Text = seciliKategori.CategoryName;
          
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;
            var seciliKategori = lstKategori.SelectedItem as Category;
            try
            {
                MarketOtomasyonEntities db = new MarketOtomasyonEntities();
                seciliKategori = db.Categories.Find(seciliKategori.CategoryId);
                if (seciliKategori == null)
                {
                    MessageBox.Show("Kategori Bulunamadı");
                    VerileriGetir();
                    return;
                }
                seciliKategori.CategoryName = txtKategoriAdi.Text;
                db.SaveChanges();
                VerileriGetir();
                lstKategori.SelectedValue = seciliKategori.CategoryId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


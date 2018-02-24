using MarketOtomasyonu.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUrunler urunlerForm = new FormUrunler();
            urunlerForm.Show();
        }

        private void btnSiparisIslemleri_Click(object sender, EventArgs e)
        {
            FormSiparisVer siparis = new FormSiparisVer();
            siparis.Show();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            FormStokIslemleri stokIslemleri = new FormStokIslemleri();
            stokIslemleri.Show();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FormKategori kategoriForm = new FormKategori();
            kategoriForm.Show();
        }

        private void btnSiparisDetayları_Click(object sender, EventArgs e)
        {
            FormSiparisDetay siparisDetayForm = new FormSiparisDetay();
            siparisDetayForm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

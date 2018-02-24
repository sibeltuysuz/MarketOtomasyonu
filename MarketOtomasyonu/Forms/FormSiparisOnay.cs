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
    public partial class FormSiparisOnay : Form
    {
       
        public FormSiparisOnay()
        {
            InitializeComponent();
        }

        private void FormSiparisOnay_Load(object sender, EventArgs e)
        {
            cmbodemeTuru.Items.Add("Nakit");
            cmbodemeTuru.Items.Add("Kredi Kartı");

            cmbKart.Items.Add("A");
            cmbKart.Items.Add("B");
        }
       
        FormSiparisVer frm = new FormSiparisVer();
       
        private void btnSiparisOnay_Click(object sender, EventArgs e)
        {
            MarketOtomasyonEntities db = new MarketOtomasyonEntities();
            var sepetlist = db.baskets.Select(x => x);
           
           
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    if (cmbodemeTuru.SelectedItem.ToString() == "Nakit")
                    {
                        decimal verilenPara = decimal.Parse(txtNakit.Text);
                        if (verilenPara < Convert.ToDecimal(txtToplamTutar.Text))
                        {
                            MessageBox.Show("Verilen Para Yeterli değil");
                            return;
                        }
                        else
                        {
                            decimal odenenTutar = (verilenPara - Convert.ToDecimal   (txtToplamTutar.Text));
                            MessageBox.Show("Para Üstü : " + odenenTutar);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Kartınızdan {Convert.ToDecimal(txtToplamTutar.Text):c2} para çekildi.");
                    }
                    var musteri = new Customer()
                    {
                        CustomerName = txtAd.Text,
                        CustomerSurname = txtSoyad.Text,
                        Address = richtxtAdres.Text,
                        Phone = mskTelefon.Text
                    };
                    db.Customers.Add(musteri);
                    db.SaveChanges();
                    var yeniSiparis = new Order()
                    {
                        CustomerId = musteri.CustomerId,
                        OrderDate = DateTime.Now,
                        RequiredDate = DateTime.Now.AddDays(1)
                       
                    };
                    db.Orders.Add(yeniSiparis);
                    db.SaveChanges();
                    
                    foreach (var item in sepetlist)
                    {
                        var siparisDetay = new Order_Details()
                        {
                            OrderId = yeniSiparis.OrderId,
                            ProductId = item.ProductId,
                            SalesPrice = item.SalesPrice,
                            Quantity = item.Quantity,
                            OdemeTuru= cmbodemeTuru.SelectedItem.ToString()
                        };

                        db.Order_Details.Add(siparisDetay);
                        var urun = db.Products.Find(item.ProductId);
                        urun.Stock -= item.Quantity;
                    }
                    db.SaveChanges();
                    tran.Commit();
                    foreach (var item in sepetlist)
                        db.baskets.Remove(item);
                    db.SaveChanges();
                    MessageBox.Show($"{yeniSiparis.OrderId}'nolu siparişiniz tarafımıza ulaşmıştır");
                   
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Sipariş Oluşturma işleminde hata oluştu.\n" + ex.Message);
                }
            }
            if (sepetlist == null)
            {
                MessageBox.Show("Sepete Ürün Ekleyiniz.");
                return;
            }
        }

        private void cmbodemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbodemeTuru.SelectedItem == null) return;
            if (cmbodemeTuru.SelectedItem.ToString()=="Nakit")
            {
               
                lblNakit.Visible = true;
                txtNakit.Visible = true;
                lblKartSecenekleri.Visible = false;
                cmbKart.Visible = false;
            }
            else
            {
                lblKartSecenekleri.Visible = true;
                cmbKart.Visible = true;
                lblNakit.Visible = false;
                txtNakit.Visible = false;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

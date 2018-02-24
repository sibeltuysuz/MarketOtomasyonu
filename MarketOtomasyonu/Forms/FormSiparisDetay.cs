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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace MarketOtomasyonu.Forms
{
    public partial class FormSiparisDetay : Form
    {
        public FormSiparisDetay()
        {
            InitializeComponent();
        }

        private void btnSiparisYukle_Click(object sender, EventArgs e)
        {
            try
            {
                MarketOtomasyonEntities db = new MarketOtomasyonEntities();
                DateTime startDate = dtptarih1.Value;

                DateTime endDate = dtptarih2.Value;
                var sonuc = (from o in db.Orders
                             join od in db.Order_Details on o.OrderId equals od.OrderId
                             join c in db.Customers on o.CustomerId equals c.CustomerId
                             where (o.OrderDate >= startDate || o.OrderDate <= endDate)
                             select new SiparisDetayViewModel
                             {
                                 OrderId = o.OrderId,
                                 CustomerId = c.CustomerId,
                                 FullName = c.CustomerName + " " + c.CustomerSurname,
                                 Phone = c.Phone,
                                 Adress = c.Address,
                                 ProductName = od.Product.ProductName,
                                 SalesPrice = od.SalesPrice ?? 0,
                                 Quantity = od.Quantity ?? 0,
                                 OdemeTuru = od.OdemeTuru
                             }).ToList();
                lstSiparisDetay.Items.Clear();
                sonuc.ForEach(x =>
                {
                    ListViewItem viewItem = new ListViewItem(x.OrderId.ToString());
                    viewItem.SubItems.Add(x.CustomerId.ToString());
                    viewItem.SubItems.Add(x.FullName);
                    viewItem.SubItems.Add(x.Phone);
                    viewItem.SubItems.Add(x.Adress);
                    viewItem.SubItems.Add(x.ProductName);
                    viewItem.SubItems.Add($"{x.SalesPrice:c2}");
                    viewItem.SubItems.Add(x.Quantity.ToString());
                    viewItem.SubItems.Add(x.OdemeTuru);

                    lstSiparisDetay.Items.Add(viewItem);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            int i = 1;
            int i2 = 1;
            foreach (ListViewItem lvi in lstSiparisDetay.Items)
            {
                i = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[i2, i] = lvs.Text;
                    i++;
                }
                i2++;
            }
        }

        private void FormSiparisDetay_Load(object sender, EventArgs e)
        {

        }
    }
}

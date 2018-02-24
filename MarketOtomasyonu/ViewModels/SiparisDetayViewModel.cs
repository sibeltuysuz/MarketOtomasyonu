using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.ViewModels
{
    public class SiparisDetayViewModel
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string ProductName { get; set; }
        public decimal SalesPrice { get; set; }
        public int Quantity { get; set; }
        public string OdemeTuru { get; set; }

        public string FullName { get; set; }

        public override string ToString() => $"{FullName}";
    }
}

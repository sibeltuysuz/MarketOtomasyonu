using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.ViewModels
{
    public class MusteriViewModel
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
       
        public override string ToString() => $"{FullName}";
    }
}

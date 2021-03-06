﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.ViewModels
{
    public class SepetViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public short Quantity { get; set; } = 1;
        public decimal SalesPrice { get; set; } = 0;
        public int KdvOrani { get; set; } = 0;
        public int OdemeTuru { get; set; }
        public decimal Total
        {
            get
            {
                return Quantity * SalesPrice;
            }
        }
        public override string ToString() => $"{ProductName} {Quantity}x{SalesPrice:c2} = {Total:c2}";
    }
}


namespace MarketOtomasyonu.ViewModels
{
    public class UrunViewModel
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string Barkot { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyatı { get; set; }
        public string Kategori { get; set; }
        public byte[] Resim { get; set; }
        public int? Stok { get; set; }
      

        public override string ToString()
        {
            return $"{UrunAdi}: {SatisFiyatı:c2}  {Barkot}";
        }

            
    }

    
}

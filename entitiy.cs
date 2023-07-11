using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace AydemirOto
{
    public class Musteri
    {
        public Guid Id { get; set; }
        public string ad { get; set; }    
        public string soyad { get; set; }
        public string telefon { get; set; }
        public string mail { get; set; }
        public string adres { get; set; }

        public override string ToString()
        {
            return $"{ad} {soyad}";
        }


    }
    public class urun
    {
        public Guid Id { get; set; }
        public string ad { get; set; }
        public string marka { get; set; }
        public double model { get; set; }
        public double km { get; set; }
        public double stok { get; set; }
        public double birim { get; set; }
        public string Fiyat { get; internal set; }
        public override string ToString()
        {
            return $"{ad}";
        }
    }
    public class satıs
    {
        public Guid Id { get; set; }
        public Musteri musteri { get; set; }
        public urun urun { get; set; }
        public DateTime tarih { get; set; }
        public double fiyat { get; set; }


    }
    public class odeme
    {
        public Guid Id { get; set; }
        public Musteri musteri { get;set; }

        public DateTime tarih { get; set; }
         public double Tutar { get; set;}
        public double Tur { get; set; }
        public double acıklama { get; set; }

    }
}

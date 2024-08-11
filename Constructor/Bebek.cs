using System;

namespace Constructor
{
    internal class Bebek
    {
       
        public DateTime DogumTarihi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Default Constructor
        public Bebek()
        {
            DogumTarihi = DateTime.Now; // Doğum tarihi o anki tarih olarak atanır
            Console.WriteLine("Ingaaaa"); // Mesajı ekrana yazdır
        }

        // Parametreli Constructor
        public Bebek(string ad, string soyad) : this() // Default constructor'ı çağır
        {
            Ad = ad;
            Soyad = soyad;
        }

        // Bebek bilgilerini yazdırma metodu
        public void BebekBilgileri()
        {
            Console.WriteLine($"Adı: {Ad}");
            Console.WriteLine($"Soyadı: {Soyad}");
            Console.WriteLine($"Doğum Tarihi: {DogumTarihi.ToShortDateString()}");
        }
    }
}

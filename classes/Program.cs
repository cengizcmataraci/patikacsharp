using System;

namespace classes
{
  class Program
  {
    static void Main(string[] args)
    {
      //Söz Dizimi
      // class SinifAdi
      // {
      //    [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
      //    [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
      //    {
      //      Metot Komutları
      //    }
      // }

      //Erişim Belirleyiciler
      // * Public -> her yerden erişilebilir
      // * Private -> sadece tanımlandığı sınıf içerisinde erişilebilir
      // * Internal -> sadece kendi bulunduğu proje içerisinde erişilebilir
      // * Protected -> sadece tanımlandığı sınıfta ve/veya o sınıftan kalıtım alan diğer sınıflarda erişilebilir

      Calisan calisan1 = new Calisan();
      calisan1.Ad = "Cengiz C.";
      calisan1.Soyad = "Mataracı";
      calisan1.No = 11111111;
      calisan1.Departman = "IT";

      calisan1.CalisanBilgileri();

      Console.WriteLine("***");

      Calisan calisan2 = new Calisan();
      calisan2.Ad = "Elif Mine";
      calisan2.Soyad = "Kılıçaslan";
      calisan2.No = 22222222;
      calisan2.Departman = "Operation";

      calisan2.CalisanBilgileri();
    }
  }

  class Calisan
  {
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
      Console.WriteLine($"Çalışanın Adı: {Ad}");
      Console.WriteLine($"Çalışanın Soyadı: {Soyad}");
      Console.WriteLine($"Çalışanın Numarası: {No}");
      Console.WriteLine($"Çalışanın Departmanı: {Departman}");
    }
  }
}

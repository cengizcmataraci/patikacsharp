using System;

namespace access_modifiers_constructors
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

      Console.WriteLine("*** Çalışan1 ***");

      Calisan calisan1 = new Calisan("Cengiz C.", "Mataracı", 111111111, "IT");

      calisan1.CalisanBilgileri();

      Console.WriteLine("*** Çalışan2 ***");

      Calisan calisan2 = new Calisan();
      calisan2.Ad = "Elif Mine";
      calisan2.Soyad = "Kılıçaslan";
      calisan2.No = 22222222;
      calisan2.Departman = "Operation";

      calisan2.CalisanBilgileri();

      Console.WriteLine("*** Çalışan3 ***");
      Calisan calisan3 = new Calisan("Furkan Tolga", "Yüce");
      calisan3.CalisanBilgileri();
    }
  }

  class Calisan
  {
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad, int no, string departman)
    {
      this.Ad = ad;
      this.Soyad = soyad;
      this.No = no;
      this.Departman = departman;
    }
    public Calisan(string ad, string soyad)
    {
      this.Ad = ad;
      this.Soyad = soyad;
    }

    public Calisan() { }

    public void CalisanBilgileri()
    {
      Console.WriteLine($"Çalışanın Adı: {Ad}");
      Console.WriteLine($"Çalışanın Soyadı: {Soyad}");
      Console.WriteLine($"Çalışanın Numarası: {No}");
      Console.WriteLine($"Çalışanın Departmanı: {Departman}");
    }
  }
}

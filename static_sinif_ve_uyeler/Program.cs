using System;

namespace static_sinif_ve_uyeler
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine($"Çalışan sayısı: {Calisan.CalisanSayisi}");

      Calisan calisan = new Calisan("Cengiz C.", "Mataracı", "IT");
      Console.WriteLine($"Çalışan sayısı: {Calisan.CalisanSayisi}");

      Calisan calisan1 = new Calisan("Elif Mine", "Kılıçaslan", "IT");
      Calisan calisan2 = new Calisan("Furkan Tolga", "Yüce", "IT");
      Console.WriteLine($"Çalışan sayısı: {Calisan.CalisanSayisi}");

      Console.WriteLine("Toplama işlemi sonucu: " + İslemler.Toplama(100, 200));
      Console.WriteLine("Çıkarma işlemi sonucu: " + İslemler.Cikarma(400, 50));
    }
  }

  class Calisan
  {
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string Isim;
    private string Soyisim;
    private string Departman;

    static Calisan()
    {
      calisanSayisi = 0;
    }

    public Calisan(string isim, string soyisim, string departman)
    {
      this.Isim = isim;
      this.Soyisim = soyisim;
      this.Departman = departman;
      calisanSayisi++;
    }
  }

  static class İslemler
  {
    public static long Toplama(int sayi1, int sayi2)
    {
      return sayi1 + sayi2;
    }
    public static long Cikarma(int sayi1, int sayi2)
    {
      return sayi1 - sayi2;
    }
  }
}

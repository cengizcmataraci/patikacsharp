using System;

namespace method_overloading
{
  class Program
  {
    static void Main(string[] args)
    {
      //out parametreler
      string sayi = "999";

      bool sonuc = int.TryParse(sayi, out int outSayi);
      if (sonuc)
      {
        Console.WriteLine($"Başarılı! {outSayi}");
      }
      else
      {
        Console.WriteLine("Başarısız!");
      }

      Metotlar metot = new Metotlar();
      metot.Topla(5, 5, out int toplam);
      Console.WriteLine(toplam);

      //Metot aşırı yükleme - overloading
      int ifade = 999;
      metot.EkranaYazdir(ifade);
      metot.EkranaYazdir("Cengiz C. ", "Mataracı");
    }
  }

  class Metotlar
  {
    public void Topla(int sayi1, int sayi2, out int toplam)
    {
      toplam = sayi1 + sayi2;
    }

    public void EkranaYazdir(string veri)
    {
      Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
      Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1, string veri2)
    {
      Console.WriteLine(veri1 + veri2);
    }
  }
}

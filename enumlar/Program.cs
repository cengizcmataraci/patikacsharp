using System;

namespace enumlar
{
  class Program
  {
    static void Main(string[] args)
    {
      //enumeration - sıralı veriler
      Console.WriteLine(Gunler.Pazar);
      Console.WriteLine(((int)Gunler.Cumartesi));

      Console.WriteLine("Sıcaklık girin: ");
      int havaSicakligi = int.Parse(Console.ReadLine());
      if (havaSicakligi <= (int)HavaDurumu.Normal)
      {
        Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim!");
      }
      else if (havaSicakligi >= (int)HavaDurumu.Sicak)
      {
        Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün!");
      }
      else if (havaSicakligi >= (int)HavaDurumu.Normal && havaSicakligi < (int)HavaDurumu.CokSicak)
      {
        Console.WriteLine("Hadi dışarıya çıkalım!");
      }
    }
  }

  enum Gunler
  {
    Pazartesi = 1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma = 23,
    Cumartesi,
    Pazar
  }

  enum HavaDurumu
  {
    Soguk = 5,
    Normal = 20,
    Sicak = 25,
    CokSicak = 30
  }
}

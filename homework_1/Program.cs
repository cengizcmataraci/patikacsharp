using System;

namespace homework_1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("*** 1 ***");
      Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
      int sayi = int.Parse(Console.ReadLine());
      int[] sayiDizisi = new int[sayi];

      if (sayi > 0)
      {
        Console.WriteLine($"Lütfen {sayi} tane sayı giriniz: ");
        for (int i = 0; i < sayiDizisi.Length; i++)
        {
          Console.Write($"{i + 1}. sayı: ");
          sayiDizisi[i] = int.Parse(Console.ReadLine());
        }
        foreach (var sayilar in sayiDizisi)
        {
          if (sayilar % 2 == 0)
          {
            Console.WriteLine(sayilar);
          }
        }
      }
      else
      {
        Console.WriteLine("İstenilen şekilde sayı girmediniz!");
      }

      Console.WriteLine("*** 2 ***");
      Console.WriteLine("Lütfen pozitif iki sayı giriniz.");

      Console.Write("Birinci sayı: ");
      int sayi1 = int.Parse(Console.ReadLine());

      Console.Write("İkinci sayı: ");
      int sayi2 = int.Parse(Console.ReadLine());

      Console.WriteLine($"Lütfen {sayi1} tane pozitif sayı giriniz.");
      int[] kiyaslamaDizisi = new int[sayi1];

      for (int i = 0; i < kiyaslamaDizisi.Length; i++)
      {
        Console.Write($"{i + 1}. sayı: ");
        kiyaslamaDizisi[i] = int.Parse(Console.ReadLine());
      }
      foreach (var bolunenSayi in kiyaslamaDizisi)
      {
        if (bolunenSayi == sayi2 || bolunenSayi % sayi2 == 0)
        {
          Console.WriteLine(bolunenSayi);
        }
      }

      Console.WriteLine("*** 3 ***");
      Console.Write("Lütfen pozitif bir sayı giriniz: ");

      int kelimeSayisi = int.Parse(Console.ReadLine());
      Console.WriteLine($"Lütfen {kelimeSayisi} adet kelime giriniz.");

      string[] kelimeDizisi = new string[kelimeSayisi];
      for (int i = 0; i < kelimeDizisi.Length; i++)
      {
        Console.Write($"{i + 1}. kelime: ");
        kelimeDizisi[i] = Console.ReadLine();
      }

      Array.Reverse(kelimeDizisi);

      foreach (var kelime in kelimeDizisi)
      {
        Console.WriteLine(kelime);
      }

      Console.WriteLine("*** 4 ***");
      Console.Write("Lütfen bir cümle yazınız: ");

      string cumle = Console.ReadLine();
      string[] parcalanmisCumle = cumle.Split(' ');
      int toplam = 0;

      foreach (string cumleler in parcalanmisCumle)
      {
        toplam += cumleler.Length;
      }
      Console.WriteLine("Toplam harf sayısı: " + toplam);
      Console.WriteLine("Toplam kelime sayısı: " + cumle.Split().Length);
    }
  }
}
